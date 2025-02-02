using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.BL
{
    public class Dish
    {
        private string Name;
        private double Price;
        public Dish() { }
        public Dish(string Name) { this.Name = Name; }
        public Dish (string Name,double Price) 
        {
            this.Name = Name;
            this.Price = Price;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetPrice(double Price)
        {
            this.Price = Price;
        }
        public double GetPrice()
        {
            return this.Price;
        }
    }
}
