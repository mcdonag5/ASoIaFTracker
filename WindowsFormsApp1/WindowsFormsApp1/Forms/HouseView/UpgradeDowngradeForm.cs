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

namespace WindowsFormsApp1.Forms.HouseView
{
    public partial class UpgradeDowngradeForm : Form
    {
        ///// VARIABLES START ///////////////////////////////////////////////////////
        public string holdingType;
        public string holdingID;

        int oldLanCost;
        int oldPopCost;
        int oldDefCost;
        int spaces;
        //Classes
        House House = new House();
        ///// VARIABLES END /////////////////////////////////////////////////////////

        ///// METHODS START /////////////////////////////////////////////////////////

        ///// METHODS END ///////////////////////////////////////////////////////////
        public UpgradeDowngradeForm(string type, string ID)
        {
            holdingType = type;
            holdingID = ID;

            InitializeComponent();
        }

        private void UpgradeDowngradeForm_Load(object sender, EventArgs e)
        {
            switch(holdingType)
            {
                case "Defense":
                    dgCurrent.DataSource = House.HouseQry("UpDown Defense", holdingID);

                    Text = "Upgrade/Downgrade " + dgCurrent.Rows[0].Cells[3].Value.ToString();
                    
                    oldDefCost = Convert.ToInt16(dgCurrent.Rows[0].Cells[9].Value);
                    spaces = Convert.ToInt32(dgCurrent.Rows[0].Cells[13].Value);

                    dgNewList.DataSource = House.HouseQry("Defense");
                    object[] holding = new object[dgNewList.RowCount];
                    for (int i = 0; i < dgNewList.RowCount; i++)
                    {
                        holding[i] = dgNewList.Rows[i].Cells[1].Value.ToString();
                    }
                    cbHolding.Items.Clear();
                    cbHolding.Items.AddRange(holding);
                    cbHolding.Text = dgCurrent.Rows[0].Cells[8].Value.ToString();
                    break;
                case "Community":

                    break;
            }
        }

        private void cbHolding_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbHolding.SelectedIndex;
            string cost = "";
            switch (holdingType)
            {
                case "Defense":
                    int defCost = Convert.ToInt32(dgNewList.Rows[index].Cells[2].Value) - oldDefCost;
                    
                    if(defCost != 0)
                    {
                        if(defCost > 0) { cost += "+"; }
                        cost += defCost + " Defense";
                    }
                    break;
            }

            lbCostDetails.Text = cost;
        }
        ///// EVENTS START //////////////////////////////////////////////////////////

        ///// EVENTS END ////////////////////////////////////////////////////////////

    }
}
