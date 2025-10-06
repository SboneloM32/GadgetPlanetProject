
namespace projectDemo
{
    partial class Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saleTableAdapter1 = new projectDemo.ist2akDataSetTableAdapters.SaleTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleTotalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ist2akDataSet1 = new projectDemo.ist2akDataSet1();
            this.saleTableAdapter = new projectDemo.ist2akDataSet1TableAdapters.SaleTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2akDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saleTableAdapter1
            // 
            this.saleTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.saleTotalAmountDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.saleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // saleIDDataGridViewTextBoxColumn
            // 
            this.saleIDDataGridViewTextBoxColumn.DataPropertyName = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.HeaderText = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.Name = "saleIDDataGridViewTextBoxColumn";
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "Sale_Date";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "Sale_Date";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            // 
            // saleTotalAmountDataGridViewTextBoxColumn
            // 
            this.saleTotalAmountDataGridViewTextBoxColumn.DataPropertyName = "Sale_TotalAmount";
            this.saleTotalAmountDataGridViewTextBoxColumn.HeaderText = "Sale_TotalAmount";
            this.saleTotalAmountDataGridViewTextBoxColumn.Name = "saleTotalAmountDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "Sale";
            this.saleBindingSource.DataSource = this.ist2akDataSet1;
            // 
            // ist2akDataSet1
            // 
            this.ist2akDataSet1.DataSetName = "ist2akDataSet1";
            this.ist2akDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 39;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 473);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Sale ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 27);
            this.button2.TabIndex = 40;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProductsToolStripMenuItem,
            this.addNewCustomerToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1310, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allProductsToolStripMenuItem
            // 
            this.allProductsToolStripMenuItem.Name = "allProductsToolStripMenuItem";
            this.allProductsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.allProductsToolStripMenuItem.Text = "Home";
            this.allProductsToolStripMenuItem.Click += new System.EventHandler(this.allProductsToolStripMenuItem_Click);
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCustomersToolStripMenuItem,
            this.addNewCustomerToolStripMenuItem1});
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.addNewCustomerToolStripMenuItem.Text = " Customers";
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewCustomersToolStripMenuItem.Text = "View Customers";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // addNewCustomerToolStripMenuItem1
            // 
            this.addNewCustomerToolStripMenuItem1.Name = "addNewCustomerToolStripMenuItem1";
            this.addNewCustomerToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.addNewCustomerToolStripMenuItem1.Text = "Add new Customer";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProductsToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewProductsToolStripMenuItem.Text = "View Products";
            this.viewProductsToolStripMenuItem.Click += new System.EventHandler(this.viewProductsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSalesToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // viewSalesToolStripMenuItem
            // 
            this.viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            this.viewSalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewSalesToolStripMenuItem.Text = "View Sales";
            this.viewSalesToolStripMenuItem.Click += new System.EventHandler(this.viewSalesToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeesToolStripMenuItem,
            this.addNewEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // viewEmployeesToolStripMenuItem
            // 
            this.viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewEmployeesToolStripMenuItem.Text = "View Employees";
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addNewEmployeeToolStripMenuItem.Text = "Add new Employee";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 586);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2akDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ist2akDataSetTableAdapters.SaleTableAdapter saleTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ist2akDataSet1 ist2akDataSet1;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private ist2akDataSet1TableAdapters.SaleTableAdapter saleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleTotalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
    }
}