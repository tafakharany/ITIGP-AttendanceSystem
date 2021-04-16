﻿using AutoMapper;
using Contracts;
using Contracts.ServicesContracts;

namespace Services
{
    public class ServicesManager : IServicesManager
    {
        private readonly IAppRepositoryManager _repositoryManager; //=>use model from student model
        private IMapper _mapper;

        private IStudentServices _studentServices;
        private ITrackActionServices _trackActionServices;
        private ITrackServices _trackServices;
        private IPermissionServices _permissionServices;
        private IEmployeeServices _employeeServices;
        private IAttendanceServices _attendanceServices;

        public ServicesManager(IAppRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public IStudentServices StudentServices
        {
            get
            {
                if (_studentServices == null) _studentServices = new StudentServices(_repositoryManager, _mapper);
                return _studentServices;
            }
        }

        public ITrackActionServices TrackActionServices
        {
            get
            {
                if (_trackActionServices == null) _trackActionServices = new TrackActionServices(_repositoryManager, _mapper);
                return _trackActionServices;
            }
        }

        public ITrackServices TrackServices
        {
            get
            {
                if (_trackServices == null) _trackServices = new TrackServices(_repositoryManager, _mapper);
                return _trackServices;
            }
        }

        public IPermissionServices PermissionServices
        {
            get
            {
                if (_permissionServices == null) _permissionServices = new PermissionServices(_repositoryManager, _mapper);
                return _permissionServices;
            }
        }

        public IEmployeeServices EmployeeServices
        {
            get
            {
                if (_employeeServices == null) _employeeServices = new EmployeeServices(_repositoryManager, _mapper);
                return _employeeServices;
            } 
        }

        public IAttendanceServices AttendanceServices
        { get
            {
                if (_attendanceServices == null) _attendanceServices = new AttendanceServices(_repositoryManager, _mapper);
                return _attendanceServices;
            }
        }
}
}
