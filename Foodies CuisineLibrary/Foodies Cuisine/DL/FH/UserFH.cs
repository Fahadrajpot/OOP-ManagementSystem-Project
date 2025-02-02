using System;
using Foodies_Cuisine.BL;
using Foodies_Cuisine.DL;
using Foodies_Cuisine.DLInterfaces;
using System.IO;
using Foodies_Cuisine.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.DL.FH
{
    public class UserFH: IUserDL
    {
        private static List<User> users = new List<User>();
        private string Path;
        public UserFH(string Path)
        {
            this.Path = Path;
            users = RetrieveUsers();
        }
        public bool AddUser(User user)
        {
            users.Add(user);
            StreamWriter streamWriter = new StreamWriter(Path, false);
            foreach (User user1 in users)
            {
                streamWriter.WriteLine(user1.GetUserName() + "," + user1.GetPassword() + "," + user1.GetRole());
                streamWriter.Flush();
            }
            streamWriter.Close();
            return true;
        }
        public List<User> RetrieveUsers()
        {  
            StreamReader streamReader = new StreamReader(Path);
            if(File.Exists(Path))
            {
                string record;
               
                while ((record=streamReader.ReadLine())!=null)
                {
                    string username  = GetField(record,1);
                    string password = GetField(record,2);
                    string role = GetField(record,3);

                    User user = new User(username,password,role);
                    users.Add(user);
                }
                streamReader.Close();
            }
            return users;   
        }
        public User SignIn(User user)
        {
            foreach (User storedusers in users)
            {
                if (storedusers.GetUserName() == user.GetUserName() && storedusers.GetPassword() == user.GetPassword())
                {
                    return storedusers;
                }
            }
            return null;
        }
        private string GetField(string record, int field)
        {
            int commaCount = 1;
            string result = "";
            for (int x = 0; x < record.Count(); x++)
            {
                if (record[x] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                    result += record[x];
                }
            }
            return result;
        }

    }
}
