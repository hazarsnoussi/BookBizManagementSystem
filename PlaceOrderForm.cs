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
    public partial class PlaceOrderForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");
        // float total = 0;//global variable that after each insertion to the table 
        public PlaceOrderForm()
        {
            InitializeComponent();
        }

        private void BackButtton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlaceOrderForm_Load(object sender, EventArgs e)
        {
            con.Open();
            //employee
            SqlCommand cmd = new SqlCommand("SELECT employeeID as'employee ID'  FROM employee WHERE title ='OrderClerk'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmployeeID", typeof(string));
            dt.Load(rdr);
            comboBoxEmployeeID.ValueMember = "employee ID";
            comboBoxEmployeeID.DisplayMember = "employee ID";
            comboBoxEmployeeID.DataSource = dt;

            //customer
            SqlCommand cmd1 = new SqlCommand("SELECT customerID as 'customer ID'  FROM customer", con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("customerID", typeof(string));
            dt1.Load(rdr1);
            comboBoxCustomerID.ValueMember = "customer ID";
            comboBoxCustomerID.DisplayMember = "customer ID";
            comboBoxCustomerID.DataSource = dt1;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            buttonCreateOrder.Visible = false;
            comboBoxISBN.Visible = true;
            labelISBN.Visible = true;
            labelQty.Visible = true;
            textBoxQty.Visible = true;
            labeliNFO.Visible = true;
            addBook.Visible = true;
            con.Open();
            //book
            SqlCommand cmd2 = new SqlCommand("SELECT ISBN FROM book", con);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ISBN", typeof(string));
            dt2.Load(rdr2);
            comboBoxISBN.ValueMember = "ISBN";
            comboBoxISBN.DisplayMember = "ISBN";
            comboBoxISBN.DataSource = dt2;
            if (comboBoxEmployeeID.GetItemText(comboBoxEmployeeID.SelectedItem).Length == 0)
            {
                MessageBox.Show("Please select your employee ID", "Select an employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxCustomerID.GetItemText(comboBoxCustomerID.SelectedItem).Length == 0)
            {
                MessageBox.Show("Please select a customer ID", "Select a customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {  //MessageBox.Show(comboBoxEmployeeID.GetItemText(comboBoxEmployeeID.SelectedItem));
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO orders (employeeID,customerID)  VALUES ('" + comboBoxEmployeeID.GetItemText(comboBoxEmployeeID.SelectedItem) + "','" + comboBoxCustomerID.GetItemText(comboBoxCustomerID.SelectedItem) + "')";
                int x = cmd.ExecuteNonQuery();
                if (x > 0) MessageBox.Show("Order has been created, please proceed to adding books", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            int quantity = 0; double creditLimit = 0; double qtyTotalOrder = 0;
            textBoxQty.Visible = true;

            if (comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem).Length == 0)
            {
                MessageBox.Show("Please select an ISBN", "Select an ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Valid.IsInteger(textBoxQty, 1, 4))
            {
                MessageBox.Show("Please enter a valid quantity, between 1 and 4 digits", "Enter valid quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                //since the number of the orders is autoincremented, the current order has the max ID order
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT MAX(orderID) from orders";
                int orderid = (int)cmd1.ExecuteScalar();
                con.Close();
                con.Open();
                //retreive the available qty
                SqlCommand cmd11 = con.CreateCommand();
                cmd11.CommandType = CommandType.Text;
                cmd11.CommandText = "SELECT cast(quantityOnHand as int) FROM book WHERE ISBN = '" + comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem) + "'";
                quantity = (int)cmd11.ExecuteScalar();
                //MessageBox.Show("qtyA " + quantity);

                //check if the ordered quantity is available
                if (quantity >= Convert.ToInt32(textBoxQty.Text))
                {
                    int qtyOrd = Convert.ToInt32(textBoxQty.Text);
                    //retrieve the unit price
                    SqlCommand cmd111 = con.CreateCommand();
                    cmd111.CommandType = CommandType.Text;
                    cmd111.CommandText = "SELECT unitPrice FROM book WHERE ISBN = '" + comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem) + "'";
                    double up = (double)cmd111.ExecuteScalar();
                    double total = (double)(qtyOrd * up);
                    //MessageBox.Show("" + total);
                    SqlCommand cmd22 = con.CreateCommand();
                    cmd22.CommandType = CommandType.Text;
                    cmd22.CommandText = "SELECT creditLimit FROM customer WHERE customerID= '" + comboBoxCustomerID.GetItemText(comboBoxCustomerID.SelectedItem) + "' ";
                    creditLimit = (double)cmd22.ExecuteScalar();


                    if (creditLimit >= total)//if the current balance + current total< creditLimit
                    {
                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "INSERT INTO detailOrders (orderID,ISBN,unitPriceOrdred,quantity) VALUES ('" + orderid + "' , '" + comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem) + "','" + up + "','" + Convert.ToInt32(textBoxQty.Text) + "')";
                        int result = cmd2.ExecuteNonQuery();
                        if (result > 0) MessageBox.Show("Book successfully added to the current order", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        double credi = creditLimit - total;
                        //MessageBox.Show("" + (creditLimit));
                        SqlCommand cmd4 = con.CreateCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "UPDATE customer SET creditLimit =  '" + credi + "' WHERE customerID = '" + Convert.ToInt64(comboBoxCustomerID.GetItemText(comboBoxCustomerID.SelectedItem)) + "'";
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show("The credit limit has been updated", "Credit Limit Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand cmd5 = con.CreateCommand();

                        //MessageBox.Show("ordered qty " + qtyOrd);
                        cmd5.CommandType = CommandType.Text;
                        cmd5.CommandText = "UPDATE book SET quantityOnHand =  '" + (quantity - qtyOrd) + "' WHERE ISBN = '" + (comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem)) + "'";
                        cmd5.ExecuteNonQuery();
                        MessageBox.Show("The quantity on hand of the Book has been updated", "Book Quantity Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Credit limit of this client is insufficent", "Credit Limit insufficient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("The ordred quantity exceeds the available quantity of that Book", "Quantity is not available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
                con.Open();
                SqlCommand cnd = con.CreateCommand();
                cnd.CommandType = CommandType.Text;
                cnd.CommandText = "SELECT SUM (unitPriceOrdred*quantity) FROM detailOrders WHERE orderID = '" + orderid + "'";
                qtyTotalOrder = (double)cnd.ExecuteScalar();
                labelTotal.Text = qtyTotalOrder.ToString() + " CAD";
                
                labelTotal.Visible = true;
                con.Close();
                dataGridViewOrder.Visible = true;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT orders.orderID,orders.customerID,orders.employeeID,detailOrders.ISBN,detailOrders.quantity,detailOrders.unitPriceOrdred FROM detailOrders INNER JOIN orders ON detailOrders.orderID = orders.orderID AND orders.orderID='" + orderid + "'", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewOrder.DataSource = dt;
                con.Close();







                /*con.Open();
                //since the number of the orders is autoincremented, the current order has the max ID order
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT MAX(orderID) from orders";
                int orderid = (int)cmd1.ExecuteScalar();
                //retreive the available qty
                SqlCommand cmd11 = con.CreateCommand();
                cmd11.CommandType = CommandType.Text;
                cmd11.CommandText = "SELECT CAST(quantityOnHand AS INT) FROM book WHERE ISBN = '" + comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem) + "'";
                quantity = (int)cmd1.ExecuteScalar();
                MessageBox.Show(quantity+ "");
                int qtyOrd = Convert.ToInt32(textBoxQty.Text);
                //check if the ordered quantity is available
                if (quantity >= qtyOrd)
                {
                    //retrieve the unit price
                    SqlCommand cmd111 = con.CreateCommand();
                    cmd111.CommandType = CommandType.Text;
                    cmd111.CommandText = "SELECT unitPrice  FROM book WHERE ISBN = '" + comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem) + "'";
                    double up = (double)cmd111.ExecuteScalar();
                    double total = (double)(qtyOrd) * up;
                    MessageBox.Show("total = " + total);
                    SqlCommand cmd22 = con.CreateCommand();
                    cmd22.CommandType = CommandType.Text;
                    cmd22.CommandText = "SELECT creditLimit FROM customer WHERE customerId = '" + comboBoxCustomerID.GetItemText(comboBoxCustomerID.SelectedItem) + "' ";
                    creditLimit = (double)cmd22.ExecuteScalar();


                    *//*SqlCommand cmd222 = con.CreateCommand();
                    cmd222.CommandType = CommandType.Text;
                    cmd222.CommandText = "SELECT (unitPriceOrderd*quantity) FROM detailOrderID WHERE orderID = '"+orderid+"'";
                    float total = (float)cmd1.ExecuteScalar();*//*

                    if (creditLimit >= total)//if the current balance + current total< creditLimit
                    {
                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "INSERT INTO detailOrders (orderID,ISBN,unitPriceOrdred,quantity) VALUES ('" + orderid + "' , '" + comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem) + "','" + up + "','" + Convert.ToInt32(textBoxQty.Text) + "')";
                        int result = cmd2.ExecuteNonQuery();
                        if (result > 0) MessageBox.Show("Book successfully added to the current order", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        double credi = creditLimit - total;
                        MessageBox.Show("The new credit of the customer is = " + (credi));
                        SqlCommand cmd4 = con.CreateCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "UPDATE customer SET creditLimit =  '" + credi + "' WHERE customerID = '" + Convert.ToInt64(comboBoxCustomerID.GetItemText(comboBoxCustomerID.SelectedItem)) + "'";
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show("The credit limit has been updated", "Credit Limit Updated to" +credi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand cmd5 = con.CreateCommand();
                        cmd5.CommandType = CommandType.Text;
                        int nv = (quantity - qtyOrd);
                        cmd5.CommandText = "UPDATE book SET quantityOnHand =  '" + nv  + "' WHERE ISBN = '" + (comboBoxISBN.GetItemText(comboBoxISBN.SelectedItem)) + "'";
                        cmd5.ExecuteNonQuery();
                        MessageBox.Show("The quantity on hand  has been updated to "+ nv, "Credit Limit Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The credit limit is insufficent", "Credit Limit insufficient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("The ordred quantity is currently not available", "Stock not availble", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
                con.Open();
                SqlCommand cnd = con.CreateCommand();
                cnd.CommandType = CommandType.Text;
                cnd.CommandText = "SELECT SUM (unitPriceOrdred*quantity) FROM detailOrders WHERE orderID=orderid";
                labelTotal.Text = "Total = " + cnd.ExecuteScalar().ToString() + " CAD";
                labelTotal.Visible = true;
                con.Close();
                dataGridViewOrder.Visible = true;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT orders.orderID,orders.CustomerID,orders.employeeID,detailOrders.ISBN,detailOrders.quantity,detailOrders.unitPriceOrdred FROM detailOrders INNER JOIN orders ON detailOrders.orderID = orders.orderID AND orders.orderID='" + orderid + "'", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewOrder.DataSource = dt;
                con.Close();
            
            }*/
            }
        }
    }
}
