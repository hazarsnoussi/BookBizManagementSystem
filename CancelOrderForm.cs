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
    public partial class CancelOrderForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");
        
        public CancelOrderForm()
        {
            InitializeComponent();
        }

        private void CancelOrderForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT orders.orderID,orders.employeeID,orders.customerID, concat(employee.firstName, employee.lastName) AS 'Employee Full Name',CustomerName as 'Cutsomer Name' FROM employee INNER JOIN orders ON orders.employeeID = employee.employeeID INNER JOIN customer ON orders.customerID = customer.customerID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewListOrders.DataSource = dt;
            SqlCommand cmd1 = new SqlCommand("SELECT orderID FROM orders", con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("orderID", typeof(string));
            dt1.Load(rdr1);
            comboBoxListOrders.ValueMember = "orderID";
            comboBoxListOrders.DisplayMember = "orderID";
            comboBoxListOrders.DataSource = dt1;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM orders WHERE orderID ='"+comboBoxListOrders.GetItemText(comboBoxListOrders.SelectedItem)+"'";
            int rowsaffected = cmd.ExecuteNonQuery();
            if (rowsaffected > 0) { MessageBox.Show("Order Cancelled","Cancel order",MessageBoxButtons.OK,MessageBoxIcon.Information); }
            con.Close();
            CancelOrderForm_Load(sender,e);
        }

        private void comboBoxISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* string curItem = comboBoxListOrders.Text;
            SqlCommand cmd = new SqlCommand("SELECT orderID FROM orders");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewListOrders.DataSource= dt;*/
        }

        private void comboBoxListOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BackButtton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
