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
    }
}
