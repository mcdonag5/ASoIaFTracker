using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LandsHolForm : Form
    {
        ///// VARIABLES START ////////////////////////////////////////////////////// 
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();
        public int houseID;

        public void DbReturn(string returnWhat, string dataGrid)
        {//makes a query to the database
            DevLog.LogItem(returnWhat + " sql run to " + dataGrid);
            if (mysqlConn.ConnOpen() == true)
            {
                switch (dataGrid)
                {
                    case "Land":
                        dgLand.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                    case "LandFea":
                        dgLandFea.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                    case "Def":
                        dgDef.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                    case "Wea":
                        dgWea.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                    case "Imp":
                        dgImp.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                }

            }
        }

        public void ToolStripEnabled (string toolStrip)
        {
            switch (toolStrip)
            {
                case "Land":
                    landFeatureToolStripMenuItem.Enabled = true;
                    defenseHoldingToolStripMenuItem.Enabled = true;
                    wealthHoldingToolStripMenuItem.Enabled = true;
                    wealthImprovementToolStripMenuItem.Enabled = false;
                    break;
                case "Defense/Feature":
                    landFeatureToolStripMenuItem.Enabled = false;
                    defenseHoldingToolStripMenuItem.Enabled = false;
                    wealthHoldingToolStripMenuItem.Enabled = true;
                    wealthImprovementToolStripMenuItem.Enabled = false;
                    break;
                case "Wealth":
                    landFeatureToolStripMenuItem.Enabled = true;
                    defenseHoldingToolStripMenuItem.Enabled = false;
                    wealthHoldingToolStripMenuItem.Enabled = false;
                    wealthImprovementToolStripMenuItem.Enabled = true;
                    break;
            }
        }

        public LandsHolForm(int ID)
        {
            houseID = ID;
            InitializeComponent();
        }

        private void LandsHolForm_Load(object sender, EventArgs e)
        {
            mysqlConn.DbConfig(); //sets database settings
            mysqlConn.Connect();
            DevLog.LogItem("Getting land holdings");
            DbReturn("SELECT `tbl_LandHolding`.`Hou_ID`, `tbl_LandHolding`.*, `tbl_Land`.`Lan_ID`, `tbl_Land`.* FROM `tbl_LandHolding`, `tbl_Land` WHERE `tbl_LandHolding`.`Hou_ID` = '" + houseID + "' AND `tbl_Land`.`Lan_ID` = `tbl_LandHolding`.`Lan_ID`; ", "Land");
            object[] landHoldings = new object[dgLand.RowCount - 1];

            for (int i = 0; i < dgLand.RowCount-1; i++)
            {
                landHoldings[i] = dgLand.Rows[i].Cells[9].Value.ToString() + "-" + dgLand.Rows[i].Cells[4].Value.ToString();
            }
            cbLandHolding.Items.AddRange(landHoldings);

        }

        private void CbLandHolding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripEnabled("Land");
            lbCost.Text = "";
            lbDesc.Text = "";
            lbBenfits.Text = "";
            lbAddions.Text = "";
            lbImprovemnt.Text = "";
            rtbNotes.Text = "";

            int index = cbLandHolding.SelectedIndex;
            lbName.Text = dgLand.Rows[index].Cells[9].Value.ToString() + "-" + dgLand.Rows[index].Cells[4].Value.ToString();
            int costLan = Convert.ToInt32(dgLand.Rows[index].Cells[10].Value) - Convert.ToInt32(dgLand.Rows[index].Cells[6].Value);
            rtbNotes.Text = dgLand.Rows[index].Cells[5].Value.ToString();
            //Land Fea
            DbReturn("SELECT `tbl_LandHoldingFeature`.*, `tbl_LandFeature`.* FROM `tbl_LandHoldingFeature`, `tbl_LandFeature` WHERE `tbl_LandHoldingFeature`.`LanHol_ID` = '" + dgLand.Rows[index].Cells[1].Value.ToString() + "' AND `tbl_LandFeature`.`LanFea_ID` = `tbl_LandHoldingFeature`.`LanFea_ID` AND `tbl_LandFeature`.`LanFea_Spaces` = '0'; ", "Imp");
            for (int n = 0; n < dgImp.RowCount - 1; n++)
            {
                costLan += Convert.ToInt32(dgImp.Rows[n].Cells[7].Value);
                lbAddions.Text += dgImp.Rows[n].Cells[6].Value.ToString() + " - " + dgImp.Rows[n].Cells[3].Value.ToString() + Environment.NewLine;
            }
            //Land Fea Towns
            DbReturn("SELECT `tbl_LandHoldingFeature`.*, `tbl_LandFeature`.* FROM `tbl_LandHoldingFeature`, `tbl_LandFeature` WHERE `tbl_LandHoldingFeature`.`LanHol_ID` = '" + dgLand.Rows[index].Cells[1].Value.ToString() + "' AND `tbl_LandFeature`.`LanFea_ID` = `tbl_LandHoldingFeature`.`LanFea_ID` AND `tbl_LandFeature`.`LanFea_Spaces` > '0'; ", "Imp");
            for (int n = 0; n < dgImp.RowCount - 1; n++)
            {
                costLan += Convert.ToInt32(dgImp.Rows[n].Cells[7].Value);
                lbAddions.Text += dgImp.Rows[n].Cells[6].Value.ToString() + " - " + dgImp.Rows[n].Cells[3].Value.ToString() + Environment.NewLine;
                

            }
            lbCost.Text = "";
            if (costLan > 0) { lbCost.Text += "Land: " + costLan + " "; }
            lbType.Text = "Land Holding";


            DbReturn("SELECT `tbl_WealthHolding`.`LanHol_ID`, `tbl_WealthHolding`.*, `tbl_Wealth`.`Wea_ID`, `tbl_Wealth`.*FROM `tbl_WealthHolding`, `tbl_Wealth` WHERE `tbl_WealthHolding`.`LanHol_ID` = '" + dgLand.Rows[cbLandHolding.SelectedIndex].Cells[1].Value+ "' AND `tbl_Wealth`.`Wea_ID` = `tbl_WealthHolding`.`Wea_ID`; ", "Wea");
            object[] weaHoldings = new object[dgWea.RowCount - 1];
            for (int i = 0; i < dgWea.RowCount - 1; i++)
            {
                weaHoldings[i] = dgWea.Rows[i].Cells[12].Value.ToString() + "-" + dgWea.Rows[i].Cells[6].Value.ToString();
            }
            cbWealthHolding.Items.Clear();
            cbWealthHolding.Items.AddRange(weaHoldings);

            DbReturn("SELECT `tbl_LandHoldingFeature`.*, `tbl_LandFeature`.* FROM `tbl_LandHoldingFeature`, `tbl_LandFeature` WHERE `tbl_LandHoldingFeature`.`LanHol_ID` = '" + dgLand.Rows[cbLandHolding.SelectedIndex].Cells[1].Value + "' AND `tbl_LandFeature`.`LanFea_ID` = `tbl_LandHoldingFeature`.`LanFea_ID` AND `tbl_LandFeature`.`LanFea_Spaces` > '0';" , "LandFea");
            DbReturn("SELECT `tbl_DefenseHolding`.*, `tbl_Defense`.`Def_ID`, `tbl_Defense`.* FROM `tbl_DefenseHolding`, `tbl_Defense` WHERE `tbl_DefenseHolding`.`LanHol_ID` = '"+ dgLand.Rows[cbLandHolding.SelectedIndex].Cells[1].Value + "' AND `tbl_Defense`.`Def_ID` = `tbl_DefenseHolding`.`Def_ID`; ", "Def");

            object[] landFeaDefHoldings = new object[dgLandFea.RowCount+dgDef.RowCount - 2];
            for (int i = 0; i < dgDef.RowCount - 1; i++)
            {
                landFeaDefHoldings[i] = dgDef.Rows[i].Cells[8].Value.ToString() + "-" + dgDef.Rows[i].Cells[3].Value.ToString();
            }
            for (int i = 0; i < dgLandFea.RowCount-1; i++)
            {
                landFeaDefHoldings[i+ dgLandFea.RowCount - 1] = dgLandFea.Rows[i].Cells[6].Value.ToString() + "-" + dgLandFea.Rows[i].Cells[3].Value.ToString();
            }
            cbDefLanFea.Items.Clear();
            cbDefLanFea.Items.AddRange(landFeaDefHoldings);
        }

        private void CbDefLanFea_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripEnabled("Defense/Feature");
            int costDef = 0;
            int costLan = 0;
            int costPop = 0;
            lbCost.Text = "";
            lbDesc.Text = "";
            lbBenfits.Text = "";
            lbAddions.Text = "";
            lbImprovemnt.Text = "";
            rtbNotes.Text = "";
            if(cbDefLanFea.SelectedIndex<dgDef.RowCount-1)
            {//Defense Holding
                lbName.Text = dgDef.Rows[cbDefLanFea.SelectedIndex].Cells[8].Value.ToString() + " - " + dgDef.Rows[cbDefLanFea.SelectedIndex].Cells[3].Value.ToString();
                lbType.Text = "Defense Holding";
                lbDesc.Text = dgDef.Rows[cbDefLanFea.SelectedIndex].Cells[11].Value.ToString();
                lbBenfits.Text = "Benfit: " + dgDef.Rows[cbDefLanFea.SelectedIndex].Cells[12].Value.ToString();
                rtbNotes.Text = dgDef.Rows[cbDefLanFea.SelectedIndex].Cells[4].Value.ToString();
                costDef += Convert.ToInt32(dgDef.Rows[cbDefLanFea.SelectedIndex].Cells[9].Value);

                DbReturn("SELECT `tbl_WealthHolding`.`LanHol_ID`, `tbl_WealthHolding`.*, `tbl_Wealth`.`Wea_ID`, `tbl_Wealth`.*FROM `tbl_WealthHolding`, `tbl_Wealth` WHERE `tbl_WealthHolding`.`DefHol_ID` = '" + dgDef.Rows[cbDefLanFea.SelectedIndex].Cells[0].Value + "' AND `tbl_Wealth`.`Wea_ID` = `tbl_WealthHolding`.`Wea_ID`; ", "Wea");
                object[] weaHoldings = new object[dgWea.RowCount - 1];
                for (int i = 0; i < dgWea.RowCount - 1; i++)
                {
                    weaHoldings[i] = dgWea.Rows[i].Cells[12].Value.ToString() + "-" + dgWea.Rows[i].Cells[6].Value.ToString();
                }
                cbWealthHolding.Items.Clear();
                cbWealthHolding.Items.AddRange(weaHoldings);

                if (costDef>0) { lbCost.Text += "Defense: " + costDef + " "; }
            } else {//Land Feature
                lbName.Text = dgLandFea.Rows[cbDefLanFea.SelectedIndex - dgDef.RowCount+1].Cells[6].Value.ToString() + " - " + dgLandFea.Rows[cbDefLanFea.SelectedIndex - dgDef.RowCount+1].Cells[3].Value.ToString();
                lbType.Text = "Land Feature Holding";
                rtbNotes.Text = dgLandFea.Rows[cbDefLanFea.SelectedIndex - dgDef.RowCount + 1].Cells[4].Value.ToString();
                costLan += Convert.ToInt32(dgLandFea.Rows[cbDefLanFea.SelectedIndex - dgDef.RowCount + 1].Cells[7].Value);
                costPop += Convert.ToInt32(dgLandFea.Rows[cbDefLanFea.SelectedIndex - dgDef.RowCount + 1].Cells[8].Value);

                DbReturn("SELECT `tbl_WealthHolding`.`LanHol_ID`, `tbl_WealthHolding`.*, `tbl_Wealth`.`Wea_ID`, `tbl_Wealth`.*FROM `tbl_WealthHolding`, `tbl_Wealth` WHERE `tbl_WealthHolding`.`LanHolFea_ID` = '" + dgLandFea.Rows[cbDefLanFea.SelectedIndex - dgDef.RowCount +1].Cells[0].Value + "' AND `tbl_Wealth`.`Wea_ID` = `tbl_WealthHolding`.`Wea_ID`; ", "Wea");
                object[] weaHoldings = new object[dgWea.RowCount - 1];
                for (int i = 0; i < dgWea.RowCount - 1; i++)
                {
                    weaHoldings[i] = dgWea.Rows[i].Cells[12].Value.ToString() + "-" + dgWea.Rows[i].Cells[6].Value.ToString();
                }
                cbWealthHolding.Items.Clear();
                cbWealthHolding.Items.AddRange(weaHoldings);

                if (costLan > 0) { lbCost.Text += "land: " + costLan + " "; }
                if (costPop > 0) { lbCost.Text += "Population: " + costPop + " "; }
            }

        }

        private void CbWealthHolding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripEnabled("Wealth");
            int costWea = 0;
            int costDef = 0;
            int costLan = 0;
            int costPow = 0;
            int costInf = 0;
            lbCost.Text = "";
            lbDesc.Text = "";
            lbBenfits.Text = "";
            lbAddions.Text = "";
            lbImprovemnt.Text = "";
            rtbNotes.Text = "";

            lbName.Text = dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[12].Value.ToString() + "-" + dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[6].Value.ToString();
            lbType.Text = dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[13].Value.ToString() + " Wealth Holdings";
            lbDesc.Text = dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[21].Value.ToString();
            lbBenfits.Text = "Benfits: " + dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[22].Value.ToString();
            rtbNotes.Text = dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[8].Value.ToString();

            costWea += Convert.ToInt32(dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[15].Value);
            costDef += Convert.ToInt32(dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[16].Value);
            costLan += Convert.ToInt32(dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[17].Value);
            costPow += Convert.ToInt32(dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[18].Value);

            DbReturn("SELECT `tbl_WealthHoldingImprovement`.`WeaHol_ID`, `tbl_WealthHoldingImprovement`.*, `tbl_WealthImprovement`.`WeaImp_ID`, `tbl_WealthImprovement`.* FROM `tbl_WealthHoldingImprovement`, `tbl_WealthImprovement` WHERE `tbl_WealthHoldingImprovement`.`WeaHol_ID` = '" + dgWea.Rows[cbWealthHolding.SelectedIndex].Cells[1].Value + "' AND `tbl_WealthImprovement`.`WeaImp_ID` = `tbl_WealthHoldingImprovement`.`WeaImp_ID`; ", "Imp");
            for (int t = 0; t < dgImp.RowCount - 1; t++)
            {
                costWea += Convert.ToInt32(dgImp.Rows[t].Cells[10].Value);
                costDef += Convert.ToInt32(dgImp.Rows[t].Cells[11].Value);
                costLan += Convert.ToInt32(dgImp.Rows[t].Cells[12].Value);
                costLan += Convert.ToInt32(dgImp.Rows[t].Cells[13].Value);
                costInf += Convert.ToInt32(dgImp.Rows[t].Cells[14].Value);
                lbImprovemnt.Text += dgImp.Rows[t].Cells[8].Value.ToString() + Environment.NewLine + dgImp.Rows[t].Cells[17].Value.ToString() + Environment.NewLine + "Benefit: "+ dgImp.Rows[t].Cells[18].Value.ToString()+ Environment.NewLine;

            }
            
            if (costWea > 0) { lbCost.Text += "Wealth: "+ costWea + " "; }
            if (costDef > 0) { lbCost.Text += "Defense: "+ costDef + " "; }
            if (costLan > 0) { lbCost.Text += "Land: "+costLan + " "; }
            if (costPow > 0) { lbCost.Text += "Power: "+costPow + " "; }
            if (costInf > 0) { lbCost.Text += "Influence: " + costInf + " "; }
        }

        
    }
}
