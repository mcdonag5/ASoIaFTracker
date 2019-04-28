using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class ChangeResourcesForm : Form
    {
        ///// VARIABLES START ////////////////////////////////////////////////////// 
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();
        House House = new House();
        Validation Validation = new Validation();
        public int houseID;
        int[] HouseFortunesArry = 
            {-3,-3,-3,-2,-1,-3,1,-1,1,-2,-1,
            1,3,-1,2,1,-2,-1,2,-2,2,
            1,1,-2,1,1,2,2,3,-2,2,
            1,1,1,1,2,3,1,1,1,1,
            1,3};

        public void UpdateChanges()
        {

        }

        public void GetChanges(int year, int month)
        {
            bool found = false;
            for(int i = 0; i < dgCal1.RowCount; i++)
            {
                if (year == Convert.ToInt32(dgCal1.Rows[i].Cells[2].Value))
                {
                    if (month == Convert.ToInt32(dgCal1.Rows[i].Cells[3].Value))
                    {
                        tbRoll.Text = dgCal1.Rows[i].Cells[4].Value.ToString();
                        if(tbRoll.Text == "") { cbFortune.Text = dgCal1.Rows[i].Cells[5].Value.ToString(); }
                        tbWealthHF.Text = dgCal1.Rows[i].Cells[6].Value.ToString();
                        tbWealthOther.Text = dgCal1.Rows[i].Cells[7].Value.ToString();
                        tbPowerHF.Text = dgCal1.Rows[i].Cells[8].Value.ToString();
                        tbPowerOther.Text = dgCal1.Rows[i].Cells[9].Value.ToString();
                        tbPopulationHF.Text = dgCal1.Rows[i].Cells[10].Value.ToString();
                        tbPopulationOther.Text = dgCal1.Rows[i].Cells[11].Value.ToString();
                        tbLawHF.Text = dgCal1.Rows[i].Cells[12].Value.ToString();
                        tbLawOther.Text = dgCal1.Rows[i].Cells[13].Value.ToString();
                        tbLandHF.Text = dgCal1.Rows[i].Cells[14].Value.ToString();
                        tbLandOther.Text = dgCal1.Rows[i].Cells[15].Value.ToString();
                        tbInfluenceHF.Text = dgCal1.Rows[i].Cells[16].Value.ToString();
                        tbInfluenceOther.Text = dgCal1.Rows[i].Cells[17].Value.ToString();
                        tbDefenseHF.Text = dgCal1.Rows[i].Cells[18].Value.ToString();
                        tbDefenseOther.Text = dgCal1.Rows[i].Cells[19].Value.ToString();
                        found = true;
                    }
                }
            }
            if (!found)
            {
                tbRoll.Text = "";
                tbWealthHF.Text = tbPowerOther.Text = tbPopulationHF.Text = tbPopulationOther.Text = tbLawHF.Text = tbLawOther.Text = tbLandHF.Text = tbLandOther.Text = tbInfluenceHF.Text = tbInfluenceOther.Text = tbDefenseHF.Text = tbDefenseOther.Text = "0";
            }

        }

        public ChangeResourcesForm(int ID)
        {
            houseID = ID;
            InitializeComponent();
            dgCal1.DataSource = House.HouseQry("HouseChanges", houseID);
            if (dgCal1.RowCount > 0)
            {
                tbYear.Text = dgCal1.Rows[dgCal1.RowCount-1].Cells[2].Value.ToString();
                tbMonth.Text = dgCal1.Rows[dgCal1.RowCount-1].Cells[3].Value.ToString();
                tbRoll.Text = dgCal1.Rows[dgCal1.RowCount - 1].Cells[4].Value.ToString();

                GetChanges(Convert.ToInt32(dgCal1.Rows[dgCal1.RowCount - 1].Cells[2].Value), Convert.ToInt32(dgCal1.Rows[dgCal1.RowCount - 1].Cells[3].Value));
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tbRoll.Text != "")
            {
                int x = 0;
                if (Convert.ToInt32(tbRoll.Text) < HouseFortunesArry.Length-1)
                {
                    x = HouseFortunesArry[Convert.ToInt32(tbRoll.Text)];
                } else if (Convert.ToInt32(tbRoll.Text)<0)
                {
                    x = HouseFortunesArry[0];
                } else {
                    x = HouseFortunesArry[HouseFortunesArry.Length-1];
                }
                string fortune = "";
                switch(x)
                {
                    case -3:
                        fortune = "Disaster";
                        break;
                    case -2:
                        fortune = "Curse";
                        break;
                    case -1:
                        fortune = "Decline";
                        break;
                    case 1:
                        fortune = "Growth";
                        break;
                    case 2:
                        fortune = "Blessing";
                        break;
                    case 3:
                        fortune = "Boon";
                        break;
                }
                cbFortune.Text = fortune;
            }
            else
            {

                lbFortuneText.Text = "";
                cbFortune.SelectedIndex = -1;
            }
        }

        private void cbRealm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fortuneText = "";
            switch (cbFortune.Text)
            {
                case "Take Growth":
                    fortuneText = "A Growth result reflects the improvement of one or more of the house’s resources. It might result in a gift of land, a sudden swell in population, an upturn in the economy, and so on. Growth should improve one resource by 1 point.";
                    break;
                case "Disaster":
                    fortuneText = "A Disaster is an event of catastrophic proportions and sets the house back in a significant way. Examples include the outbreak of plague, the disfavor of a lord or king, the disgrace of a staunch ally, widespread lawlessness, or a combination of any of these dire events. Disaster reduces a single resource by 1–6 points or two resources by 1–3 points.";
                    break;
                case "Curse":
                    fortuneText = "A Curse is an unfortunate downturn in events that could weaken the house in some way. Curses are significant setbacks, and they can include brigands, bad weather, blights, desertion, lawlessness, and other effects. A Curse reduces one resource by 1–3 points or two resources by 1 point.";
                    break;
                case "Decline":
                    fortuneText = "When Decline results, it reflects a diminishing of one or more of the house’s resources. Decline reveals a shift in the house’s fortunes, such as the loss of land, the weakening of defenses, an outbreak of sickness, and other minor but unfortunate developments. Decline should reduce one resource by 1 point.";
                    break;
                case "Growth":
                    fortuneText = "A Growth result reflects the improvement of one or more of the house’s resources. It might result in a gift of land, a sudden swell in population, an upturn in the economy, and so on. Growth should improve one resource by 1 point.";
                    break;
                case "Blessing":
                    fortuneText = "A Blessing is a minor benefit, an upturn in events that improves the house in some way. Blessings might be useful alliances, receiving an invitation to participate in a notable tournament, a visit from a powerful lord, and so on. Blessings improve one resource by 1–3 points or two resources by 1 point each.";
                    break;
                case "Boon":
                    fortuneText = "A Boon is a fortune of considerable benefit and value to the house. Its occurrence might signify favor from a lord or the king, a windfall, a beneficial alliance, a business opportunity, or a profitable marriage. A boon should always improve one of a house’s resources by 1–6 points or two of a house’s resources by 1–3 points.";
                    break;
            }
            lbFortuneText.Text = fortuneText;
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {

        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMonth_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbMonth.Text) < 1) { tbMonth.Text = "1"; }
            else if (Convert.ToInt32(tbMonth.Text) > 12) { tbMonth.Text = "12"; }
            if (!(tbYear.Text == "" || tbMonth.Text == ""))
            {
                GetChanges(Convert.ToInt32(tbYear.Text), Convert.ToInt32(tbMonth.Text));
            }
        }

        private void btDateNext_Click(object sender, EventArgs e)
        {
            if (!(tbYear.Text == "" || tbMonth.Text == ""))
            {
                if(Convert.ToInt32(tbMonth.Text)>=12)
                {
                    tbYear.Text = Convert.ToString(Convert.ToInt32(tbYear.Text)+1);
                    tbMonth.Text = "1";
                } else
                {
                    tbMonth.Text = Convert.ToString(Convert.ToInt32(tbMonth.Text) + 1);
                }
            }
        }

        private void btDateBack_Click(object sender, EventArgs e)
        {
            if (!(tbYear.Text == "" || tbMonth.Text == ""))
            {
                if (Convert.ToInt32(tbMonth.Text) <= 1)
                {
                    tbYear.Text = Convert.ToString(Convert.ToInt32(tbYear.Text) - 1);
                    tbMonth.Text = "12";
                }
                else
                {
                    tbMonth.Text = Convert.ToString(Convert.ToInt32(tbMonth.Text) - 1);
                }
            }
        }

        private void OnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyDigit(e);
        }
    }
}
