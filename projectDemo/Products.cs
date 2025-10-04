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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            // Enable scrolling on the form
            this.AutoScroll = true;

            // Create a big GroupBox
            GroupBox groupBox1 = new GroupBox();
            groupBox1.Text = "Large GroupBox";
            groupBox1.Width = 300;
            groupBox1.Height = 800;   // bigger than the form height
            groupBox1.Top = 20;
            groupBox1.Left = 20;

            this.Controls.Add(groupBox1);
        }

     

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            View_Cart vc = new View_Cart();
            this.Hide();
            vc.Show();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            this.Hide();
            cs.Show();
            ///
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales cs = new Sales();
            this.Hide();
            cs.Show();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2akDataSet1.Employee1' table. You can move, or remove it, as needed.
            this.employee1TableAdapter.Fill(this.ist2akDataSet1.Employee1);

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BuyingProduct cs= new BuyingProduct();
            cs.Show();
        }
    }
}
