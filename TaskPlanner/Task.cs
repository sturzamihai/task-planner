using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPlanner.Users;

namespace TaskPlanner
{
    internal class Task
    {
        private string title;
        private string description;
        private User? asignee;

        public Task()
        {
            title = "N/A";
            description = "";
            asignee = null;
        }

        public Task(string title, string description)
        {
            this.title = title;
            this.description = description;
            asignee = null;
        }

        public Task(string title, string description, User? asignee)
        {
            this.title = title;
            this.description = description;
            this.asignee = asignee;
        }

        public string Title { get { return title; } set { title = value; } }
        public string Description { get { return description; } set { description = value; } }
    }
}
