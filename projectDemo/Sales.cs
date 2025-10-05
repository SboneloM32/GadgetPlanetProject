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
    }
}
