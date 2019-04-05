using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class User
    {
        public string username;
        public string password;
        public string facultyNumber;
        public UserRole userRole;
        public DateTime created;

        public User() { }

        public User(string username, string password, string facultyNumber, UserRole userRole, DateTime created)
        {
            this.username = username;
            this.password = password;
            this.facultyNumber = facultyNumber;
            this.userRole = userRole;
            this.created = created;
        }

        public override string ToString()
        {
            return "Username: " + username + "\nPassword: " + password + "\nFaculty number: " + facultyNumber + "\nUser role: ";
        }
    }
}
