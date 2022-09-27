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
    public partial class FCrud : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1V7UU0S;Initial Catalog=BookBizDB;Integrated Security=True");
        public FCrud()
        {
            InitializeComponent();
            
            DateTime time = DateTime.Now;
            Timer timer = new Timer();
            int diffms = time.Millisecond - 100;
            timer.Interval = 1000 - diffms / 2;
            LabelTime.Text = time.ToString("dd-MMM-yyyy HH:mm:ss");
            
           
        }

        private void FCrud_Load(object sender, EventArgs e)
        {

        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            CancelOrderForm form = new CancelOrderForm();
            form.Show();
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            PlaceOrderForm form = new PlaceOrderForm();
            form.Show();
        }

      

       

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            
            AddEmployee FormAddEmp = new AddEmployee();
            FormAddEmp.Show();

        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
           
            AddCustomerForm formAddCust = new AddCustomerForm();
            formAddCust.Show();
        }

        private void ListUsersButton_Click(object sender, EventArgs e)
        {
            ListEmployeeForm dispForm = new ListEmployeeForm();
            dispForm.Show();

        }

        private void ListCustomersButton_Click(object sender, EventArgs e)
        {
            ListCustomerForm fDisp = new ListCustomerForm();
            fDisp.Show();
        }

        private void SearchEmployeeButton_Click(object sender, EventArgs e)
        {
            
            SearchByIdEmployee empForm = new SearchByIdEmployee();
            empForm.Show();
        }

        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            
            SearchByIdCustomer form = new SearchByIdCustomer();
            form.Show();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm form = new AddBookForm();
            form.Show();
        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            SearchByISBN form = new SearchByISBN();
            form.Show();
        }

        private void buttonListBook_Click(object sender, EventArgs e)
        {
            ListBookForm form = new ListBookForm();
            form.Show ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOrderForm form = new ListOrderForm();
            form.Show();
        }

        private void SearchOrderButton_Click(object sender, EventArgs e)
        {
            SearchOrderForm form = new SearchOrderForm();
            form.Show();
        }
    }
}
