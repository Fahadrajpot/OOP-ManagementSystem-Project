using Foodies_Cuisine.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.DLInterfaces
{
    public interface IDishDL
    {
        bool AddDish(Dish dish);
        List<Dish> GetDishList();
        bool RemoveDish(Dish dish);
        bool CheckDish(Dish dish);
        bool UpdateDish(Dish dish);
    }
}
