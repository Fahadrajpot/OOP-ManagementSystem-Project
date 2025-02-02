using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodies_Cuisine.BL;
using Foodies_Cuisine.DL;
using Foodies_Cuisine.DLInterfaces;
using Foodies_Cuisine.Utilities;

namespace Foodies_Cuisine.DL.FH
{
    public class DishFH: IDishDL
    {
        private static List<Dish> dishes = new List<Dish>();
        private string Path;
        public DishFH(string Path)
        {
            this.Path = Path;
            ReadDishes(Path);
        }
        public bool AddDish(Dish dish)
        {
            dishes.Add(dish);
            StreamWriter streamWriter = new StreamWriter(Path, false);
            foreach (Dish dish1 in dishes)
            {
                streamWriter.WriteLine(dish1.GetName() + "," + dish1.GetPrice());
                streamWriter.Flush();
            }
            streamWriter.Close();
            return true;
        }
        public List<Dish> GetDishList()
        {
            return dishes;
        }
        private bool ReadDishes(string Path)
        {
            StreamReader streamReader = new StreamReader(Path);
            if (File.Exists(Path))
            {
                string record;

                while ((record = streamReader.ReadLine()) != null)
                {
                    string Name = GetField(record, 1);
                    string Price = GetField(record, 2);

                    Dish dish = new Dish(Name, double.Parse(Price));
                    dishes.Add(dish);
                }
                streamReader.Close();
            }
            return true;
        }
        public bool RemoveDish(Dish dish)
        {
            
            foreach (Dish dish1 in dishes)
            {
                if (dish.GetName() == dish1.GetName())
                {
                    dishes.Remove(dish1);
                    StreamWriter streamWriter = new StreamWriter(Path, false);
                    streamWriter.WriteLine(dish1.GetName() + "," + dish1.GetPrice());
                    streamWriter.Flush();
                    streamWriter.Close();
                    return true;
                }
            }
            return false;
        }
        public bool CheckDish(Dish dish)
        {
            foreach (Dish dishes1 in dishes)
            {
                if (dishes1.GetName() == dish.GetName())
                {
                    return false;
                }
            }
            return true;
        }
        public bool UpdateDish(Dish dish)
        {
            foreach(Dish dish1 in dishes)
            {
                if (dish.GetName() == dish1.GetName())
                {
                    dish1.SetPrice(dish.GetPrice());
                }

            }
            StreamWriter streamWriter = new StreamWriter(Path, false);
            foreach (Dish dish1 in dishes)
            {
                streamWriter.WriteLine(dish1.GetName() + "," + dish1.GetPrice());
                streamWriter.Flush();
            }
            streamWriter.Close();
            return true;
        }
        private string GetField(string record, int field)
        {
            int commaCount = 1;
            string result = "";
            for (int x = 0; x < record.Count(); x++)
            {
                if (record[x] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                    result += record[x];
                }
            }
            return result;
        }
    }
}
