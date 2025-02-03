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
    public partial class UpdateContactPage : Form
    {
        public UpdateContactPage()
        {
            InitializeComponent();
        }

        private void UpdateContact_Click(object sender, EventArgs e)
        {
            IEmployeeDL employeeDL = new EmployeeDL(Utility.GetConnectionString());
            Employee employee = new Employee(CheckCNICPage.GetCheckCNIC());
            employee.SetContactNumber(Contact.Text);
            employeeDL.UpdateEmployee(employee, "ContactNumber");
            MessageBox.Show("Contact Number Updated");
            this.Hide();
            UpdateEmployeePage updateEmployeePage = new UpdateEmployeePage();
            updateEmployeePage.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateEmployeePage updateEmployeePage=new UpdateEmployeePage();
            updateEmployeePage.ShowDialog();
        }
    }
}
