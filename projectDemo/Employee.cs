using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectDemo.ist2akDataSet1TableAdapters;
using projectDemo.ist2akDataSetTableAdapters;

namespace projectDemo
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee1BindingSource.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.ist2akDataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2akDataSet1.Employee1' table. You can move, or remove it, as needed.
            this.employee1TableAdapter.Fill(this.ist2akDataSet1.Employee1);
            // TODO: This line of code loads data into the 'ist2akDataSet.Employee' table. You can move, or remove it, as needed.
           //// this.employee1TableAdapter.Fill(this.ist2akDataSet1.Employee1);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void employee1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee1BindingSource.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.ist2akDataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string employeeID = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(employeeID))
            {
                MessageBox.Show("Please enter employeeID!");
            }
            else
            {
                if (!employeeID.All(char.IsDigit))
                {
                    MessageBox.Show("Input must contain only digits!");
                }
                else
                {
                    employee1BindingSource.Filter = "EmployeeID = '" + employeeID + " '";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string employeeID = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(employeeID))
            {
                MessageBox.Show("Please enter a EmployeeID!");
                return;
            }

            if (!employeeID.All(char.IsDigit))
            {
                MessageBox.Show("Input must contain only digits!");
                return;
            }

            employee1BindingSource.Filter = "EmployeeID = '" + employeeID + "'";

            if (employee1BindingSource.Count == 0)
            {
                MessageBox.Show("No employee found with the provided EmployeeID.");
                return;
            }

            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    employee1BindingSource.RemoveCurrent();
                    MessageBox.Show("Employee record deleted successfully.");
                    employee1BindingSource.EndEdit();
                    employee1TableAdapter.Update(ist2akDataSet1);
                }
                catch
                {
                    MessageBox.Show("Error deleting customer: ");
                }
            }
            else
            {
                MessageBox.Show("Deletion cancelled.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult confirmLogout;

            confirmLogout = MessageBox.Show("Are you sure you want log out?", "Confirm", MessageBoxButtons.YesNo);
            if (confirmLogout == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer newcustomer = new AddCustomer();
            newcustomer.Show();
            this.Hide();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        private void vieCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products(); 
            products.Show();
            this.Hide();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee newemployee = new AddEmployee();    
            newemployee.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Hide();
        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
