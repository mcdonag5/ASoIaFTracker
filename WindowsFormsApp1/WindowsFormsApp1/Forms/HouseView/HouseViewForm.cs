using System;
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

        string landHoldings;
        string powerHoldings;
        string bannerHoldings;
        string influenceHoldings;
        string heirHoldings;

        int[,] LawModifierArry = { { 0, 0, -20 }, { 1, 10, -10 }, { 11, 20, -5 }, { 21, 30, -2 }, { 31, 40, -1 }, { 41, 50, 0 }, { 51, 60, 1 }, { 61, 70, 2 }, { 71, 999, 5 } };
        int[,] PopModifierArry = { { 0, 0, -10 }, { 1, 10, -5 }, { 11, 20, 0 }, { 21, 30, 1 }, { 31, 40, 3 }, { 14, 50, 1 }, { 51, 60, 0 }, { 61, 70, -5 }, { 71, 999, -10 } };
        //Marketplace Rules
        public int marketplaceAdd;
        public bool hasMarketplace;
        //Bowyer/Fletcher or Weaponsmith Rules
        public bool hasFletcher = false;
        public bool hasWeaponsmith = false;
        //Criminal Syndicate rules
        public bool hasCriminalSyndicate = false;
        //classes //
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House;
        Functions Functions = new Functions();
        //forms //
        LandsHolForm landsHolForm;
        PowerHolForm powerHolForm;
        BannersHoldingsForm BannersHoldings;
        ChangeResourcesForm changeResourcesForm;
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////

        public void UpdateHouse()
        {
            DevLog.LogItem("Updating resources start");
            dgHouse.DataSource = House.HouseQry("ThisHouse");
            string prefix;
            switch (dgHouse.Rows[0].Cells[3].Value.ToString())
            {
                case "The Wall":
                    prefix = "";
                    break;
                default:
                    prefix = "House ";
                    break;
            }
            tbName.Text = dgHouse.Rows[0].Cells[1].Value.ToString();
            House.name = Text = prefix + dgHouse.Rows[0].Cells[1].Value.ToString();
            tbPlayer.Text = dgHouse.Rows[0].Cells[2].Value.ToString();
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
            powerHoldings = "";
            bannerHoldings = "";
            influenceHoldings = "";
            heirHoldings = "";
            landHoldings = "";
            //set current resources to label
            Validation.CheckIfSame(lbTotalWeaText, houWea.ToString());
            Validation.CheckIfSame(lbTotalPowText, houPow.ToString());
            Validation.CheckIfSame(lbTotalPopText, houPop.ToString());
            Validation.CheckIfSame(lbTotalLawText, houLaw.ToString());
            Validation.CheckIfSame(lbTotalLanText, houLan.ToString());
            Validation.CheckIfSame(lbTotalInfText, houInf.ToString());
            Validation.CheckIfSame(lbTotalDefText, houDef.ToString());

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
                houPow -= Convert.ToInt32(dgHouseDetails.Rows[i].Cells[33].Value) + traningCost - Convert.ToInt32(dgHouseDetails.Rows[i].Cells[5].Value);

                powerHoldings += Functions.HoldingName(dgHouseDetails.Rows[i].Cells[4].Value.ToString() + " " + dgHouseDetails.Rows[i].Cells[32].Value.ToString(), dgHouseDetails.Rows[i].Cells[3].Value.ToString()) + Environment.NewLine;
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
                else if (i == 1) { houPow -= 10; }
                else { houPow -= 5; }
                bannerHoldings += "House " + dgHouseDetails.Rows[i].Cells[2].Value.ToString() + Environment.NewLine;
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

                influenceHoldings += Functions.HoldingName(dgHouseDetails.Rows[i].Cells[10].Value.ToString(), dgHouseDetails.Rows[i].Cells[4].Value.ToString()) + Environment.NewLine;
                dgCal1.DataSource = House.HouseQry("InfluenceHolding", dgHouseDetails.Rows[i].Cells[1].Value.ToString());
                for (int n = 0; n < dgCal1.RowCount - 1; n++)
                {//Imp Table
                    houInf -= Convert.ToInt32(dgCal1.Rows[n].Cells[8].Value)- Convert.ToInt32(dgCal1.Rows[n].Cells[4].Value);
                    influenceHoldings += "    " + dgCal1.Rows[n].Cells[7].Value.ToString() + Environment.NewLine;
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
                    switch (male)
                    {
                        case 1:
                            houInf -= 20;
                            break;
                        case 2:
                            houInf -= 10;
                            break;
                        default:
                            houInf -= 5;
                            break;
                    }
                } else {
                    female++;
                    switch (female)
                    {
                        case 1:
                            houInf -= 10;
                            break;
                        default:
                            houInf -= 5;
                            break;
                    }
                }
                heirHoldings += dgHouseDetails.Rows[i].Cells[2].Value.ToString() + Environment.NewLine;
            }
            //Land table
            DevLog.LogItem("Getting land holdings");
            dgHouseDetails.DataSource = House.HouseQry("LandHolding");
            for (int i = 0; i < dgHouseDetails.RowCount; i++)
            {
                marketplaceAdd = 0;
                hasMarketplace = false;
                houLan -= Convert.ToInt32(dgHouseDetails.Rows[i].Cells[10].Value) - Convert.ToInt32(dgHouseDetails.Rows[i].Cells[6].Value);
                landHoldings += Functions.HoldingName(dgHouseDetails.Rows[i].Cells[9].Value.ToString(), dgHouseDetails.Rows[i].Cells[4].Value.ToString()) + Environment.NewLine;
                dgTrade1.DataSource = House.HouseQry("TradeBackwards", dgHouseDetails.Rows[i].Cells[1].Value.ToString());
                for(int n = 0; n < dgTrade1.RowCount;n++)
                {
                    landHoldings += "  ";
                    if(!Convert.ToBoolean(dgTrade1.Rows[n].Cells[4].Value)) { landHoldings += "B: "; }
                    landHoldings += "Trade Route - " + dgTrade1.Rows[n].Cells[12].Value.ToString() + Environment.NewLine;
                }
                //Land Features
                dgCal1.DataSource = House.HouseQry("LandHoldingFeature", dgHouseDetails.Rows[i].Cells[1].Value.ToString());
                for (int n = 0; n < dgCal1.RowCount - 1; n++)
                {
                    houLan -= Convert.ToInt32(dgCal1.Rows[n].Cells[7].Value);
                    landHoldings += "      " + Functions.HoldingName(dgCal1.Rows[n].Cells[6].Value.ToString(), dgCal1.Rows[n].Cells[3].Value.ToString()) + Environment.NewLine;
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
                    landHoldings += "    " + Functions.HoldingName(dgCal1.Rows[n].Cells[6].Value.ToString(), dgCal1.Rows[n].Cells[3].Value.ToString()) + Environment.NewLine;

                    //Wealth holding in LandHolFea
                    CheckWealthHolding("LanHolFea_ID", Convert.ToInt32(dgCal1.Rows[n].Cells[0].Value.ToString()), 1, "        ");
                    CheckWealthHolding("LanHolFea_ID", Convert.ToInt32(dgCal1.Rows[n].Cells[0].Value.ToString()), 0, "        ");

                }
                //Wealth holdings in Def
                dgCal1.DataSource = House.HouseQry("DefenseHolding", dgHouseDetails.Rows[i].Cells[1].Value.ToString());
                for (int n = 0; n < dgCal1.RowCount - 1; n++)
                {
                    houDef -= Convert.ToInt32(dgCal1.Rows[n].Cells[10].Value) - Convert.ToInt32(dgCal1.Rows[n].Cells[6].Value);
                    landHoldings += "    " + Functions.HoldingName(dgCal1.Rows[n].Cells[9].Value.ToString(), dgCal1.Rows[n].Cells[3].Value.ToString()) + Environment.NewLine;


                    //Wealth holding in LandHolFea
                    CheckWealthHolding("DefHol_ID", Convert.ToInt32(dgCal1.Rows[n].Cells[0].Value.ToString()), 1, "        ");
                    CheckWealthHolding("DefHol_ID", Convert.ToInt32(dgCal1.Rows[n].Cells[0].Value.ToString()), 0, "        ");

                }
                //if the land has a marketplace add to Wea gain for every Estate and Artisan
                if (hasMarketplace) { houWeaGain += marketplaceAdd; }

            }
            //set list labels
            Validation.CheckIfSame(lbLanHolList, landHoldings);
            Validation.CheckIfSame(lbInfHolList, influenceHoldings);
            Validation.CheckIfSame(lbHeirList, heirHoldings);
            Validation.CheckIfSame(lbPowHolList, powerHoldings);
            Validation.CheckIfSame(lbBanList, bannerHoldings);
            //set spare labels
            DevLog.LogItem("Setting spare resources");
            Validation.CheckIfSame(lbSpareWeaText, houWea.ToString());
            Validation.CheckIfSame(lbSparePowText, houPow.ToString());
            Validation.CheckIfSame(lbSparePopText, houPop.ToString());
            Validation.CheckIfSame(lbSpareLanText, houLan.ToString());
            Validation.CheckIfSame(lbSpareInfText, houInf.ToString());
            Validation.CheckIfSame(lbSpareDefText, houDef.ToString());
            //set Gain and loss labels
            DevLog.LogItem("Setting Gain and Loss");
            Validation.CheckIfSame(lbHFText, houHF.ToString()); Validation.CheckIfSame(lbHFGainDice, BounusDiceCal(houHF));
            Validation.CheckIfSame(lbWeaGainText, houWeaGain.ToString()); Validation.CheckIfSame(lbWeaGainDice, BounusDiceCal(houWeaGain));
            Validation.CheckIfSame(lbPowGainText, houPowGain.ToString()); Validation.CheckIfSame(lbPowGainDice, BounusDiceCal(houPowGain));
            Validation.CheckIfSame(lbPopGainText, houPopGain.ToString()); Validation.CheckIfSame(lbPopGainDice, BounusDiceCal(houPopGain));
            Validation.CheckIfSame(lbLawGainText, houLanGain.ToString()); Validation.CheckIfSame(lbLawGainDice, BounusDiceCal(houLawGain));
            Validation.CheckIfSame(lbLanGainText, houLanGain.ToString()); Validation.CheckIfSame(lbLanGainDice, BounusDiceCal(houLanGain));
            Validation.CheckIfSame(lbInfGainText, houInfGain.ToString()); Validation.CheckIfSame(lbInfGainDice, BounusDiceCal(houInfGain));
            Validation.CheckIfSame(lbDefGainText, houDefGain.ToString()); Validation.CheckIfSame(lbDefGainDice, BounusDiceCal(houDefGain));
            Validation.CheckIfSame(lbWeaLossText, houWeaLoss.ToString()); Validation.CheckIfSame(lbWeaLossDice, BounusDiceCal(houWeaLoss));
            Validation.CheckIfSame(lbPowLossText, houPowLoss.ToString()); Validation.CheckIfSame(lbPowLossDice, BounusDiceCal(houPowLoss));
            Validation.CheckIfSame(lbPopLossText, houPopLoss.ToString()); Validation.CheckIfSame(lbPopLossDice, BounusDiceCal(houPopLoss));
            Validation.CheckIfSame(lbLawLossText, houLawLoss.ToString()); Validation.CheckIfSame(lbLawLossDice, BounusDiceCal(houLawLoss));
            Validation.CheckIfSame(lbLanLossText, houLanLoss.ToString()); Validation.CheckIfSame(lbLanLossDice, BounusDiceCal(houLanLoss));
            Validation.CheckIfSame(lbInfLossText, houInfLoss.ToString()); Validation.CheckIfSame(lbInfLossDice, BounusDiceCal(houInfLoss));
            Validation.CheckIfSame(lbDefLossText, houDefLoss.ToString()); Validation.CheckIfSame(lbDefLossDice, BounusDiceCal(houDefLoss));

            Validation.CheckIfSame(lbModifierPopText, HouseModifier(Convert.ToInt32(lbTotalPopText.Text), PopModifierArry));
            if(!hasCriminalSyndicate)
            {
                Validation.CheckIfSame(lbModifierLawText, HouseModifier(Convert.ToInt32(lbTotalLawText.Text), LawModifierArry));
            } else
            {
                Validation.CheckIfSame(lbModifierLawText, HouseModifier(Convert.ToInt32(lbTotalLawText.Text) + 10, LawModifierArry));
            }
            
            DevLog.LogItem("Updating end");
        }

        public void CheckWealthHolding(string place, int ID, int space, string indent)
        {
            DevLog.LogItem("Getting Wealth Holdings");
            dgCal2.DataSource = House.WealthHolding(place, ID.ToString(), space);
            for (int n = 0; n < dgCal2.RowCount - 1; n++)
            {
                bool working = true;
                houWea -= Convert.ToInt32(dgCal2.Rows[n].Cells[15].Value);
                houDef -= Convert.ToInt32(dgCal2.Rows[n].Cells[16].Value);
                houLan -= Convert.ToInt32(dgCal2.Rows[n].Cells[17].Value);
                houPow -= Convert.ToInt32(dgCal2.Rows[n].Cells[18].Value);
                landHoldings += indent;
                if (Convert.ToInt32(dgCal2.Rows[n].Cells[7].Value) == 1)
                {
                    //check if wealth has extra rules 
                    switch(dgCal2.Rows[n].Cells[12].Value.ToString())
                    {
                        case "Marketplace":
                            hasMarketplace = true;
                            break;
                        case "Artisan Craftsman":
                            marketplaceAdd++;
                            break;
                        case "Criminal Syndicate":
                            if(Convert.ToInt32(lbTotalLawText.Text) >31)
                            {
                                working = false;
                            } else
                            {
                                hasCriminalSyndicate = true;
                            }
                            break;
                    }
                    if (working)
                    {
                        //check if add to marketplace
                        if (dgCal2.Rows[n].Cells[13].Value.ToString() == "Estate") { marketplaceAdd++; }

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
                    else
                    {
                        landHoldings += "NW: ";
                    }
                }
                else { landHoldings += "B: "; }

                landHoldings += Functions.HoldingName(dgCal2.Rows[n].Cells[12].Value.ToString(), dgCal2.Rows[n].Cells[6].Value.ToString()) + Environment.NewLine;

                dgCal3.DataSource = House.HouseQry("WealthHoldingImprovement", dgCal2.Rows[n].Cells[1].Value.ToString());
                for (int t = 0; t < dgCal3.RowCount - 1; t++)
                {
                    working = true;
                    houWea -= Convert.ToInt32(dgCal3.Rows[t].Cells[10].Value);
                    houDef -= Convert.ToInt32(dgCal3.Rows[t].Cells[11].Value);
                    houLan -= Convert.ToInt32(dgCal3.Rows[t].Cells[12].Value);
                    houPow -= Convert.ToInt32(dgCal3.Rows[t].Cells[13].Value);
                    houInf -= Convert.ToInt32(dgCal3.Rows[t].Cells[14].Value);
                    landHoldings += indent + "    ";
                    if (Convert.ToInt32(dgCal3.Rows[t].Cells[4].Value) == 1)
                    {
                        //check for special holdings
                        switch (dgCal3.Rows[t].Cells[8].Value.ToString())
                        {
                            case "Bowyer & Fletcher":
                                hasFletcher = true;
                                break;
                            case "Weaponsmith":
                                hasWeaponsmith = true;
                                break;
                            case "Wreckers":
                                if (Convert.ToInt32(lbTotalLawText.Text) > 31) { working = false; }
                                break;
                        }
                        if (working)
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
                        else
                        {
                            landHoldings += "NW: ";
                        }
                    }
                    else { landHoldings += "B: "; }


                    landHoldings += dgCal3.Rows[t].Cells[8].Value.ToString();
                    if (dgCal3.Rows[t].Cells[9].Value.ToString() == "False") { landHoldings += "*"; }
                    landHoldings += Environment.NewLine;
                }

                if(dgCal2.Rows[n].Cells[12].Value.ToString() == "Marketplace")
                {
                    dgTrade1.DataSource = House.HouseQry("Trade", dgCal2.Rows[n].Cells[1].Value.ToString());


                    //Land table
                    for (int i = 0; i < dgTrade1.RowCount; i++)
                    {
                        int tradeValue = 0;
                        houWea -= 5;
                        landHoldings += indent + "    ";
                        if (!Convert.ToBoolean(dgTrade1.Rows[i].Cells[4].Value)) { landHoldings += "B: "; }
                        if (Convert.ToBoolean(dgTrade1.Rows[i].Cells[3].Value))
                        {
                            landHoldings += "Trade Connection: " + dgTrade1.Rows[i].Cells[9].Value.ToString() + Environment.NewLine;
                        }
                        else
                        {
                            landHoldings += "Trade Route: " + dgTrade1.Rows[i].Cells[8].Value.ToString() + " - " + dgTrade1.Rows[i].Cells[9].Value.ToString() + Environment.NewLine;
                            houInf -= 2;
                        }

                        if(Convert.ToBoolean(dgTrade1.Rows[i].Cells[4].Value))
                        {
                            //Wealth Holdings on Land (Estate)
                            dgTrade2.DataSource = House.WealthHolding("LanHol_ID", dgTrade1.Rows[i].Cells[2].Value.ToString(), 1);
                            if (dgTrade2.RowCount > 0 && Convert.ToBoolean(dgTrade2.Rows[0].Cells[7].Value))
                            {
                                tradeValue++;
                            }

                            //Land Features Towns
                            dgTrade2.DataSource = House.HouseQry("LandHoldingCommunity", dgTrade1.Rows[i].Cells[2].Value.ToString());
                            for (int t = 0; t < dgTrade2.RowCount; t++)
                            {
                                dgTrade3.DataSource = House.WealthHolding("LanHolFea_ID", dgTrade2.Rows[t].Cells[0].Value.ToString(), "Artisan Craftsman");
                                for (int x = 0; x < dgTrade3.RowCount; x++)
                                {
                                    if (Convert.ToBoolean(dgTrade3.Rows[x].Cells[7].Value)) { tradeValue++; }
                                }
                            }
                            //Wealth holdings in Def
                            dgTrade2.DataSource = House.HouseQry("DefenseHolding", dgTrade1.Rows[i].Cells[2].Value.ToString());
                            for (int t = 0; t < dgTrade2.RowCount; t++)
                            {
                                dgTrade3.DataSource = House.WealthHolding("DefHol_ID", dgTrade2.Rows[t].Cells[0].Value.ToString(), "Artisan Craftsman");
                                for (int x = 0; x < dgTrade3.RowCount; x++)
                                {
                                    if (Convert.ToBoolean(dgTrade3.Rows[x].Cells[7].Value)) { tradeValue++; }
                                }
                            }

                            landHoldings += indent + "          Trade Value: " + tradeValue + Environment.NewLine;
                            houWeaGain += tradeValue;
                        }
                    }
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

        private void LandHoldingsVisible(object sender, EventArgs e)
        {
            if (landsHolForm.Visible)
            {
                UpdateHouse();
            }
        }

        private void PowerFormVisible(object sender, EventArgs e)
        {
            if (powerHolForm.Visible)
            {
                UpdateHouse();
            }
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
        private void BtLand_Click(object sender, EventArgs e)
        {
            landsHolForm = new LandsHolForm(House.ID,House.name,"Land", cbRealm.Text);
            landsHolForm.VisibleChanged += new EventHandler(this.HouseViewForm_Load);
            landsHolForm.FormClosing += new FormClosingEventHandler(LandHoldingsVisible);
            landsHolForm.Show();
        }

        private void BtInfluence_Click(object sender, EventArgs e)
        {
            landsHolForm = new LandsHolForm(House.ID, House.name, "Influence", cbRealm.Text);
            landsHolForm.VisibleChanged += new EventHandler(this.HouseViewForm_Load);
            landsHolForm.FormClosing += new FormClosingEventHandler(LandHoldingsVisible);
            landsHolForm.Show();
        }

        private void BtPowerHolForm_Click(object sender, EventArgs e)
        {
            powerHolForm = new PowerHolForm(House.ID, House.name, hasWeaponsmith, hasFletcher);
            powerHolForm.FormClosing += new FormClosingEventHandler(HouseViewForm_Load);
            powerHolForm.VisibleChanged += new EventHandler(PowerFormVisible);
            powerHolForm.Show();
        }

        private void BtBanners_Click(object sender, EventArgs e)
        {
            BannersHoldings = new BannersHoldingsForm(House.ID, House.name);
            BannersHoldings.FormClosing += new FormClosingEventHandler(HouseViewForm_Load);
            BannersHoldings.Show();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            changeResourcesForm = new ChangeResourcesForm(House.ID,House.name);
            changeResourcesForm.FormClosing += new FormClosingEventHandler(this.HouseViewForm_Load);
            changeResourcesForm.Show();
        }

        private void HouseViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DevLog.LogItem("Closing House View");
            if (tbName.Text != dgHouse.Rows[0].Cells[1].Value.ToString() || tbPlayer.Text != dgHouse.Rows[0].Cells[2].Value.ToString() || tbSeatOfPower.Text != dgHouse.Rows[0].Cells[4].Value.ToString() || cbRealm.Text != dgHouse.Rows[0].Cells[3].Value.ToString() || tbLiege.Text != dgHouse.Rows[0].Cells[6].Value.ToString() || tbLiegeLord.Text != dgHouse.Rows[0].Cells[5].Value.ToString())
            {
                DevLog.LogItem("Details do not match");
                House.UpdateHouseDetails(tbName.Text, tbPlayer.Text, cbRealm.Text, tbSeatOfPower.Text, tbLiegeLord.Text, tbLiege.Text);
            }
            if (landsHolForm != null) { landsHolForm.Close(); }
            if (powerHolForm != null) { powerHolForm.Close(); }
            if (BannersHoldings != null) { BannersHoldings.Close(); }
            if (changeResourcesForm != null) { changeResourcesForm.Close(); }
        }




        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
