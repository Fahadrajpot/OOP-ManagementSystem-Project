using Foodies_Cuisine.BL;
using Foodies_Cuisine.DL;
using Foodies_Cuisine.DL.FH;
using Foodies_Cuisine.DLInterfaces;
using Foodies_Cuisine.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.UI
{
    public partial class OrderPage : Form
    { 
    IDishDL dishDL = new DishDL(Utility.GetConnectionString());
        private static Dish dish = new Dish();
        public static void SetDish(Dish dish1)
        {
            dish = dish1;
        } 
        public static Dish GetDish() { return dish; }

        public OrderPage()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Dish Name");
            dataTable.Columns.Add("Price(Rs.)");
            List<Dish> dishes = dishDL.GetDishList();
            foreach (Dish dish in dishes)
            {
                dataTable.Rows.Add(dish.GetName(), dish.GetPrice());
            }
            DishList.DataSource = dataTable;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.ShowDialog();
        }

        private void DishList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            dish.SetName(DishName.Text);
            List<Dish> dishes = dishDL.GetDishList();
            foreach (Dish dish1 in dishes)
            {
                if (dish.GetName()==dish1.GetName())
                {
                    a = 1;
                    dish.SetPrice(dish1.GetPrice());
                    this.Hide();
                    BillPage billPage = new BillPage();
                    billPage.ShowDialog();
                }
            }
            if (a == 0)
            {
                MessageBox.Show("Invalid Dish Name");
            }
        }
    }
}
