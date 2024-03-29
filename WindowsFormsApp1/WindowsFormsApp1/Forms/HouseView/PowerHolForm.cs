﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class PowerHolForm : Form
    {
        ///// VARIABLES START ////////////////////////////////////////////////////// 
        int startingNum;
        int currentPage;
        int pageNum;
        int unitPageNum;

        bool addFigDAM;
        bool addMarkDAM;
        //Classes
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();
        Validation Validation = new Validation();
        House House;
        //Forms
        NewPowerForm NewPowerForm;
        //arrays
        TextBox[] unitName;
        Label[] unitType;
        Label[] unitCost;
        Label[] unitDiscipline;
        ComboBox[] unitTraining;
        NumericUpDown[] unitHealth;
        Label[] unitMaxHealthText;
        NumericUpDown[] unitDisorganized;
        RichTextBox[] unitNotes;

        Label[,] unitAbilitiesLabel;
        TextBox[,] unitAbilitiesTextBox;

        Label[] unitDefense;
        Label[] unitMovement;
        CheckBox[,] unitUpgrades;
        Label[,] unitUpgradeLabel;
        Label[,] unitArmorNum;
        Label[] unitFightDMG;
        Label[] unitMarksDMG;

        Button[] unitDelete;
        ///// METHODS START ////////////////////////////////////////////////////////
        public void UpdateUnits(int pageChange)
        {
            DevLog.LogItem("Updating units");
            currentPage += pageChange;
            startingNum = (currentPage - 1) * 4;
            lbPageNumber.Text = "Page " + currentPage + " of " + pageNum;
            btPrevious.Enabled = currentPage > 1 ? true : false;
            btNext.Enabled = currentPage < pageNum ? true : false;
            unitPageNum = -1;
            

            int endNum;
            if(dgCal1.RowCount > startingNum+4) { endNum = 4; } else { endNum = dgCal1.RowCount - startingNum; }
            for(int i = 0; i< 4;i++)
            {
                DevLog.LogItem("Updating unit: " + i);
                //clear
                unitName[i].Text = unitNotes[i].Text = unitCost[i].Text = unitDiscipline[i].Text = unitType[i].Text = unitDefense[i].Text = unitMovement[i].Text = unitFightDMG[i].Text = unitMarksDMG[i].Text ="";
                for(int j = 0; j<unitArmorNum.GetLength(1);j++) { unitArmorNum[i, j].Text = ""; }
                unitHealth[i].Value = unitDisorganized[i].Value = 0;
                unitTraining[i].SelectedIndex = -1;
                for (int j = 0; j < unitAbilitiesTextBox.GetLength(1); j++) { unitAbilitiesTextBox[i, j].Text = ""; }
                for (int j = 0; j < unitAbilitiesLabel.GetLength(1); j++) { unitAbilitiesLabel[i, j].ForeColor = Color.Black; }
                for (int j = 0; j < unitUpgradeLabel.GetLength(1); j++) { unitUpgradeLabel[i, j].ForeColor = Color.Black; }
                for (int j = 0; j < unitUpgrades.GetLength(1); j++) { unitUpgrades[i, j].Checked = false; }

                if (i < endNum)
                {
                    unitPageNum++;
                    unitName[i].Enabled = unitTraining[i].Enabled = unitHealth[i].Enabled = unitDisorganized[i].Enabled = unitNotes[i].Enabled = unitDelete[i].Enabled = true;
                    for (int j = 0; j < unitAbilitiesTextBox.GetLength(1); j++) { unitAbilitiesTextBox[i, j].Enabled = true; }
                    for (int j = 0; j < unitUpgrades.GetLength(1); j++) { unitUpgrades[i, j].Enabled = true; }
                    //basic details
                    unitName[i].Text = dgCal1.Rows[i + startingNum].Cells[3].Value.ToString();
                    unitType[i].Text = dgCal1.Rows[i + startingNum].Cells[32].Value.ToString();
                    unitTraining[i].Text = dgCal1.Rows[i + startingNum].Cells[4].Value.ToString();
                    unitDisorganized[i].Text = dgCal1.Rows[i + startingNum].Cells[28].Value.ToString();
                    unitNotes[i].Text = dgCal1.Rows[i + startingNum].Cells[29].Value.ToString();
                    
                    //abilities

                    for (int j = 0; j < 3; j++)
                    {
                        switch (dgCal1.Rows[i + startingNum].Cells[35 + j].Value.ToString())
                        {
                            case "Agility":
                                unitAbilitiesLabel[i, 0].ForeColor = Color.Blue;
                                break;
                            case "Animal Handling":
                                unitAbilitiesLabel[i, 1].ForeColor = Color.Blue;
                                break;
                            case "Athletics":
                                unitAbilitiesLabel[i, 2].ForeColor = Color.Blue;
                                break;
                            case "Awareness":
                                unitAbilitiesLabel[i, 3].ForeColor = Color.Blue;
                                break;
                            case "Cunning":
                                unitAbilitiesLabel[i, 4].ForeColor = Color.Blue;
                                break;
                            case "Endurance":
                                unitAbilitiesLabel[i, 5].ForeColor = Color.Blue;
                                break;
                            case "Fighting":
                                unitAbilitiesLabel[i, 6].ForeColor = Color.Blue;
                                break;
                            case "Healing":
                                unitAbilitiesLabel[i, 7].ForeColor = Color.Blue;
                                break;
                            case "Language":
                                unitAbilitiesLabel[i, 8].ForeColor = Color.Blue;
                                break;
                            case "Knowledge":
                                unitAbilitiesLabel[i, 9].ForeColor = Color.Blue;
                                break;
                            case "Marksmanship":
                                unitAbilitiesLabel[i, 10].ForeColor = Color.Blue;
                                break;
                            case "Persuasion":
                                unitAbilitiesLabel[i, 11].ForeColor = Color.Blue;
                                break;
                            case "Status":
                                unitAbilitiesLabel[i, 12].ForeColor = Color.Blue;
                                break;
                            case "Stealth":
                                unitAbilitiesLabel[i, 13].ForeColor = Color.Blue;
                                break;
                            case "Survival":
                                unitAbilitiesLabel[i, 14].ForeColor = Color.Blue;
                                break;
                            case "Thievery":
                                unitAbilitiesLabel[i, 15].ForeColor = Color.Blue;
                                break;
                            case "Warfare":
                                unitAbilitiesLabel[i, 16].ForeColor = Color.Blue;
                                break;
                            case "Will":
                                unitAbilitiesLabel[i, 17].ForeColor = Color.Blue;
                                break;
                        }
                    }

                    for (int j = 0; j < unitAbilitiesTextBox.GetLength(1); j++)
                    {
                        unitAbilitiesTextBox[i, j].Text = dgCal1.Rows[i + startingNum].Cells[6 + j].Value.ToString();
                    }

                    //armor + weapons
                    if (unitUpgrades[i, 0].Checked.ToString() == dgCal1.Rows[i + startingNum].Cells[24].Value.ToString())
                    {
                        UnitArmor(i);
                    }
                    else
                    {
                        unitUpgrades[i, 0].Checked = Convert.ToBoolean(dgCal1.Rows[i + startingNum].Cells[24].Value);
                    }

                    if (unitUpgrades[i, 1].Checked.ToString() == dgCal1.Rows[i + startingNum].Cells[25].Value.ToString())
                    {
                        UnitFightDMG(i);
                    }
                    else
                    {
                        unitUpgrades[i, 1].Checked = Convert.ToBoolean(dgCal1.Rows[i + startingNum].Cells[25].Value);
                    }

                    if (unitUpgrades[i, 2].Checked.ToString() == dgCal1.Rows[i + startingNum].Cells[26].Value.ToString())
                    {
                        UnitMarksDMG(i);
                    }
                    else
                    {
                        unitUpgrades[i, 2].Checked = Convert.ToBoolean(dgCal1.Rows[i + startingNum].Cells[26].Value);
                    }
                    //calculated stats
                    unitHealth[i].Text = Convert.ToString(unitHealth[i].Maximum - Convert.ToInt32(dgCal1.Rows[i + startingNum].Cells[27].Value));
                }
                else
                {
                    unitName[i].Enabled = unitTraining[i].Enabled = unitHealth[i].Enabled = unitDisorganized[i].Enabled = unitNotes[i].Enabled = unitDelete[i].Enabled = false;
                    for(int j = 0; j<unitAbilitiesTextBox.GetLength(1); j++) { unitAbilitiesTextBox[i, j].Enabled = false; }
                    for (int j = 0; j < unitUpgrades.GetLength(1); j++) { unitUpgrades[i, j].Enabled = false; }
                }
            }
        }

        public void UnitTraning (int unit)
        {
            if (unit <= unitPageNum)
            {
                int cost = 0;
                int discipline = 0;
                switch (unitTraining[unit].Text)
                {
                    case "Green":
                        cost = 1;
                        discipline = 9;
                        break;
                    case "Trained":
                        cost = 3;
                        discipline = 6;
                        break;
                    case "Veteran":
                        cost = 5;
                        discipline = 3;
                        break;
                    case "Elite":
                        cost = 7;
                        discipline = 0;
                        break;
                    default:
                        DevLog.LogItem("Traning cost error: " + unitDiscipline[unit].Text);
                        break;
                }
                cost += Convert.ToInt32(dgCal1.Rows[unit + startingNum].Cells[33].Value) - Convert.ToInt32(dgCal1.Rows[unit + startingNum].Cells[5].Value);
                discipline += Convert.ToInt32(dgCal1.Rows[unit + startingNum].Cells[34].Value);
                unitCost[unit].Text = cost.ToString();
                unitDiscipline[unit].Text = discipline.ToString();
                if (unitType[unit].Text == "Garrison") { unitDiscipline[unit].Text += "/" + (discipline + 6); }
            }
        }

        public void UnitHealth(int unit)
        {
            if (unit <= unitPageNum)
            {
                if (unitAbilitiesTextBox[unit, 5].Text != "")
                {
                    unitHealth[unit].Maximum = Convert.ToInt32(unitAbilitiesTextBox[unit, 5].Text) * 3;
                    unitHealth[unit].Value = unitHealth[unit].Maximum;
                }
                else
                {
                    unitHealth[unit].Maximum = 0;
                }
                unitMaxHealthText[unit].Text = "/" + unitHealth[unit].Maximum.ToString();
            }
        }

        public void UnitArmor(int unit)
        {
            if (unit <= unitPageNum)
            {
                int armorStart;
                if (unitUpgrades[unit, 0].Checked)
                {
                    armorStart = 40;
                    for(int i = 0; i < 3 ; i++) { unitUpgradeLabel[unit, i].ForeColor = Color.DarkGoldenrod; }
                }
                else
                {
                    armorStart = 39;
                    for (int i = 0; i < 3; i++) { unitUpgradeLabel[unit, i].ForeColor = Color.Black; }
                }
                for (int x = 0; x < 3; x++)
                {
                    if (dgCal1.Rows[unit + startingNum].Cells[armorStart + (x * 2)].Value.ToString() != "")
                    {
                        unitArmorNum[unit, x].Text = dgCal1.Rows[unit + startingNum].Cells[armorStart + (x * 2)].Value.ToString();
                    }
                    else
                    {
                        unitArmorNum[unit, x].Text = "";
                    }
                }
                //movement
                int movement = Convert.ToInt32(dgCal1.Rows[unit + startingNum].Cells[50].Value);
                if (unitArmorNum[unit, 2].Text != "") { movement -= Convert.ToInt32(unitArmorNum[unit, 2].Text) * 10; }
                unitMovement[unit].Text = movement + " yards";
                UnitDefense(unit);
            }
        }
        
        public void UnitFightDMG (int unit)
        {
            if (unit <= unitPageNum)
            {
                int fightingStart;
                if (unitUpgrades[unit, 1].Checked)
                {
                    fightingStart = 46;
                    unitUpgradeLabel[unit, 3].ForeColor = Color.DarkGoldenrod;
                }
                else
                {
                    fightingStart = 45;
                    unitUpgradeLabel[unit, 3].ForeColor = Color.Black;
                }
                int dmg = Convert.ToInt32(dgCal1.Rows[unit + startingNum].Cells[fightingStart].Value);
                if(unitType[unit].Text == "Cavalry")
                {
                    if (unitAbilitiesTextBox[unit, 1].Text != "") { dmg += Convert.ToInt32(unitAbilitiesTextBox[unit, 1].Text); }
                }
                else
                {
                    if (unitAbilitiesTextBox[unit, 2].Text != "") { dmg += Convert.ToInt32(unitAbilitiesTextBox[unit, 2].Text); }
                }
                
                if(addFigDAM) { dmg++; }
                unitFightDMG[unit].Text = dmg.ToString();
            }
        }

        public void UnitMarksDMG(int unit)
        {

            if (unit <= unitPageNum && dgCal1.Rows[unit + startingNum].Cells[47].Value.ToString() != "")
            {
                unitUpgrades[unit, 2].Enabled = true;
                int marksStart;
                if (unitUpgrades[unit, 2].Checked)
                {
                    marksStart = 48;
                    unitUpgradeLabel[unit,4].ForeColor = Color.DarkGoldenrod;
                }
                else
                {
                    marksStart = 47;
                    unitUpgradeLabel[unit, 4].ForeColor = Color.Black;
                }
                int dmg = Convert.ToInt32(dgCal1.Rows[unit + startingNum].Cells[marksStart].Value);
                if (unitAbilitiesTextBox[unit, 0].Text != "") { dmg += Convert.ToInt32(unitAbilitiesTextBox[unit, 0].Text); }
                if(addMarkDAM) { dmg++; }
                unitMarksDMG[unit].Text = dmg + " " + dgCal1.Rows[unit + startingNum].Cells[49].Value.ToString();
            }
            else
            {
                unitUpgrades[unit, 2].Enabled = false;
                unitMarksDMG[unit].Text = "";
            }
        }

        public void UnitDefense (int unit)
        {
            if (unit <= unitPageNum)
            {
                //Unit Defense = Agility + Athletics + Awareness - Armor Penalty
                int defense = 0;
                if (unitAbilitiesTextBox[unit, 0].Text != "") { defense += Convert.ToInt32(unitAbilitiesTextBox[unit, 0].Text); }
                if (unitAbilitiesTextBox[unit, 2].Text != "") { defense += Convert.ToInt32(unitAbilitiesTextBox[unit, 2].Text); }
                if (unitAbilitiesTextBox[unit, 3].Text != "") { defense += Convert.ToInt32(unitAbilitiesTextBox[unit, 3].Text); }
                if (unitArmorNum[unit, 1].Text != "") { defense += Convert.ToInt32(unitArmorNum[unit, 1].Text); }
                unitDefense[unit].Text = defense.ToString();
            }
        }

        public bool CheckIfUnitChange(int unit)
        {
            bool change = false;
            if (unitName[unit].Text != dgCal1.Rows[unit + startingNum].Cells[3].Value.ToString() || unitTraining[unit].Text != dgCal1.Rows[unit + startingNum].Cells[4].Value.ToString() || unitDisorganized[unit].Text != dgCal1.Rows[unit + startingNum].Cells[28].Value.ToString() || unitNotes[unit].Text != dgCal1.Rows[unit + startingNum].Cells[29].Value.ToString() || Convert.ToString(unitHealth[unit].Maximum - unitHealth[unit].Value) != dgCal1.Rows[unit + startingNum].Cells[27].Value.ToString() || unitUpgrades[unit, 0].Checked.ToString() != dgCal1.Rows[unit + startingNum].Cells[24].Value.ToString() || unitUpgrades[unit, 1].Checked.ToString() != dgCal1.Rows[unit + startingNum].Cells[25].Value.ToString() || unitUpgrades[unit, 2].Checked.ToString() != dgCal1.Rows[unit + startingNum].Cells[26].Value.ToString())
            {
                change = true;
            }
            for(int i =0; i < unitAbilitiesTextBox.GetLength(1) && !change; i++)
            {
                if(unitAbilitiesTextBox[unit,i].Text != dgCal1.Rows[unit + startingNum].Cells[6 + i].Value.ToString()) { change = true; }
            }
            for (int i = 0; i < unitUpgrades.GetLength(1) && !change; i++)
            {
                if (unitUpgrades[unit, i].Checked.ToString() != dgCal1.Rows[unit + startingNum].Cells[24+i].Value.ToString()) { change = true; }
            }
            DevLog.LogItem("Unit Change: " + change);
            return change;
        }

        public void CheckAllUnitChange ()
        {
            DevLog.LogItem("Checking All units");
            for(int i = 0; i<=unitPageNum; i++)
            {
                DevLog.LogItem("Checking unit: " + i);
                if(CheckIfUnitChange(i))
                {
                    House.UpdatePowerHolding(dgCal1.Rows[i + startingNum].Cells[0].Value.ToString(), unitName[i].Text, unitTraining[i].Text, Convert.ToString(unitHealth[i].Maximum - Convert.ToInt32(unitHealth[i].Value.ToString())),unitDisorganized[i].Value.ToString(),unitNotes[i].Text,unitUpgrades[i,0].Checked.ToString(), unitUpgrades[i, 1].Checked.ToString(), unitUpgrades[i, 2].Checked.ToString(),
                        unitAbilitiesTextBox[i,0].Text, unitAbilitiesTextBox[i, 1].Text, unitAbilitiesTextBox[i, 2].Text, unitAbilitiesTextBox[i, 3].Text, unitAbilitiesTextBox[i, 4].Text, unitAbilitiesTextBox[i, 5].Text, unitAbilitiesTextBox[i, 6].Text, unitAbilitiesTextBox[i, 7].Text, unitAbilitiesTextBox[i, 8].Text, unitAbilitiesTextBox[i, 9].Text, unitAbilitiesTextBox[i, 10].Text, unitAbilitiesTextBox[i, 11].Text, unitAbilitiesTextBox[i, 12].Text, unitAbilitiesTextBox[i, 13].Text, unitAbilitiesTextBox[i, 14].Text, unitAbilitiesTextBox[i, 15].Text, unitAbilitiesTextBox[i, 16].Text, unitAbilitiesTextBox[i, 17].Text);
                    dgCal1.DataSource = House.HouseQry("PowerHolding");
                }
            }
        }

        public void DeleteUnit (int unit, object sender, EventArgs e)
        {
            House.DeletePower(dgCal1.Rows[startingNum + unit].Cells[0].Value.ToString());
            PowerHolForm_Load(sender, e);
        }
        ///// METHODS END //////////////////////////////////////////////////////////
        public PowerHolForm(int houseID, string houseName, bool hasWeaponsmith, bool hasFletcher)
        {
            House = new House(houseID,houseName);
            addFigDAM = hasWeaponsmith;
            addMarkDAM = hasFletcher;

            InitializeComponent();
            Text = House.name + " Power Holdings";
            //array
            unitName = new TextBox[] { tbName1, tbName2, tbName3, tbName4 };
            unitType =  new Label[] { lbTypeText1, lbTypeText2, lbTypeText3, lbTypeText4 };
            unitCost = new Label[] { lbCostNumber1, lbCostNumber2, lbCostNumber3, lbCostNumber4 };
            unitDiscipline = new Label[] { lbDiscipText1, lbDiscipText2, lbDiscipText3, lbDiscipText4 };
            unitTraining = new ComboBox[] { cbTraining1, cbTraining2, cbTraining3, cbTraining4 };
            unitHealth = new NumericUpDown[] { nudHea1, nudHea2, nudHea3, nudHea4 };
            unitMaxHealthText = new Label[] { lbMaxHealth1, lbMaxHealth2, lbMaxHealth3, lbMaxHealth4 };
            unitDisorganized = new NumericUpDown[] { nudDis1, nudDis2, nudDis3, nudDis4 };
            unitNotes = new RichTextBox[] { rtbNotes1, rtbNotes2, rtbNotes3, rtbNotes4 };

            unitAbilitiesLabel = new Label[,] { {lbAgi1, lbAni1, lbAth1,lbAwa1,lbCun1,lbEnd1,lbFig1,lbHea1,lbLan1,lbKno1,lbMar1,lbPer1,lbSta1,lbSte1,lbSur1,lbThi1,lbWar1,lbWil1 },{ lbAgi2, lbAni2, lbAth2, lbAwa2, lbCun2, lbEnd2, lbFig2, lbHea2, lbLan2, lbKno2, lbMar2, lbPer2, lbSta2, lbSte2, lbSur2, lbThi2, lbWar2, lbWil2 },{ lbAgi3, lbAni3, lbAth3, lbAwa3, lbCun3, lbEnd3, lbFig3, lbHea3, lbLan3, lbKno3, lbMar3, lbPer3, lbSta3, lbSte3, lbSur3, lbThi3, lbWar3, lbWil3 },{ lbAgi4, lbAni4, lbAth4, lbAwa4, lbCun4, lbEnd4, lbFig4, lbHea4, lbLan4, lbKno4, lbMar4, lbPer4, lbSta4, lbSte4, lbSur4, lbThi4, lbWar4, lbWil4 } };
            unitAbilitiesTextBox = new TextBox[,] { { tbAgi1, tbAni1, tbAth1, tbAwa1, tbCun1, tbEnd1, tbFig1, tbHea1, tbLan1, tbKno1, tbMar1, tbPer1, tbSta1, tbSte1, tbSur1, tbThi1, tbWar1, tbWil1 }, { tbAgi2, tbAni2, tbAth2, tbAwa2, tbCun2, tbEnd2, tbFig2, tbHea2, tbLan2, tbKno2, tbMar2, tbPer2, tbSta2, tbSte2, tbSur2, tbThi2, tbWar2, tbWil2 }, { tbAgi3, tbAni3, tbAth3, tbAwa3, tbCun3, tbEnd3, tbFig3, tbHea3, tbLan3, tbKno3, tbMar3, tbPer3, tbSta3, tbSte3, tbSur3, tbThi3, tbWar3, tbWil3 }, { tbAgi4, tbAni4, tbAth4, tbAwa4, tbCun4, tbEnd4, tbFig4, tbHea4, tbLan4, tbKno4, tbMar4, tbPer4, tbSta4, tbSte4, tbSur4, tbThi4, tbWar4, tbWil4 } }; ;

            unitDefense = new Label[] { lbDef1, lbDef2, lbDef3, lbDef4 };
            unitMovement = new Label[] { lbMov1, lbMov2, lbMov3, lbMov4 };
            unitUpgrades = new CheckBox[,] { { chbArmor1,chbFightDMG1,chbMarkDMG1},{ chbArmor2, chbFightDMG2, chbMarkDMG2 },{ chbArmor3, chbFightDMG3, chbMarkDMG3 },{ chbArmor4, chbFightDMG4, chbMarkDMG4 } };
            unitUpgradeLabel = new Label[,] { { lbArmRTG1, lbArmPen1, lbBul1, lbFigDMG1, lbMarDMG1 }, { lbArmRTG2, lbArmPen2, lbBul2, lbFigDMG2, lbMarDMG2 }, { lbArmRTG3, lbArmPen3, lbBul3, lbFigDMG3, lbMarDMG3 }, { lbArmRTG4, lbArmPen4, lbBul4, lbFigDMG4, lbMarDMG4 } };
            unitArmorNum = new Label[,] { { lbArmRTGNum1, lbArmPenNum1, lbBulNum1 }, { lbArmRTGNum2, lbArmPenNum2, lbBulNum2 }, { lbArmRTGNum3, lbArmPenNum3, lbBulNum3 }, { lbArmRTGNum4, lbArmPenNum4, lbBulNum4 } };
            unitFightDMG = new Label[] { lbFigDMGNum1, lbFigDMGNum2, lbFigDMGNum3, lbFigDMGNum4 };
            unitMarksDMG = new Label[] { lbMarDMGNum1, lbMarDMGNum2, lbMarDMGNum3, lbMarDMGNum4 };

            unitDelete = new Button[] { btDelete1, btDelete2, btDelete3, btDelete4 };
        }

        private void PowerHolForm_Load(object sender, EventArgs e)
        {
            startingNum = 0;
            currentPage = 1;
            dgCal1.DataSource = House.HouseQry("PowerHolding");

            pageNum = dgCal1.RowCount / 4;
            if (dgCal1.RowCount % 4 > 0) { pageNum++; }

            UpdateUnits(0);
            Visible = true;
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void ChbArmor1_CheckedChanged(object sender, EventArgs e)
        {
            UnitArmor(0);
        }

        private void ChbArmor2_CheckedChanged(object sender, EventArgs e)
        {
            UnitArmor(1);
        }

        private void ChbArmor3_CheckedChanged(object sender, EventArgs e)
        {
            UnitArmor(2);
        }

        private void ChbArmor4_CheckedChanged(object sender, EventArgs e)
        {
            UnitArmor(3);
        }

        private void TbEnd1_TextChanged(object sender, EventArgs e)
        {
            UnitHealth(0);
        }

        private void TbEnd2_TextChanged(object sender, EventArgs e)
        {
            UnitHealth(1);
        }

        private void TbEnd3_TextChanged(object sender, EventArgs e)
        {
            UnitHealth(2);
        }

        private void TbEnd4_TextChanged(object sender, EventArgs e)
        {
            UnitHealth(3);
        }

        private void TbAgi1_TextChanged(object sender, EventArgs e)
        {
            UnitDefense(0);
            UnitMarksDMG(0);
        }

        private void TbAth1_TextChanged(object sender, EventArgs e)
        {
            UnitDefense(0);
            UnitFightDMG(0);
        }

        private void TbAwa1_TextChanged(object sender, EventArgs e)
        {
            UnitDefense(0);
        }

        private void TbAgi2_TextChanged(object sender, EventArgs e)
        {
            UnitDefense(1);
            UnitMarksDMG(1);
        }

        private void TbAth2_TextChanged(object sender, EventArgs e)
        {
            UnitDefense(1);
            UnitFightDMG(1);
        }

        private void TbAwa2_TextChanged(object sender, EventArgs e)
        {
            UnitDefense(1);
        }

        private void TbAgi3_TextChanged(object sender, EventArgs e)
        {
            UnitDefense(2);
            UnitMarksDMG(2);
        }

        private void TbAth3_TextChanged(object sender, EventArgs e)
        {
            UnitDefense(2);
            UnitFightDMG(2);
        }

        private void TbAwa3_TextChanged(object sender, EventArgs e)
        {
            UnitDefense(2);
        }

        private void TbAgi4_TextChanged(object sender, EventArgs e)
        {
            UnitDefense(3);
            UnitMarksDMG(3);
        }

        private void TbAth4_TextChanged(object sender, EventArgs e)
        {
            UnitDefense(3);
            UnitFightDMG(3);
        }

        private void TbAwa4_TextChanged(object sender, EventArgs e)
        {
            UnitDefense(3);
        }

        private void ChbFightDMG1_CheckedChanged(object sender, EventArgs e)
        {
            UnitFightDMG(0);
        }

        private void ChbFightDMG2_CheckedChanged(object sender, EventArgs e)
        {
            UnitFightDMG(1);
        }

        private void ChbFightDMG3_CheckedChanged(object sender, EventArgs e)
        {
            UnitFightDMG(2);
        }

        private void ChbFightDMG4_CheckedChanged(object sender, EventArgs e)
        {
            UnitFightDMG(3);
        }

        private void ChbMarkDMG1_CheckedChanged(object sender, EventArgs e)
        {
            UnitMarksDMG(0);
        }

        private void ChbMarkDMG2_CheckedChanged(object sender, EventArgs e)
        {
            UnitMarksDMG(1);
        }

        private void ChbMarkDMG3_CheckedChanged(object sender, EventArgs e)
        {
            UnitMarksDMG(2);
        }

        private void ChbMarkDMG4_CheckedChanged(object sender, EventArgs e)
        {
            UnitMarksDMG(3);
        }
        //Training cb changing
        private void CbTraining1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitTraning(0);
        }

        private void CbTraining2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitTraning(1);
        }

        private void CbTraining3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitTraning(2);
        }

        private void CbTraining4_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitTraning(3);
        }
        //Page buttons
        private void BtNext_Click(object sender, EventArgs e)
        {
            CheckAllUnitChange();
            UpdateUnits(1);
        }

        private void BtPrevious_Click(object sender, EventArgs e)
        {
            CheckAllUnitChange();
            UpdateUnits(-1);
        }
        
        //Delete
        private void BtDelete1_Click(object sender, EventArgs e)
        {
            DeleteUnit(0, sender, e);
        }

        private void BtDelete2_Click(object sender, EventArgs e)
        {
            DeleteUnit(1, sender, e);
        }

        private void BtDelete3_Click(object sender, EventArgs e)
        {
            DeleteUnit(2, sender, e);
        }

        private void BtDelete4_Click(object sender, EventArgs e)
        {
            DeleteUnit(3, sender, e);
        }
        //tool strip buttons
        private void TsbNewUnit_Click(object sender, EventArgs e)
        {
            CheckAllUnitChange();
            NewPowerForm = new NewPowerForm(House.ID,House.name);
            NewPowerForm.FormClosing += new FormClosingEventHandler(PowerHolForm_Load);
            Visible = false;
            NewPowerForm.ShowDialog();
        }
        //Closing
        private void PowerHolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckAllUnitChange();
            if (NewPowerForm != null) { NewPowerForm.Close(); }
        }
        //Validation
        private void OnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyDigit(e);
        }


        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
