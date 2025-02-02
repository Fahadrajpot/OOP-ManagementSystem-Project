using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConsoleBased.UI
{
    internal class AdminUI
    {
        public static int PrintAdminMenu()
        {
            Console.WriteLine("1.Menu Card ");
            Console.WriteLine("2.Add Dish ");
            Console.WriteLine("3.Remove Dish");
            Console.WriteLine("4.Update Dish");
            Console.WriteLine("5.Employee Info");
            Console.WriteLine("6.Add Employee");
            Console.WriteLine("7.Remove Employee");
            Console.WriteLine("8.Update Employee");
            Console.WriteLine("9.Edit Profile");
            Console.WriteLine("10.Sales");
            Console.WriteLine("11.Log Out");
            Console.Write("Enter an option to continue...");
            int Option = int.Parse(Console.ReadLine());
            return Option;
        }
    }
}
