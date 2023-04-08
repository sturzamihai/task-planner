﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Users
{
    public abstract class User
    {
        protected string name;
        protected string email;

        protected User(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public string Name { get { return name; } }
        public string Email { get { return email; } }
    }
}