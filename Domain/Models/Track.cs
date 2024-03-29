﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Models
{
    public partial class Track
    {
        public Track()
        {
            TrackActions = new HashSet<TrackAction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ProgramId { get; set; }

        public virtual Program Program { get; set; }
        public virtual ICollection<TrackAction> TrackActions { get; set; }
    }
}
