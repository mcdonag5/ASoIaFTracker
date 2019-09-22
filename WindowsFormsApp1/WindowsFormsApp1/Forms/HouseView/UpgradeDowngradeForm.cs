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
        int oldSpaces;
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
                    
                    oldDefCost = Convert.ToInt32(dgCurrent.Rows[0].Cells[9].Value);
                    oldSpaces = Convert.ToInt32(dgCurrent.Rows[0].Cells[13].Value);

                    dgNewList.DataSource = House.HouseQry("Defense");
                    object[] holdingDef = new object[dgNewList.RowCount];
                    for (int i = 0; i < dgNewList.RowCount; i++)
                    {
                        holdingDef[i] = dgNewList.Rows[i].Cells[1].Value.ToString();
                    }
                    cbHolding.Items.Clear();
                    cbHolding.Items.AddRange(holdingDef);
                    cbHolding.Text = dgCurrent.Rows[0].Cells[8].Value.ToString();
                    break;
                case "Feature":
                    dgCurrent.DataSource = House.HouseQry("UpDown Community", holdingID);

                    Text = "Upgrade/Downgrade " + dgCurrent.Rows[0].Cells[3].Value.ToString();

                    oldLanCost = Convert.ToInt32(dgCurrent.Rows[0].Cells[7].Value);
                    oldPopCost = Convert.ToInt32(dgCurrent.Rows[0].Cells[8].Value);
                    oldSpaces = Convert.ToInt32(dgCurrent.Rows[0].Cells[9].Value);

                    dgNewList.DataSource = House.HouseQry("Land Features Community");
                    object[] holdingFea = new object[dgNewList.RowCount];
                    for (int i = 0; i < dgNewList.RowCount; i++)
                    {
                        holdingFea[i] = dgNewList.Rows[i].Cells[1].Value.ToString();
                    }
                    cbHolding.Items.Clear();
                    cbHolding.Items.AddRange(holdingFea);
                    cbHolding.Text = dgCurrent.Rows[0].Cells[6].Value.ToString();
                    break;
            }
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void CbHolding_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbHolding.SelectedIndex;
            string cost = "";
            string space = "";
            int newSpaces;
            switch (holdingType)
            {
                case "Defense":
                    int defCost = Convert.ToInt32(dgNewList.Rows[index].Cells[2].Value) - oldDefCost;
                    
                    if(defCost != 0)
                    {
                        if(defCost > 0) { cost += "+"; }
                        cost += defCost + " Defense";
                    }
                   newSpaces = Convert.ToInt32(dgNewList.Rows[index].Cells[6].Value) - oldSpaces;
                    if (newSpaces != 0)
                    {
                        if (newSpaces > 0) { space += "+"; }
                        space += newSpaces + " Settlement Holding";
                    }
                    lbDescription.Text = dgNewList.Rows[index].Cells[4].Value.ToString() + Environment.NewLine + "Benfits: " + dgNewList.Rows[index].Cells[5].Value.ToString() + " Can Hold " + dgNewList.Rows[index].Cells[6].Value.ToString() + " settlement Wealth holdings.";
                    break;
                case "Feature":
                    int lanCost = Convert.ToInt32(dgNewList.Rows[index].Cells[2].Value) - oldLanCost;
                    int popCost = Convert.ToInt32(dgNewList.Rows[index].Cells[3].Value) - oldPopCost;
                    newSpaces = Convert.ToInt32(dgNewList.Rows[index].Cells[4].Value) - oldSpaces;

                    if(lanCost!=0)
                    {
                        if(lanCost>0) { cost += "+"; }
                        cost += lanCost + " Land";
                    }
                    if (popCost != 0)
                    {
                        if(cost != "") { cost += ", "; }
                        if (popCost > 0) { cost += "+"; }
                        cost += popCost + " Population";
                    }
                    if (newSpaces != 0)
                    {
                        if (newSpaces > 0) { space += "+"; }
                        space += newSpaces + " Settlement Holding";
                    }
                    lbDescription.Text = dgNewList.Rows[index].Cells[5].Value.ToString() + Environment.NewLine + "Benfits: " + " Can Hold " + dgNewList.Rows[index].Cells[4].Value.ToString() + " settlement Wealth holdings.";
                    break;
            }

            lbCostDetails.Text = cost;
            lbSpacesDetails.Text = space;
            
        }

        private void btUpDown_Click(object sender, EventArgs e)
        {
            int index = cbHolding.SelectedIndex;
            switch (holdingType)
            {
                case "Defense":
                    House.UpdateDefenseUpgradeDowngrade(holdingID, dgNewList.Rows[index].Cells[0].Value.ToString());
                    Close();
                    break;
                case "Feature":
                    House.UpdateLandFeatureUpgradeDowngrade(holdingID, dgNewList.Rows[index].Cells[0].Value.ToString());
                    Close();
                    break;
            }
        }
        

        ///// EVENTS END ////////////////////////////////////////////////////////////

    }
}
