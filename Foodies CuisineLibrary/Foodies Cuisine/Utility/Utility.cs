using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.Utilities
{
    public class Utility
    {
        private static string ConnectionString = "Data Source = DESKTOP-6VJN5PP\\SQLEXPRESS;Initial Catalog=FoodiesCuisine;Integrated Security=True;";
            public static string GetConnectionString()
        {
            return ConnectionString;
        }
    }
}
