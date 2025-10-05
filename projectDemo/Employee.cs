using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectDemo.ist2akDataSetTableAdapters;

namespace projectDemo
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee1BindingSource.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.ist2akDataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2akDataSet1.Employee1' table. You can move, or remove it, as needed.
            this.employee1TableAdapter.Fill(this.ist2akDataSet1.Employee1);
            // TODO: This line of code loads data into the 'ist2akDataSet.Employee' table. You can move, or remove it, as needed.
           //// this.employee1TableAdapter.Fill(this.ist2akDataSet1.Employee1);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void employee1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee1BindingSource.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.ist2akDataSet1);

        }
    }
}
