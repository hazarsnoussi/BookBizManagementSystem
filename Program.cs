using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthenticationForm());
            //Application.Run(new FCrud());
            //Application.Run(new AddEmployee());
            //Application.Run(new AddCustomerForm());
            //Application.Run(new SearchByIdEmployee());
            //Application.Run(new SearchByIdCustomer());
            //Application.Run(new ListCustomerForm());
            //Application.Run(new ListBookForm());
            //Application.Run(new SearchByISBN());
           // Application.Run(new AddBookForm());
            //Application.Run(new ListEmployeeForm());
            //Application.Run(new PlaceOrderForm());
            //Application.Run(new ListOrderForm());
            //Application.Run(new CancelOrderForm());
            //Application.Run(new SearchOrderForm());
           

        }
    }
}
