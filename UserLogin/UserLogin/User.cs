using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public string username;
        public string password;
        public string facultyNumber;
        public UserRole userRole;
        public DateTime created;
        public DateTime activeDate;

        public User() { }

        public User(string username, string password, string facultyNumber, UserRole userRole, DateTime created, DateTime activeDate)
        {
            this.username = username;
            this.password = password;
            this.facultyNumber = facultyNumber;
            this.userRole = userRole;
            this.created = created;
            this.activeDate = activeDate;
        }

        public override string ToString()
        {
            return "Username: " + username + "\nPassword: " + password + "\nFaculty number: " + facultyNumber + "\nRole : " + userRole + "\nCreated: " + 
                created + "\nActive to: " + activeDate;
        }
    }
}
