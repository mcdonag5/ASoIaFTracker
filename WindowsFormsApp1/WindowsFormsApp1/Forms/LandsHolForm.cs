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
    }
}
