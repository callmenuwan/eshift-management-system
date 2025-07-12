using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_management
{
    public abstract class User
    {
        public int UId { get; set; }              // Unique user ID
        public string Name { get; set; } = "";     // Name of the user
        public string Email { get; set; } = "";        // Email used as login credential
        public string Password { get; set; } = "";     // Password for login

        public abstract bool Login(string inputEmail, string inputPassword);
    }

}
