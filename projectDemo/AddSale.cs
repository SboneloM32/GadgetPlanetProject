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
    public partial class AddSale : Form
    {
        public AddSale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saleTableAdapter1.InsertQuery(maskedTextBox1.Text, Decimal.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), comboBox1.Text);
            saleTableAdapter1.Fill(ist2akDataSet11.Sale);
            MessageBox.Show("Sale added successfully.");
        }
    }
}
