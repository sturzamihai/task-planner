using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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
        public TimeSpan CalculateTrackedTime()
        {
            TimeSpan trackedSeconds = new TimeSpan(0);
            foreach(TrackedTime time in TimesTracked)
            {
                trackedSeconds += time.Interval;
            }

            return trackedSeconds;
        }

        public Project Project { get; set; }

        public static void SerializeToXML(Task task, XmlWriter writer)
        {
            writer.WriteStartElement("Task");
            writer.WriteElementString("Title", task.Title);
            writer.WriteElementString("Asignee", task.Asignee.Name);
            writer.WriteElementString("Status", task.Status.Title);
            writer.WriteEndElement();
        }
    }
}
