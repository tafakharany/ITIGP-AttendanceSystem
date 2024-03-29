﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServicesContracts
{
    public interface IServicesManager
    {
        IStudentServices StudentServices { get; }
        ITrackActionServices TrackActionServices { get; }
        ITrackServices TrackServices { get; }
        IPermissionServices PermissionServices { get; }
        IEmployeeServices EmployeeServices { get; }
        IProgramServices ProgramServices { get; }
        IAttendanceServices AttendanceServices { get; }
        IRoleServices RoleServices { get; }
        IUserServices UserServices { get; }

    }
}
