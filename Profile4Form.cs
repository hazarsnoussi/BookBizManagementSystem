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
    public partial class Profile4Form : Form
    {
        public Profile4Form()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            PlaceOrderForm form = new PlaceOrderForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOrderForm form = new ListOrderForm();
            form.Show();
        }

        private void SearchOrderButton_Click(object sender, EventArgs e)
        {
            SearchOrderForm form = new SearchOrderForm ();
            form.Show();
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            CancelOrderForm form = new CancelOrderForm();
            form.Show();
        }
    }
}
