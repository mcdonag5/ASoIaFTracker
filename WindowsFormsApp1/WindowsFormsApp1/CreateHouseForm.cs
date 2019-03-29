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
    public partial class CreateHouseForm : Form
    {
        ///// VARIABLES START ////////////////////////////////////////////////////// 
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();


        public CreateHouseForm()
        {
            InitializeComponent();
        }

        private void CreateHouseForm_Load(object sender, EventArgs e)
        {
            mysqlConn.DbConfig(); //sets database settings
            mysqlConn.Connect();
        }

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
                }

            }
        }

        private void cbRealm_TextChanged(object sender, EventArgs e)
        {
            switch (cbRealm.Text)
            {
                case "King's Landing":
                    pbHouseShield.Image = Properties.Resources.Targaryen;
                    break;
                case "Dragonstone":
                    pbHouseShield.Image = Properties.Resources.Targaryen;
                    break;
                case "The North":
                    pbHouseShield.Image = Properties.Resources.Stark;
                    break;
                case "The Iron Islands":
                    pbHouseShield.Image = Properties.Resources.Greyjoy;
                    break;
                case "The Riverlands":
                    pbHouseShield.Image = Properties.Resources.Tully;
                    break;
                case "The Mountains of the Moon":
                    pbHouseShield.Image = Properties.Resources.Arryn;
                    break;
                case "The Westerlands":
                    pbHouseShield.Image = Properties.Resources.Lannister;
                    break;
                case "The Reach":
                    pbHouseShield.Image = Properties.Resources.Tyrell;
                    break;
                case "The Stormlands":
                    pbHouseShield.Image = Properties.Resources.Baratheon;
                    break;
                case "Dorne":
                    pbHouseShield.Image = Properties.Resources.Martell;
                    break;
                case "The Wall":
                    pbHouseShield.Image = Properties.Resources.NightsWatch;
                    break;
            }
            DbReturn("SELECT `tbl_Realms`.`Rea_Name`, `tbl_Realms`.* FROM `tbl_Realms` WHERE `tbl_Realms`.`Rea_Name` = '"+cbRealm.Text+"'; ", "1");
            lbRealmDescription.Text = dgCal1.Rows[0].Cells[3].Value.ToString();
        }
    }
}
