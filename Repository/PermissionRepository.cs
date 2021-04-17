﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Contracts.RepositoryContracts;

namespace Repository
{
    class PermissionRepository : AppRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(ITIAttendanceContext context) : base(context)
        {

        }
        public void CreatePermission(int studentId, Permission permission)
        {
            permission.StudentId = studentId;
            Create(permission);
        }

        public void DeletePermission(Permission permission)
        {
            Delete(permission);
        }

        public async Task<Permission> GetPermissionAsync(int studentId, int permissionId, bool trackChanges) =>
            await FindByCondition(e => e.StudentId == studentId && e.Id == permissionId, trackChanges).SingleOrDefaultAsync();


        public async Task<List<Permission>> GetPermissionsForStudent(int studentId, bool trackChanges) =>
            await FindByCondition(e => e.StudentId == studentId && e.ResponseBy !=null , trackChanges).ToListAsync();

        public async Task<List<Permission>> GetAllPermissionsForEmployee(bool trackChanges) =>
           await FindByCondition(e => e.ResponseType == null , trackChanges).Include(per=>per.Student.TtackAction.Track).ToListAsync();


    //public void UpdatePermission(Permission permission)
    //{
    //    Update(permission);
    //}

    }
}
