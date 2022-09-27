using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizManagementSystem
{
    public partial class Profile1Form : Form
    {
        public Profile1Form()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployee FormAddEmp = new AddEmployee();
            FormAddEmp.Show();
        }

        private void SearchEmployeeButton_Click(object sender, EventArgs e)
        {
            SearchByIdEmployee empForm = new SearchByIdEmployee();
            empForm.Show();
        }

        private void ListEmployeesButton_Click(object sender, EventArgs e)
        {
            ListEmployeeForm dispForm = new ListEmployeeForm();
            dispForm.Show();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm formAddCust = new AddCustomerForm();
            formAddCust.Show();
        }

        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            SearchByIdCustomer form = new SearchByIdCustomer();
            form.Show();
        }

        private void ListCustomersButton_Click(object sender, EventArgs e)
        {
            ListCustomerForm fDisp = new ListCustomerForm();
            fDisp.Show();
        }
    }
}
