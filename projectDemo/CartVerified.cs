using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectDemo
{
    public partial class CartVerified : Form
    {
        public CartVerified()
        {
            InitializeComponent();
        }

        private void CartVerified_Load(object sender, EventArgs e)
        {

        }
        public void SetTotalAmount(decimal total)
        {
            textBox4.Text = total.ToString("0.00");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal totalAmount = decimal.Parse(textBox4.Text);
            int TotalAmount = (int)totalAmount;

            saleTableAdapter1.InsertQuery(maskedTextBox1.Text, TotalAmount, int.Parse(textBox2.Text), int.Parse(textBox3.Text), comboBox1.Text);
            saleTableAdapter1.Fill(ist2akDataSet11.Sale);
            MessageBox.Show("Sale added successfully");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
