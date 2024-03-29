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
    public class TrackRepository : AppRepository<Track>, ITrackRepository
    {
        private readonly ITIAttendanceContext _context;
        public TrackRepository(ITIAttendanceContext context) : base(context)
        {
            _context = context;
        }



        public Track CreateTrack(int programId, Track track)
        {
            track.ProgramId = programId;
            Create(track);
            return track;
        }

        public void DeleteTrack(Track track) => Delete(track);


       

        public async Task<Track> GetTrackAsync(int trackId, bool trackChanges) =>
            await FindByCondition(e => e.Id == trackId, trackChanges).Include(t => t.Program).SingleOrDefaultAsync();


        public async Task<List<Track>> GetTracks(int programId, bool trackChanges) =>
            await FindByCondition(e => e.ProgramId == programId, trackChanges).Include(t=>t.Program).ToListAsync();

        //public void UpdateTrack(Track track) => Update(track);

        public async Task<Track> GetTrackWithProgram(int programId, int trackId, bool trackChanges)=>
            await _context.Tracks.Include(t => t.Program).FirstOrDefaultAsync(t => t.ProgramId == programId && t.Id == trackId );
    }
}
