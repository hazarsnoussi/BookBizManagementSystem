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
    public partial class SearchByIdEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");
        public SearchByIdEmployee()
        {
            InitializeComponent();
        }

        private void SearchById_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT employeeID FROM employee", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("employeeID", typeof(string));
            dt.Load(rdr);
            comboBoxListId.ValueMember = "employeeID";
            comboBoxListId.DisplayMember = "employeeID";
            comboBoxListId.DataSource = dt;  
        }



       

        private void comboBoxListId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string curItem = comboBoxListId.Text;
            SqlCommand cmd = new SqlCommand("Select * from employee where employeeID='"+curItem+"'", con);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
