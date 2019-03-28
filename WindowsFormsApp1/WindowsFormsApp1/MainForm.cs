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

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {

        /// <sumary>
        /// NOTES
        /// 
        /// </summary>


        ///// VARIABLES START ////////////////////////////////////////////////////// 
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();
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
        int[,] LawModifierArry = { {0,0,-20 }, { 1,10,-10},{ 11, 20, -5 },{21,30,-2 },{31,40,-1 },{ 41,50,0},{51,60,1 },{61,70,2 },{71,999,5 } };
        int[,] PopModifierArry = { { 0, 0, -10 }, { 1, 10, -5 } ,{11,20,0 },{21,30,1 },{31,40,3 },{14,50,1 },{51,60,0 },{61,70,-5 },{ 71, 999, -10 } };
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////

        

        public void DbReturn(string returnWhat, string dataGrid)
        {//makes a query to the database
            DevLog.LogItem(returnWhat + " sql run to " + dataGrid);
            if (mysqlConn.ConnOpen() == true)
            {
                switch (dataGrid)
                {
                    case "house detail":
                        dgHouseDetails.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                    case "1":
                        dgCal1.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                    case "2":
                        dgCal2.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                    case "3":
                        dgCal3.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                }

            }
        }

        public void UpdateHouse(int ID)
        {
            DevLog.LogItem("Updating resources start");
            DbReturn("SELECT * FROM `tbl_House` WHERE hou_ID = '" + ID + "'", "house detail");
            dgHouseDetails.Enabled = false;
            houseID = ID;
            tbHouseName.Text = dgHouseDetails.Rows[0].Cells[1].Value.ToString();
            tbHouseSeatOfPower.Text = dgHouseDetails.Rows[0].Cells[4].Value.ToString();
            cbHouseRealm.Text = dgHouseDetails.Rows[0].Cells[3].Value.ToString();
            tbHouseLiege.Text = dgHouseDetails.Rows[0].Cells[6].Value.ToString();
            tbHouseLiegeLord.Text = dgHouseDetails.Rows[0].Cells[5].Value.ToString();
            //get current house resources
              houWea = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[7].Value);
              houPow = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[8].Value);
              houPop = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[9].Value);
              houLaw = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[10].Value);
              houLan = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[11].Value);
              houInf = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[12].Value);
              houDef = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[13].Value);
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
            lbHouInfHolList.Text = "";
            lbHouLanHolList.Text = "";
            lbHouPowHolList.Text = "";
            lbHouBanList.Text = "";
            //set current resources to label
            lbHouseCurrent.Text = "Current" + Environment.NewLine +
                houWea + Environment.NewLine +
                houPow + Environment.NewLine +
                houPop + Environment.NewLine +
                houLaw + Environment.NewLine +
                houLan + Environment.NewLine +
                houInf + Environment.NewLine +
                houDef;
            //Power table
            DevLog.LogItem("Getting units");
            DbReturn("SELECT `tbl_PowerHolding`.*, `tbl_UnitType`.`Uni_ID`, `tbl_UnitType`.* FROM `tbl_PowerHolding`, `tbl_UnitType` WHERE `tbl_PowerHolding`.`Hou_ID` = '" + ID + "' AND `tbl_UnitType`.`Uni_ID` = `tbl_PowerHolding`.`Uni_ID`; ", "house detail");
            for ( int i = 0; i < dgHouseDetails.RowCount; i++)
            {//Main table 
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
                houPow -= (Convert.ToInt32(dgHouseDetails.Rows[i].Cells[32].Value) + traningCost) - Convert.ToInt32(dgHouseDetails.Rows[i].Cells[5].Value);

                lbHouPowHolList.Text += dgHouseDetails.Rows[i].Cells[4].Value.ToString() + " " + dgHouseDetails.Rows[i].Cells[31].Value.ToString() + " - " + dgHouseDetails.Rows[i].Cells[3].Value.ToString() + Environment.NewLine;
            }
            DevLog.LogItem("Getting Banners");
            //Banner Table
            DbReturn("SELECT `tbl_Banner`.`HouLie_ID`, `tbl_House`.* FROM `tbl_Banner`, `tbl_House` WHERE `tbl_Banner`.`HouLie_ID` = '" + ID + "' AND `tbl_House`.`Hou_ID` = `tbl_Banner`.`HouBan_ID`; ", "house detail");
            for (int i = 0; i < dgHouseDetails.RowCount; i ++)
            {
                if (i == 0) { houPow -= 20; }
                else if (i == 1) { houPow += 10; }
                else { houPow += 5; }
                lbHouBanList.Text += "House " + dgHouseDetails.Rows[i].Cells[2].Value.ToString() + Environment.NewLine;
            }


            //Influence table
            DevLog.LogItem("Getting Influence Holdings");
            DbReturn("SELECT `tbl_InfluenceHoldings`.`Hou_ID`, `tbl_InfluenceHoldings`.*, `tbl_Influence`.`Inf_ID`, `tbl_Influence`.* FROM `tbl_InfluenceHoldings`, `tbl_Influence` WHERE `tbl_InfluenceHoldings`.`Hou_ID` = '" + ID + "' AND `tbl_Influence`.`Inf_ID` = `tbl_InfluenceHoldings`.`Inf_ID`;", "house detail");
            for (int i = 0; i < dgHouseDetails.RowCount; i++)
            {//Main table
                houInf -= Convert.ToInt32(dgHouseDetails.Rows[i].Cells[11].Value) - Convert.ToInt32(dgHouseDetails.Rows[i].Cells[7].Value); DevLog.LogItem("houInf: " + houInf);
                houDefGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[14].Value);
                houInfGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[15].Value);
                houLanGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[16].Value);
                houLawGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[17].Value);
                houPopGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[18].Value);
                houPowGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[19].Value);
                houWeaGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[20].Value);
                houLawMit += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[21].Value);
                houPopMit += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[22].Value);

                lbHouInfHolList.Text += dgHouseDetails.Rows[i].Cells[10].Value.ToString() + " - " + dgHouseDetails.Rows[i].Cells[4].Value.ToString() + Environment.NewLine;
                DbReturn("SELECT `tbl_InfluenceHoldingImprovement`.*, `tbl_InfluenceImprovemnt`.* FROM `tbl_InfluenceHoldingImprovement`, `tbl_InfluenceImprovemnt` WHERE `tbl_InfluenceHoldingImprovement`.`InfHol_ID` = '" + dgHouseDetails.Rows[i].Cells[1].Value + "' AND `tbl_InfluenceImprovemnt`.`InfImp_ID` = `tbl_InfluenceHoldingImprovement`.`InfImp_ID`; ", "1");
                for (int n = 0; n < dgCal1.RowCount - 1; n++)
                {//Imp Table
                    houInf -= Convert.ToInt32(dgCal1.Rows[n].Cells[7].Value);
                    lbHouInfHolList.Text += "       " + dgCal1.Rows[n].Cells[6].Value.ToString() + Environment.NewLine;
                }
            }

            //Land table
            DevLog.LogItem("Getting land holdings");
            DbReturn("SELECT `tbl_LandHolding`.`Hou_ID`, `tbl_LandHolding`.*, `tbl_Land`.`Lan_ID`, `tbl_Land`.* FROM `tbl_LandHolding`, `tbl_Land` WHERE `tbl_LandHolding`.`Hou_ID` = '" + ID + "' AND `tbl_Land`.`Lan_ID` = `tbl_LandHolding`.`Lan_ID`; ", "house detail");
            for (int i = 0; i < dgHouseDetails.RowCount; i++)
            {
                houLan -= Convert.ToInt32(dgHouseDetails.Rows[i].Cells[10].Value) - Convert.ToInt32(dgHouseDetails.Rows[i].Cells[6].Value);
                lbHouLanHolList.Text += dgHouseDetails.Rows[i].Cells[9].Value.ToString() + "-" + dgHouseDetails.Rows[i].Cells[4].Value.ToString() + Environment.NewLine;
                //Land Features
                DbReturn("SELECT `tbl_LandHoldingFeature`.*, `tbl_LandFeature`.* FROM `tbl_LandHoldingFeature`, `tbl_LandFeature` WHERE `tbl_LandHoldingFeature`.`LanHol_ID` = '" + dgHouseDetails.Rows[i].Cells[1].Value.ToString() + "' AND `tbl_LandFeature`.`LanFea_ID` = `tbl_LandHoldingFeature`.`LanFea_ID` AND `tbl_LandFeature`.`LanFea_Spaces` = '0'; ", "1");
                for (int n = 0; n < dgCal1.RowCount - 1; n++)
                {
                    houLan -= Convert.ToInt32(dgCal1.Rows[n].Cells[7].Value);
                    lbHouLanHolList.Text += "       " + dgCal1.Rows[n].Cells[6].Value.ToString() + " - " + dgCal1.Rows[n].Cells[3].Value.ToString() + Environment.NewLine;
                }
                //Wealth Holdings on Land (Estate)
                CheckWealthHolding("LanHol_ID", Convert.ToInt32(dgHouseDetails.Rows[i].Cells[1].Value.ToString()), 1,"          ");

                //Wealth Holdings on Land (non-Estate)
                CheckWealthHolding("LanHol_ID", Convert.ToInt32(dgHouseDetails.Rows[i].Cells[1].Value.ToString()), 0,"          ");

                //Land Features Towns
                DbReturn("SELECT `tbl_LandHoldingFeature`.*, `tbl_LandFeature`.* FROM `tbl_LandHoldingFeature`, `tbl_LandFeature` WHERE `tbl_LandHoldingFeature`.`LanHol_ID` = '" + dgHouseDetails.Rows[i].Cells[1].Value.ToString() + "' AND `tbl_LandFeature`.`LanFea_ID` = `tbl_LandHoldingFeature`.`LanFea_ID` AND `tbl_LandFeature`.`LanFea_Spaces` > '0'; ", "1");
                for (int n = 0; n < dgCal1.RowCount - 1; n++)
                {
                    houLan -= Convert.ToInt32(dgCal1.Rows[n].Cells[7].Value);
                    lbHouLanHolList.Text += "       " + dgCal1.Rows[n].Cells[6].Value.ToString() + " - " + dgCal1.Rows[n].Cells[3].Value.ToString() + Environment.NewLine;


                    //Wealth holding in LandHolFea
                    CheckWealthHolding("LanHolFea_ID",Convert.ToInt32(dgCal1.Rows[n].Cells[0].Value.ToString()), 1, "           ");
                    CheckWealthHolding("LanHolFea_ID",Convert.ToInt32(dgCal1.Rows[n].Cells[0].Value.ToString()), 0, "           ");
                    
                }
                //Wealth holdings in Def
                DbReturn("SELECT `tbl_DefenseHolding`.*, `tbl_Defense`.`Def_ID`, `tbl_Defense`.* FROM `tbl_DefenseHolding`, `tbl_Defense` WHERE `tbl_DefenseHolding`.`LanHol_ID` = '"+ dgHouseDetails.Rows[i].Cells[1].Value.ToString() + "' AND `tbl_Defense`.`Def_ID` = `tbl_DefenseHolding`.`Def_ID`; ", "1");
                for (int n = 0; n < dgCal1.RowCount - 1; n++)
                {
                    houDef -= Convert.ToInt32(dgCal1.Rows[n].Cells[9].Value) - Convert.ToInt32(dgCal1.Rows[n].Cells[5].Value);
                    lbHouLanHolList.Text += "    " + dgCal1.Rows[n].Cells[8].Value.ToString() + " - " + dgCal1.Rows[n].Cells[3].Value.ToString() + Environment.NewLine;


                    //Wealth holding in LandHolFea
                    CheckWealthHolding("DefHol_ID", Convert.ToInt32(dgCal1.Rows[n].Cells[0].Value.ToString()), 1, "         ");
                    CheckWealthHolding("DefHol_ID", Convert.ToInt32(dgCal1.Rows[n].Cells[0].Value.ToString()), 0, "         ");

                }

            }
            DevLog.LogItem("Setting spare resources");
            //set labels
            lbHouseSpare.Text = "Current" + Environment.NewLine +
                houWea + Environment.NewLine +
                houPow + Environment.NewLine +
                houPop + Environment.NewLine +
                Environment.NewLine +
                houLan + Environment.NewLine +
                houInf + Environment.NewLine +
                houDef;
            DevLog.LogItem("Setting Gain and Loss");
            lbHouseHF.Text = "HF" + Environment.NewLine + houHF + Environment.NewLine + BounusCal(houHF);
            lbHouseWeaGain.Text = "WEA" + Environment.NewLine + houWeaGain + Environment.NewLine + BounusCal(houWeaGain);
            lbHousePowGain.Text = "POW" + Environment.NewLine + houPowGain + Environment.NewLine + BounusCal(houPowGain);
            lbHousePopGain.Text = "POP" + Environment.NewLine + houPopGain + Environment.NewLine + BounusCal(houPopGain);
            lbHouseLawGain.Text = "LAW" + Environment.NewLine + houLawGain + Environment.NewLine + BounusCal(houLawGain);
            lbHouseLanGain.Text = "LAN" + Environment.NewLine + houLanGain + Environment.NewLine + BounusCal(houLanGain);
            lbHouseInfGain.Text = "INF" + Environment.NewLine + houInfGain + Environment.NewLine + BounusCal(houInfGain);
            lbHouseDefGain.Text = "DEF" + Environment.NewLine + houDefGain + Environment.NewLine + BounusCal(houDefGain);
            lbHouseWeaLoss.Text = "WEA" + Environment.NewLine + houWeaLoss + Environment.NewLine + BounusCal(houWeaLoss);
            lbHousePowLoss.Text = "POW" + Environment.NewLine + houPowLoss + Environment.NewLine + BounusCal(houPowLoss);
            lbHousePopLoss.Text = "POP" + Environment.NewLine + houPopLoss + Environment.NewLine + BounusCal(houPopLoss);
            lbHouseLawLoss.Text = "LAW" + Environment.NewLine + houLawLoss + Environment.NewLine + BounusCal(houLawLoss);
            lbHouseLanLoss.Text = "LAN" + Environment.NewLine + houLanLoss + Environment.NewLine + BounusCal(houLanLoss);
            lbHouseInfLoss.Text = "INF" + Environment.NewLine + houInfLoss + Environment.NewLine + BounusCal(houInfLoss);
            lbHouseDefLoss.Text = "DEF" + Environment.NewLine + houDefLoss + Environment.NewLine + BounusCal(houDefLoss);
            lbHouPopMod.Text = HousePopModifier(houPop);
            lbHouLawMod.Text = HouseLawModifier(houLaw);
            dgHouseDetails.Visible = false;
            dgHouseDetails.Enabled = true;
            DevLog.LogItem("Updating end");
        }

        public void CheckWealthHolding(string place, int ID,int space,string indent)
        {
            DevLog.LogItem("Getting Wealth Holdings");
            DbReturn("SELECT `tbl_WealthHolding`.`LanHol_ID`, `tbl_WealthHolding`.*, `tbl_Wealth`.`Wea_ID`, `tbl_Wealth`.* FROM `tbl_WealthHolding`, `tbl_Wealth` WHERE `tbl_WealthHolding`.`"+place+"` = '" +ID+ "' AND `tbl_Wealth`.`Wea_ID` = `tbl_WealthHolding`.`Wea_ID` AND `tbl_Wealth`.`Wea_TakesSpace` = '"+space+"'; ", "2");
            for (int n = 0; n < dgCal2.RowCount - 1; n++)
            {
                houWea -= Convert.ToInt32(dgCal2.Rows[n].Cells[15].Value);
                houDef -= Convert.ToInt32(dgCal2.Rows[n].Cells[16].Value);
                houLan -= Convert.ToInt32(dgCal2.Rows[n].Cells[17].Value);
                houPow -= Convert.ToInt32(dgCal2.Rows[n].Cells[18].Value);
                lbHouLanHolList.Text += indent;
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
                } else { lbHouLanHolList.Text += "B: "; }

                lbHouLanHolList.Text += dgCal2.Rows[n].Cells[12].Value.ToString() + " - " + dgCal2.Rows[n].Cells[6].Value.ToString() + Environment.NewLine;

                DbReturn("SELECT `tbl_WealthHoldingImprovement`.`WeaHol_ID`, `tbl_WealthHoldingImprovement`.*, `tbl_WealthImprovement`.`WeaImp_ID`, `tbl_WealthImprovement`.* FROM `tbl_WealthHoldingImprovement`, `tbl_WealthImprovement` WHERE `tbl_WealthHoldingImprovement`.`WeaHol_ID` = '" + Convert.ToInt32(dgCal2.Rows[n].Cells[1].Value) + "' AND `tbl_WealthImprovement`.`WeaImp_ID` = `tbl_WealthHoldingImprovement`.`WeaImp_ID`; ", "3");
                for (int t = 0; t < dgCal3.RowCount - 1; t++)
                {
                    houWea -= Convert.ToInt32(dgCal3.Rows[t].Cells[10].Value);
                    houDef -= Convert.ToInt32(dgCal3.Rows[t].Cells[11].Value);
                    houLan -= Convert.ToInt32(dgCal3.Rows[t].Cells[12].Value);
                    houPow -= Convert.ToInt32(dgCal3.Rows[t].Cells[13].Value);
                    houInf -= Convert.ToInt32(dgCal3.Rows[t].Cells[14].Value);
                    lbHouLanHolList.Text += indent +"   ";
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
                    } else { lbHouLanHolList.Text += "B: "; }


                    lbHouLanHolList.Text += dgCal3.Rows[t].Cells[8].Value.ToString() + Environment.NewLine;

                }

            }
        }

        public string BounusCal(double bounus)
        {
            string text = "";
            if(bounus <= 1){ text = bounus.ToString(); }
            else if(bounus>=2 && bounus<=3) { text = "1d3"; }
            else { text= Math.Ceiling(bounus / 6).ToString() +"d6"; }
            return text;
        }

        public void ResetViewHouse(string player)
        {
            DevLog.LogItem("Reset House and view " + player + " Houses");
            dgHouseDetails.Visible = true;
            lbHouInfHolList.Text = "";
            lbHouLanHolList.Text = "";
            string qry = "SELECT `tbl_House`.`Hou_ID` AS ID, `tbl_House`.`Hou_Name` AS Name, `tbl_House`.`Hou_Player` AS `Player`, `tbl_House`.`Rea_Name` AS `Realm`, `tbl_House`.`Hou_SeatOfPower` AS `Seat of Power`, `tbl_House`.`Hou_LiegeLord` AS `Liege Lord`, `tbl_House`.`Hou_Liege` AS `Liege` FROM `tbl_House`";
            if(player != "all") { qry += " WHERE hou_Player = '" + player + "'"; }
            qry += ";";
            DbReturn(qry, "house detail");
            dgHouseDetails.Visible = true;
           
        }
        public string HouseLawModifier(int lawMod)
        {
            string text ="";
            int modifier = 0;
            for( int i = 0;i < LawModifierArry.GetLength(0);i++ )
            {
                if (Between(lawMod, LawModifierArry[i, 0], LawModifierArry[i,1])) { modifier = LawModifierArry[i, 2]; }
            }
            if(modifier>0) { text += "+"; }
            else if (modifier < 0)
            {
                modifier += houLawMit;
                if (modifier>0) { modifier = 0; }
            }
            text += modifier.ToString();
            return text;
        }

        public string HousePopModifier(int popMod)
        {
            string text = "";
            int modifier = 0;
            for (int i = 0; i < LawModifierArry.GetLength(0); i++)
            {
                if (Between(popMod, PopModifierArry[i, 0], PopModifierArry[i, 1])) { modifier = PopModifierArry[i, 2]; }
            }
            if (modifier > 0) { text += "+"; }
            else if (modifier < 0)
            {
                modifier += houPopMit;
                if (modifier > 0) { modifier = 0; }
            }
            text += modifier.ToString();
            return text;
        }
        public bool Between(int x, int y,int z)
        {
            if(x>=y&&x<=z) { return true; }
            else { return false; }
        }
        ///// METHODS END //////////////////////////////////////////////////////////

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.WriteAllText("DevLog.txt", String.Empty);//Clear contents of DevLog
            DevLog.LogItem("Program started");
            mysqlConn.DbConfig(); //sets database settings
            mysqlConn.Connect();
            DbReturn("SELECT `tbl_House`.`Hou_ID` AS ID, `tbl_House`.`Hou_Name` AS Name, `tbl_House`.`Hou_Player` AS `Player`, `tbl_House`.`Rea_Name` AS `Realm`, `tbl_House`.`Hou_SeatOfPower` AS `Seat of Power`, `tbl_House`.`Hou_LiegeLord` AS `Liege Lord`, `tbl_House`.`Hou_Liege` AS `Liege` FROM `tbl_House`; ", "house detail");
            Size size = new Size(1108, 559);
            dgHouseDetails.Size = size;
            LandsHolForm landsForm = new LandsHolForm();
            landsForm.ShowDialog();
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void DevLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form devForm = new Form {Text = "DevLog.LogItem"};
            RichTextBox rtbDevLog.LogItem = new RichTextBox();
            Timer timerRefreshDevLog.LogItem = new Timer {Interval = 2500};
            timerRefreshDevLog.LogItem.Tick += new EventHandler(devRefreshTimer_Tick);
            timerRefreshDevLog.LogItem.Start();
            rtbDevLog.LogItem.Location = new Point(0, 0);
            rtbDevLog.LogItem.Size = new Size(300, 380);
            rtbDevLog.LogItem.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            devForm.Size = new Size(300, 400);
            devForm.Controls.Add(rtbDevLog.LogItem);
            DevLog.LogItem("DevLog.LogItem viewed");
            void devRefreshTimer_Tick(object timer, EventArgs args)
            {
                rtbDevLog.LogItem.Text = "";
                string line;
                try
                {
                    StreamReader sr = new StreamReader("DevLog.txt");
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        rtbDevLog.LogItem.Text += line + "\r\n";
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception ex) { DevLog.LogItem("ex: " + ex); DevLog.LogItem("error reading DevLog.LogItem"); }
            }
            devForm.Show();
        }

        private void DgHouseDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (dgHouseDetails.Columns[0].Name)
            {
                case "ID":
                    UpdateHouse(Convert.ToInt32(dgHouseDetails.Rows[e.RowIndex].Cells[0].Value));
                    break;
                case "Lie ID":
                    UpdateHouse(Convert.ToInt32(dgHouseDetails.Rows[e.RowIndex].Cells[1].Value));
                    break;
            }
        }
        private void NPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetViewHouse("NPC");
        }

        private void RossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetViewHouse("Ross");
        }

        private void AllHousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetViewHouse("all");
        }

        private void TbHouBanView_Click(object sender, EventArgs e)
        {
            DbReturn("SELECT `tbl_Banner`.`HouLie_ID` AS `Lie ID`, `tbl_House`.`Hou_ID` AS `ID`, `tbl_House`.`Hou_Name` AS `Name`, `tbl_House`.`Hou_Player` AS `Player`, `tbl_House`.`Rea_Name` AS `Realm`, `tbl_House`.`Hou_SeatOfPower` AS `Seat of Power`, `tbl_House`.`Hou_LiegeLord` AS `Liege Lord` FROM `tbl_Banner`, `tbl_House` WHERE `tbl_Banner`.`HouLie_ID` = '"+houseID+"' AND `tbl_House`.`Hou_ID` = `tbl_Banner`.`HouBan_ID`; ","house detail");
            dgHouseDetails.Visible = true;
        }

        private void tbHouPowView_Click(object sender, EventArgs e)
        {
            PowerHolForm power = new PowerHolForm();
            power.ShowDialog();
        }

        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
