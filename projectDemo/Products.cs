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
         //   double totalPrice = products.TotalPrice;
          //  MessageBox.Show("Total Price = R" + totalPrice.ToString("F2"));

            View_Cart vc = new View_Cart(cartItems);
            vc.Show();
        }
    




        private void button2_Click(object sender, EventArgs e)
        {
 
            double price = 7653.00;
            String productName = label13.Text;
         
            int quantity = (int)numericUpDown2.Value;
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
            //MessageBox.Show("Total Price = R" + totalPrice.ToString("F2"));

              
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
           
            int quantity = (int)numericUpDown3.Value;
            double totalPrice = price * quantity;
            MessageBox.Show("Total Price = R" + totalPrice.ToString("F2"));


            AddToCart(productName, quantity, totalPrice);

        }

        private void MacBookBtn_Click(object sender, EventArgs e)
        {
            double price = 18950.60;
            String productName = label15.Text;
       
            int quantity = (int)numericUpDown4.Value;
            double totalPrice = price * quantity;
            MessageBox.Show("Total Price = R" + totalPrice.ToString("F2"));


            AddToCart(productName, quantity, totalPrice);
        }

        private void AsusBtn_Click(object sender, EventArgs e)
        {
            double price = 9200.81;
            String productName = label16.Text;
          
            int quantity = (int)numericUpDown5.Value;
            double totalPrice = price * quantity;
          //  MessageBox.Show("Total Price = R" + totalPrice.ToString("F2"));


            AddToCart(productName, quantity, totalPrice);
        }

        private void Iphone13Btn_Click(object sender, EventArgs e)
        {
            double price13 = 13450.12;
            String productName = label2.Text;
            int quantity= (int)numericUpDown6.Value;
            double totalPrice = price13 * quantity; 
            AddToCart(productName,quantity, totalPrice);    
            


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iphone15Btn_Click(object sender, EventArgs e)
        {
            double price15 =18999.00;
            String productName = label3.Text;
            int quantity = (int)numericUpDown7.Value;
            double totalPrice = price15 * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void iphone12Btn_Click(object sender, EventArgs e)
        {
            double price12 = 4499.00;
            String productName = label4.Text;   
            int quantity=(int)numericUpDown8.Value;
            double totalPrice = price12 * quantity;
            AddToCart (productName, quantity, totalPrice);  
        }

        private void iphoneSEBtn_Click(object sender, EventArgs e)
        {
            double priceSE = 3890.12;
            String productName = label5.Text;
            int quantity = (int)numericUpDown9.Value;
            double totalPrice = priceSE * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void HuaweiMateBtn_Click(object sender, EventArgs e)
        {
            double priceHM = 21661.00;
            String productName = label6.Text;
            int quantity = (int)numericUpDown10.Value;
            double totalPrice = priceHM * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //********************************************************Change
            double priceHw = 8999.70;
            String productName = label7.Text;
            int quantity = (int)numericUpDown11.Value;
            double totalPrice = priceHw * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //****************************************Change
            double priceS21= 8999.00;
            String productName = label8.Text;
            int quantity = (int)numericUpDown12.Value;
            double totalPrice = priceS21 * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //***********************************************
            double priceS1 = 4210.00;
         
            String productName = label9.Text;
            int quantity = (int)numericUpDown13.Value;
            double totalPrice = priceS1 * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //***************
            double priceN25 = 13212.00;
            String productName = label10.Text;
            int quantity = (int)numericUpDown14.Value;
            double totalPrice = priceN25 * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //*********************
            double priceSE = 21661.00;
            String productName = label11.Text;
            int quantity = (int)numericUpDown15.Value;
            double totalPrice = priceSE * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //*************************
            double priceHH = 29790.00;
            String productName = label12.Text;
            int quantity = (int)numericUpDown16.Value;
            double totalPrice = priceHH * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //**************************************
            double priceHS = 3400.00;
            String productName = label13.Text;
            int quantity = (int)numericUpDown17.Value;
            double totalPrice = priceHS* quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //*******************************************
            double priceMobi= 799.00;
            String productName = label20.Text;
            int quantity = (int)numericUpDown18.Value;
            double totalPrice = priceMobi * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //********************************************
            double priceCan = 8999.00;
            String productName = label21.Text;
            int quantity = (int)numericUpDown19.Value;
            double totalPrice = priceCan * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //******************************************
            double priceSA = 406798.00;
            String productName = label22.Text;
            int quantity = (int)numericUpDown20.Value;
            double totalPrice = priceSA * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //********************************************
            double priceKK = 4299.00;
            String productName = label23.Text;
            int quantity = (int)numericUpDown21.Value;
            double totalPrice = priceKK* quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //*************************Changed
            double priceFuji = 1495.00;
            String productName = label24.Text;
            int quantity = (int)numericUpDown22.Value;
            double totalPrice = priceFuji* quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //**************************
            double priceSE = 21661.00;
            String productName = label25.Text;
            int quantity = (int)numericUpDown23.Value;
            double totalPrice = priceSE * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //******************************
            double priceBr = 2199.00;
            String productName = label26.Text;
            int quantity = (int)numericUpDown24.Value;
            double totalPrice = priceBr * quantity;
            AddToCart(productName, quantity, totalPrice);
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void addNewCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            this.Hide();
            addCustomer.Show();
        }

        private void addNewSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuyingProduct buyingProduct = new BuyingProduct();
            buyingProduct.Show();
        }
    }
}
