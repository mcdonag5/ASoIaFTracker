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

        public void OnlyDigit(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void OnlyDigitWithNegatives(object sender,KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '-') && !((sender as TextBox).Text.Length==0))
            {
                e.Handled = true;
            }
            //Set to 0 if no text
            if((sender as TextBox).Text=="")
            {
                (sender as TextBox).Text = "0";
            }
        }
        public void SetNullToZero(object sender)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).Text = "0";
            }
        }
    }
}
