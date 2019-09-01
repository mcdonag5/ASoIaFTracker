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
    public partial class NewPowerForm : Form
    {
        ///// VARIABLES START //////////////////////////////////////////////////////
        
        //classes
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House;
        //arrays
        Label[] abilitiesLabel;
        TextBox[] abilitiesTextBox;
        Label[] armorNumber;
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public void UnitDetailsUpdate()
        {
            string description = "";
            description += dgType.Rows[cbType.SelectedIndex].Cells[7].Value.ToString() + Environment.NewLine;
            description += dgTraining.Rows[cbTraining.SelectedIndex].Cells[4].Value.ToString();
            lbDescription.Text = description;

            for (int i = 0; i < abilitiesLabel.Length; i++) { abilitiesLabel[i].ForeColor = Color.Black; }
            for (int i = 0; i < 3; i++)
            {
                switch (dgType.Rows[cbType.SelectedIndex].Cells[4 + i].Value.ToString())
                {
                    case "Agility":
                        abilitiesLabel[0].ForeColor = Color.Blue;
                        break;
                    case "Animal Handling":
                        abilitiesLabel[1].ForeColor = Color.Blue;
                        break;
                    case "Athletics":
                        abilitiesLabel[2].ForeColor = Color.Blue;
                        break;
                    case "Awareness":
                        abilitiesLabel[3].ForeColor = Color.Blue;
                        break;
                    case "Cunning":
                        abilitiesLabel[4].ForeColor = Color.Blue;
                        break;
                    case "Endurance":
                        abilitiesLabel[5].ForeColor = Color.Blue;
                        break;
                    case "Fighting":
                        abilitiesLabel[6].ForeColor = Color.Blue;
                        break;
                    case "Healing":
                        abilitiesLabel[7].ForeColor = Color.Blue;
                        break;
                    case "Language":
                        abilitiesLabel[8].ForeColor = Color.Blue;
                        break;
                    case "Knowledge":
                        abilitiesLabel[9].ForeColor = Color.Blue;
                        break;
                    case "Marksmanship":
                        abilitiesLabel[10].ForeColor = Color.Blue;
                        break;
                    case "Persuasion":
                        abilitiesLabel[11].ForeColor = Color.Blue;
                        break;
                    case "Status":
                        abilitiesLabel[12].ForeColor = Color.Blue;
                        break;
                    case "Stealth":
                        abilitiesLabel[13].ForeColor = Color.Blue;
                        break;
                    case "Survival":
                        abilitiesLabel[14].ForeColor = Color.Blue;
                        break;
                    case "Thievery":
                        abilitiesLabel[15].ForeColor = Color.Blue;
                        break;
                    case "Warfare":
                        abilitiesLabel[16].ForeColor = Color.Blue;
                        break;
                    case "Will":
                        abilitiesLabel[17].ForeColor = Color.Blue;
                        break;
                }
            }

            CostUpdate();
            int discipline = Convert.ToInt32(dgTraining.Rows[cbTraining.SelectedIndex].Cells[2].Value) + Convert.ToInt32(dgType.Rows[cbType.SelectedIndex].Cells[3].Value);
            lbDiscipText1.Text = discipline.ToString();
            if (cbType.Text == "Garrison - Pow: 2") { lbDiscipText1.Text += "/" + (discipline + 6); }
            UpdateExperience();

            Armor();
            FightDMG();
            MarksDMG();
        }

        public void CostUpdate()
        {
            int cost = Convert.ToInt32(dgTraining.Rows[cbTraining.SelectedIndex].Cells[1].Value) + Convert.ToInt32(dgType.Rows[cbType.SelectedIndex].Cells[2].Value);
            if(tbDiscount.Text != "") { cost -= Convert.ToInt32(tbDiscount.Text); }
            lbCostNumber1.Text = cost.ToString();

        }

        public void UpdateExperience()
        {
            int experience = 0;
            for (int i = 0; i < abilitiesTextBox.Length; i++)
            {
                if (abilitiesTextBox[i].Text != "") { experience += Convert.ToInt32(abilitiesTextBox[i].Text); }
            }
            experience -= (abilitiesTextBox.Length) * 2;
            experience = experience * 20;
            experience = Convert.ToInt32(dgTraining.Rows[cbTraining.SelectedIndex].Cells[3].Value) - experience;
            if(experience==0) { lbExperience.ForeColor = Color.Black; }
            else if (experience>0) { lbExperience.ForeColor = Color.DarkGreen; }
            else { lbExperience.ForeColor = Color.Red; }
            lbExperience.Text = experience.ToString();
        }
        
        public void Armor()
        {
            int armorStart;
            if (chbArmor1.Checked)
            {
                armorStart = 9;
                lbArmRTG1.ForeColor = lbArmPen1.ForeColor = lbBul1.ForeColor = Color.DarkGoldenrod;
            }
            else
            {
                armorStart = 8;
                lbArmRTG1.ForeColor = lbArmPen1.ForeColor = lbBul1.ForeColor = Color.Black;
            }
            for (int x = 0; x < 3; x++)
            {
                if (dgType.Rows[cbType.SelectedIndex].Cells[armorStart + (x * 2)].Value.ToString() != "")
                {
                    armorNumber[x].Text = dgType.Rows[cbType.SelectedIndex].Cells[armorStart + (x * 2)].Value.ToString();
                }
                else
                {
                    armorNumber[x].Text = "";
                }
            }
            //movement
            int movement = Convert.ToInt32(dgType.Rows[cbType.SelectedIndex].Cells[19].Value);
            if (armorNumber[2].Text != "") { movement -= Convert.ToInt32(armorNumber[2].Text) * 10; }
            lbMov1.Text = movement + " yards";
            UnitDefense();
        }

        public void FightDMG()
        {
            int dmg;
            if (chbFightDMG1.Checked)
            {
                dmg = Convert.ToInt32(dgType.Rows[cbType.SelectedIndex].Cells[15].Value);
                lbFigDMG1.ForeColor = Color.DarkGoldenrod;
            }
            else
            {
                dmg = Convert.ToInt32(dgType.Rows[cbType.SelectedIndex].Cells[14].Value);
                lbFigDMG1.ForeColor = Color.Black;
            }
            if (cbType.Text == dgType.Rows[cbType.SelectedIndex].Cells[1].Value.ToString())
            {
                if (abilitiesTextBox[1].Text != "") { dmg += Convert.ToInt32(abilitiesTextBox[1].Text); }
            }
            else
            {
                if (abilitiesTextBox[2].Text != "") { dmg += Convert.ToInt32(abilitiesTextBox[2].Text); }
            }
            lbFigDMGNum1.Text = dmg.ToString();
        }

        public void MarksDMG()
        {
            if (dgType.Rows[cbType.SelectedIndex].Cells[16].Value.ToString() != "")
            {
                chbMarkDMG1.Enabled = true;
                int dmg;
                if (chbMarkDMG1.Checked)
                {
                    dmg = Convert.ToInt32(dgType.Rows[cbType.SelectedIndex].Cells[17].Value);
                    lbMarDMG1.ForeColor = Color.DarkGoldenrod;
                }
                else
                {
                    dmg = Convert.ToInt32(dgType.Rows[cbType.SelectedIndex].Cells[16].Value);
                    lbMarDMG1.ForeColor = Color.Black;
                }
                if (abilitiesTextBox[0].Text != "") { dmg += Convert.ToInt32(abilitiesTextBox[0].Text); }
                lbMarDMGNum1.Text = dmg + " " + dgType.Rows[cbType.SelectedIndex].Cells[18].Value.ToString();
            }
            else
            {
                chbMarkDMG1.Enabled = false;
                chbMarkDMG1.Checked = false;
                lbMarDMG1.ForeColor = Color.Black;
                lbMarDMGNum1.Text = "";
            }
        }

        public void Health()
        {
            int health = 0;
            if (tbEnd1.Text != "")
            {
                health = Convert.ToInt32(tbEnd1.Text) * 3;
            }
            lbHealth.Text = health.ToString();
        }

        public void UnitDefense()
        {
            //Unit Defense = Agility + Athletics + Awareness - Armor Penalty
            int defense = 0;
            if (abilitiesTextBox[0].Text != "") { defense += Convert.ToInt32(abilitiesTextBox[0].Text); }
            if (abilitiesTextBox[2].Text != "") { defense += Convert.ToInt32(abilitiesTextBox[2].Text); }
            if (abilitiesTextBox[3].Text != "") { defense += Convert.ToInt32(abilitiesTextBox[3].Text); }
            if (lbArmPenNum1.Text != "") { defense += Convert.ToInt32(lbArmPenNum1.Text); }
            lbDef1.Text = defense.ToString();
        }
        ///// METHODS END //////////////////////////////////////////////////////////
        public NewPowerForm(int houseID, string houseName)
        {
            House = new House(houseID, houseName);

            InitializeComponent();

            Text = House.name + " New Power Holdings";

            abilitiesLabel = new Label[] { lbAgi1, lbAni1, lbAth1, lbAwa1, lbCun1, lbEnd1, lbFig1, lbHea1, lbLan1, lbKno1, lbMar1, lbPer1, lbSta1, lbSte1, lbSur1, lbThi1, lbWar1, lbWil1 };
            abilitiesTextBox = new TextBox[] { tbAgi1, tbAni1, tbAth1, tbAwa1, tbCun1, tbEnd1, tbFig1, tbHea1, tbLan1, tbKno1, tbMar1, tbPer1, tbSta1, tbSte1, tbSur1, tbThi1, tbWar1, tbWil1 };
            armorNumber = new Label[] { lbArmRTGNum1, lbArmPenNum1, lbBulNum1 };
        }

        private void NewPowerForm_Load(object sender, EventArgs e)
        {
            //Unit Types cb
            dgType.DataSource = House.HouseQry("Unit Type");
            object[] unitType = new object[dgType.RowCount];
            for (int i = 0; i < dgType.RowCount; i++)
            {
                unitType[i] = dgType.Rows[i].Cells[1].Value.ToString() + " - Pow: " + dgType.Rows[i].Cells[2].Value.ToString();
            }
            cbType.Items.Clear();
            cbType.Items.AddRange(unitType);
            cbType.SelectedIndex = 0;
            //Unit Training cb
            dgTraining.DataSource = House.HouseQry("UnitTraining");
            object[] unitTraining = new object[dgTraining.RowCount];
            for (int i = 0; i < dgTraining.RowCount; i++)
            {
                unitTraining[i] = dgTraining.Rows[i].Cells[0].Value.ToString() + " - Pow: " + dgTraining.Rows[i].Cells[1].Value.ToString();
            }
            cbTraining.Items.Clear();
            cbTraining.Items.AddRange(unitTraining);
            cbTraining.SelectedIndex = 0;
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTraining.SelectedIndex != -1 && cbType.SelectedIndex != -1)
            {
                UnitDetailsUpdate();
            }
        }

        private void cbTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTraining.SelectedIndex != -1 && cbType.SelectedIndex != -1)
            {
                UnitDetailsUpdate();
            }
        }

        private void chbArmor1_CheckedChanged(object sender, EventArgs e)
        {
            Armor();
        }

        private void chbFightDMG1_CheckedChanged(object sender, EventArgs e)
        {
            FightDMG();
        }

        private void chbMarkDMG1_CheckedChanged(object sender, EventArgs e)
        {
            MarksDMG();
        }

        private void tbDiscount_TextChanged(object sender, EventArgs e)
        {
            CostUpdate();
        }

        private void tbAgi1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
            UnitDefense();
            MarksDMG();
        }

        private void tbAni1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
            FightDMG();
        }

        private void tbAth1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
            UnitDefense();
            FightDMG();
        }

        private void tbAwa1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
            UnitDefense();
        }

        private void tbCun1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void tbEnd1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
            Health();
        }

        private void tbFig1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void tbHea1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void tbLan1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void tbKno1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void tbMar1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void tbPer1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void tbSta1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void tbSte1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void tbSur1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void tbThi1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void tbWar1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void tbWil1_TextChanged(object sender, EventArgs e)
        {
            UpdateExperience();
        }

        private void btDelete3_Click(object sender, EventArgs e)
        {
            Validation.SetNullTo(tbDiscount,"0");
            for(int i = 0; i < abilitiesTextBox.Length;i++) { Validation.SetNullTo(abilitiesTextBox[i], "2"); }
            House.InsertPower(dgType.Rows[cbType.SelectedIndex].Cells[0].Value.ToString(),tbName1.Text,tbDiscount.Text, dgTraining.Rows[cbTraining.SelectedIndex].Cells[0].Value.ToString(), rtbNotes1.Text,chbArmor1.Checked.ToString(),chbFightDMG1.Checked.ToString(),chbMarkDMG1.Checked.ToString(),tbAgi1.Text,tbAni1.Text,tbAth1.Text,tbAwa1.Text,tbCun1.Text,tbEnd1.Text,tbFig1.Text,tbHea1.Text,tbLan1.Text,tbKno1.Text,tbMar1.Text,tbPer1.Text,tbSta1.Text,tbSte1.Text,tbSur1.Text,tbThi1.Text,tbWar1.Text,tbWil1.Text);
            Close();
        }
        
        //Validation
        private void OnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyDigit(e);
        }


        ///// EVENTS END ////////////////////////////////////////////////////////////

    }
}
