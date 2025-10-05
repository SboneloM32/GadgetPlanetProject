using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace projectDemo
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2akDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2akDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.ist2akDataSet1.Customer);
            // TODO: This line of code loads data into the 'ist2akDataSet1.Customer1' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.ist2akDataSet1.Customer);
            // TODO: This line of code loads data into the 'ist2akDataSet.Customer' table. You can move, or remove it, as needed.
         

        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products pp = new Products();
            this.Hide();
            pp.Show();//
            // comment ch
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerID = textBox1.Text.Trim();
            
            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Please enter customerID!");
            }
            else
            {
                if (!customerID.All(char.IsDigit))
                {
                    MessageBox.Show("Input must contain only digits!");
                }
                else
                {
                    customerBindingSource.Filter = "CustomerID = '" + customerID + " '";
                }
            }  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string customerID = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Please enter a CustomerID!");
                return;
            }

            if (!customerID.All(char.IsDigit))
            {
                MessageBox.Show("Input must contain only digits!");
                return;
            }

            customerBindingSource.Filter = "CustomerID = '" + customerID + "'";

            if (customerBindingSource.Count == 0)
            {
                MessageBox.Show("No customer found with the provided CustomerID.");
                return;
            }

            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo
            );

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    customerBindingSource.RemoveCurrent();
                    MessageBox.Show("Customer record deleted successfully.");
                    customerBindingSource.EndEdit();
                    customerTableAdapter.Update(ist2akDataSet1);
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

    }
}
