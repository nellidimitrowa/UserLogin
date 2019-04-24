using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {
        private static List<User> _testUsers = new List<User>();
        public static List<User> TestUsers
        {
            get { ResetTestUserData(); return _testUsers; }
            set { }
        }

        private static void ResetTestUserData()
        {
            _testUsers.Add(new User("nedyalka", "123456", "121212605", UserRole.ADMIN, DateTime.Today, DateTime.MaxValue));
            _testUsers.Add(new User("boyana", "147258", "125456456", UserRole.STUDENT, DateTime.Today, DateTime.MaxValue));
            _testUsers.Add(new User("dimitar", "654321", "12132155", UserRole.STUDENT, DateTime.Today, DateTime.MaxValue));
        }

        public static User IsUserPassCorrect(string username, string password)
        {

            User findedUser = (from user in TestUsers
                               where username.Equals(user.username) && password.Equals(user.password)
                               select user).FirstOrDefault();

            return findedUser;
        }

        public static User IsUserUsernameCorrect(string username) {
            User findedUser = (from user in TestUsers
                               where username.Equals(user.username)
                               select user).FirstOrDefault();

            return findedUser;
        }

        public static User IsUserPasswordCorrect(string password)
        {
            User findedUser = (from user in TestUsers
                               where password.Equals(user.password)
                               select user).FirstOrDefault();

            return findedUser;
        }
        public static void SetUserActiveTo(int userIndex, DateTime newDate) 
        {
            _testUsers[userIndex].activeDate = newDate;
            Logger.LogActivity("Changed validation to " + _testUsers[userIndex].username);
        }

        public static void AssignUserRole(int  userIndex, UserRole newRole)
        {
            _testUsers[userIndex].userRole = newRole;
            Logger.LogActivity("Changed role to " + _testUsers[userIndex].username);
        }

        public static Dictionary<string,int> PrintAllUsersUsernames()
        {
            Dictionary<string, int> allUsers = new Dictionary<string, int>();
            for (int i = 0; i < _testUsers.Count; i++) 
            {
                allUsers.Add(_testUsers[i].username, i);
            }
            return allUsers;
        }
    }
}
