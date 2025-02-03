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
    public partial class EmployeeInfoPage : Form
    {
        IEmployeeDL employeeDL = new EmployeeDL(Utility.GetConnectionString());
        public EmployeeInfoPage()
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
                dataTable.Rows.Add(employee.GetName(), employee.GetGmail(),employee.GetCNIC(),employee.GetContactNumber());
            }
            EmployeeList.DataSource = dataTable;
        }

        private void DishList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm= new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
