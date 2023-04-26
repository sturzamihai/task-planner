using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPlanner.Entities.Users;

namespace TaskPlanner.Entities
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Required]
        public User Asignee { get; set; }

        [Required]
        public TaskStatus Status { get; set; }

        public List<TrackedTime> TimesTracked { get; set; } = new List<TrackedTime>();

        // Returns tracked time in seconds for this Task
        public int CalculateTrackedTime()
        {
            int trackedSeconds = 0;
            foreach(TrackedTime time in TimesTracked)
            {
                trackedSeconds += time.Interval;
            }

            return trackedSeconds;
        }
    }
}
