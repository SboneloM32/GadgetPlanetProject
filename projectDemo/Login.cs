using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel.Design;

namespace projectDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Employee ny = new Employee();
            this.Hide();
            //  this.Close();
            ny.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Employee ny = new Employee();
            ny.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Connection string (replace with your actual DB connection string)
            string connectionString = "Data Source=143.128.146.30\\istn2;Initial Catalog=ist2ak;User ID=ist2ak;Password=kwiy14;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Define your query to check username and password (make sure to hash password in real applications)
                    string query = "SELECT COUNT(*) FROM Employee1 WHERE Emp_UserName = @Username AND Emp_Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters safely to avoid SQL injection
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password); // In real scenarios, consider hashing the password before saving and comparing

                        // Execute the query and get the result
                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            // If login is successful
                            MessageBox.Show("Employee login successful!");
                            Products f = new Products();
                            f.Show();
                            this.Hide(); // Hide current form
                        }
                        else
                        {
                            // If login fails
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., DB connection issues)
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2akDataSet1.Employee1' table. You can move, or remove it, as needed.
            this.employee1TableAdapter.Fill(this.ist2akDataSet1.Employee1);
            // TODO: This line of code loads data into the 'ist2akDataSet1.Employee1' table. You can move, or remove it, as needed.
            this.employee1TableAdapter.Fill(this.ist2akDataSet1.Employee1);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employee1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2akDataSet1);

        }

        private void employee1BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employee1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2akDataSet1);

        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword fg = new ForgetPassword();
            fg.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
