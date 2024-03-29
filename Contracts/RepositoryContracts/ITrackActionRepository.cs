﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ITrackActionRepository
    {
        Task<List<TrackAction>> GetTrackActions(int trackId, bool trackChanges);
        Task<TrackAction> GetTrackActionAsync(int id, bool trackChanges);
        TrackAction CreateTrackAction(int trackId, TrackAction trackAction);
        void DeleteTrackAction(TrackAction trackAction);
    }
}
