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
    public partial class SearchOrderForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");

        public SearchOrderForm()
        {
            InitializeComponent();
        }

        private void comboBoxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
           // con.Open();
            string curItem = comboBoxOrderID.Text;
           //MessageBox.Show("curItem"+ curItem);
            SqlCommand cmd = new SqlCommand("SELECT orders.orderID,orders.CustomerID,orders.employeeID,detailOrders.ISBN,detailOrders.quantity,detailOrders.unitPriceOrdred FROM detailOrders INNER JOIN orders ON detailOrders.orderID = orders.orderID AND DetailOrders.orderID='"+Convert.ToInt32(curItem)+"'", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewOrderDetails.DataSource = dt;
            con.Close();
           
        }

        private void SearchOrderForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT orderID FROM orders", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("orderID", typeof(string));
            dt.Load(rdr);
            comboBoxOrderID.ValueMember = "orderID";
            comboBoxOrderID.DisplayMember = "orderID";
            comboBoxOrderID.DataSource = dt;
           
        }
    }
}
