using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.BL
{
    public class Admin:User
    {
        public Admin() { }
        public Admin(string UserName,string Password,string Role):base(UserName, Password, Role) { }
        private List<Dish> DishList = new List<Dish>();
        private List <Dish> Sales=new List<Dish>();
        private List<Employee> EmployeeList = new List<Employee>();
        public void SetDishList(List<Dish> DishList)
        {
            this.DishList = DishList;
        }
        public List<Dish> GetDishList()
        {
            return DishList;
        }
        public void SetSales(List<Dish> Sales)
        {
            this.Sales = Sales;
        }
        public List<Dish> GetSales()
        {
            return Sales;
        }
        public void SetEmployeeList(List<Employee> EmployeeList)
        {
            this.EmployeeList = EmployeeList;
        }
        public List<Employee> GetEmployeeList()
        {
            return EmployeeList;
        }
    }
}
