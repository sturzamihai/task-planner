using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPlanner.Users;

namespace TaskPlanner.Departments
{
    public class Department
    {
        private string name;
        private List<User> members;

        public Department()
        {
            name = "N/A";
            members = new List<User>();
        }

        public Department(string name)
        {
            this.name = name;
            members = new List<User>();
        }

        public string Name { get { return name; } }
        public List<User> Members { get {  return members; } }
    }
}
