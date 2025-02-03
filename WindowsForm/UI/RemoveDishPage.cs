using Foodies_Cuisine.BL;
using Foodies_Cuisine.DL;
using Foodies_Cuisine.DLInterfaces;
using Foodies_Cuisine.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.UI
{
    public partial class RemoveDishPage : Form
    {
        public RemoveDishPage()
        {
            InitializeComponent();
        }

        private void RemoveDishPage_Load(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            IDishDL dishDL = new DishDL(Utility.GetConnectionString());
            Dish dish = new Dish(DishName.Text);
            if (!dishDL.CheckDish(dish))
            {
                dishDL.RemoveDish(dish);
                MessageBox.Show("Dish Removed");
                this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Dish not found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
