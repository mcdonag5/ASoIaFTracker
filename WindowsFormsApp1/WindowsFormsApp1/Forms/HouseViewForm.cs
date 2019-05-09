﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class HouseViewForm : Form
    {
        ///// VARIABLES START ////////////////////////////////////////////////////// 
        DevLog DevLog = new DevLog();
        House House;
        public int houseID;
        public int houWea;
        public int houPow;
        public int houPop;
        public int houLaw;
        public int houLan;
        public int houInf;
        public int houDef;
        public int houHF;
        public int houWeaGain;
        public int houPowGain;
        public int houPopGain;
        public int houLawGain;
        public int houLanGain;
        public int houInfGain;
        public int houDefGain;
        public int houWeaLoss;
        public int houPowLoss;
        public int houPopLoss;
        public int houLawLoss;
        public int houLanLoss;
        public int houInfLoss;
        public int houDefLoss;
        public int houPopMit;
        public int houLawMit;
        int[,] LawModifierArry = { { 0, 0, -20 }, { 1, 10, -10 }, { 11, 20, -5 }, { 21, 30, -2 }, { 31, 40, -1 }, { 41, 50, 0 }, { 51, 60, 1 }, { 61, 70, 2 }, { 71, 999, 5 } };
        int[,] PopModifierArry = { { 0, 0, -10 }, { 1, 10, -5 }, { 11, 20, 0 }, { 21, 30, 1 }, { 31, 40, 3 }, { 14, 50, 1 }, { 51, 60, 0 }, { 61, 70, -5 }, { 71, 999, -10 } };
        ///// VARIABLES END ////////////////////////////////////////////////////////
        

        ///// METHODS START ////////////////////////////////////////////////////////
        
        public void UpdateHouse()
        {
            DevLog.LogItem("Updating resources start");
            dgHouse.DataSource = House.HouseQry("ThisHouse");
            tbName.Text = dgHouse.Rows[0].Cells[1].Value.ToString();
            Text = "House "+ dgHouse.Rows[0].Cells[1].Value.ToString();
            tbSeatOfPower.Text = dgHouse.Rows[0].Cells[4].Value.ToString();
            cbRealm.Text = dgHouse.Rows[0].Cells[3].Value.ToString();
            tbLiege.Text = dgHouse.Rows[0].Cells[6].Value.ToString();
            tbLiegeLord.Text = dgHouse.Rows[0].Cells[5].Value.ToString();
            //get current house resources
            houWea = Convert.ToInt32(dgHouse.Rows[0].Cells[7].Value);
            houPow = Convert.ToInt32(dgHouse.Rows[0].Cells[8].Value);
            houPop = Convert.ToInt32(dgHouse.Rows[0].Cells[9].Value);
            houLaw = Convert.ToInt32(dgHouse.Rows[0].Cells[10].Value);
            houLan = Convert.ToInt32(dgHouse.Rows[0].Cells[11].Value);
            houInf = Convert.ToInt32(dgHouse.Rows[0].Cells[12].Value);
            houDef = Convert.ToInt32(dgHouse.Rows[0].Cells[13].Value);
            houHF = 0;
            houWeaGain = 0;
            houPowGain = 0;
            houPopGain = 0;
            houLawGain = 0;
            houLanGain = 0;
            houInfGain = 0;
            houDefGain = 0;
            houWeaLoss = 0;
            houPowLoss = 0;
            houPopLoss = 0;
            houLawLoss = 0;
            houLanLoss = 0;
            houInfLoss = 0;
            houDefLoss = 0;
            houPopMit = 0;
            houLawMit = 0;
            //clear labels
            lbInfHolList.Text = "";
            lbLanHolList.Text = "";
            lbPowHolList.Text = "";
            lbBanList.Text = "";
            lbHeirList.Text = "";
            //set current resources to label
            lbTotalWeaText.Text = houWea.ToString();
            lbTotalPowText.Text = houPow.ToString();
            lbTotalPopText.Text = houPop.ToString();
            lbTotalLawText.Text = houLaw.ToString();
            lbTotalLanText.Text = houLan.ToString();
            lbTotalInfText.Text = houInf.ToString();
            lbTotalDefText.Text = houDef.ToString();

            //Power table
            DevLog.LogItem("Getting units");
            dgHouseDetails.DataSource = House.HouseQry("PowerHolding");
            for (int i = 0; i < dgHouseDetails.RowCount; i++)
            {//Power List
                int traningCost = 0;
                switch (dgHouseDetails.Rows[i].Cells[4].Value)
                {
                    case "Green":
                        traningCost = 1;
                        break;
                    case "Trained":
                        traningCost = 3;
                        break;
                    case "Veteran":
                        traningCost = 5;
                        break;
                    case "Elite":
                        traningCost = 7;
                        break;
                    default:
                        DevLog.LogItem("Traning cost error: " + dgHouseDetails.Rows[i].Cells[4].Value);
                        break;
                }
                houPow -= (Convert.ToInt32(dgHouseDetails.Rows[i].Cells[33].Value) + traningCost) - Convert.ToInt32(dgHouseDetails.Rows[i].Cells[5].Value);

                lbPowHolList.Text += dgHouseDetails.Rows[i].Cells[4].Value.ToString() + " " + dgHouseDetails.Rows[i].Cells[32].Value.ToString() + " - " + dgHouseDetails.Rows[i].Cells[3].Value.ToString() + Environment.NewLine;
            }
            DevLog.LogItem("Getting Banners");

            //Banner Table
            dgHouseDetails.DataSource = House.HouseQry("Banner");
            //set Banner Dice
            lbBannerDiceText.Text = "+"+dgHouseDetails.RowCount.ToString() + "d6";
            for (int i = 0; i < dgHouseDetails.RowCount; i++)
            {
                //Banners List
                if (i == 0) { houPow -= 20; }
                else if (i == 1) { houPow += 10; }
                else { houPow += 5; }
                lbBanList.Text += "House " + dgHouseDetails.Rows[i].Cells[2].Value.ToString() + Environment.NewLine;
            }


            //Influence table
            DevLog.LogItem("Getting Influence Holdings");
            dgHouseDetails.DataSource = House.HouseQry("InfluenceHoldings");
            for (int i = 0; i < dgHouseDetails.RowCount; i++)
            {//Main table
                houInf -= Convert.ToInt32(dgHouseDetails.Rows[i].Cells[11].Value) - Convert.ToInt32(dgHouseDetails.Rows[i].Cells[7].Value);
                houDefGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[14].Value);
                houInfGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[15].Value);
                houLanGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[16].Value);
                houLawGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[17].Value);
                houPopGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[18].Value);
                houPowGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[19].Value);
                houWeaGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[20].Value);
                houLawMit += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[21].Value);
                houPopMit += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[22].Value);

                lbInfHolList.Text += dgHouseDetails.Rows[i].Cells[10].Value.ToString() + " - " + dgHouseDetails.Rows[i].Cells[4].Value.ToString() + Environment.NewLine;
                dgCal1.DataSource = House.HouseQry("InfluenceHolding", dgHouseDetails.Rows[i].Cells[1].Value.ToString());
                for (int n = 0; n < dgCal1.RowCount - 1; n++)
                {//Imp Table
                    houInf -= Convert.ToInt32(dgCal1.Rows[n].Cells[7].Value);
                    lbInfHolList.Text += "       " + dgCal1.Rows[n].Cells[6].Value.ToString() + Environment.NewLine;
                }
            }
            //Heir table
            DevLog.LogItem("Getting Heirs");
            dgHouseDetails.DataSource = House.HouseQry("Heir");
            int male = 0;
            int female = 0;
            for (int i = 0; i < dgHouseDetails.RowCount; i++)
            {
                if (dgHouseDetails.Rows[i].Cells[3].Value.ToString()=="M"||cbRealm.Text=="Dorne")
                {
                    male++;
                    if(male==1) { houInf -= 20; }
                    else if (male == 2) { houInf -= 10; }
                    else { houInf -= 5; }
                } else {
                    female++;
                    if(female==1) { houInf -= 10; }
                    else { houInf -= 5; }
                }
                lbHeirList.Text += dgHouseDetails.Rows[i].Cells[2].Value.ToString() + Environment.NewLine;
            }

            //Land table
            DevLog.LogItem("Getting land holdings");
            dgHouseDetails.DataSource = House.HouseQry("LandHolding");
            for (int i = 0; i < dgHouseDetails.RowCount; i++)
            {
                houLan -= Convert.ToInt32(dgHouseDetails.Rows[i].Cells[10].Value) - Convert.ToInt32(dgHouseDetails.Rows[i].Cells[6].Value);
                lbLanHolList.Text += dgHouseDetails.Rows[i].Cells[9].Value.ToString() + "-" + dgHouseDetails.Rows[i].Cells[4].Value.ToString() + Environment.NewLine;
                //Land Features
                dgCal1.DataSource = House.HouseQry("LandHoldingFeature", dgHouseDetails.Rows[i].Cells[1].Value.ToString());
                for (int n = 0; n < dgCal1.RowCount - 1; n++)
                {
                    houLan -= Convert.ToInt32(dgCal1.Rows[n].Cells[7].Value);
                    lbLanHolList.Text += "       " + dgCal1.Rows[n].Cells[6].Value.ToString() + " - " + dgCal1.Rows[n].Cells[3].Value.ToString() + Environment.NewLine;
                }
                //Wealth Holdings on Land (Estate)
                CheckWealthHolding("LanHol_ID", Convert.ToInt32(dgHouseDetails.Rows[i].Cells[1].Value.ToString()), 1, "          ");

                //Wealth Holdings on Land (non-Estate)
                CheckWealthHolding("LanHol_ID", Convert.ToInt32(dgHouseDetails.Rows[i].Cells[1].Value.ToString()), 0, "          ");

                //Land Features Towns
                dgCal1.DataSource = House.HouseQry("LandHoldingCommunity", dgHouseDetails.Rows[i].Cells[1].Value.ToString());
                for (int n = 0; n < dgCal1.RowCount - 1; n++)
                {
                    houLan -= Convert.ToInt32(dgCal1.Rows[n].Cells[7].Value);
                    houPop -= Convert.ToInt32(dgCal1.Rows[n].Cells[8].Value);
                    lbLanHolList.Text += "       " + dgCal1.Rows[n].Cells[6].Value.ToString() + " - " + dgCal1.Rows[n].Cells[3].Value.ToString() + Environment.NewLine;


                    //Wealth holding in LandHolFea
                    CheckWealthHolding("LanHolFea_ID", Convert.ToInt32(dgCal1.Rows[n].Cells[0].Value.ToString()), 1, "           ");
                    CheckWealthHolding("LanHolFea_ID", Convert.ToInt32(dgCal1.Rows[n].Cells[0].Value.ToString()), 0, "           ");

                }
                //Wealth holdings in Def
                dgCal1.DataSource = House.HouseQry("DefenseHolding", dgHouseDetails.Rows[i].Cells[1].Value.ToString());
                for (int n = 0; n < dgCal1.RowCount - 1; n++)
                {
                    houDef -= Convert.ToInt32(dgCal1.Rows[n].Cells[10].Value) - Convert.ToInt32(dgCal1.Rows[n].Cells[6].Value);
                    lbLanHolList.Text += "    " + dgCal1.Rows[n].Cells[9].Value.ToString() + " - " + dgCal1.Rows[n].Cells[3].Value.ToString() + Environment.NewLine;


                    //Wealth holding in LandHolFea
                    CheckWealthHolding("DefHol_ID", Convert.ToInt32(dgCal1.Rows[n].Cells[0].Value.ToString()), 1, "         ");
                    CheckWealthHolding("DefHol_ID", Convert.ToInt32(dgCal1.Rows[n].Cells[0].Value.ToString()), 0, "         ");

                }

            }
            DevLog.LogItem("Setting spare resources");
            //set labels
            lbSpareWeaText.Text = houWea.ToString();
            lbSparePowText.Text = houPow.ToString();
            lbSparePopText.Text = houPop.ToString();
            lbSpareLanText.Text = houLan.ToString();
            lbSpareInfText.Text = houInf.ToString();
            lbSpareDefText.Text = houDef.ToString();
            DevLog.LogItem("Setting Gain and Loss");
            lbHFText.Text = houHF.ToString(); lbHFGainDice.Text = BounusDiceCal(houHF);
            lbWeaGainText.Text = houWeaGain.ToString(); lbWeaGainDice.Text = BounusDiceCal(houWeaGain);
            lbPowGainText.Text = houPowGain.ToString(); lbPowGainDice.Text = BounusDiceCal(houPowGain);
            lbPopGainText.Text = houPopGain.ToString(); lbPopGainDice.Text = BounusDiceCal(houPopGain);
            lbLawGainText.Text = houLanGain.ToString(); lbLawGainDice.Text = BounusDiceCal(houLawGain);
            lbLanGainText.Text = houLanGain.ToString(); lbLanGainDice.Text = BounusDiceCal(houLanGain);
            lbInfGainText.Text = houInfGain.ToString(); lbInfGainDice.Text = BounusDiceCal(houInfGain);
            lbDefGainText.Text = houDefGain.ToString(); lbDefGainDice.Text = BounusDiceCal(houDefGain);
            lbWeaLossText.Text = houWeaLoss.ToString(); lbWeaLossDice.Text = BounusDiceCal(houWeaLoss);
            lbPowLossText.Text = houPowLoss.ToString(); lbPowLossDice.Text = BounusDiceCal(houPowLoss);
            lbPopLossText.Text = houPopLoss.ToString(); lbPopLossDice.Text = BounusDiceCal(houPopLoss);
            lbLawLossText.Text = houLawLoss.ToString(); lbLawLossDice.Text = BounusDiceCal(houLawLoss);
            lbLanLossText.Text = houLanLoss.ToString(); lbLanLossDice.Text = BounusDiceCal(houLanLoss);
            lbInfLossText.Text = houInfLoss.ToString(); lbInfLossDice.Text = BounusDiceCal(houInfLoss);
            lbDefLossText.Text = houDefLoss.ToString(); lbDefLossDice.Text = BounusDiceCal(houDefLoss);

            lbModifierPopText.Text = HouseModifier(Convert.ToInt32(lbTotalPopText.Text), PopModifierArry);
            lbModifierLawText.Text = HouseModifier(Convert.ToInt32(lbTotalLawText.Text), LawModifierArry);
            DevLog.LogItem("Updating end");
        }

        public void CheckWealthHolding(string place, int ID, int space, string indent)
        {
            DevLog.LogItem("Getting Wealth Holdings");
            dgCal2.DataSource = House.WealthHolding(place, ID.ToString(), space);
            for (int n = 0; n < dgCal2.RowCount - 1; n++)
            {
                houWea -= Convert.ToInt32(dgCal2.Rows[n].Cells[15].Value);
                houDef -= Convert.ToInt32(dgCal2.Rows[n].Cells[16].Value);
                houLan -= Convert.ToInt32(dgCal2.Rows[n].Cells[17].Value);
                houPow -= Convert.ToInt32(dgCal2.Rows[n].Cells[18].Value);
                lbLanHolList.Text += indent;
                if (Convert.ToInt32(dgCal2.Rows[n].Cells[7].Value) == 1)
                {
                    houHF += Convert.ToInt32(dgCal2.Rows[n].Cells[23].Value);
                    houWeaGain += Convert.ToInt32(dgCal2.Rows[n].Cells[24].Value);
                    houPowGain += Convert.ToInt32(dgCal2.Rows[n].Cells[25].Value);
                    houPopGain += Convert.ToInt32(dgCal2.Rows[n].Cells[26].Value);
                    houLawGain += Convert.ToInt32(dgCal2.Rows[n].Cells[27].Value);
                    houLanGain += Convert.ToInt32(dgCal2.Rows[n].Cells[28].Value);
                    houInfGain += Convert.ToInt32(dgCal2.Rows[n].Cells[29].Value);
                    houDefGain += Convert.ToInt32(dgCal2.Rows[n].Cells[30].Value);
                    houWeaLoss += Convert.ToInt32(dgCal2.Rows[n].Cells[31].Value);
                    houPowLoss += Convert.ToInt32(dgCal2.Rows[n].Cells[32].Value);
                    houPopLoss += Convert.ToInt32(dgCal2.Rows[n].Cells[33].Value);
                    houLawLoss += Convert.ToInt32(dgCal2.Rows[n].Cells[34].Value);
                    houLanLoss += Convert.ToInt32(dgCal2.Rows[n].Cells[35].Value);
                    houInfLoss += Convert.ToInt32(dgCal2.Rows[n].Cells[36].Value);
                    houDefLoss += Convert.ToInt32(dgCal2.Rows[n].Cells[37].Value);
                    houLawMit += Convert.ToInt32(dgCal2.Rows[n].Cells[38].Value);
                    houPopMit += Convert.ToInt32(dgCal2.Rows[n].Cells[39].Value);
                }
                else { lbLanHolList.Text += "B: "; }

                lbLanHolList.Text += dgCal2.Rows[n].Cells[12].Value.ToString() + " - " + dgCal2.Rows[n].Cells[6].Value.ToString() + Environment.NewLine;

                dgCal3.DataSource = House.HouseQry("WealthHoldingImprovement", dgCal2.Rows[n].Cells[1].Value.ToString());
                for (int t = 0; t < dgCal3.RowCount - 1; t++)
                {
                    houWea -= Convert.ToInt32(dgCal3.Rows[t].Cells[10].Value);
                    houDef -= Convert.ToInt32(dgCal3.Rows[t].Cells[11].Value);
                    houLan -= Convert.ToInt32(dgCal3.Rows[t].Cells[12].Value);
                    houPow -= Convert.ToInt32(dgCal3.Rows[t].Cells[13].Value);
                    houInf -= Convert.ToInt32(dgCal3.Rows[t].Cells[14].Value);
                    lbLanHolList.Text += indent + "   ";
                    if (Convert.ToInt32(dgCal3.Rows[t].Cells[4].Value) == 1)
                    {
                        houHF += Convert.ToInt32(dgCal3.Rows[t].Cells[19].Value);
                        houWeaGain += Convert.ToInt32(dgCal3.Rows[t].Cells[20].Value);
                        houPowGain += Convert.ToInt32(dgCal3.Rows[t].Cells[21].Value);
                        houPopGain += Convert.ToInt32(dgCal3.Rows[t].Cells[22].Value);
                        houLawGain += Convert.ToInt32(dgCal3.Rows[t].Cells[23].Value);
                        houLanGain += Convert.ToInt32(dgCal3.Rows[t].Cells[24].Value);
                        houInfGain += Convert.ToInt32(dgCal3.Rows[t].Cells[25].Value);
                        houDefGain += Convert.ToInt32(dgCal3.Rows[t].Cells[26].Value);
                        houWeaLoss += Convert.ToInt32(dgCal3.Rows[t].Cells[27].Value);
                        houPowLoss += Convert.ToInt32(dgCal3.Rows[t].Cells[28].Value);
                        houPopLoss += Convert.ToInt32(dgCal3.Rows[t].Cells[29].Value);
                        houLawLoss += Convert.ToInt32(dgCal3.Rows[t].Cells[30].Value);
                        houLanLoss += Convert.ToInt32(dgCal3.Rows[t].Cells[31].Value);
                        houInfLoss += Convert.ToInt32(dgCal3.Rows[t].Cells[32].Value);
                        houDefLoss += Convert.ToInt32(dgCal3.Rows[t].Cells[33].Value);
                        houLawMit += Convert.ToInt32(dgCal3.Rows[t].Cells[34].Value);
                        houPopMit += Convert.ToInt32(dgCal3.Rows[t].Cells[35].Value);
                    }
                    else { lbLanHolList.Text += "B: "; }


                    lbLanHolList.Text += dgCal3.Rows[t].Cells[8].Value.ToString() + Environment.NewLine;

                }

            }
        }

        public string BounusDiceCal(double bounus)
        {
            string text = "";
            if (bounus <= 1) { text = bounus.ToString(); }
            else if (bounus >= 2 && bounus <= 3) { text = "1d3"; }
            else { text = Math.Ceiling(bounus / 6).ToString() + "d6"; }
            return text;
        }

        public string HouseModifier(int stat,int[,] array)
        {
            string text = "";
            int modifier = 0;
            for (int i = 0; i < LawModifierArry.GetLength(0); i++)
            {
                if (Between(stat, array[i, 0], array[i, 1])) { modifier = array[i, 2]; }
            }
            if (modifier > 0) { text += "+"; }
            else if (modifier < 0)
            {
                modifier += houLawMit;
                if (modifier > 0) { modifier = 0; }
            }
            text += modifier.ToString();
            return text;
        }
        public bool Between(int x, int y, int z)
        {
            if (x >= y && x <= z) { return true; }
            else { return false; }
        }

        ///// METHODS END //////////////////////////////////////////////////////////
        public HouseViewForm(int ID)
        {
            House = new House(ID);
            houseID = ID;
            DevLog.LogItem("Opened House View From with ID: " + ID);
            InitializeComponent();
        }

        private void HouseViewForm_Load(object sender, EventArgs e)
        {
            UpdateHouse();
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void TbHouLanView_Click(object sender, EventArgs e)
        {
            LandsHolForm landsHolForm = new LandsHolForm(houseID);
            landsHolForm.VisibleChanged += new EventHandler(this.HouseViewForm_Load);
            landsHolForm.FormClosing += new FormClosingEventHandler(HouseViewForm_Load);
            landsHolForm.Show();
        }

        private void BtPowerHolForm_Click(object sender, EventArgs e)
        {
            PowerHolForm powerHolForm = new PowerHolForm(houseID);
            powerHolForm.Show();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            ChangeResourcesForm changeResourcesForm = new ChangeResourcesForm(houseID);
            changeResourcesForm.FormClosing += new FormClosingEventHandler(this.HouseViewForm_Load);
            changeResourcesForm.Show();
        }

        private void HouseViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DevLog.LogItem("Closing House View");
            if (!(tbName.Text == dgHouse.Rows[0].Cells[1].Value.ToString()) || !(tbSeatOfPower.Text == dgHouse.Rows[0].Cells[4].Value.ToString()) || !(cbRealm.Text == dgHouse.Rows[0].Cells[3].Value.ToString()) || !(tbLiege.Text == dgHouse.Rows[0].Cells[6].Value.ToString()) || !(tbLiegeLord.Text == dgHouse.Rows[0].Cells[5].Value.ToString()))
            {
                DevLog.LogItem("Details do not match");
                House.UpdateHouseDetails(tbName.Text, cbRealm.Text, tbSeatOfPower.Text, tbLiegeLord.Text, tbLiege.Text);
            }
        }

        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
