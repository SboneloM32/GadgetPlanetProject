
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.customerTableAdapter = new projectDemo.ist2akDataSet1TableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new projectDemo.ist2akDataSet1TableAdapters.TableAdapterManager();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2akDataSet1)).BeginInit();
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
            this.customerDataGridView.Location = new System.Drawing.Point(449, 65);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(942, 307);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove Customer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cell Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "UserName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Payment Method";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerID", true));
            this.textBox1.Location = new System.Drawing.Point(155, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "Cust_FName", true));
            this.textBox2.Location = new System.Drawing.Point(155, 97);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "Cust_LName", true));
            this.textBox3.Location = new System.Drawing.Point(155, 138);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(223, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "Cust_Address", true));
            this.textBox4.Location = new System.Drawing.Point(155, 168);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(223, 58);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "Cust_Email", true));
            this.textBox5.Location = new System.Drawing.Point(155, 247);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(223, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "Cust_PhoneNumber", true));
            this.textBox6.Location = new System.Drawing.Point(155, 290);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(167, 20);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "Cust_UserName", true));
            this.textBox7.Location = new System.Drawing.Point(155, 331);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(175, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Payment_Method", true));
            this.textBox8.Location = new System.Drawing.Point(155, 410);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 19;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Password";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Cust_Password", true));
            this.textBox9.Location = new System.Drawing.Point(155, 366);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(167, 20);
            this.textBox9.TabIndex = 21;
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
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1522, 606);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerDataGridView);
            this.Name = "Customer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2akDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button3;
    }
}

