using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            cbRealm.SelectedIndex = 0;
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
                case "Kings Landing":
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
            lbRealmWeaText.Text = dgCal1.Rows[0].Cells[4].Value.ToString();
            lbRealmPowText.Text = dgCal1.Rows[0].Cells[5].Value.ToString();
            lbRealmPopText.Text = dgCal1.Rows[0].Cells[6].Value.ToString();
            lbRealmLawText.Text = dgCal1.Rows[0].Cells[7].Value.ToString();
            lbRealmLanText.Text = dgCal1.Rows[0].Cells[8].Value.ToString();
            lbRealmInfText.Text = dgCal1.Rows[0].Cells[9].Value.ToString();
            lbRealmDefText.Text = dgCal1.Rows[0].Cells[10].Value.ToString();
            UpdateTotals();
        }

        public void UpdateTotals()
        {
            if (tbBaseWea.Text != "") { lbTotalWeaText.Text = "0"; lbTotalWeaText.Text = Convert.ToString(Convert.ToInt32(tbBaseWea.Text) + Convert.ToInt32(lbRealmWeaText.Text) + Convert.ToInt32(lbHistoryWeaText.Text)); }
            if (tbBasePow.Text != "") { lbTotalPowText.Text = Convert.ToString(Convert.ToInt32(tbBasePow.Text) + Convert.ToInt32(lbRealmPowText.Text) + Convert.ToInt32(lbHistoryPowText.Text)); }
            if (tbBasePop.Text != "") { lbTotalPopText.Text = Convert.ToString(Convert.ToInt32(tbBasePop.Text) + Convert.ToInt32(lbRealmPopText.Text) + Convert.ToInt32(lbHistoryPopText.Text)); }
            if (tbBaseLaw.Text != "") { lbTotalLawText.Text = Convert.ToString(Convert.ToInt32(tbBaseLaw.Text) + Convert.ToInt32(lbRealmLawText.Text) + Convert.ToInt32(lbHistoryLawText.Text)); }
            if (tbBaseLan.Text != "") { lbTotalLanText.Text = Convert.ToString(Convert.ToInt32(tbBaseLan.Text) + Convert.ToInt32(lbRealmLanText.Text) + Convert.ToInt32(lbHistoryLanText.Text)); }
            if (tbBaseInf.Text != "") { lbTotalInfText.Text = Convert.ToString(Convert.ToInt32(tbBaseInf.Text) + Convert.ToInt32(lbRealmInfText.Text) + Convert.ToInt32(lbHistoryInfText.Text)); }
            if (tbBaseDef.Text != "") { lbTotalDefText.Text = Convert.ToString(Convert.ToInt32(tbBaseDef.Text) + Convert.ToInt32(lbRealmDefText.Text) + Convert.ToInt32(lbHistoryDefText.Text)); }
        }

        public string RollD6(int amount)
        {
            int sum = 0;
            Random rnd = new Random();
            for (int i = 0; i < amount; i++)
            {
                int x = rnd.Next(1, 7);
                sum += x;
                DevLog.LogItem("Random Number: " + x);
            }
            return sum.ToString();
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbBaseWea.Text = RollD6(7);
            tbBasePow.Text = RollD6(7);
            tbBasePop.Text = RollD6(7);
            tbBaseLaw.Text = RollD6(7);
            tbBaseLan.Text = RollD6(7);
            tbBaseInf.Text = RollD6(7);
            tbBaseDef.Text = RollD6(7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbBaseWea.Text = RollD6(5);
            tbBasePow.Text = RollD6(5);
            tbBasePop.Text = RollD6(5);
            tbBaseLaw.Text = RollD6(5);
            tbBaseLan.Text = RollD6(5);
            tbBaseInf.Text = RollD6(5);
            tbBaseDef.Text = RollD6(5);
        }
    }
}
