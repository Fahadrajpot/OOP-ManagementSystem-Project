using System;
using Foodies_Cuisine.DL;
using Foodies_Cuisine.DLInterfaces;
using Foodies_Cuisine.BL;
using Foodies_Cuisine.Utilities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.UI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            ICustomerDL customerDL = new CustomerDL(Utility.GetConnectionString());
            IUserDL userDL = new UserDL(Utility.GetConnectionString());
            Customer customer=new Customer(Username.Text, Password.Text,Gmail.Text,CNIC.Text,Contact.Text);
            if (customerDL.SignUp(customer)==true && Password.Text == Confirm.Text)
            {
                User user =new User(Username.Text,Password.Text,"Customer");
                userDL.AddUser(user);
                customerDL.AddCustomer(customer);
                MessageBox.Show("Account Added");
                this.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }
    }
}
