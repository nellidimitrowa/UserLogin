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
            if (username.Equals(String.Empty) == true)
            {
                errorMessage = "The username is empty";
                return false;
            }

            if (password.Equals(String.Empty) == true)
            {
                errorMessage = "The password is empty";
                return false;
            }
            if (username.Length < 5)
            {
                errorMessage = "The username is less than 5 characters";
                return false;
            }
            if (password.Length < 5)
            {
                errorMessage = "The password is less than 5 characters";
                return false;
            }
            user = UserData.TestUser;
            currentUserRole = (UserRole)user.userRole;
            return true;
        }
    }
}
