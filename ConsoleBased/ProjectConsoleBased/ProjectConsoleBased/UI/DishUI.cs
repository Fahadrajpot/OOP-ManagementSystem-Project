using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodies_Cuisine.BL;

namespace ProjectConsoleBased.UI
{
    internal class DishUI
    {
        public static void PrintDishs(List<Dish> dishs )
        {
            Console.WriteLine("Dish Name                               Prices(Rs.)");
            Console.WriteLine();
            foreach (Dish dish in dishs) 
            {
                Console.WriteLine(dish.GetName()+ "                                        "+dish.GetPrice() );
            }
            Console.WriteLine();
            ConsoleUtility.ContinueStatement();
        }

        public static Dish AddDishUI()
        {
            Console.Write("Enter Dish Name: ");
            string Name=Console.ReadLine();
            Console.Write("Enter Dish Price: ");
            double Price=double.Parse(Console.ReadLine());
            ConsoleUtility.ContinueStatement();
            Dish dish = new Dish(Name, Price);
            return dish;
        }
        public static Dish RemoveDishUI()
        {
            Console.Write("Enter Dish Name: ");
            string Name=Console.ReadLine();
            ConsoleUtility.ContinueStatement();
            Dish dish=new Dish(Name);   
            return dish;
        }
        public static Dish UpdateDishUI() 
        {
            Console.Write("Enter Dish Name: ");
            string Name= Console.ReadLine();
            Console.Write("Enter New Price: ");
            double Price = double.Parse(Console.ReadLine());    
            ConsoleUtility.ContinueStatement();
            Dish dish = new Dish(Name,Price);
            return dish;
        }
    }
}
