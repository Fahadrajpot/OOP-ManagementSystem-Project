using Foodies_Cuisine.BL;
using Foodies_Cuisine.DL;
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
    public partial class MenuCardPage : Form
    {
        IDishDL dishDL = new DishDL(Utility.GetConnectionString());
        public MenuCardPage()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Dish Name");
            dataTable.Columns.Add("Price(Rs.)");
            List<Dish>  dishes = dishDL.GetDishList();
            foreach (Dish dish in dishes) 
            {
                dataTable.Rows.Add(dish.GetName(), dish.GetPrice());
            }
            DishList.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm  = new AdminForm();
            adminForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuCardPage_Load(object sender, EventArgs e)
        {

        }
    }
}
