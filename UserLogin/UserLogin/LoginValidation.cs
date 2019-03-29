using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class LoginValidation
    {
        string username;
        string password;
        string errorMessage;
        public static UserRole currentUserRole
        {
            get;
            private set;
        }
        public LoginValidation() { }

        public LoginValidation(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool validateUserInput(ref User user)
        {
            user = UserData.TestUser;
            currentUserRole = (UserRole)user.userRole;
            return true;
        }
    }
}
