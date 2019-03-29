using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        public static User TestUser;

        private static void resetTestUserData()
        {
            TestUser = new User("nedyalka", "password", "121212605", 1);
        }
    }
}
