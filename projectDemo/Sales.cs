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

namespace projectDemo
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2akDataSet1.Sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.ist2akDataSet1.Sale);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string saleID = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(saleID))
            {
                MessageBox.Show("Please enter customerID!");
            }
            else
            {
                if (!saleID.All(char.IsDigit))
                {
                    MessageBox.Show("Input must contain only digits!");
                }
                else
                {
                    saleBindingSource.Filter = "SaleID = '" + saleID + " '";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string saleID = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(saleID))
            {
                MessageBox.Show("Please enter a SaleID!");
                return;
            }

            if (!saleID.All(char.IsDigit))
            {
                MessageBox.Show("Input must contain only digits!");
                return;
            }

            saleBindingSource.Filter = "SaleID = '" + saleID + "'";

            if (saleBindingSource.Count == 0)
            {
                MessageBox.Show("No sale found with the provided SaleID.");
                return;
            }

            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    saleBindingSource.RemoveCurrent();
                    MessageBox.Show("Sale record deleted successfully.");
                    saleBindingSource.EndEdit();
                    saleTableAdapter.Update(ist2akDataSet1);
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

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();    
            this.Hide();    
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();  
            sales.Show();   

            this.Hide();    
        }
    }
}
