using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPlanner.Departments;
using TaskPlanner.Users;

namespace TaskPlanner.Projects
{
    public class Project
    {
        private string title;
        private string description;
        private DateTime start;
        private DateTime end;
        private List<Task> tasks;
        private List<Department> departments;
        private Client? client;

        public Project(string title, string description, DateTime start, DateTime end, List<Department> departments, Client? client)
        {
            this.title = title;
            this.description = description;
            this.start = start;
            this.end = end;
            this.tasks = new List<Task>();
            this.departments = departments;
            this.client = client;
        }

        public string Title { get { return title; } set { title = value; } }
    }
}
