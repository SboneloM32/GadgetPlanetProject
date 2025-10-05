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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            int uppercase = 0;
            int lowercase = 0; 
            int    digit = 0;
            int punctuation = 0;
            string myemployeeID = textBox1.Text.Trim();
            string password = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(password) || password.Length < 8 || password.Length > 12)
            {
                MessageBox.Show("Invalid data");
            }
            else
            {
                for ( int c = 0; c < password.Length; c++)
                {
                    if (Char.IsUpper(password[c]))
                    {
                        uppercase ++;
                    }
                    else if (Char.IsLower(password[c]))
                    {
                        lowercase ++;
                    } 
                    else if (Char.IsDigit(password[c]))
                    {
                        digit ++;  
                    }
                    else if (Char.IsPunctuation(password[c]))
                    {
                        punctuation ++;
                    }
                }
                if (uppercase > 0 && lowercase > 0 && digit > 0 && punctuation > 0)
                {
                    MessageBox.Show("Please log in", "New password is created");


                    string connectionString = "Data Source=143.128.146.30\\istn2;Initial Catalog=ist2ak;User ID=ist2ak;Password=kwiy14;";


                    
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            
                            string query = "Update Employee1 Set Emp_Password = @password WHERE EmployeeID = @myemployeeID";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@myemployeeID", myemployeeID);
                                cmd.Parameters.AddWithValue("@password", password);
                              
                                String newPassword=textBox4.Text;
                                int employeeID = int.Parse(textBox1.Text);
                                employee1TableAdapter1.UpdateQuery(newPassword,employeeID);


                                Login LI = new Login();
                                LI.Show();
                                this.Hide(); 

                            }
                        }
                } 
                else
                {
                    MessageBox.Show("Invalid password!");
                }
            }

           
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

                        
                        string query = "SELECT COUNT(*) FROM Employee1 WHERE EmployeeID = @employeeID AND Emp_Email = @empEmail AND Emp_UserName = @username";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            

                            cmd.Parameters.AddWithValue("@employeeID", employeeID);
                            cmd.Parameters.AddWithValue("@empEmail", empEmail);
                            cmd.Parameters.AddWithValue("@Username", username);

                           
                            int userCount = (int)cmd.ExecuteScalar();

                            if (userCount > 0)
                            {
                                

                                MessageBox.Show("Verification succesful");
                                label4.Visible = true;  
                                textBox4.Visible = true;
                                button2.Visible = true;
                                label5.Visible = true;
                             
                            }
                            else
                            {
                                
                                MessageBox.Show("Invalid Data.");
                                label4.Visible = false;
                                textBox4.Visible = false;
                                button2.Visible = false;
                                label5.Visible = false;
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);



                }
            }
        }
    }
}
