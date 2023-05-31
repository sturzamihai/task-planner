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
    public class Project 
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        public List<Task> Tasks { get; set; } = new List<Task>();

        public List<Department> Departments { get; set; } = new List<Department>();

        public Client? Client { get; set; }

        public List<TaskStatus> AllowedStatuses { get; set; } = new List<TaskStatus>();

        public static void SerializeToXML(Project project, XmlWriter writer)
        {
            writer.WriteStartElement("Project");
            writer.WriteElementString("Title", project.Title);
            writer.WriteElementString("Description", project.Description);
            writer.WriteElementString("Client", (project.Client != null ? project.Client.Name : "Internal"));

            writer.WriteStartElement("DepartmentList");
            foreach (Department department in project.Departments)
            {
                writer.WriteElementString("Department", department.Name);
            }
            writer.WriteEndElement();

            writer.WriteStartElement("TaskList");
            foreach (Entities.Task task in project.Tasks)
            {
                Entities.Task.SerializeToXML(task, writer);
            }
            writer.WriteEndElement();

            writer.WriteEndElement();
        }
    }
}
