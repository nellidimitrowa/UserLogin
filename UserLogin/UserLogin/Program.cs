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
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            LoginValidation loginValidation = new LoginValidation(username, password, actionOnError);
            User user = new User();
            if (loginValidation.validateUserInput(ref user))
            {
                int choice;
                do
                {
                    menu();
                    choice = Convert.ToInt32(Console.ReadLine());
                    userChoice(choice);
                } while (choice != 0);
                Console.WriteLine(user);
            }
            else
            {
                Console.WriteLine(loginValidation.errorMessage);
            }
            Console.ReadKey();
        }

        public static void actionOnError(string errorMsg) 
        {
           Console.WriteLine("Error! " + errorMsg);
        }

        public static void menu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Change user role");
            Console.WriteLine("2. Change user validation");
            Console.WriteLine("3. View all users usernames");
            Console.WriteLine("4. View activity log");
            Console.WriteLine("Enter choice: ");
        }

        public static void userChoice(int choice) 
        {
            Dictionary<string, int> allUsers = UserData.printAllUsersUsernames();
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Bye.");
                    Console.ReadKey();
                    break;
                case 1:
                    Console.WriteLine("Enter username: ");
                    string userToEditHisRole = Console.ReadLine();
                    Console.WriteLine("1 - Anonymous    2 - Admin   3 - Inspector   4 - Professor 5 - Student");
                    Console.WriteLine("Enter new role:");
                    int newRole = Convert.ToInt32(Console.ReadLine());
                    newRole = newRole - 1;
                    UserData.assignUserRole(allUsers[userToEditHisRole], (UserRole)newRole);
                    break;
                case 2:
                    Console.WriteLine("Enter username: ");
                    string userToEditHisActivity = Console.ReadLine();
                    Console.WriteLine("Enter new date (yyyy.mm.dd): ");
                    string date = Console.ReadLine();
                    DateTime newDate = Convert.ToDateTime(date);
                    UserData.setUserActiveTo(allUsers[userToEditHisActivity], newDate);
                    break;
                case 3:
                    foreach (KeyValuePair<string, int> user in allUsers)
                    {
                        Console.WriteLine(user.Key);
                    }
                    break;
                case 4:
                    Logger.viewLogActivity();
                    break;
            }
        }
    }
}
