﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        private static User[] _testUsers;
        public static User[] TestUsers
        {
            get { resetTestUserData(); return _testUsers; }
            set { }
        }

        private static void resetTestUserData()
        {
            _testUsers[0] = new User("nedyalka", "password", "121212605", 1);
            _testUsers[1] = new User("boyana", "password", "125456456", 4);
            _testUsers[2] = new User("dimitar", "password", "12132155", 4);
        }

        private static User isUserPassCorrect(string username, string password)
        {
            for (int i = 0; i < TestUsers.Length; i++)
            {
                if (username.Equals(_testUsers[i].username) && password.Equals(_testUsers[i].password))
                {
                    return _testUsers[i];
                }
            }
            return null;
        }
    }
}
