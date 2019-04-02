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
                    case "1":
                        dgCal1.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                    case "2":
                        dgCal2.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                    case "3":
                        dgCal3.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                    case "4":
                        dgCal4.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                }

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
            DbReturn("SELECT `tbl_LandHolding`.`Hou_ID`, `tbl_LandHolding`.*, `tbl_Land`.`Lan_ID`, `tbl_Land`.* FROM `tbl_LandHolding`, `tbl_Land` WHERE `tbl_LandHolding`.`Hou_ID` = '" + houseID + "' AND `tbl_Land`.`Lan_ID` = `tbl_LandHolding`.`Lan_ID`; ", "1");
            object[] landHoldings = new object[dgCal1.RowCount - 1];

            for (int i = 0; i < dgCal1.RowCount-1; i++)
            {
                landHoldings[i] = dgCal1.Rows[i].Cells[9].Value.ToString() + "-" + dgCal1.Rows[i].Cells[4].Value.ToString();
            }
            cbLandHolding.Items.AddRange(landHoldings);
        }

        private void cbLandHolding_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCost.Text = "";
            lbDesc.Text = "";
            lbBenfits.Text = "";
            lbAddions.Text = "";
            lbImprovemnt.Text = "";
            rtbNotes.Text = "";

            int index = cbLandHolding.SelectedIndex;
            lbName.Text = dgCal1.Rows[index].Cells[9].Value.ToString() + "-" + dgCal1.Rows[index].Cells[4].Value.ToString();
            int costLand = Convert.ToInt32(dgCal1.Rows[index].Cells[10].Value) - Convert.ToInt32(dgCal1.Rows[index].Cells[6].Value);
            rtbNotes.Text = dgCal1.Rows[index].Cells[5].Value.ToString();
            //Land Fea
            DbReturn("SELECT `tbl_LandHoldingFeature`.*, `tbl_LandFeature`.* FROM `tbl_LandHoldingFeature`, `tbl_LandFeature` WHERE `tbl_LandHoldingFeature`.`LanHol_ID` = '" + dgCal1.Rows[index].Cells[1].Value.ToString() + "' AND `tbl_LandFeature`.`LanFea_ID` = `tbl_LandHoldingFeature`.`LanFea_ID` AND `tbl_LandFeature`.`LanFea_Spaces` = '0'; ", "4");
            for (int n = 0; n < dgCal4.RowCount - 1; n++)
            {
                costLand += Convert.ToInt32(dgCal1.Rows[n].Cells[7].Value);
                lbAddions.Text += dgCal4.Rows[n].Cells[6].Value.ToString() + " - " + dgCal4.Rows[n].Cells[3].Value.ToString() + Environment.NewLine;
            }
            //Land Fea Towns
            DbReturn("SELECT `tbl_LandHoldingFeature`.*, `tbl_LandFeature`.* FROM `tbl_LandHoldingFeature`, `tbl_LandFeature` WHERE `tbl_LandHoldingFeature`.`LanHol_ID` = '" + dgCal1.Rows[index].Cells[1].Value.ToString() + "' AND `tbl_LandFeature`.`LanFea_ID` = `tbl_LandHoldingFeature`.`LanFea_ID` AND `tbl_LandFeature`.`LanFea_Spaces` > '0'; ", "4");
            for (int n = 0; n < dgCal4.RowCount - 1; n++)
            {
                costLand += Convert.ToInt32(dgCal4.Rows[n].Cells[7].Value);
                lbAddions.Text += dgCal4.Rows[n].Cells[6].Value.ToString() + " - " + dgCal4.Rows[n].Cells[3].Value.ToString() + Environment.NewLine;
                

            }
            lbCost.Text = "";
            lbCost.Text += "Land: "+costLand+" ";
            lbType.Text = "Land Holding";
        }
    }
}
