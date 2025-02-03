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
    public partial class UpdateNamePage : Form
    {
        public UpdateNamePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateName_Click(object sender, EventArgs e)
        {
            IEmployeeDL employeeDL = new EmployeeDL(Utility.GetConnectionString());
            Employee employee = new Employee(CheckCNICPage.GetCheckCNIC());
            employee.SetName( NewName.Text);
            employeeDL.UpdateEmployee(employee,"Name");
            MessageBox.Show("Name Updated");
            this.Hide();
            UpdateEmployeePage updateEmployeePage = new UpdateEmployeePage();
            updateEmployeePage.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateEmployeePage updateEmployeePage2 = new UpdateEmployeePage();
            updateEmployeePage2.ShowDialog();
        }
    }
}
