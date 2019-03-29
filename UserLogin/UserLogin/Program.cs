using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginValidation loginValidation = new LoginValidation();
            User user = new User("nedyalka", "password", "121212605", 1);
            if (loginValidation.validateUserInput())
            {
                Console.WriteLine(user);
            }
            Console.ReadKey();
        }
    }
}
