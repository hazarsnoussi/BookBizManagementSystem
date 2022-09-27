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
    public partial class ListBookForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");

        public ListBookForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListBookForm_Load(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT book.ISBN,title AS 'Title',unitPrice AS 'Unit Price',categoryLabel AS 'Categorie',publisherName AS 'Publisher Name',firstName AS 'Author First Name',lastName AS 'Author Last Name' FROM book INNER JOIN writtenBy ON book.ISBN = writtenBy.ISBN INNER JOIN author ON author.authorID = writtenBy.authorID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewBooks.DataSource = dt;
            con.Close();
        }
    }
}
