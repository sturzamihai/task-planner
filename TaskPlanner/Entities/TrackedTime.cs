using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPlanner.Entities.Users;

namespace TaskPlanner.Entities
{
    public class TrackedTime : IComparable<TrackedTime>
    {
        public int Id { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public int CompareTo(TrackedTime? other)
        {
            return this.Interval.CompareTo(other.Interval);
        }

        public TimeSpan Interval
        {
            get
            {
                return EndTime.Subtract(StartTime);
            }
        }
    }
}
