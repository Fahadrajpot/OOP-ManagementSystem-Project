using Foodies_Cuisine.BL;
using Foodies_Cuisine.DLInterfaces;
using Foodies_Cuisine.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.DL
{
    public class EmployeeDL : IEmployeeDL
    {
        public string ConnectionString = Utility.GetConnectionString();
        public EmployeeDL(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public bool AddEmployee(Employee employee)
        {
            string query = String.Format("Insert into Employees(Name,Gmail,CNIC,ContactNumber)" + " values('{0}','{1}','{2}','{3}')", employee.GetName(), employee.GetGmail(), employee.GetCNIC(), employee.GetContactNumber());
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sql = new SqlCommand(query, sqlConnection);
            int rows = sql.ExecuteNonQuery();
            sqlConnection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string query = "Select * from Employees ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee(Convert.ToString(reader["Name"]), Convert.ToString(reader["Gmail"]), Convert.ToString(reader["CNIC"]), Convert.ToString(reader["ContactNumber"]));
                employees.Add(employee);
            }
            reader.Close();
            sqlConnection.Close();
            return employees;
        }
        public Employee GetEmployee(Employee employe)
        {
            string query = String.Format("Select * from Employees where CNIC = '{0}'", employe.GetCNIC());
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                Employee employee = new Employee(Convert.ToString(reader["Name"]), Convert.ToString(reader["Gmail"]), Convert.ToString(reader["CNIC"]), Convert.ToString(reader["ContactNumber"]));
                return employee;
            }
            return null;
        }

        public bool RemoveEmployee(Employee employee)
        {

            string query = String.Format("Delete from Employees where CNIC ='{0}'", employee.GetCNIC());
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sql = new SqlCommand(query, sqlConnection);
            int rows = sql.ExecuteNonQuery();
            sqlConnection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;

        }
        public bool ValidateEmployee(Employee employee)
        {
            List<Employee> employees = GetEmployees();
            foreach (Employee storedemployees in employees)
            {
                if (storedemployees.GetGmail() == employee.GetGmail() ||storedemployees.GetCNIC()== employee.GetCNIC())
                {
                    return false;
                }
            }
            return true;
        }
        public bool UpdateEmployee(Employee employee,string column)
        {
            if (column == "Name")
            {
                string query = String.Format("Update Employees SET Name = '{0}' WHERE CNIC = '{1}'", employee.GetName(), employee.GetCNIC());
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sql = new SqlCommand(query, sqlConnection);
                int rows = sql.ExecuteNonQuery();
                sqlConnection.Close();
                if (rows > 0)
                {
                    return true;
                }
                return false;
            }
            else if (column == "ContactNumber")
            {
                string query = String.Format("Update Employees SET ContactNumber = '{0}' WHERE CNIC = '{1}'", employee.GetContactNumber(), employee.GetCNIC());
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                sqlConnection.Open();
                SqlCommand sql = new SqlCommand(query, sqlConnection);
                int rows = sql.ExecuteNonQuery();
                sqlConnection.Close();
                if (rows > 0)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
