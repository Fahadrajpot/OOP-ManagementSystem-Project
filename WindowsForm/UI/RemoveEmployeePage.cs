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
    public partial class RemoveEmployeePage : Form
    {
        public RemoveEmployeePage()
        {
            InitializeComponent();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            IEmployeeDL employeeDL = new EmployeeDL(Utility.GetConnectionString());
            Employee employee = new Employee(CNIC.Text);
            List<Employee> employees = employeeDL.GetEmployees();
            foreach (Employee storedemployees in employees)
            {
                if ( storedemployees.GetCNIC() == employee.GetCNIC())
                {
                    employeeDL.RemoveEmployee(employee);
                    MessageBox.Show("Employee Removed");
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                }
            }
            MessageBox.Show("Employee not found");
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm =new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
