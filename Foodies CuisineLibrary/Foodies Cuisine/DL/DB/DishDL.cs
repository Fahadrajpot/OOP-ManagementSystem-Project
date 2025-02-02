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
    public class DishDL: IDishDL
    {
        public string ConnectionString = Utility.GetConnectionString();
        public DishDL(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public bool AddDish(Dish dish)
        {
            string query = String.Format("Insert into Dishlist(Name,Price)" + " values('{0}','{1}')",dish.GetName(), dish.GetPrice());
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

        public List<Dish> GetDishList()
        {
            List<Dish> dishes =new List<Dish> ();
            string query = "Select * from Dishlist ";
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
        public bool CheckDish(Dish dish)
        {
            List<Dish> dishs = GetDishList();
            foreach (Dish dishes in dishs)
            {
                if (dishes.GetName() == dish.GetName())
                {
                    return false;
                }
            }
            return true;
        }
        public bool RemoveDish(Dish dish)
        {

            string query = String.Format("Delete from Dishlist where Name ='{0}'", dish.GetName());
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
        public bool UpdateDish(Dish dish)
        {

            string query = String.Format("Update Dishlist SET Price = '{1}' WHERE Name = '{0}'", dish.GetName(),dish.GetPrice());
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
