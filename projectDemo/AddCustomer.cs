using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectDemo
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ContactNumber = textBox6.Text;
                string EmailAddress = textBox5.Text;
                string Password = textBox9.Text;

                if (string.IsNullOrWhiteSpace(Password) || Password.Length < 8 || Password.Length > 12)
                {
                    MessageBox.Show("Invalid password. Password must be between 8 and 12 characters.");
                    return;
                }

                bool hasUpper = false;
                bool hasLower = false;
                bool hasDigit = false;

                for (int i = 0; i < Password.Length; i++)
                {
                    if (char.IsUpper(Password[i]))
                    {
                        hasUpper = true;
                    }
                    else if (char.IsLower(Password[i]))
                    {
                        hasLower = true;
                    }
                    else if (char.IsDigit(Password[i]))
                    {
                        hasDigit = true;
                    }
                }

                if (!hasUpper || !hasLower || !hasDigit)
                {
                    MessageBox.Show("Invalid password. Password must contain at least one uppercase letter, one lowercase letter, and one number.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(ContactNumber) || ContactNumber.Length != 10 || !ContactNumber.All(char.IsDigit))
                {
                    MessageBox.Show("Invalid contact number. It must be exactly 10 digits and contain only numbers.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(EmailAddress) || !char.IsLetter(EmailAddress[0]) || !EmailAddress.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Invalid email address. It must start with a letter and end with '@gmail.com'.");
                    return;
                }

                customerTableAdapter1.InsertQuery(textBox2.Text, textBox3.Text, textBox4.Text, EmailAddress, ContactNumber, textBox7.Text, Password, textBox8.Text);
                customerTableAdapter1.Fill(ist2akDataSet11.Customer);
                MessageBox.Show("Customer added successfully.");

            }
            catch
            {
                MessageBox.Show("Customer already exist.");

            }
        }
    }
}
