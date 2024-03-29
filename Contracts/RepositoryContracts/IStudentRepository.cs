﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudents(int trackActionId, bool trackChanges);
        Task<Student> GetStudentAsync(int studentId, bool trackChanges);
        Student CreateStudent(int trackActionId,int userId, Student student);
        void DeleteStudent(Student student);
    }
}
