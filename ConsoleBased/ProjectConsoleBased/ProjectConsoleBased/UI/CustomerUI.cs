using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConsoleBased.UI
{
    internal class CustomerUI
    {
        public static int PrintCustomerMenu()
        {
            Console.WriteLine("1.Order");
            Console.WriteLine("2.Order History");
            Console.WriteLine("3.Edit Profile");
            Console.WriteLine("4.Feedback");
            Console.WriteLine("5.Log Out");
            Console.WriteLine();
            Console.Write("Enter an option to continue...");
            int Option = int.Parse(Console.ReadLine());
            return Option;
        }
    }
}
