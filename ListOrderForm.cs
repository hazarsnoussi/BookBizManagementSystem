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
    public partial class ListOrderForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");
        public ListOrderForm()
        {
            InitializeComponent();
        }

        private void ListOrderForm_Load(object sender, EventArgs e)
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
            con.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewListOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
