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
    public partial class NewHeirForm : Form
    {
        ///// VARIABLES START //////////////////////////////////////////////////////
        int maleCost;
        int femaleCost;
        //classes
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House;
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////

        ///// METHODS END //////////////////////////////////////////////////////////
        public NewHeirForm(int houseID, string houseName, int mCost,int fCost)
        {
            House = new House(houseID, houseName);
            maleCost = mCost;
            femaleCost = fCost;

            InitializeComponent();

            Text = House.name + " New Heir";
            lbCost.Text = "Cost: " + maleCost + " influence";
        }

        
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            int cost = rbMale.Checked == true ? maleCost : femaleCost;
            lbCost.Text = "Cost: " + cost + " influence";
        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "")
            {
                string gender = rbMale.Checked == true ? "M" : "F";
                House.InsertHeir(tbName.Text,gender,rtbNotes.Text);
                Close();
            } 
            else
            {
                MessageBox.Show("Your heir needs a name.");
            }
        }
        ///// EVENTS END ////////////////////////////////////////////////////////////

    }
}
