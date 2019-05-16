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
    public partial class NewWealthImprovementForm : Form
    {
        ///// VARIABLES START //////////////////////////////////////////////////////
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House;
        string wealthID;
        string holdingID;
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public NewWealthImprovementForm(int houseID, string houseName, string wealthHoldingID,string weaID, string wealthName)
        {
            House = new House(houseID , House.name);
            holdingID = wealthHoldingID;
            wealthID = weaID;

            InitializeComponent();

            lbName.Text = wealthName + " New Wealth Improvement";
            dgImprovement.DataSource = House.HouseQry("WealthImprovement", wealthID);
            object[] improvement = new object[dgImprovement.RowCount];
            string item;
            for (int i = 0; i < dgImprovement.RowCount; i++)
            {
                item = dgImprovement.Rows[i].Cells[2].Value.ToString();
                if (Convert.ToInt32(dgImprovement.Rows[i].Cells[4].Value) > 0) { item += " Wea: " + dgImprovement.Rows[i].Cells[4].Value.ToString(); }
                if (Convert.ToInt32(dgImprovement.Rows[i].Cells[5].Value) > 0) { item += " Def: " + dgImprovement.Rows[i].Cells[5].Value.ToString(); }
                if (Convert.ToInt32(dgImprovement.Rows[i].Cells[6].Value) > 0) { item += " Lan: " + dgImprovement.Rows[i].Cells[6].Value.ToString(); }
                if (Convert.ToInt32(dgImprovement.Rows[i].Cells[7].Value) > 0) { item += " Pow: " + dgImprovement.Rows[i].Cells[7].Value.ToString(); }
                if (Convert.ToInt32(dgImprovement.Rows[i].Cells[8].Value) > 0) { item += " Inf: " + dgImprovement.Rows[i].Cells[8].Value.ToString(); }
                improvement[i] = item;
            }
            cbImprovement.Items.Clear();
            cbImprovement.Items.AddRange(improvement);
            cbImprovement.SelectedIndex = 0;
        }

        private void CbImprovement_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cost = "";
            if (Convert.ToInt32(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[4].Value) > 0) { cost += " Wealth: " + dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[4].Value.ToString(); }
            if (Convert.ToInt32(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[5].Value) > 0) { cost += " Defense: " + dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[5].Value.ToString(); }
            if (Convert.ToInt32(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[6].Value) > 0) { cost += " Land: " + dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[6].Value.ToString(); }
            if (Convert.ToInt32(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[7].Value) > 0) { cost += " power: " + dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[7].Value.ToString(); }
            if (Convert.ToInt32(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[8].Value) > 0) { cost += " Influence: " + dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[8].Value.ToString(); }
            lbCost.Text = cost;

            lbBuildTime.Text = dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[9].Value.ToString();
            if(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[10].Value.ToString() == "") { label6.Visible = false; lbRequirement.Text = ""; }
            else { label6.Visible = true; lbRequirement.Text = dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[10].Value.ToString(); }
            lbDescription.Text = dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[11].Value.ToString();
            lbBenefits.Text = Environment.NewLine + dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[12].Value.ToString();

        }

        private void BtBuy_Click(object sender, EventArgs e)
        {
            House.InsertWealthImprovementHolding(holdingID, dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[0].Value.ToString(), chbBuilt.Checked.ToString());
            Close();
        }
    }
}
