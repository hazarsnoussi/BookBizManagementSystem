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
using BookBizManagementSystem.Validation;

namespace BookBizManagementSystem
{
    public partial class AddCustomerForm : Form
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void RESETbutton_Click(object sender, EventArgs e)
        {


            textBoxCustomerName.Clear();
            textBoxStreetNumber.Clear();
            textBoxStreetName.Clear();
            textBoxCity.Clear();
            textBoxCreditLimit.Clear();
            maskedTextBoxPhoneNumber.Clear();
            maskedTextBoxFax.Clear();
            maskedTextBoxPostalCode.Clear();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MainMenubutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddCust_Click(object sender, EventArgs e)
        {
            //validation all text boxes 
            float x;
            if (!Valid.IsAlphabetical(textBoxCustomerName,5,20)) { MessageBox.Show("Please enter a customer name, from 5 to 20 letters", "Text field empty", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxCustomerName.Focus(); }
            else if (!Valid.IsInteger(textBoxStreetNumber,1,4)) { MessageBox.Show("Please enter a street number between 1 and 4 digits", "Text field empty", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxStreetNumber.Focus(); }
            else if (!Valid.IsAlphabeticalWithSpace(textBoxStreetName,3,20)) { MessageBox.Show("Please enter a street name between 3 and 20 letters", "Text field empty", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxStreetName.Focus(); }
            else if (!Valid.IsAlphabeticalWithSpace(textBoxCity,3,20)) { MessageBox.Show("Please enter a city", "Text field empty", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxCity.Focus(); }
            else if (maskedTextBoxPostalCode.Text.Length != 7) { MessageBox.Show("Please enter a postal code", "Text field empty", MessageBoxButtons.OK, MessageBoxIcon.Error); maskedTextBoxPostalCode.Focus(); }
            else if (maskedTextBoxPhoneNumber.Text.Length != 14) { MessageBox.Show("Please enter a phone number", "Text field empty", MessageBoxButtons.OK, MessageBoxIcon.Error); maskedTextBoxPhoneNumber.Focus(); }
            else if (maskedTextBoxFax.Text.Length != 14) { MessageBox.Show("Please enter a fax number", "Text field empty", MessageBoxButtons.OK, MessageBoxIcon.Error); maskedTextBoxFax.Focus(); }
            else if (!float.TryParse(textBoxCreditLimit.Text,out x)) { MessageBox.Show("Please enter a valid credit limit", "Text field empty", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxCreditLimit.Focus(); }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Customer (customerName,streetNumber,streetName,city,postalCode,phoneNumber,faxNumber,creditLimit) VALUES ('" + textBoxCustomerName.Text.Trim() + "','" + Convert.ToInt32(textBoxStreetNumber.Text.Trim()) + "','" + textBoxStreetName.Text.Trim() + "','" + textBoxCity.Text.Trim() + "','" + maskedTextBoxPostalCode.Text.Trim() + "','" + maskedTextBoxPhoneNumber.Text + "','" + maskedTextBoxFax.Text + "','" + Convert.ToInt32(textBoxCreditLimit.Text.Trim()) + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
