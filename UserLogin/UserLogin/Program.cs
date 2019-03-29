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
            if (loginValidation.validateUserInput())
            {
                Console.WriteLine(user);
            }
            Console.ReadKey();
        }
    }
}
