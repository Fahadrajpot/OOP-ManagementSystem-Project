using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.BL
{
    public class User
    {
        protected string UserName;
        protected string Password;
        protected string Role;
        public User() { }   
        public User(string UserName)
        {
            this.UserName = UserName;
        }
        public User(string UserName,string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }        
        public User(string UserName, string Password, string Role)
        {
            this.UserName = UserName;
                this.Password = Password;
            this.Role = Role;
        }
        public void SetUserName(string UserName)
        {
            this.UserName= UserName;
        }
        public void SetPassword(string Password)
        { 
                this.Password = Password; 
        }
        public void SetRole(string Role)
        {
            this.Role = Role;
        }
        public string GetUserName() {  return this.UserName; }
        public string GetPassword() {  return this.Password; }
        public string GetRole() { return this.Role; }
    }
}
