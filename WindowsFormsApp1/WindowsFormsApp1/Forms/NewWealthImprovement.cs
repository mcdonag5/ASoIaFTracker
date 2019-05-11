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
    public partial class NewWealthImprovement : Form
    {
        ///// VARIABLES START //////////////////////////////////////////////////////
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House;
        string holdingID;
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public NewWealthImprovement(int HouseID, string wealthID, string wealthName)
        {
            House = new House(HouseID);
            holdingID = wealthID;

            InitializeComponent();

            lbName.Text = wealthName;
        }
    }
}
