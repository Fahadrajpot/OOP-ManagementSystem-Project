using Foodies_Cuisine.DL;
using Foodies_Cuisine.BL;
using Foodies_Cuisine.DLInterfaces;
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

namespace WindowsForm.UI
{
    public partial class AddDishPage : Form
    {
        public AddDishPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            IDishDL dishDL = new DishDL(Utility.GetConnectionString());
            Dish dish = new Dish(DishName.Text, double.Parse(Price.Text));
            if (dishDL.CheckDish(dish))
            {
                dishDL.AddDish(dish);
                MessageBox.Show("Dish Added");
                this.Hide();
                AdminForm adminForm= new AdminForm();
                adminForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void AddDishPage_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
