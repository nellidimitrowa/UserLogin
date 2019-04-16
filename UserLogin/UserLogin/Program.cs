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
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            LoginValidation loginValidation = new LoginValidation(username, password, ActionOnError);
            User user = new User();
            if (loginValidation.ValidateUserInput(ref user))
            {
                int choice;
                do
                {
                    Menu();
                    choice = Convert.ToInt32(Console.ReadLine());
                    UserChoice(choice);
                } while (choice != 0);
                Console.WriteLine(user);
            }
            else
            {
                Console.WriteLine(loginValidation.errorMessage);
            }
            Console.ReadKey();
        }

        public static void ActionOnError(string errorMsg) 
        {
           Console.WriteLine("Error! " + errorMsg);
        }

        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Change user role");
            Console.WriteLine("2. Change user validation");
            Console.WriteLine("3. View all users usernames");
            Console.WriteLine("4. View activity log");
            Console.WriteLine("5. View current session activity");
            Console.Write("Enter choice: ");
        }

        public static void UserChoice(int choice) 
        {
            Dictionary<string, int> allUsers = UserData.PrintAllUsersUsernames();
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Bye.");
                    Console.ReadKey();
                    break;
                case 1:
                    Console.Write("Enter username: ");
                    string userToEditHisRole = Console.ReadLine();
                    Console.WriteLine("1 - Anonymous    2 - Admin   3 - Inspector   4 - Professor 5 - Student");
                    Console.Write("Enter new role: ");
                    int newRole = Convert.ToInt32(Console.ReadLine());
                    newRole = newRole - 1;
                    UserData.AssignUserRole(allUsers[userToEditHisRole], (UserRole)newRole);
                    break;
                case 2:
                    Console.Write("Enter username: ");
                    string userToEditHisActivity = Console.ReadLine();
                    Console.Write("Enter new date (yyyy.mm.dd): ");
                    string date = Console.ReadLine();
                    DateTime newDate = Convert.ToDateTime(date);
                    UserData.SetUserActiveTo(allUsers[userToEditHisActivity], newDate);
                    break;
                case 3:
                    foreach (KeyValuePair<string, int> user in allUsers)
                    {
                        Console.WriteLine(user.Key);
                    }
                    break;
                case 4:
                    Logger.ViewLogActivity();
                    break;
                case 5:
                    Console.Write("Enter filter: ");
                    string filter = Console.ReadLine();
                    Logger.GetCurrentSessionActivities(filter);
                    break;
            }
        }
    }
}
