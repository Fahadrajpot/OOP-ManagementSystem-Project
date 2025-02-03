using Foodies_Cuisine.DLInterfaces;
using Foodies_Cuisine.BL;
using Foodies_Cuisine.DL;
using Foodies_Cuisine.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.UI;

namespace WindowsForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            IUserDL DB = new UserDL(Utility.GetConnectionString());
            User user=new User(Username.Text,Password.Text);
            if (DB.SignIn(user) == null)
            {
                MessageBox.Show("Invalid Credentials");
            }
            else
            {
                if (DB.SignIn(user).GetRole() == "Admin")
                {
                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.ShowDialog();
                }
                else if (DB.SignIn(user).GetRole() == "Customer")
                {
                    this.Hide();
                    CustomerMenu customerMenu = new CustomerMenu();
                    customerMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show(DB.SignIn(user).GetRole());
                }
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
