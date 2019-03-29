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
        public string errorMessage;
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

            user = UserData.isUserPassCorrect(username, password);
            if (user == null)
            {
                errorMessage = "There is no user with these username or password";
                return false;
            }

            currentUserRole = UserRole.ANONYMOUS;
            return true;
        }

        public static void printCurrentUserRole()
        {
            switch (currentUserRole)
            {
                case UserRole.ANONYMOUS:
                    Console.WriteLine("Anonymous");
                    break;
                case UserRole.ADMIN:
                    Console.WriteLine("Admin");
                    break;
                case UserRole.INSPECTOR:
                    Console.WriteLine("Inspector");
                    break;
                case UserRole.PROFESSOR:
                    Console.WriteLine("Professor");
                    break;
                case UserRole.STUDENT:
                    Console.WriteLine("Student");
                    break;
            }
        }
    }
}
