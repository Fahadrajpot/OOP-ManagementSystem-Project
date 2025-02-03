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
    public partial class BillPage : Form
    {
        IDishDL dishDL = new DishDL(Utility.GetConnectionString());
        IAdminDL adminDL=new AdminDL(Utility.GetConnectionString());
        public BillPage()
        {
            InitializeComponent();
            Total.Text = OrderPage.GetDish().GetPrice().ToString();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Dish Name");
            dataTable.Columns.Add("Price(Rs.)");
            List<Dish> dishes = dishDL.GetDishList();
            foreach (Dish dish in dishes)
            {
                if (dish.GetName()==OrderPage.GetDish().GetName())
                dataTable.Rows.Add(dish.GetName(), dish.GetPrice());
            }
            DishData.DataSource = dataTable;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderPage orderPage = new OrderPage();
            orderPage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDL.AddSales(OrderPage.GetDish());
            MessageBox.Show("Bill payed");
            this.Hide();
            OrderPage orderPage =new OrderPage();
            orderPage.ShowDialog();
        }

        private void Total_Click(object sender, EventArgs e)
        {
        }

        private void DishData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BillPage_Load(object sender, EventArgs e)
        {

        }
    }
}
