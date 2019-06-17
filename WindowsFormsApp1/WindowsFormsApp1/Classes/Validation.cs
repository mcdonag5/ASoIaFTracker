using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Classes
{
    class Validation
    {
        //Allows only postive digits for a textbox
        public void OnlyDigit(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Allows only digits and - symbol for a textbox
        public void OnlyDigitWithNegatives(object sender,KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
        //If the textbox text is null will set to a value
        public void SetNullTo(object sender, string setTo)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).Text = setTo;
            }
        }
        //checks if the label has teh same text and if not will change it to the new text
        public void CheckIfSame(object label, string newText)
        {
            if((label as Label).Text != newText)
            {
                (label as Label).Text = newText;
            }
        }
    }
}
