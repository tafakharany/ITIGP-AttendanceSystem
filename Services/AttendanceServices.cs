﻿using AutoMapper;
using Contracts;
using Contracts.ServicesContracts;
using Domain.Dtos;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AttendanceServices : IAttendanceServices
    {

        private readonly IAppRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public AttendanceServices(IAppRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task Create(int studentId, AttendanceManipulationDto attendance)
        {
            var attendanceEntity = _mapper.Map<Attendance>(attendance);
            _repositoryManager.AttendanceRepository.CreateTrackAttendance(studentId, attendanceEntity);
            await _repositoryManager.SaveAsync();

        }

        public async Task Delete(int studentId, DateTime date)
        {
            var attendanceEntity = await _repositoryManager.AttendanceRepository.GetAttendanceForStudent(studentId, date, false);
            _repositoryManager.AttendanceRepository.DeleteAttendance(attendanceEntity);
            await _repositoryManager.SaveAsync();

        }

        public async Task<AttendanceManipulationDto> GetAttendanceForStudent(int studentId, DateTime date)
        {
            var attendance = await _repositoryManager.AttendanceRepository.GetAttendanceForStudent(studentId, date, false);
            var attendanceEntity = _mapper.Map<AttendanceManipulationDto>(attendance);
            return attendanceEntity;
        }

        public  async Task<AttendanceManipulationDto> GetAttendanceForTrack(int trackActionId, DateTime date)
        {
            var attendance = await _repositoryManager.AttendanceRepository.GetAttendanceForTrack(trackActionId, date, false);
            var attendanceEntity = _mapper.Map<AttendanceManipulationDto>(attendance);
            return attendanceEntity;
        }

        public Task<List<AttendanceManipulationDto>> GetAllAttendances(int trackActionId)
        {
            throw new NotImplementedException();
        }

        public async Task Update(int studentId, DateTime date, AttendanceManipulationDto attendance)
        {
            var attendanceEntity = await _repositoryManager.AttendanceRepository.GetAttendanceForStudent(studentId, date, true);
            _mapper.Map(attendance, attendanceEntity);
            await _repositoryManager.SaveAsync();
        }
    }
}