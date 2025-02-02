using Foodies_Cuisine.BL;
using Foodies_Cuisine.DLInterfaces;
using Foodies_Cuisine.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Foodies_Cuisine.DL
{
    public class UserDL: IUserDL
    {
        public  string ConnectionString= Utility.GetConnectionString();
        public UserDL (string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public bool AddUser(User user)
        { 
            string query = string.Format("Insert into Users(Username,Password,Role)" + "Values('{0}','{1}','{2}')", user.GetUserName(), user.GetPassword(), user.GetRole());
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sql = new SqlCommand(query, sqlConnection);
            int rowsaffected =sql.ExecuteNonQuery();    
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
        public List<User> RetrieveUsers()
        {
            List<User> users = new List<User>();
            string query = "Select * from Users";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);   
            SqlDataReader reader = sqlCommand.ExecuteReader();  
            while (reader.Read())
            {
                User user = new User(Convert.ToString(reader["UserName"]), Convert.ToString(reader["Password"]), Convert.ToString(reader["Role"]));
                users.Add(user);
            }
            reader.Close();
            sqlConnection.Close();
            return users;
        }
        public User SignIn(User user)
        {
            List<User> Users = RetrieveUsers();
            foreach (User storedusers in Users)
            {
                if (storedusers.GetUserName() == user.GetUserName() && storedusers.GetPassword() == user.GetPassword())
                {
                    return storedusers;
                }
            }
            return null;
        }
       
    }
}
