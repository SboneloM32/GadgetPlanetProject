using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDemo
{
    public partial class BuyingProduct : Form
    {
        public BuyingProduct()
        {
            InitializeComponent();
        }

        private void BuyingProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2akDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.ist2akDataSet1.Product);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productID = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(productID))
            {
                MessageBox.Show("Please enter customerID!");
            }
            else
            {
                if (!productID.All(char.IsDigit))
                {
                    MessageBox.Show("Input must contain only digits!");
                }
                else
                {
                    productBindingSource.Filter = "ProductID = '" + productID + " '";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productID = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(productID))
            {
                MessageBox.Show("Please enter a ProductID!");
                return;
            }

            if (!productID.All(char.IsDigit))
            {
                MessageBox.Show("Input must contain only digits!");
                return;
            }

            productBindingSource.Filter = "ProductID = '" + productID + "'";

            if (productBindingSource.Count == 0)
            {
                MessageBox.Show("No product found with the provided ProductID.");
                return;
            }

            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    productBindingSource.RemoveCurrent();
                    MessageBox.Show("Product record deleted successfully.");
                    productBindingSource.EndEdit();
                    productTableAdapter.Update(ist2akDataSet1);
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer customer = new AddCustomer();
            customer.Show();
            this.Hide();
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

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
           
            sales.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee employee = new AddEmployee();   

            employee.Show();
            this.Hide(); 
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Hide();
        }
    }
}
