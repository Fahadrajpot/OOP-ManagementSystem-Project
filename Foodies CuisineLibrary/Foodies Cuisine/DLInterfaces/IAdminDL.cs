using Foodies_Cuisine.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.DLInterfaces
{
    public interface IAdminDL
    {
        bool AddSales(Dish dish);
        List<Dish> GetSales();
        bool RemoveSales();
    }
}
