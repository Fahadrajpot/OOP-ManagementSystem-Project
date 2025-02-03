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
    public partial class FeedbackPage : Form
    {
        public FeedbackPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.ShowDialog();
        }
    }
}
