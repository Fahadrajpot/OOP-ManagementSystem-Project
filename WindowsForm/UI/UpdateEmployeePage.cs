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
   
    public partial class UpdateEmployeePage : Form
    {
        IEmployeeDL employeeDL = new EmployeeDL(Utility.GetConnectionString());
        public UpdateEmployeePage()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Gmail");
            dataTable.Columns.Add("CNIC");
            dataTable.Columns.Add("Contact Number");
            List<Employee> employees = employeeDL.GetEmployees();
            foreach (Employee employee in employees)
            { 
                if (employee.GetCNIC()== CheckCNICPage.GetCheckCNIC())
                dataTable.Rows.Add(employee.GetName(), employee.GetGmail(), employee.GetCNIC(), employee.GetContactNumber());
            }
            EmployeeData.DataSource= dataTable;
        }

        private void UpdateName_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateNamePage updateNamePage= new UpdateNamePage();
            updateNamePage.ShowDialog();
        }

        private void UpdateContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateContactPage updateContactPage= new UpdateContactPage();
            updateContactPage.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckCNICPage checkCNICPage= new CheckCNICPage();
            checkCNICPage.ShowDialog();
        }

        private void EmployeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
