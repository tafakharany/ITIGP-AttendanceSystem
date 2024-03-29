﻿using Contracts;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StudentRepository : AppRepository<Student>, IStudentRepository
    {
        public StudentRepository(ITIAttendanceContext context) : base(context)
        {
        }

        public Student CreateStudent(int trackActionId, int userId, Student student)
        {
            student.UserId = userId;
            student.TrackActionId = trackActionId;
            Create(student);
            return student;
        }

        public void DeleteStudent(Student student) => Delete(student);



        public async Task<Student> GetStudentAsync( int studentId, bool trackChanges) =>
            await FindByCondition(e=>e.Id == studentId, trackChanges)
            .Include(st=>st.CreatedByNavigation.User)
            .Include(x => x.User).Where(x => x.UserId == x.User.Id)
            .SingleOrDefaultAsync();


        public async Task<List<Student>> GetStudents(int trackActionId, bool trackChanges) =>
            await FindByCondition(e => e.TrackActionId == trackActionId, trackChanges)
            .Include(x=>x.TrackAction)
            .Include(st => st.CreatedByNavigation.User).Include(s=>s.User).ToListAsync();
    }
}
