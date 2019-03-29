using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        private static User _testUser;
        public static User TestUser
        {
            get { resetTestUserData(); return _testUser; }
            set { }
        }

        private static void resetTestUserData()
        {
            _testUser = new User("nedyalka", "password", "121212605", 1);
        }
    }
}
