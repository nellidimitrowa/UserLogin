using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class User
    {
        string username;
        string password;
        string facultyNumber;
        int userRole;

        public User() { }

        public User(string username, string password, string facultyNumber, int userRole)
        {
            this.username = username;
            this.password = password;
            this.facultyNumber = facultyNumber;
            this.userRole = userRole;
        }

        public override string ToString()
        {
            return "Username: " + username + "\nPassword: " + password + "\nFaculty number: " + facultyNumber + "\nUser role: " + userRole;
        }
    }
}
