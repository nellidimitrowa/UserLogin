using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        private static User[] _testUsers = new User[3];
        public static User[] TestUsers
        {
            get { resetTestUserData(); return _testUsers; }
            set { }
        }

        private static void resetTestUserData()
        {
            _testUsers[0] = new User("nedyalka", "password", "121212605", UserRole.ADMIN, DateTime.Today, DateTime.MaxValue);
            _testUsers[1] = new User("boyana", "password", "125456456", UserRole.STUDENT, DateTime.Today, DateTime.MaxValue);
            _testUsers[2] = new User("dimitar", "password", "12132155", UserRole.STUDENT, DateTime.Today, DateTime.MaxValue);
        }

        public static User isUserPassCorrect(string username, string password)
        {
            foreach (User user in TestUsers)
            {
                if (username.Equals(user.username) && password.Equals(user.password))
                {
                    return user;
                }
            }
            return null;
        }

        public static void setUserActiveTo(string username, DateTime newDate) 
        {
            foreach (User user in TestUsers)
            {
                if (username.Equals(user.username))
                {
                    user.activeDate = newDate;
                    Logger.LogActivity("Changed validation to " + username);
                }
            }
        }

        public static void assignUserRole(string username, UserRole newRole)
        {
            foreach (User user in TestUsers)
            {
                if (username.Equals(user.username))
                {
                    user.userRole = newRole;
                    Logger.LogActivity("Changed role to " + username);
                }
            }
        }
    }
}
