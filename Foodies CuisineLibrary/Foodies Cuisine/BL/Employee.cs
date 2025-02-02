using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodies_Cuisine.BL
{
    public class Employee
    {
        private string Name;
        private string Gmail;
        private string CNIC;
        private string ContactNumber;
        public Employee(string CNIC)
        {
            this.CNIC = CNIC;
        }
        public Employee (string Name,string  Gmail,string CNIC,string ContactNumber)
        {
            this.Name = Name;
            this.Gmail = Gmail;
            this.CNIC = CNIC;
            this.ContactNumber = ContactNumber;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetGmail(string Gmail)
        {
            this.Gmail = Gmail;
        }
        public string GetGmail()
        {
            return this.Gmail;
        }
        public void SetCNIC(string CNIC)
        {
            this.CNIC = CNIC;
        }
        public string GetCNIC()
        {
            return this.CNIC;
        }
        public void SetContactNumber(string ContactNumber)
        {
            this.ContactNumber = ContactNumber;
        }
        public string GetContactNumber()
        {
            return this.ContactNumber;
        }
    }
}
