using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDemo
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2akDataSet1.Employee1' table. You can move, or remove it, as needed.
          //  this.employee1TableAdapter1.Fill(this.ist2akDataSet1.Employee1);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string employeeID = textBox1.Text.Trim();
            string empEmail = textBox2.Text.Trim();
            string username = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(employeeID) || string.IsNullOrEmpty(empEmail) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter all the details.");
                return;
            }
            else
            {
                string connectionString = "Data Source=143.128.146.30\\istn2;Initial Catalog=ist2ak;User ID=ist2ak;Password=kwiy14;";


                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Define your query to check username and password (make sure to hash password in real applications)
                        string query = "SELECT COUNT(*) FROM Employee1 WHERE EmployeeID = @employeeID AND Emp_Email = @empEmail AND Emp_UserName = @username";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Add parameters safely to avoid SQL injection

                            cmd.Parameters.AddWithValue("@employeeID", employeeID);
                            cmd.Parameters.AddWithValue("@empEmail", empEmail);
                            cmd.Parameters.AddWithValue("@Username", username);

                             // In real scenarios, consider hashing the password before saving and comparing

                            // Execute the query and get the result
                            int userCount = (int)cmd.ExecuteScalar();

                            if (userCount > 0)
                            {
                                // If login is successful

                                MessageBox.Show("Verification succesful");
                                label4.Visible = true;  
                                textBox4.Visible = true;
                                button2.Visible = true;

                              //  Products f = new Products();
                               // f.Show();
                               // this.Hide(); // Hide current form
                            }
                            else
                            {
                                // If login fails
                                MessageBox.Show("Invalid Data.");
                                label4.Visible = false;
                                textBox4.Visible = false;
                                button2.Visible = false;
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
        }
    }
}
