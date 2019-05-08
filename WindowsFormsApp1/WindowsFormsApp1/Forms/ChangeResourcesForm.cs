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
        House House;
        Validation Validation = new Validation();
        public int houseID;
        public int changeRow;
        int[] HouseFortunesArry = 
            {-3,-3,-3,-2,-1,-3,1,-1,1,-2,-1,
            1,3,-1,2,1,-2,-1,2,-2,2,
            1,1,-2,1,1,2,2,3,-2,2,
            1,1,1,1,2,3,1,1,1,1,
            1,3};
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        //Gets the changes 
        public void GetChanges()
        {
            DevLog.LogItem("Getting changes from " + dgCal1.Rows[changeRow].Cells[2].Value.ToString()+" AL month "+ dgCal1.Rows[changeRow].Cells[3].Value.ToString());
            tbRoll.Text = dgCal1.Rows[changeRow].Cells[4].Value.ToString();
            if(tbRoll.Text == "") { cbFortune.Text = dgCal1.Rows[changeRow].Cells[5].Value.ToString(); }
            tbWealthHF.Text = dgCal1.Rows[changeRow].Cells[6].Value.ToString();
            tbWealthOther.Text = dgCal1.Rows[changeRow].Cells[7].Value.ToString();
            tbPowerHF.Text = dgCal1.Rows[changeRow].Cells[8].Value.ToString();
            tbPowerOther.Text = dgCal1.Rows[changeRow].Cells[9].Value.ToString();
            tbPopulationHF.Text = dgCal1.Rows[changeRow].Cells[10].Value.ToString();
            tbPopulationOther.Text = dgCal1.Rows[changeRow].Cells[11].Value.ToString();
            tbLawHF.Text = dgCal1.Rows[changeRow].Cells[12].Value.ToString();
            tbLawOther.Text = dgCal1.Rows[changeRow].Cells[13].Value.ToString();
            tbLandHF.Text = dgCal1.Rows[changeRow].Cells[14].Value.ToString();
            tbLandOther.Text = dgCal1.Rows[changeRow].Cells[15].Value.ToString();
            tbInfluenceHF.Text = dgCal1.Rows[changeRow].Cells[16].Value.ToString();
            tbInfluenceOther.Text = dgCal1.Rows[changeRow].Cells[17].Value.ToString();
            tbDefenseHF.Text = dgCal1.Rows[changeRow].Cells[18].Value.ToString();
            tbDefenseOther.Text = dgCal1.Rows[changeRow].Cells[19].Value.ToString();
        }
        //check if a date is in the data grid
        public bool CheckDate(int year,int month)
        {
            DevLog.LogItem("Checking date " + year + " AL month " + month);
            for (int i = 0; i < dgCal1.RowCount; i++)
            {
                if (year == Convert.ToInt32(dgCal1.Rows[i].Cells[2].Value))
                {
                    if (month == Convert.ToInt32(dgCal1.Rows[i].Cells[3].Value))
                    {
                        DevLog.LogItem("Date found on row " + i);
                        changeRow = i;
                        return true;
                    }
                }
            }
            DevLog.LogItem("Date not Found");
            return false;
        }

        public void UpdateChanges(int year, int month)
        {
            if (CheckDate(year, month))
            {
                GetChanges();
            } else {
                DevLog.LogItem("Values reset");
                tbRoll.Text = "";
                tbWealthHF.Text = tbWealthOther.Text = tbPowerHF.Text = tbPowerOther.Text = tbPopulationHF.Text = tbPopulationOther.Text = tbLawHF.Text = tbLawOther.Text = tbLandHF.Text = tbLandOther.Text = tbInfluenceHF.Text = tbInfluenceOther.Text = tbDefenseHF.Text = tbDefenseOther.Text = "0";
            }
        }

        public void SetNullToZero()
        {
            Object[] resourceTextboxArry = { tbWealthHF, tbWealthOther, tbPowerHF, tbPowerOther, tbPopulationHF, tbPopulationOther, tbLawHF, tbLawOther, tbLandHF, tbLandOther, tbInfluenceHF, tbInfluenceOther, tbDefenseHF, tbDefenseOther };
            foreach(Object x in resourceTextboxArry)
            {
                Validation.SetNullToZero(x);
            }
        }

        ///// METHODS END //////////////////////////////////////////////////////////
        
        public ChangeResourcesForm(int ID)
        {
            DevLog.LogItem("Opening Change Resource Form");
            House = new House(ID);
            InitializeComponent();
            dgCal1.DataSource = House.HouseQry("HouseChanges");
            
            if (dgCal1.RowCount > 0)
            {
                DevLog.LogItem("Oldest change set");
                tbYear.Text = dgCal1.Rows[dgCal1.RowCount-1].Cells[2].Value.ToString();
                tbMonth.Text = dgCal1.Rows[dgCal1.RowCount-1].Cells[3].Value.ToString();
                tbRoll.Text = dgCal1.Rows[dgCal1.RowCount - 1].Cells[4].Value.ToString();

                UpdateChanges(Convert.ToInt32(dgCal1.Rows[dgCal1.RowCount - 1].Cells[2].Value), Convert.ToInt32(dgCal1.Rows[dgCal1.RowCount - 1].Cells[3].Value));
            } else { DevLog.LogItem("No chsnges found"); }
        }

        ///// EVENTS START //////////////////////////////////////////////////////////
        private void TbRoll_TextChanged(object sender, EventArgs e)
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
                DevLog.LogItem("Roll:" + tbRoll.Text + " Fortune:" + fortune);
                cbFortune.Text = fortune;
            }
            else
            {
                DevLog.LogItem("tbRoll empty reset fortune text and combo box");
                lbFortuneText.Text = "";
                cbFortune.SelectedIndex = -1;
            }
        }

        private void CbRealm_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevLog.LogItem("Combo box change: "+cbFortune.Text+" setting fortune text");
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

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            DevLog.LogItem("Pressed Submit button");
            if (!(tbYear.Text == "" || tbMonth.Text == ""))
            {
                dgCal2.DataSource = House.HouseQry("ThisHouse");
                int wealthChange = 0;
                int powerChange = 0;
                int populationChange = 0;
                int lawChange = 0;
                int landsChange = 0;
                int influenceChange = 0;
                int defenseChange = 0;
                SetNullToZero();
                if (CheckDate(Convert.ToInt32(tbYear.Text), Convert.ToInt32(tbMonth.Text)))
                {
                    House.UpdateHouseChanges(Convert.ToInt32(dgCal1.Rows[changeRow].Cells[0].Value), Convert.ToInt32(tbRoll.Text), cbFortune.Text, Convert.ToInt32(tbWealthHF.Text), Convert.ToInt32(tbWealthOther.Text), Convert.ToInt32(tbPowerHF.Text), Convert.ToInt32(tbPowerOther.Text), Convert.ToInt32(tbPopulationHF.Text), Convert.ToInt32(tbPopulationOther.Text), Convert.ToInt32(tbLawHF.Text), Convert.ToInt32(tbLawOther.Text), Convert.ToInt32(tbLandHF.Text), Convert.ToInt32(tbLandOther.Text), Convert.ToInt32(tbInfluenceHF.Text), Convert.ToInt32(tbInfluenceOther.Text), Convert.ToInt32(tbDefenseHF.Text), Convert.ToInt32(tbDefenseOther.Text));
                    wealthChange = Convert.ToInt32(tbWealthHF.Text) + Convert.ToInt32(tbWealthOther.Text)-(Convert.ToInt32(dgCal1.Rows[changeRow].Cells[6].Value)+ Convert.ToInt32(dgCal1.Rows[changeRow].Cells[7].Value));
                    powerChange = Convert.ToInt32(tbPowerHF.Text) + Convert.ToInt32(tbPowerOther.Text) - (Convert.ToInt32(dgCal1.Rows[changeRow].Cells[8].Value) + Convert.ToInt32(dgCal1.Rows[changeRow].Cells[9].Value));
                    populationChange = Convert.ToInt32(tbPopulationHF.Text) + Convert.ToInt32(tbPopulationOther.Text) - (Convert.ToInt32(dgCal1.Rows[changeRow].Cells[10].Value) + Convert.ToInt32(dgCal1.Rows[changeRow].Cells[11].Value));
                    lawChange = Convert.ToInt32(tbLawHF.Text) + Convert.ToInt32(tbLawOther.Text) - (Convert.ToInt32(dgCal1.Rows[changeRow].Cells[12].Value) + Convert.ToInt32(dgCal1.Rows[changeRow].Cells[13].Value));
                    landsChange = Convert.ToInt32(tbLandHF.Text) + Convert.ToInt32(tbLandOther.Text) - (Convert.ToInt32(dgCal1.Rows[changeRow].Cells[14].Value) + Convert.ToInt32(dgCal1.Rows[changeRow].Cells[15].Value));
                    influenceChange = Convert.ToInt32(tbInfluenceHF.Text) + Convert.ToInt32(tbInfluenceOther.Text) - (Convert.ToInt32(dgCal1.Rows[changeRow].Cells[16].Value) + Convert.ToInt32(dgCal1.Rows[changeRow].Cells[17].Value));
                    defenseChange = Convert.ToInt32(tbDefenseHF.Text) + Convert.ToInt32(tbDefenseOther.Text) - (Convert.ToInt32(dgCal1.Rows[changeRow].Cells[18].Value) + Convert.ToInt32(dgCal1.Rows[changeRow].Cells[19].Value));
                    DevLog.LogItem("Update change ID: " + dgCal1.Rows[changeRow].Cells[0].Value.ToString());
                }
                else
                {
                    House.InsertHouseChanges(Convert.ToInt32(tbYear.Text), Convert.ToInt32(tbMonth.Text), Convert.ToInt32(tbRoll.Text), cbFortune.Text, Convert.ToInt32(tbWealthHF.Text), Convert.ToInt32(tbWealthOther.Text), Convert.ToInt32(tbPowerHF.Text), Convert.ToInt32(tbPowerOther.Text), Convert.ToInt32(tbPopulationHF.Text), Convert.ToInt32(tbPopulationOther.Text), Convert.ToInt32(tbLawHF.Text), Convert.ToInt32(tbLawOther.Text), Convert.ToInt32(tbLandHF.Text), Convert.ToInt32(tbLandOther.Text), Convert.ToInt32(tbInfluenceHF.Text), Convert.ToInt32(tbInfluenceOther.Text), Convert.ToInt32(tbDefenseHF.Text), Convert.ToInt32(tbDefenseOther.Text));
                    wealthChange = Convert.ToInt32(tbWealthHF.Text) + Convert.ToInt32(tbWealthOther.Text);
                    powerChange = Convert.ToInt32(tbPowerHF.Text) + Convert.ToInt32(tbPowerOther.Text);
                    populationChange = Convert.ToInt32(tbPopulationHF.Text) + Convert.ToInt32(tbPopulationOther.Text);
                    lawChange = Convert.ToInt32(tbLawHF.Text) + Convert.ToInt32(tbLawOther.Text);
                    landsChange = Convert.ToInt32(tbLandHF.Text) + Convert.ToInt32(tbLandOther.Text);
                    influenceChange = Convert.ToInt32(tbInfluenceHF.Text) + Convert.ToInt32(tbInfluenceOther.Text);
                    defenseChange = Convert.ToInt32(tbDefenseHF.Text) + Convert.ToInt32(tbDefenseOther.Text);
                    DevLog.LogItem("New change inserted");
                }
                House.UpdateHouseResources(Convert.ToInt32(dgCal2.Rows[0].Cells[7].Value) + wealthChange, Convert.ToInt32(dgCal2.Rows[0].Cells[8].Value) + powerChange, Convert.ToInt32(dgCal2.Rows[0].Cells[9].Value) + populationChange, Convert.ToInt32(dgCal2.Rows[0].Cells[10].Value) + lawChange, Convert.ToInt32(dgCal2.Rows[0].Cells[11].Value) + landsChange, Convert.ToInt32(dgCal2.Rows[0].Cells[12].Value) + influenceChange, Convert.ToInt32(dgCal2.Rows[0].Cells[13].Value) + defenseChange);
                dgCal1.DataSource = House.HouseQry("HouseChanges");
                DevLog.LogItem("House resources updated");

            }
            else { MessageBox.Show("Need a year and month to save change"); DevLog.LogItem("No year or month entered"); }
        }

        private void TbYear_TextChanged(object sender, EventArgs e)
        {
            if (!(tbYear.Text == "" || tbMonth.Text == ""))
            {
                UpdateChanges(Convert.ToInt32(tbYear.Text), Convert.ToInt32(tbMonth.Text));
            }
        }

        private void TbMonth_TextChanged(object sender, EventArgs e)
        {
            if (!(tbMonth.Text == "")) {
                if (Convert.ToInt32(tbMonth.Text) < 1) { tbMonth.Text = "1"; }
                else if (Convert.ToInt32(tbMonth.Text) > 12) { tbMonth.Text = "12"; }
                if (!(tbYear.Text == ""))
                {
                    UpdateChanges(Convert.ToInt32(tbYear.Text), Convert.ToInt32(tbMonth.Text));
                }
            }
        }

        private void BtDateNext_Click(object sender, EventArgs e)
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

        private void BtDateBack_Click(object sender, EventArgs e)
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
        //Validation
        private void OnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyDigit(e);
        }

        private void OnlyDigitWithNegatives_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyDigitWithNegatives(sender, e);
        }

        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
