using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Entities.Users
{
    public abstract class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        private string password;
        [Required]
        private string Password // TODO: Update with password hashing logic
        {
            get { return password; }
            set { password = value; }
        }
    }
}
