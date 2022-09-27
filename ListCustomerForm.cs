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
    public partial class ListCustomerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");
        public ListCustomerForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayCustomer_Load(object sender, EventArgs e)
        {
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM customer";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewCustomer.DataSource = dt;
                con.Close();

            }
        }
    }
}
