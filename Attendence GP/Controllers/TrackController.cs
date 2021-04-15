﻿using Contracts.ServicesContracts;
using Domain.Dtos;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Attendence_GP.Controllers
{
    [Route("programs/{programId}/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly IServicesManager _manager;

        public TrackController(IServicesManager manager)
        {
            _manager = manager;
        }

        [HttpPost]
        public async Task AddTrack(int programId, [FromBody] Track track)
        {
            await _manager.TrackServices.Create(programId, track);
        }

        #region Read

        [HttpGet]
        public async Task<IActionResult> GetStudentsForTrack(int programId)
        {
            var tracks = await _manager.TrackServices.GetTracksForProgram(programId);
            return Ok(tracks);
        }

        [HttpGet("{trackId}")]
        public async Task<IActionResult> GetStudentPerId(int programId, int trackId)
        {
            var track = await _manager.TrackServices.GetTrack(programId, trackId);
            return Ok(track);
        }

        #endregion Read

        [HttpPut("{trackId}")]
        public async Task<IActionResult> UpdateStudentForTrack(int programid, int trackId, [FromBody] TrackUpdateDto track)
        {
            await _manager.TrackServices.Update(programid, trackId, track);
            return NoContent();
        }

        [HttpDelete("{trackId}")]
        public async Task<IActionResult> DeleteStudentForTrack(int trackActionId, int studentId)
        {
            await _manager.StudentServices.Delete(trackActionId, studentId);
            return NoContent();
        }
    }
}