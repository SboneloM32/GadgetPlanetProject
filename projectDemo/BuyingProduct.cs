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
    }
}
