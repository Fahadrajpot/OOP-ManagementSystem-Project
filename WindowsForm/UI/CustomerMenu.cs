using System;
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
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderPage orderPage = new OrderPage();
            orderPage.Show();
        }

        private void OrderHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderHistoryPage orderHistoryPage = new OrderHistoryPage();
            orderHistoryPage.ShowDialog();
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedbackPage feedbackPage = new FeedbackPage();
            feedbackPage.ShowDialog();
        }

        private void EditProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfilePage editProfilePage = new EditProfilePage();
            editProfilePage.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }
    }
}
