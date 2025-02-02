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
    public class AdminDL: IAdminDL
    {
        public string ConnectionString = Utility.GetConnectionString();
        public AdminDL(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public bool AddSales(Dish dish)
        {
            string query = String.Format("Insert into Sales(Name,Price)" + " values('{0}','{1}')", dish.GetName(), dish.GetPrice());
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

        public List<Dish> GetSales()
        {
            List<Dish> dishes = new List<Dish>();
            string query = "Select * from Sales ";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Dish dish = new Dish(Convert.ToString(reader["Name"]), Convert.ToInt64(reader["Price"]));
                dishes.Add(dish);
            }
            reader.Close();
            sqlConnection.Close();
            return dishes;
        }
        public bool RemoveSales()
        {

            string query = String.Format("Delete from Sales ");
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
    }
}
