using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class LoginValidation
    {
        public static UserRole currentUserRole
        {
            get;
            private set;
        }
        public LoginValidation() { }

        public bool validateUserInput()
        {
            return true;
        }
    }
}
