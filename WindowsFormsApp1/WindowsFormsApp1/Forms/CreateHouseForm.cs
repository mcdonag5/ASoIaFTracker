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
        
        int foundingMod = 3;
        int currentEvent = 1;


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
            tbLiege.Text = dgCal1.Rows[0].Cells[2].Value.ToString();
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
            if (tbBaseWea.Text != "") { lbTotalWeaText.Text = UpdateResource(Convert.ToInt32(tbBaseWea.Text), Convert.ToInt32(lbRealmWeaText.Text), Convert.ToInt32(lbHistoryWeaText.Text)); }
            if (tbBasePow.Text != "") { lbTotalPowText.Text = UpdateResource(Convert.ToInt32(tbBasePow.Text), Convert.ToInt32(lbRealmPowText.Text), Convert.ToInt32(lbHistoryPowText.Text)); }
            if (tbBasePop.Text != "") { lbTotalPopText.Text = UpdateResource(Convert.ToInt32(tbBasePop.Text), Convert.ToInt32(lbRealmPopText.Text), Convert.ToInt32(lbHistoryPopText.Text)); }
            if (tbBaseLaw.Text != "") { lbTotalLawText.Text = UpdateResource(Convert.ToInt32(tbBaseLaw.Text), Convert.ToInt32(lbRealmLawText.Text), Convert.ToInt32(lbHistoryLawText.Text)); }
            if (tbBaseLan.Text != "") { lbTotalLanText.Text = UpdateResource(Convert.ToInt32(tbBaseLan.Text), Convert.ToInt32(lbRealmLanText.Text), Convert.ToInt32(lbHistoryLanText.Text)); }
            if (tbBaseInf.Text != "") { lbTotalInfText.Text = UpdateResource(Convert.ToInt32(tbBaseInf.Text), Convert.ToInt32(lbRealmInfText.Text), Convert.ToInt32(lbHistoryInfText.Text)); }
            if (tbBaseDef.Text != "") { lbTotalDefText.Text = UpdateResource(Convert.ToInt32(tbBaseDef.Text), Convert.ToInt32(lbRealmDefText.Text), Convert.ToInt32(lbHistoryDefText.Text)); }
        }

        public string UpdateResource(int x,int y, int z)
        {
            int sum = x + y + z;
            if (sum < 0) { sum = 0; }
            return sum.ToString();
        }

        public string RollD6(int amount,int mod)
        {
            int sum = 0;
            Random rnd = new Random();
            for (int i = 0; i < amount; i++)
            {
                int x = rnd.Next(1, 7);
                sum += x;
                DevLog.LogItem("Random Number: " + x);
            }
            sum += mod;
            return sum.ToString();
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

        public string RollHistory (int dice, int mod)
        {
            string roll ="";
            if(dice>0)
            {
                roll = RollD6(dice, mod);
            } else if(dice<0)
            {
                roll = "-"+RollD6(Math.Abs(dice), mod);
            }
            Thread.Sleep(100);
            return roll;
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

        private void tbFoundingNumber_TextChanged(object sender, EventArgs e)
        {
            switch(tbFoundingNumber.Text)
            {
                case "1":
                    lbFoundingText.Text = "Ancient";
                    lbEventText.Text = "Events (1d6+3)";
                    foundingMod = 3;
                    break;
                case "2":
                    lbFoundingText.Text = "Very Old";
                    lbEventText.Text = "Events (1d6+2)";
                    foundingMod = 2;
                    break;
                case "3":
                    lbFoundingText.Text = "Old";
                    lbEventText.Text = "Events (1d6+1)";
                    foundingMod = 1;
                    break;
                case "4":
                    lbFoundingText.Text = "Established";
                    lbEventText.Text = "Events (1d6)";
                    foundingMod = 0;
                    break;
                case "5":
                    lbFoundingText.Text = "Recent";
                    lbEventText.Text = "Events (1d6-1)";
                    foundingMod = -1;
                    break;
                case "6":
                    lbFoundingText.Text = "New";
                    lbEventText.Text = "Events (1d6-2)";
                    foundingMod = -2;
                    break;
            }
            if (tbFoundingNumber.TextLength > 0 && tbEventNumber.TextLength > 0)
            {
                if (Convert.ToInt32(tbFoundingNumber.Text) > 0 && Convert.ToInt32(tbFoundingNumber.Text) < 7 && Convert.ToInt32(tbEventNumber.Text) > 0 && Convert.ToInt32(tbEventNumber.Text) < 10)
                {
                    btEventRoll.Enabled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbFoundingNumber.Text = RollD6(1);
            tbEventNumber.Text = RollD6(1, foundingMod);
            if(Convert.ToInt32(tbEventNumber.Text)<1) { tbEventNumber.Text = "1"; }
        }

        private void tbEventRoll_TextChanged(object sender, EventArgs e)
        {
            if (tbEventRoll.TextLength>0 && Convert.ToInt32(tbEventRoll.Text) >=3 && Convert.ToInt32(tbEventRoll.Text) <= 18)
            {
                btNextEvent.Enabled = true;
                DbReturn("SELECT * FROM `tbl_HistoricalEvents` WHERE `His_ID` = " + tbEventRoll.Text, "1");
                lbEventName.Text = dgCal1.Rows[0].Cells[1].Value.ToString();
                lbEventDescription.Text = dgCal1.Rows[0].Cells[2].Value.ToString();
                if (currentEvent == 1) { lbEventDescription.Text += dgCal1.Rows[0].Cells[3].Value.ToString(); }
                string mod ="";
                if(dgCal1.Rows[0].Cells[11].Value.ToString()!="0")
                {
                    if(Convert.ToInt32(dgCal1.Rows[0].Cells[11].Value)>0) { mod += "+"; }
                    mod += dgCal1.Rows[0].Cells[11].Value.ToString();
                }
                lbWeaHistoryMod.Text = dgCal1.Rows[0].Cells[4].Value.ToString() + "d6" + mod;
                lbPowHistoryMod.Text = dgCal1.Rows[0].Cells[5].Value.ToString() + "d6" + mod;
                lbPopHistoryMod.Text = dgCal1.Rows[0].Cells[6].Value.ToString() + "d6" + mod;
                lbLawHistoryMod.Text = dgCal1.Rows[0].Cells[7].Value.ToString() + "d6" + mod;
                lbLanHistoryMod.Text = dgCal1.Rows[0].Cells[8].Value.ToString() + "d6" + mod;
                lbInfHistoryMod.Text = dgCal1.Rows[0].Cells[9].Value.ToString() + "d6" + mod;
                lbDefHistoryMod.Text = dgCal1.Rows[0].Cells[10].Value.ToString() + "d6" + mod;
            } else
            {
                btNextEvent.Enabled = false;
                lbEventName.Text = "";
                lbEventDescription.Text = "";
                tbWeaHistory.Text = "";
                tbPowHistory.Text = "";
                tbPopHistory.Text = "";
                tbLawHistory.Text = "";
                tbLanHistory.Text = "";
                tbInfHistory.Text = "";
                tbDefHistory.Text = "";
                lbWeaHistoryMod.Text = "";
                lbPowHistoryMod.Text = "";
                lbPopHistoryMod.Text = "";
                lbLawHistoryMod.Text = "";
                lbLanHistoryMod.Text = "";
                lbInfHistoryMod.Text = "";
                lbDefHistoryMod.Text = "";
            }
        }

        private void btEventRoll_Click(object sender, EventArgs e)
        {
            tbEventRoll.Text = RollD6(3);
            btFoundingRoll.Enabled = false;
            tbFoundingNumber.Enabled = false;
            tbEventNumber.Enabled = false;
            if (tbEventRoll.Text == "11")
            {
                Random rnd = new Random();
                int rndResource = 0;
                int lastResource = 0;
                for(int i =0;i<1;i++)
                {
                    while(rndResource == lastResource)
                    {
                        rndResource = rnd.Next(1, 8);
                    }
                    lastResource = rndResource;
                    switch(rndResource)
                    {
                        case 1:
                            tbWeaHistory.Text = RollD6(1);
                            break;
                        case 2:
                            tbPowHistory.Text = RollD6(1);
                            break;
                        case 3:
                            tbPopHistory.Text = RollD6(1);
                            break;
                        case 4:
                            tbLawHistory.Text = RollD6(1);
                            break;
                        case 5:
                            tbLanHistory.Text = RollD6(1);
                            break;
                        case 6:
                            tbInfHistory.Text = RollD6(1);
                            break;
                        case 7:
                            tbDefHistory.Text = RollD6(1);
                            break;
                    }
                }
            }
            else
            {
                tbWeaHistory.Text = RollHistory(Convert.ToInt32(dgCal1.Rows[0].Cells[4].Value), Convert.ToInt32(dgCal1.Rows[0].Cells[11].Value));
                tbPowHistory.Text = RollHistory(Convert.ToInt32(dgCal1.Rows[0].Cells[5].Value), Convert.ToInt32(dgCal1.Rows[0].Cells[11].Value));
                tbPopHistory.Text = RollHistory(Convert.ToInt32(dgCal1.Rows[0].Cells[6].Value), Convert.ToInt32(dgCal1.Rows[0].Cells[11].Value));
                tbLawHistory.Text = RollHistory(Convert.ToInt32(dgCal1.Rows[0].Cells[7].Value), Convert.ToInt32(dgCal1.Rows[0].Cells[11].Value));
                tbLanHistory.Text = RollHistory(Convert.ToInt32(dgCal1.Rows[0].Cells[8].Value), Convert.ToInt32(dgCal1.Rows[0].Cells[11].Value));
                tbInfHistory.Text = RollHistory(Convert.ToInt32(dgCal1.Rows[0].Cells[9].Value), Convert.ToInt32(dgCal1.Rows[0].Cells[11].Value));
                tbDefHistory.Text = RollHistory(Convert.ToInt32(dgCal1.Rows[0].Cells[10].Value), Convert.ToInt32(dgCal1.Rows[0].Cells[11].Value));
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbFoundingNumber.Text) > 0 && Convert.ToInt32(tbFoundingNumber.Text) < 7 && Convert.ToInt32(tbFoundingNumber.Text) > 0 && Convert.ToInt32(tbFoundingNumber.Text) < 10)
            {
                if (tbEventRoll.TextLength > 0 && Convert.ToInt32(tbEventRoll.Text) >= 3 && Convert.ToInt32(tbEventRoll.Text) <= 18)
                {
                    btFoundingRoll.Enabled = false;
                    tbFoundingNumber.Enabled = false;
                    tbEventNumber.Enabled = false;
                    if (tbWeaHistory.Text.Length > 0) { lbHistoryWeaText.Text = Convert.ToString(Convert.ToInt32(lbHistoryWeaText.Text) + Convert.ToInt32(tbWeaHistory.Text)); }
                    if (tbPowHistory.Text.Length > 0) { lbHistoryPowText.Text = Convert.ToString(Convert.ToInt32(lbHistoryPowText.Text) + Convert.ToInt32(tbPowHistory.Text)); }
                    if (tbPopHistory.Text.Length > 0) { lbHistoryPopText.Text = Convert.ToString(Convert.ToInt32(lbHistoryPopText.Text) + Convert.ToInt32(tbPopHistory.Text)); }
                    if (tbLawHistory.Text.Length > 0) { lbHistoryLawText.Text = Convert.ToString(Convert.ToInt32(lbHistoryLawText.Text) + Convert.ToInt32(tbLawHistory.Text)); }
                    if (tbLanHistory.Text.Length > 0) { lbHistoryLanText.Text = Convert.ToString(Convert.ToInt32(lbHistoryLanText.Text) + Convert.ToInt32(tbLanHistory.Text)); }
                    if (tbInfHistory.Text.Length > 0) { lbHistoryInfText.Text = Convert.ToString(Convert.ToInt32(lbHistoryInfText.Text) + Convert.ToInt32(tbInfHistory.Text)); }
                    if (tbDefHistory.Text.Length > 0) { lbHistoryDefText.Text = Convert.ToString(Convert.ToInt32(lbHistoryDefText.Text) + Convert.ToInt32(tbDefHistory.Text)); }
                    lbHistoryList.Text += currentEvent + ": " + lbEventName.Text + Environment.NewLine;
                    currentEvent++;
                    if (currentEvent > Convert.ToInt32(tbEventNumber.Text)) { btNextEvent.Enabled = false; }
                    UpdateTotals();
                    tbEventRoll.Text = "";
                    tbWeaHistory.Text = "";
                    tbPowHistory.Text = "";
                    tbPopHistory.Text = "";
                    tbLawHistory.Text = "";
                    tbLanHistory.Text = "";
                    tbInfHistory.Text = "";
                    tbDefHistory.Text = "";
                }
            }
        }

        private void tbEventNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbFoundingNumber.TextLength > 0 && tbEventNumber.TextLength > 0)
            {
                if (Convert.ToInt32(tbFoundingNumber.Text) > 0 && Convert.ToInt32(tbFoundingNumber.Text) < 7 && Convert.ToInt32(tbEventNumber.Text) > 0 && Convert.ToInt32(tbEventNumber.Text) < 10)
                {
                    btEventRoll.Enabled = true;
                }
            }
        }

        private void tbCreateHouse_Click(object sender, EventArgs e)
        {
            if (tbName.TextLength > 0 && lbPlayer.Text.Length > 0)
            {
                if (mysqlConn.ConnOpen() == true)
                {
                    mysqlConn.InsertHouse(tbName.Text, tbPlayer.Text, cbRealm.Text, tbSeatOfPower.Text, tbLiegeLord.Text, tbLiege.Text, lbTotalWeaText.Text, lbTotalPowText.Text, lbTotalPopText.Text, lbTotalLawText.Text, lbTotalLanText.Text, lbTotalInfText.Text, lbTotalDefText.Text, lbFoundingText.Text, lbHistoryList.Text);
                    Close();
                }
            }
        }
    }
}
