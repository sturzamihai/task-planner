﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPlanner.Entities.Users;

namespace TaskPlanner.Entities
{
    public class TrackedTime
    {
        public int Id { get; set; }

        [Required]
        public User User { get; set; }

        // In seconds
        [Required]
        public int Interval { get; set; }
    }
}