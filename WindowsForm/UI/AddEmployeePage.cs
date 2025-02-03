using Foodies_Cuisine.BL;
using Foodies_Cuisine.DL;
using Foodies_Cuisine.DLInterfaces;
using Foodies_Cuisine.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.UI
{
    public partial class AddEmployeePage : Form
    {
        public AddEmployeePage()
        {
            InitializeComponent();
        }

        private void AddEmployeePage_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Add_Click(object sender, EventArgs e)
        {
            IEmployeeDL employeeDL=new EmployeeDL(Utility.GetConnectionString());
            Employee employee = new Employee(EmpName.Text, Gmail.Text, CNIC.Text, Contact.Text);
            if (employeeDL.ValidateEmployee(employee))
            {
                employeeDL.AddEmployee(employee);
                MessageBox.Show("Employee Added");
                this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
