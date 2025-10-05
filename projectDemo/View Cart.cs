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
    public partial class View_Cart : Form
    {
        private List<Product> cartItems;
      public View_Cart(List<Product> items)
   
        {
           InitializeComponent();
     
          cartItems = items;
           
            UpdatedCart();
        }
        private void UpdatedCart()
        {
    
            listBox1.Items.Clear();
            foreach (var product in cartItems)
            {
                listBox1.Items.Add($"{product.ProductName} - {product.Quantity} = R{product.Price} ");
            }
        }
        public void AddCartItem(Product product) {
        
            cartItems.Add(product);
            UpdatedCart();

        }
        private void DisplayCartItems()
        {         
            listBox1.Items.Clear();

            foreach (var product in cartItems)
            {
                // Add each product to the ListBox with formatted string
               
                listBox1.Items.Add($"{product.ProductName}-  Quantity:{product.Quantity} -Total Price : R{product.Price:F2}"+Environment.NewLine);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void View_Cart_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products pr = new Products();
           // pr.Hide();
            pr.Show();
        }
    }
}
