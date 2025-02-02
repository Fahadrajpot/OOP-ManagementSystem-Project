using Foodies_Cuisine.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodies_Cuisine.DL;

namespace Foodies_Cuisine.DLInterfaces
{
    public interface ICustomerDL
    {
        bool AddCustomer(Customer customer);
        bool SignUp (Customer customer);
        List<Customer> GetAllCustomers();
        Customer GetCustomer (string CNIC);
    }
}
