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
    public partial class SearchByIdCustomer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");
        public SearchByIdCustomer()
        {
            InitializeComponent();
        }

     
        private void comboBoxListId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = comboBoxListId.Text;
            SqlCommand cmd = new SqlCommand("Select * from customer where customerID='" + Convert.ToInt32(curItem) + "'", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewEmployee.DataSource = dt;
            con.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
           
        }

        private void SearchByIdCustomer_Load_1(object sender, EventArgs e)
        {   
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT customerID FROM customer", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("customerID", typeof(string));
                dt.Load(rdr);
                comboBoxListId.ValueMember = "customerID";
                comboBoxListId.DisplayMember = "customerID";
                comboBoxListId.DataSource = dt;
        }
    }
}
