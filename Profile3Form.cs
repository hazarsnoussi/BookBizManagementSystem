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
    public partial class Profile3Form : Form
    {
        public Profile3Form()
        {
            InitializeComponent();
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
            form.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
