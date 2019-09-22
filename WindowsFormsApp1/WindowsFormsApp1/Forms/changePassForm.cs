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

namespace WindowsFormsApp1.Forms
{
    public partial class changePassForm : Form
    {
        ///// VARIABLES START ///////////////////////////////////////////////////////
        string user = "";
        //Classes
        House House = new House();
        ///// VARIABLES END /////////////////////////////////////////////////////////

        ///// METHODS START /////////////////////////////////////////////////////////

        ///// METHODS END ///////////////////////////////////////////////////////////
        public changePassForm(string username)
        {
            user = username;

            InitializeComponent();


        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void btLogIn_Click(object sender, EventArgs e)
        {
            if(tbNewPass.Text == tbRepeatPass.Text)
            {
                House.UpdatePassword(user, tbNewPass.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Both passwords need to match");
            }
        }

        private void tbRepeatPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btLogIn_Click(sender,e); }
        }

        ///// EVENTS END ////////////////////////////////////////////////////////////

    }
}
