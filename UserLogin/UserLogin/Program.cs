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
            Console.WriteLine("username: ");
            string username = Console.ReadLine();
            Console.WriteLine("password: ");
            string password = Console.ReadLine();
            LoginValidation loginValidation = new LoginValidation(username, password, actionOnError);
            User user = new User();
            if (loginValidation.validateUserInput(ref user))
            {
                Console.WriteLine(user);
                LoginValidation.printCurrentUserRole();
            }
            else
            {
                Console.WriteLine(loginValidation.errorMessage);
            }

            DateTime dateAndTime = new DateTime(1997, 11, 16, 13, 30, 00);
            Console.WriteLine(dateAndTime.DayOfWeek);
            Console.ReadKey();
        }

        public static void actionOnError(string errorMsg) 
        {
           Console.WriteLine("!!! Error! " + errorMsg + " !!!");
        }
    }
}
