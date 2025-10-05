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
        private List<Product> cartItems = new List<Product>();
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
        // Initialize a list to hold cart items
    

        private void AddToCart(string productName, int quantity ,double price)
        {
            Product products = new Product()
            {
                ProductName = productName,
                Price = price,
                Quantity = quantity
            };


            cartItems.Add(products);
            double totalPrice = products.TotalPrice;
            MessageBox.Show("Total Price = R" + totalPrice.ToString("F2"));

            View_Cart vc = new View_Cart(cartItems);
            vc.Show();
        }
    




        private void button2_Click(object sender, EventArgs e)
        {
 
            double price = 7653.00;
            String productName = label13.Text;
         
            int quantity = (int)numericUpDown1.Value;
            double totalPrice = price * quantity;
            MessageBox.Show("Total Price = R" + totalPrice.ToString("F2"));
          

            AddToCart(productName, quantity, totalPrice);
            return;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            View_Cart nv = new View_Cart(cartItems);
            nv.Show();  
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             String productName= label12.Text;
            double price = 5671.50;
            int quantity = (int)numericUpDown1.Value;
            double totalPrice = price * quantity;
            MessageBox.Show("Total Price = R" + totalPrice.ToString("F2"));

              
            AddToCart(productName , quantity, totalPrice);  

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

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BuyingProduct bp=new BuyingProduct();
            this.Hide();
            bp.Show();
        }

        private void HuaweiLaptopBtn_Click(object sender, EventArgs e)
        {
            double price= 12999.00;
            String productName = label27.Text;
           
            int quantity = (int)numericUpDown1.Value;
            double totalPrice = price * quantity;
            MessageBox.Show("Total Price = R" + totalPrice.ToString("F2"));


            AddToCart(productName, quantity, totalPrice);

        }

        private void MacBookBtn_Click(object sender, EventArgs e)
        {
            double price = 18950.60;
            String productName = label15.Text;
       
            int quantity = (int)numericUpDown1.Value;
            double totalPrice = price * quantity;
            MessageBox.Show("Total Price = R" + totalPrice.ToString("F2"));


            AddToCart(productName, quantity, totalPrice);
        }

        private void AsusBtn_Click(object sender, EventArgs e)
        {
            double price = 9200.81;
            String productName = label16.Text;
          
            int quantity = (int)numericUpDown1.Value;
            double totalPrice = price * quantity;
            MessageBox.Show("Total Price = R" + totalPrice.ToString("F2"));


            AddToCart(productName, quantity, totalPrice);
        }

        private void Iphone13Btn_Click(object sender, EventArgs e)
        {
          
          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
