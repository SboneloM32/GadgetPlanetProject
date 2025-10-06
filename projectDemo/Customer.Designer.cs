
namespace projectDemo
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ist2akDataSet1 = new projectDemo.ist2akDataSet1();
            this.customerTableAdapter = new projectDemo.ist2akDataSet1TableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new projectDemo.ist2akDataSet1TableAdapters.TableAdapterManager();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2akDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.custFNameDataGridViewTextBoxColumn,
            this.custLNameDataGridViewTextBoxColumn,
            this.custAddressDataGridViewTextBoxColumn,
            this.custPhoneNumberDataGridViewTextBoxColumn,
            this.custEmailDataGridViewTextBoxColumn,
            this.custUserNameDataGridViewTextBoxColumn,
            this.custPasswordDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(12, 119);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(948, 377);
            this.customerDataGridView.TabIndex = 1;
            this.customerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // custFNameDataGridViewTextBoxColumn
            // 
            this.custFNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_FName";
            this.custFNameDataGridViewTextBoxColumn.HeaderText = "Cust_FName";
            this.custFNameDataGridViewTextBoxColumn.Name = "custFNameDataGridViewTextBoxColumn";
            // 
            // custLNameDataGridViewTextBoxColumn
            // 
            this.custLNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_LName";
            this.custLNameDataGridViewTextBoxColumn.HeaderText = "Cust_LName";
            this.custLNameDataGridViewTextBoxColumn.Name = "custLNameDataGridViewTextBoxColumn";
            // 
            // custAddressDataGridViewTextBoxColumn
            // 
            this.custAddressDataGridViewTextBoxColumn.DataPropertyName = "Cust_Address";
            this.custAddressDataGridViewTextBoxColumn.HeaderText = "Cust_Address";
            this.custAddressDataGridViewTextBoxColumn.Name = "custAddressDataGridViewTextBoxColumn";
            // 
            // custPhoneNumberDataGridViewTextBoxColumn
            // 
            this.custPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Cust_PhoneNumber";
            this.custPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Cust_PhoneNumber";
            this.custPhoneNumberDataGridViewTextBoxColumn.Name = "custPhoneNumberDataGridViewTextBoxColumn";
            // 
            // custEmailDataGridViewTextBoxColumn
            // 
            this.custEmailDataGridViewTextBoxColumn.DataPropertyName = "Cust_Email";
            this.custEmailDataGridViewTextBoxColumn.HeaderText = "Cust_Email";
            this.custEmailDataGridViewTextBoxColumn.Name = "custEmailDataGridViewTextBoxColumn";
            // 
            // custUserNameDataGridViewTextBoxColumn
            // 
            this.custUserNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_UserName";
            this.custUserNameDataGridViewTextBoxColumn.HeaderText = "Cust_UserName";
            this.custUserNameDataGridViewTextBoxColumn.Name = "custUserNameDataGridViewTextBoxColumn";
            // 
            // custPasswordDataGridViewTextBoxColumn
            // 
            this.custPasswordDataGridViewTextBoxColumn.DataPropertyName = "Cust_Password";
            this.custPasswordDataGridViewTextBoxColumn.HeaderText = "Cust_Password";
            this.custPasswordDataGridViewTextBoxColumn.Name = "custPasswordDataGridViewTextBoxColumn";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "Payment_Method";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "Payment_Method";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.ist2akDataSet1;
            // 
            // ist2akDataSet1
            // 
            this.ist2akDataSet1.DataSetName = "ist2akDataSet1";
            this.ist2akDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.Employee1TableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.SaleItemTableAdapter = null;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projectDemo.ist2akDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(1297, 560);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Return to  Product ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 36;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 522);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Customer ID";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(526, 515);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 27);
            this.button4.TabIndex = 42;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1522, 24);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCustomersToolStripMenuItem,
            this.addNewCustomerToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewCustomersToolStripMenuItem.Text = "View Customers";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
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
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewEmployeesToolStripMenuItem.Text = "View Employees";
            this.viewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeesToolStripMenuItem_Click);
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
            this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1212, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Log out";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1522, 606);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.customerDataGridView);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2akDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView customerDataGridView;
        private ist2akDataSet1 ist2akDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private ist2akDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private ist2akDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

