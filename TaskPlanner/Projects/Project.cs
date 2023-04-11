using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPlanner.Departments;
using TaskPlanner.Users;

namespace TaskPlanner.Projects
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

        public ICollection<Task> Tasks { get; set; }

        public ICollection<Department> Departments { get; set; }

        public Client? Client { get; set; }
    }
}
