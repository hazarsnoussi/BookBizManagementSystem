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

namespace BookBizManagementSystem
{
    public partial class AddEmployee : Form

    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void ConfirmPaswordlabel_Click(object sender, EventArgs e)
        {

        }

        private void ResetFormButton_Click(object sender, EventArgs e)
        {

           
            //maskedTextBoxEmpID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxConfirmPassword.Clear();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile1Form form = new Profile1Form();
            form.Show();

        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            
          
            
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string userName = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            //if (empId.Length == 0) { MessageBox.Show("Id field empty", "Empty Identifier Field", MessageBoxButtons.OK, MessageBoxIcon.Error); maskedTextBoxEmpID.Focus(); }
            if (comboBoxRole.GetItemText(comboBoxRole.SelectedItem).Length == 0) { MessageBox.Show("Title field empty", "Empty Title Field", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (firstName.Length == 0) { MessageBox.Show("First Name field empty", "Empty First Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxFirstName.Focus(); }
            else if (lastName.Length == 0) { MessageBox.Show("Last Name field empty", "Empty Last Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxLastName.Focus(); }

            else
            {
                con.Open();
                string title = comboBoxRole.GetItemText(comboBoxRole.SelectedItem);
                if (title == "Employee")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO employee (title,firstName,lastName) VALUES ('" + title + "','" + firstName + "','" + lastName + "')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee successfully added", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (userName.Length == 0) { MessageBox.Show("Username field empty", "Empty Username Field", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxUsername.Focus(); }
                    else if (password.Length == 0) { MessageBox.Show("Password field empty", "Empty Password Field", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxPassword.Focus(); }
                    else if (!(textBoxPassword.Text.Equals(textBoxConfirmPassword.Text)))
                    {
                        MessageBox.Show("retyped password does not match", "Confirmation password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxFirstName.Focus();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO employee (title,firstName,lastName,login,password) VALUES ('" + title + "','" + firstName + "','" + lastName + "','" + userName + "','" + password + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("User successfully added", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } 
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void textBoxEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedIndex == 4) {
                MessageBox.Show("The text fields username and password are not enabled for your profile","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBoxUsername.Enabled = false;
                textBoxPassword.Enabled = false;
                textBoxConfirmPassword.Enabled = false;
            }
        }
    }
}
/*
 •	Add user information
•	Search/List user information
•	Add employee information
•	Search/list employee information
•	Add client information
•	Search/List client information
•	Add/search/list book information and related information
•	Add/Cancel clients’ orders
•	Search/List clients’ orders
*/