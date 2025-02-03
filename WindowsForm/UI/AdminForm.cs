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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddDish_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDishPage adddishpage = new AddDishPage();
            adddishpage.ShowDialog();
        }

        private void RemoveDish_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveDishPage removedishpage = new RemoveDishPage();
            removedishpage.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        private void UpdateDish_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateDishPage updatedishpage = new UpdateDishPage();
            updatedishpage.ShowDialog();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployeePage addemployeepage = new AddEmployeePage();
            addemployeepage.ShowDialog();
        }

        private void RemoveEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveEmployeePage removedemployeepage = new RemoveEmployeePage();
            removedemployeepage.ShowDialog();
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckCNICPage checkCNICPage = new CheckCNICPage();
            checkCNICPage.ShowDialog();
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesPage updatesalespage = new SalesPage();
            updatesalespage.ShowDialog();
        }

        private void EmployeeInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeInfoPage employeeInfoPage = new EmployeeInfoPage();
            employeeInfoPage.ShowDialog();
        }

        private void EditAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAdminPage editAdminPage= new EditAdminPage();
            editAdminPage.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MenuCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuCardPage menuCardPage = new MenuCardPage();
            menuCardPage.ShowDialog();
        }
    }
}
