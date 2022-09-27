using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace BookBizManagementSystem.Validation
{
    public static class Valid 
    {
        public static bool IsInteger(TextBox textBoxInput, int min,int max)
        {
            return (Regex.IsMatch(textBoxInput.Text, @"^\d{" + min + "," + max + "}$"));
        }

        public static bool IsAlphabetical(TextBox textBoxInput, int min, int max)

        {                      
            return (Regex.IsMatch(textBoxInput.Text, @"^[a-zA-Z]{" + min + "," + max + "}$"));
        }

        public static bool IsAlphabeticalWithSpace(TextBox textBoxInput, int min, int max)

        {
            return (Regex.IsMatch(textBoxInput.Text, @"^[a-zA-Z ]{" + min + "," + max + "}$"));
        }

        public static bool IsAlphaNumericWithSpace(TextBox textBoxInput, int min, int max)

        {
            return (Regex.IsMatch(textBoxInput.Text, @"^[a-zA-Z0-9 ]{" + min + "," + max + "}$"));
        }

        public static bool IsAlphaNumeric(TextBox textBoxInput, int min, int max)

        {
            return (Regex.IsMatch(textBoxInput.Text, @"^[a-zA-Z0-9]{" + min + "," + max + "}$"));
        }
        public static bool IsEmail(TextBox textBoxInput, int min, int max)

        {//reference stackoverflow.com
            return (Regex.IsMatch(textBoxInput.Text, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"));
        }

    }
}
