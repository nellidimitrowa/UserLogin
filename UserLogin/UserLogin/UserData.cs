﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        private static List<User> _testUsers = new List<User>();
        public static List<User> TestUsers
        {
            get { resetTestUserData(); return _testUsers; }
            set { }
        }

        private static void resetTestUserData()
        {
            _testUsers.Add(new User("nedyalka", "password", "121212605", UserRole.ADMIN, DateTime.Today, DateTime.MaxValue));
            _testUsers.Add(new User("boyana", "password", "125456456", UserRole.STUDENT, DateTime.Today, DateTime.MaxValue));
            _testUsers.Add(new User("dimitar", "password", "12132155", UserRole.STUDENT, DateTime.Today, DateTime.MaxValue));
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

        public static void setUserActiveTo(int userIndex, DateTime newDate) 
        {
            _testUsers[userIndex].activeDate = newDate;
            Logger.LogActivity("Changed validation to " + _testUsers[userIndex].username);
        }

        public static void assignUserRole(int  userIndex, UserRole newRole)
        {
            _testUsers[userIndex].userRole = newRole;
            Logger.LogActivity("Changed role to " + _testUsers[userIndex].username);
        }

        public static Dictionary<string,int> printAllUsersUsernames()
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
