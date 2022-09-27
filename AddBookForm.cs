using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBizManagementSystem.Validation;


namespace BookBizManagementSystem
{
    public partial class AddBookForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");
        

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            float resul;
           
            if (maskedTextBoxISBN.Text.Length != 17)
            {
                MessageBox.Show("ISBN has 10 digits", "ISBN missing", MessageBoxButtons.OK, MessageBoxIcon.Error); maskedTextBoxISBN.Focus();
            }
            else if (!Valid.IsAlphaNumericWithSpace(textBoxTitle, 3, 20))
            { 
                MessageBox.Show("Title must have at least 5 alphanumerical characters", "Title missing", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxTitle.Focus();
            }
            else if (!float.TryParse(textBoxUnitPrice.Text, out resul) || textBoxUnitPrice.Text.IndexOf(',')>0) { 
                MessageBox.Show("Unit price has at least 1 digits, use . to add decimal part", "Unit price missing", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxUnitPrice.Focus(); 
            }
            else if (!Valid.IsInteger(textBoxPublishedYear,4,4) || Convert.ToInt16(textBoxPublishedYear.Text) < 1600 || Convert.ToInt16(textBoxPublishedYear.Text) >2022) { 
                MessageBox.Show("Published year must have 4 digits, greater than 1600", "Year missing", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxPublishedYear.Focus();
            }
            else if (!Valid.IsInteger(textBoxQuantity, 1, 5)) {
                MessageBox.Show("Quantity must have at least one integer ", "Quantity missing", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxQuantity.Focus(); 
            }
            else if (!Valid.IsAlphabeticalWithSpace(textBoxCategory, 5, 20)) {
                MessageBox.Show("Category must have at least 5 letters and less than 20 characters", "Category missing", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxCategory.Focus();
            }
            else if (!Valid.IsAlphabeticalWithSpace(textBoxPublisher, 3, 20)) { 
                MessageBox.Show("Publisher must have at least 3 letters and less than 20", "Publisher missing", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxQuantity.Focus(); }
            else
            {
                con.Open();

                float up = float.Parse(textBoxUnitPrice.Text);

                int pyear = Convert.ToInt32(textBoxPublishedYear.Text.Trim());
                int qty = Convert.ToInt16(textBoxQuantity.Text.Trim());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO book (ISBN,title,unitPrice,yearPublished,quantityOnHand,publisherName,categoryLabel) VALUES ('" + maskedTextBoxISBN.Text + "','" + textBoxTitle.Text + "','" + up + "','" + pyear + "','" + qty + "','" + textBoxQuantity.Text + "','" + textBoxCategory.Text + "')";
                int res = (int)cmd.ExecuteNonQuery();
                if (res > 0) { MessageBox.Show("Book has been added", "Book added ", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                con.Close();
                label9.Visible = true;
                comboBoxListAuthors.Visible = true;
                butAddAuthor.Visible = true;
                label11.Visible = true;
                label10.Visible = true;
                buttonAddAuthor.Visible = true;
            }
        }

        private void butAddAuthor_Click(object sender, EventArgs e)
        {
            if (comboBoxListAuthors.GetItemText(comboBoxListAuthors.SelectedItem).Length == 0)
            { MessageBox.Show("Please select an author", "Select an author", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                String selected = comboBoxListAuthors.GetItemText(comboBoxListAuthors.SelectedItem);
                string[] fln = selected.Split(',');
                string fn = fln[0];
                string ln = fln[1];
                con.Open();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT authorID FROM author WHERE (firstName = '" + fn + "') AND (lastName = '" + ln + "')";
                int authorId = (int)(cmd1.ExecuteScalar());
                con.Close();
                con.Open();
                cmd1.CommandText = "INSERT INTO writtenBy (authorID,ISBN) VALUES ('" + authorId + "','" + maskedTextBoxISBN.Text + "') ";
                int affectedrow1 = cmd1.ExecuteNonQuery();
                if (affectedrow1 > 0) { MessageBox.Show("Author has been added", "(Co)Author added ", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                con.Close();
            }
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            labelFN.Visible = true;
            textBoxFirstName.Visible = true;
            labelLN.Visible = true;
            textBoxLastName.Visible = true;
            labelEmail.Visible = true;
            textBoxEmail.Visible = true;
            buttonaddAuth.Visible = true;
            buttonResetAuth.Visible = true;
        }

        private void buttonaddAuth_Click(object sender, EventArgs e)
        {
            if (!Valid.IsAlphabetical(textBoxFirstName, 5, 20))
            {
                MessageBox.Show("Please input a valid first name, between 5 and 20 letters)", "First Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxFirstName.Focus();
            }
            else if (!Valid.IsAlphabetical(textBoxLastName, 5, 20))
            {
                MessageBox.Show("Please input a valid last name, between 5 and 20 letters", "Last Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxLastName.Focus();
            }
            else if (!Valid.IsEmail(textBoxEmail, 7, 20))
            {
                MessageBox.Show("Please input a valid email (add . and @), between 7 and 20 characters", "Last Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error); textBoxLastName.Focus();
            }
            else
            {
                con.Open();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "INSERT INTO author(firstName,lastName,email) VALUES ( '" + textBoxFirstName.Text + "', '" + textBoxLastName.Text + "','" + textBoxEmail.Text + "')";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Author added to the list of authors", "Author added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void AddBookForm1_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT CONCAT(firstName,',',lastName) as 'Full Name' FROM author", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Full Name", typeof(string));
            dt.Load(rdr);
            comboBoxListAuthors.ValueMember = "Full Name";
            comboBoxListAuthors.DisplayMember = "Full Name";
            comboBoxListAuthors.DataSource = dt;
            con.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            maskedTextBoxISBN.Clear();
            textBoxTitle.Clear();
            textBoxUnitPrice.Clear();
            textBoxQuantity.Clear();
            textBoxQuantity.Clear();
            textBoxCategory.Clear();
            textBoxPublishedYear.Clear();

        }

        private void buttonResetAuth_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
        }
    }
}
