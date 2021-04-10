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
        public StudentRepository(AttendContext context) : base(context)
        {
        }

        public void CreateStudent(int trackActionId, Student student)
        {
            student.TrackActionId = trackActionId;
            Create(student); 
        }

        public void DeleteStudent(Student student) => Delete(student);
        
       

        public async Task<Student> GetStudentAsync(int trackActionId, int studentId, bool trackChanges)=>  
            await FindByCondition(e => e.TrackActionId == trackActionId && e.Id == studentId, trackChanges).SingleOrDefaultAsync();


        public async Task<List<Student>> GetStudents(int trackActionId, bool trackChanges) =>
            await FindByCondition(e => e.TrackActionId == trackActionId, trackChanges).ToListAsync();



        public void UpdateStudent(Student student) => Update(student);
        
    }
}