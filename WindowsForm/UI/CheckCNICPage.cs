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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.UI
{
    public partial class CheckCNICPage : Form
    {
        private static string CNICl;
        public static void SetCheckCNIC(string CNIC)
        {
            CNICl = CNIC;
        }
        public static string GetCheckCNIC()
        {
            return CNICl;
        }
        public CheckCNICPage()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int a=0;
            IEmployeeDL employeeDL = new EmployeeDL(Utility.GetConnectionString());
            CNICl = CNIC.Text;
            Employee employee = new Employee(CNIC.Text);
            List<Employee> employees = employeeDL.GetEmployees();
            foreach (Employee storedemployees in employees)
            {
                if (storedemployees.GetCNIC() == employee.GetCNIC())
                {
                    a = 1;
                    this.Hide();
                    UpdateEmployeePage updateEmployeePage = new UpdateEmployeePage();
                    updateEmployeePage.ShowDialog();
                }
            }
            if (a == 0)
            {
                MessageBox.Show("Employee not found");
            }
        }

        private void CheckCNICPage_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();  
            adminForm.ShowDialog();
        }
    }
}
