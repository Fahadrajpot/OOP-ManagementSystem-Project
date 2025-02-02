using Foodies_Cuisine.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.DLInterfaces
{
    public interface IEmployeeDL
    {
        bool AddEmployee(Employee employee);
        List<Employee> GetEmployees();
        Employee GetEmployee(Employee employee);
        bool RemoveEmployee(Employee employee);
        bool ValidateEmployee(Employee employee);
        bool UpdateEmployee(Employee employee, string column);
    }
}
