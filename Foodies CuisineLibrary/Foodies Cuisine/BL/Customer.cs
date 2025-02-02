using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.BL
{
    public class Customer : User
    {
        private string Gmail;
        private string CNIC;
        private string ContactNumber;
        private List<Dish> Order=new List<Dish>();
        private string FeedBack;
        public Customer(string UserName, string Gmail, string CNIC, string ContactNumber) : base(UserName)
        {
            Role = "Customer";
            this.Gmail = Gmail;
            this.CNIC = CNIC;
            this.ContactNumber = ContactNumber;
        }

        public Customer(string UserName,string Password,string Gmail, string CNIC, string ContactNumber):base (UserName,Password)
        {
            Role = "Customer";
            this.Gmail = Gmail;
            this.CNIC = CNIC;
            this.ContactNumber = ContactNumber;
        }
        public void SetGamil(string Gmail)
        {
            this.Gmail = Gmail;
        }
        public string GetGmail()
        {
            return this.Gmail;
        }
        public void SetCNIC(string CNIC)
        {
            this.CNIC=CNIC;
        }
        public string GetContactNumber()
        {
            return this.ContactNumber;
        }
        public void SetContactNumber(string ContactNumber)
        {
            this.ContactNumber = ContactNumber;
        }
        public string GetCNIC()
        {
            return this.ContactNumber;
        }
        public void SetFeedBack (string FeedBack)
        {
            this.FeedBack = FeedBack;
        }
        public String GetFeedBack()
        {
            return this.FeedBack;
        }
        public void SetOrder(List<Dish> Order)
        {
            this.Order = Order;
        }
        public List<Dish> GetOrder()
        {
            return this.Order;
        }
    }
}
