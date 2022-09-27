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
    public partial class SearchByISBN : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");

        public SearchByISBN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = comboBoxISBN.Text;
            //SqlCommand cmd1 = new SqlCommand("SELECT * FROM book WHERE ISBN='" + curItem + "'", con);
            SqlCommand cmd = new SqlCommand("SELECT book.ISBN,title,unitPrice,categoryLabel,publisherName,firstName as 'Author First Name',lastName as 'Author Last Name' FROM book INNER JOIN writtenBy ON book.ISBN = writtenBy.ISBN INNER JOIN author ON author.authorID = writtenBy.authorID AND book.ISBN='" + curItem + "'", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewBooks.DataSource = dt;
            con.Close();
        }

        private void SearchByISBN_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ISBN FROM book", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ISBN", typeof(string));
            dt.Load(rdr);
            comboBoxISBN.ValueMember = "ISBN";
            comboBoxISBN.DisplayMember = "ISBN";
            comboBoxISBN.DataSource = dt;
        }
    }
}
