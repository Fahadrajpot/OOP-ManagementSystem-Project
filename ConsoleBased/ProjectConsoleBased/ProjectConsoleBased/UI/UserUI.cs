using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodies_Cuisine;
using Foodies_Cuisine.BL;

namespace ProjectConsoleBased.UI
{
    internal class UserUI
    {
        public static User SignUpUI()
        {
           string Username;
           string Password;
            while (true)
            {
                Console.Write("Enter the username: ");
                Username = Console.ReadLine();
                Console.Write("Enter the Gmail: ");
                string Gmail = Console.ReadLine();
                Console.Write("Enter the CNIC: ");
                string CNIC = Console.ReadLine();
                Console.Write("Enter Contact Number: ");
                string Contact = Console.ReadLine();
                Console.Write("Enter Password: ");
                Password= Console.ReadLine();
                Console.Write("Confirm Password: ");
                string Password1 = Console.ReadLine();
                if (Password == Password1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Credentials");
                    ConsoleUtility.ContinueStatement();
                    Console.Clear();
                    ConsoleUtility.PrintMenu();
                }
            }
            User user = new User(Username, Password, "Customer");
            return user;
        }
        public static User SignInUI()
        {
            Console.Write("Enter the username: ");
            string username = Console.ReadLine();
            Console.Write("Enter the password: ");
            string password = Console.ReadLine();
            User user = new User(username, password);
            return user;
        }
    }
}

