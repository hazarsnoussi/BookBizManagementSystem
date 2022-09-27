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

namespace BookBizManagementSystem
{
    public partial class AuthenticationForm : Form
        
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");
                                              
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        



        private void CancelButton_Click(object sender, EventArgs e)
        {

            usernameTextBox.Clear();
            passwordTextBox.Clear();
            usernameTextBox.Focus();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            

            con.Open();
            try
            {
                string role =  comboBox1.GetItemText(comboBox1.SelectedItem.ToString());
                string querry = "";
                if (role =="MIS Manage")
                { querry = "SELECT login,password,title FROM employee  WHERE login = '" + usernameTextBox.Text + "' AND password = '" + passwordTextBox.Text + "' AND title = '" + role + "' AND title='MIS Manage'"; }
                else if (role == "SaleManagr")
                { querry = "SELECT login,password,title FROM employee  WHERE login = '" + usernameTextBox.Text + "' AND password = '" + passwordTextBox.Text + "' AND title = '" + role + "' AND title='SaleManagr'"; }
                else if (role == "InventCont")
                { querry = "SELECT login,password,title FROM employee  WHERE login = '" + usernameTextBox.Text + "' AND password = '" + passwordTextBox.Text + "' AND title = '" + role + "' AND title='InventCont'"; }
                else if (role == "OrderClerk")
                { querry = "SELECT login,password,title FROM employee  WHERE login = '" + usernameTextBox.Text + "' AND password = '" + passwordTextBox.Text + "' AND title = '" + role + "' AND title='OrderClerk'"; }
                    
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    if (role == "MIS Manage")
                    {
                        this.Hide();
                        Profile1Form form = new Profile1Form();
                        form.Show();
                    }
                    else if (role == "SaleManagr")
                        {
                            this.Hide();
                            Profile2Form form = new Profile2Form();
                            form.Show();
                        }
                    else if (role == "InventCont")
                    {
                        this.Hide();
                        Profile3Form form = new Profile3Form();
                        form.Show();
                    }
                    else if (role == "OrderClerk")
                        {
                        this.Hide();
                        Profile4Form form = new Profile4Form();
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid login or password", "error authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();

                    usernameTextBox.Focus();
                }
            }
            catch {
                MessageBox.Show("Exception thrown");
            }
            finally { 
                con.Close();
            }
           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
