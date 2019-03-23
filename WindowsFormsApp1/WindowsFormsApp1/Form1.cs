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
        public int houseID;

        ///// VARIABLES END ////////////////////////////////////////////////////////
        
        ///// METHODS START ////////////////////////////////////////////////////////

        public void DevLogs(string logItem)
        {//Write development log to DevLog
            using (StreamWriter devlog = new StreamWriter("DevLog.txt", append: true))
            { devlog.WriteLine(DateTime.Now + " --- " + logItem); }//Concat current time and logItem and write to DevLog file
        }

        public void DbReturn(string returnWhat, string dataGrid)
        {//makes a query to the database
            DevLogs(returnWhat + " sql run to " + dataGrid);
            if (mysqlConn.ConnOpen() == true)
            {
                switch (dataGrid)
                {
                    case "house detail":
                        dgHouseDetails.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                    case "1":
                        dgCalculation.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                }

            }
        }

        public void UpdateHouse(int ID)
        {
            DevLogs("Updating resources");
            DbReturn("SELECT * FROM `tbl_House` WHERE hou_ID = '" + ID + "'", "house detail");

            tbHouseName.Text = dgHouseDetails.Rows[0].Cells[1].Value.ToString();
            tbHouseSeatOfPower.Text = dgHouseDetails.Rows[0].Cells[4].Value.ToString();
            cbHouseRealm.Text = dgHouseDetails.Rows[0].Cells[3].Value.ToString();
            tbHouseLiege.Text = dgHouseDetails.Rows[0].Cells[6].Value.ToString();
            tbHouseLiegeLord.Text = dgHouseDetails.Rows[0].Cells[5].Value.ToString();
            //get current house resources
            int houWea = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[7].Value);
            int houPow = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[8].Value);
            int houPop = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[9].Value);
            int houLaw = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[10].Value);
            int houLan = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[11].Value);
            int houInf = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[12].Value);
            int houDef = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[13].Value);
            int houHF = 0;
            int houWeaGain = 0;
            int houPowGain = 0;
            int houPopGain = 0;
            int houLawGain = 0;
            int houLanGain = 0;
            int houInfGain = 0;
            int houDefGain = 0;
            int houWeaLoss = 0;
            int houPowLoss = 0;
            int houPopLoss = 0;
            int houLawLoss = 0;
            int houLanLoss = 0;
            int houInfLoss = 0;
            int houDefLoss = 0;
            //clear labels
            lbHouInfHolList.Text = "";
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
            DbReturn("SELECT `tbl_PowerHolding`.*, `tbl_UnitType`.`Uni_ID`, `tbl_UnitType`.* FROM `tbl_PowerHolding`, `tbl_UnitType` WHERE `tbl_PowerHolding`.`Hou_ID` = '" + ID + "' AND `tbl_UnitType`.`Uni_ID` = `tbl_PowerHolding`.`Uni_ID`; ", "house detail");
            for (int i = 0; i < dgHouseDetails.RowCount - 1; i++)
            {//Main table 31
                int traningCost=0;
                switch(dgHouseDetails.Rows[i].Cells[4].Value)
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
                        DevLogs("Traning cost error: "+ dgHouseDetails.Rows[i].Cells[4].Value);
                        break;
                }
                houPow -= (Convert.ToInt32(dgHouseDetails.Rows[i].Cells[32].Value) + traningCost) - Convert.ToInt32(dgHouseDetails.Rows[i].Cells[5].Value);
            }

            //Influence table
            DbReturn("SELECT `tbl_InfluenceHoldings`.`Hou_ID`, `tbl_InfluenceHoldings`.*, `tbl_Influence`.`Inf_ID`, `tbl_Influence`.* FROM `tbl_InfluenceHoldings`, `tbl_Influence` WHERE `tbl_InfluenceHoldings`.`Hou_ID` = '"+ID+"' AND `tbl_Influence`.`Inf_ID` = `tbl_InfluenceHoldings`.`Inf_ID`;", "house detail");
            for (int i = 0; i < dgHouseDetails.RowCount - 1; i++)
            {//Main table
                houInf -= Convert.ToInt32(dgHouseDetails.Rows[i].Cells[11].Value) - Convert.ToInt32(dgHouseDetails.Rows[i].Cells[7].Value); DevLogs("houInf: "+houInf);
                houDefGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[14].Value);
                houInfGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[15].Value);
                houLanGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[16].Value);
                houLawGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[17].Value);
                houPopGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[18].Value);
                houPowGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[19].Value);
                houWeaGain += Convert.ToInt32(dgHouseDetails.Rows[i].Cells[20].Value);
                lbHouInfHolList.Text += dgHouseDetails.Rows[i].Cells[10].Value.ToString() + " - " + dgHouseDetails.Rows[i].Cells[4].Value.ToString() + Environment.NewLine;
                DbReturn("SELECT `tbl_InfluenceHoldingImprovement`.*, `tbl_InfluenceImprovemnt`.* FROM `tbl_InfluenceHoldingImprovement`, `tbl_InfluenceImprovemnt` WHERE `tbl_InfluenceHoldingImprovement`.`InfHol_ID` = '" + dgHouseDetails.Rows[i].Cells[1].Value + "' AND `tbl_InfluenceImprovemnt`.`InfImp_ID` = `tbl_InfluenceHoldingImprovement`.`InfImp_ID`; ", "1");
                for (int n = 0; n < dgCalculation.RowCount-1;n++)
                {//Imp Table
                    houInf -= Convert.ToInt32(dgCalculation.Rows[n].Cells[7].Value);
                    lbHouInfHolList.Text += "    "+dgCalculation.Rows[n].Cells[6].Value.ToString()+Environment.NewLine;
                }
            }

            //dbReturn("SELECT Hou_Defense FROM `tbl_House` WHERE Hou_ID = '"+ID+"'", "house detail");
            //int start = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[0].Value);
            //int sum = 0;
            //dbReturn("SELECT * FROM `tbl_LandHolding` WHERE Hou_ID = '" + houseID + "'", "house detail");
            //for (int i = 0; i < dgHouseDetails.RowCount-1; i++)
            //{

            //    dbReturn("SELECT `tbl_DefenseHolding`.`LanHol_ID`, `tbl_Defense`.`Def_ID`, `tbl_Defense`.`Def_DefenseCost`,`tbl_DefenseHolding`.`DefHol_Discount` FROM `tbl_DefenseHolding`, `tbl_Defense` WHERE `tbl_DefenseHolding`.`LanHol_ID` = '" + Convert.ToUInt32(dgHouseDetails.Rows[i].Cells[0].Value)+"' AND `tbl_Defense`.`Def_ID` = `tbl_DefenseHolding`.`Def_ID`;", "calculation");
            //    devLogs("Times: "+i);
            //    for(int n = 0; i < dgCalculation.RowCount-1;i++)
            //    {
            //        sum += Convert.ToInt32(dgCalculation.Rows[i].Cells[2].Value) - Convert.ToInt32(dgCalculation.Rows[i].Cells[3].Value);
            //    }
            //}
            //set labels
            lbHouseSpare.Text = "Current" + Environment.NewLine +
                houWea + Environment.NewLine +
                houPow + Environment.NewLine +
                houPop + Environment.NewLine +
                Environment.NewLine +
                houLan + Environment.NewLine +
                houInf + Environment.NewLine +
                houDef;

            lbHouseHF.Text = "HF" + Environment.NewLine + houHF;
        }

        public string BounusCal(int bounus)
        {
            string text = "";
            if(bounus < 2){ text = bounus.ToString(); }
            else if(bounus>1 && bounus<4) { text = "1d3"; }
            else { double x = bounus / 6; text = Math.Ceiling(x).ToString(); }
            return text;
        }
        ///// METHODS END //////////////////////////////////////////////////////////

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.WriteAllText("DevLog.txt", String.Empty);//Clear contents of DevLog
            DevLogs("Program started");
            mysqlConn.DbConfig(); //sets database settings
            mysqlConn.Connect();
            houseID = 3;
            UpdateHouse(houseID);
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void DevLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form devForm = new Form {Text = "DevLogs"};
            RichTextBox rtbDevLogs = new RichTextBox();
            Timer timerRefreshDevLogs = new Timer {Interval = 2500};
            timerRefreshDevLogs.Tick += new EventHandler(devRefreshTimer_Tick);
            timerRefreshDevLogs.Start();
            rtbDevLogs.Location = new Point(0, 0);
            rtbDevLogs.Size = new Size(300, 380);
            rtbDevLogs.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            devForm.Size = new Size(300, 400);
            devForm.Controls.Add(rtbDevLogs);
            DevLogs("devlogs viewed");
            void devRefreshTimer_Tick(object timer, EventArgs args)
            {
                rtbDevLogs.Text = "";
                string line;
                try
                {
                    StreamReader sr = new StreamReader("DevLog.txt");
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        rtbDevLogs.Text += line + "\r\n";
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception ex) { DevLogs("ex: " + ex); DevLogs("error reading devlogs"); }
            }
            devForm.Show();
        }

        


        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
