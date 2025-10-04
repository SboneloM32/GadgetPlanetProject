
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
            this.ist2akDataSet1 = new projectDemo.ist2akDataSet1();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleTableAdapter = new projectDemo.ist2akDataSet1TableAdapters.SaleTableAdapter();
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleTotalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2akDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(613, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // ist2akDataSet1
            // 
            this.ist2akDataSet1.DataSetName = "ist2akDataSet1";
            this.ist2akDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "Sale";
            this.saleBindingSource.DataSource = this.ist2akDataSet1;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SaleID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sale Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sale TotalAmount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CustomerID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "EmployeeID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Payment Method";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(475, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "SaleID", true));
            this.textBox1.Location = new System.Drawing.Point(182, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.saleBindingSource, "Sale_TotalAmount", true));
            this.textBox3.Location = new System.Drawing.Point(182, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "CustomerID", true));
            this.textBox4.Location = new System.Drawing.Point(182, 192);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "EmployeeID", true));
            this.textBox5.Location = new System.Drawing.Point(182, 229);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 20);
            this.textBox5.TabIndex = 14;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "Sale_Date", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(182, 105);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(141, 20);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "PaymentMethod", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Transaction"});
            this.comboBox1.Location = new System.Drawing.Point(182, 265);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 586);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2akDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}