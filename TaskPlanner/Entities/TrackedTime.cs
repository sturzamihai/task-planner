using System;
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

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public TimeSpan Interval()
        {
            return EndTime.Subtract(StartTime);
        }
    }
}
