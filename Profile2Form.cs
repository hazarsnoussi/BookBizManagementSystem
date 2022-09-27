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
    public partial class Profile2Form : Form
    {
        public Profile2Form()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
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
