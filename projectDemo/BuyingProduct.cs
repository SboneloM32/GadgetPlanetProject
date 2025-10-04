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
            string text = textBox2.Text;
            decimal num3 = decimal.Parse(text);

            productTableAdapter.InsertQuery(textBox2.Text, num3, int.Parse(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text);
            productTableAdapter.Fill(this.ist2akDataSet1.Product);
        }
    }
}
