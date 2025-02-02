using Foodies_Cuisine.BL;
using Foodies_Cuisine.DLInterfaces;
using Foodies_Cuisine.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.DL
{
    public class CustomerDL : ICustomerDL
    {
        public string ConnectionString = Utility.GetConnectionString();
        public CustomerDL(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public bool AddCustomer(Customer customer)
        {
            string query= string.Format("Insert into Customer(Username,Gmail,CNIC,ContactNumber)" + "Values('{0}','{1}','{2}','{3}')", customer.GetUserName(), customer.GetGmail(), customer.GetCNIC(),customer.GetContactNumber());
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sql = new SqlCommand(query, sqlConnection);
            int rowsaffected = sql.ExecuteNonQuery();
            sqlConnection.Close();
            if (rowsaffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Customer> GetAllCustomers()
        {
            List<Customer> Customerlist = new List<Customer>();
            string query = "Select * from Customer";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Customer customer= new Customer(Convert.ToString(reader["UserName"]), Convert.ToString(reader["Gmail"]), Convert.ToString(reader["CNIC"]), Convert.ToString(reader["ContactNumber"]));
                Customerlist.Add(customer);
            }
            return Customerlist;
        }

        public Customer GetCustomer(string CNIC)
        {
            string query = String.Format("Select * from Customer where CNIC = '{0}'", CNIC);
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                Customer customer = new Customer(Convert.ToString(reader["UserName"]), Convert.ToString(reader["Gmail"]), Convert.ToString(reader["CNIC"]), Convert.ToString(reader["ContactNumber"]));
                return customer;
            }
            return null;
        }
        public bool SignUp(Customer customer)
        {
            List<Customer> customers = GetAllCustomers();
            foreach (Customer storedcustomers in customers)
            {
                if (storedcustomers.GetUserName() == customer.GetUserName() || storedcustomers.GetPassword() == customer.GetPassword() || storedcustomers.GetCNIC()==customer.GetCNIC() || storedcustomers.GetGmail()==customer.GetGmail())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
