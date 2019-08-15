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
        string wealthID;
        string holdingID;
        //Classes
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House;
        Functions Functions = new Functions();
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public NewWealthImprovementForm(int houseID, string houseName, string wealthHoldingID,string weaID, string wealthName, bool limit)
        {
            House = new House(houseID , houseName);
            holdingID = wealthHoldingID;
            wealthID = weaID;

            InitializeComponent();

            lbName.Text = wealthName + " New Wealth Improvement";
            if(limit)
            {
                dgImprovement.DataSource = House.HouseQry("WealthImprovementLimit", wealthID);
            }
            else
            {
                dgImprovement.DataSource = House.HouseQry("WealthImprovement", wealthID);
            }
            
            if(dgImprovement.RowCount>0)
            {
                object[] improvement = new object[dgImprovement.RowCount];
                string item;
                for (int i = 0; i < dgImprovement.RowCount; i++)
                {
                    item = dgImprovement.Rows[i].Cells[2].Value.ToString();
                    if (dgImprovement.Rows[i].Cells[3].Value.ToString() == "False") { item += "*"; }
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
            else
            {
                btBuy.Enabled = false;
            }
            
        }

        private void CbImprovement_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevLog.LogItem(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[2].Value.ToString());
            switch(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[2].Value.ToString())
            {
                case "Trade Connection":
                    cbTradeHouse.Visible = lbTradeHouse.Visible = false;
                    cbTradeLand.Visible = lbTradeLand.Visible = true;

                    dgHouse.DataSource = House.HouseQry("ThisHouse");
                    object[] houses = new object[dgHouse.RowCount];
                    for (int i = 0; i < dgHouse.RowCount; i++)
                    {
                        houses[i] = dgHouse.Rows[i].Cells[1].Value.ToString();
                    }
                    cbTradeHouse.Items.Clear();
                    cbTradeHouse.Items.AddRange(houses);
                    cbTradeHouse.SelectedIndex = 0;
                    break;
                case "Trade Routes":
                    cbTradeHouse.Visible = lbTradeHouse.Visible = cbTradeLand.Visible = lbTradeLand.Visible = true;

                    dgHouse.DataSource = House.HouseQry("OtherHouse");
                    object[] house = new object[dgHouse.RowCount];
                    string prefix;
                    for (int i = 0; i < dgHouse.RowCount; i++)
                    {
                        switch (dgHouse.Rows[i].Cells[3].Value.ToString())
                        {
                            case "The Wall":
                                prefix = "";
                                break;
                            default:
                                prefix = "House ";
                                break;
                        }
                        house[i] = prefix + dgHouse.Rows[i].Cells[1].Value.ToString();
                    }
                    cbTradeHouse.Items.Clear();
                    cbTradeHouse.Items.AddRange(house);
                    cbTradeHouse.SelectedIndex = 0;
                    break;
                default:
                    cbTradeHouse.Visible = cbTradeLand.Visible = lbTradeHouse.Visible = lbTradeLand.Visible = false;
                    break;
            }
            string cost = "";
            if (Convert.ToInt32(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[4].Value) > 0) { cost += "Wealth: " + dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[4].Value.ToString() + " "; }
            if (Convert.ToInt32(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[5].Value) > 0) { cost += "Defense: " + dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[5].Value.ToString() + " "; }
            if (Convert.ToInt32(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[6].Value) > 0) { cost += "Land: " + dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[6].Value.ToString() + " "; }
            if (Convert.ToInt32(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[7].Value) > 0) { cost += "Power: " + dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[7].Value.ToString() + " "; }
            if (Convert.ToInt32(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[8].Value) > 0) { cost += "Influence: " + dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[8].Value.ToString() + " "; }
            lbCost.Text = cost;

            lbBuildTime.Text = dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[9].Value.ToString();
            if(dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[10].Value.ToString() == "") { label6.Visible = false; lbRequirement.Text = ""; }
            else { label6.Visible = true; lbRequirement.Text = dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[10].Value.ToString(); }
            lbDescription.Text = dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[11].Value.ToString();
            lbBenefits.Text = Environment.NewLine + dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[12].Value.ToString();

        }

        private void CbTradeHouse_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgLand.DataSource = House.HouseQry("LandHolding", dgHouse.Rows[cbTradeHouse.SelectedIndex].Cells[0].Value.ToString());
            object[] land = new object[dgLand.RowCount];
            for (int i = 0; i < dgLand.RowCount; i++)
            {
                land[i] = Functions.HoldingName(dgLand.Rows[i].Cells[9].Value.ToString(), dgLand.Rows[i].Cells[4].Value.ToString());
            }
            cbTradeLand.Items.Clear();
            cbTradeLand.Items.AddRange(land);
            cbTradeLand.SelectedIndex = 0;
        }

        private void cbTradeLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tradeValue = 0;
            //Wealth Holdings on Land (Estate)
            dgTrade1.DataSource = House.WealthHolding("LanHol_ID", dgLand.Rows[cbTradeLand.SelectedIndex].Cells[1].Value.ToString(), 1);
            if (dgTrade1.RowCount > 0 && Convert.ToBoolean(dgTrade1.Rows[0].Cells[7].Value))
            {
                tradeValue++;
            }

            //Land Features Towns
            dgTrade1.DataSource = House.HouseQry("LandHoldingCommunity", dgLand.Rows[cbTradeLand.SelectedIndex].Cells[1].Value.ToString());
            for (int t = 0; t < dgTrade1.RowCount; t++)
            {
                dgTrade2.DataSource = House.WealthHolding("LanHolFea_ID", dgTrade1.Rows[t].Cells[0].Value.ToString(), "Artisan Craftsman");
                for (int x = 0; x < dgTrade2.RowCount; x++)
                {
                    if (Convert.ToBoolean(dgTrade2.Rows[x].Cells[7].Value)) { tradeValue++; }
                }
            }
            //Wealth holdings in Def
            dgTrade1.DataSource = House.HouseQry("DefenseHolding", dgLand.Rows[cbTradeLand.SelectedIndex].Cells[1].Value.ToString());
            for (int t = 0; t < dgTrade1.RowCount; t++)
            {
                dgTrade2.DataSource = House.WealthHolding("DefHol_ID", dgTrade1.Rows[t].Cells[0].Value.ToString(), "Artisan Craftsman");
                for (int x = 0; x < dgTrade2.RowCount; x++)
                {
                    if (Convert.ToBoolean(dgTrade2.Rows[x].Cells[7].Value)) { tradeValue++; }
                }
            }

            lbTradeLand.Text = "Land Trade Value: " + tradeValue ;
        }

        private void BtBuy_Click(object sender, EventArgs e)
        {
            switch (dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[2].Value.ToString())
            {
                case "Trade Connection":
                    House.InsertTrade(holdingID, dgLand.Rows[cbTradeLand.SelectedIndex].Cells[1].Value.ToString(), "1", chbBuilt.Checked.ToString());
                    break;
                case "Trade Routes":
                    House.InsertTrade(holdingID, dgLand.Rows[cbTradeLand.SelectedIndex].Cells[1].Value.ToString(), "0", chbBuilt.Checked.ToString());
                    break;
                default:
                    House.InsertWealthImprovementHolding(holdingID, dgImprovement.Rows[cbImprovement.SelectedIndex].Cells[0].Value.ToString(), chbBuilt.Checked.ToString());
                    break;
            }
            Close();
        }

        
    }
}
