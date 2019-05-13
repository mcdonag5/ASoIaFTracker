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

namespace WindowsFormsApp1
{
    public partial class PowerHolForm : Form
    {
        ///// VARIABLES START ////////////////////////////////////////////////////// 
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();
        House House;
        //arrays
        TextBox[] unitName;
        Label[] unitType;
        Label[] unitCost;
        Label[] unitDiscipline;
        ComboBox[] unitTraining;
        NumericUpDown[] unitHealth;
        int[] unitMaxHealth = new int[4];
        NumericUpDown[] unitDisorganized;
        RichTextBox[] unitNotes;

        Label[,] unitAbilitiesLabel;
        TextBox[,] unitAbilitiesTextBox;

        Label[] unitDefense;
        Label[,] unitArmorNum;

        ///// METHODS START ////////////////////////////////////////////////////////
        public void UpdateUnits(int startingNum)
        {
            int endNum;
            if(dgCal1.RowCount > startingNum+4) { endNum = 3; } else { endNum = dgCal1.RowCount - startingNum; }
            for(int i = 0; i< endNum;i++)
            {
                //basic details
                unitName[i].Text = dgCal1.Rows[i+startingNum].Cells[3].Value.ToString();
                unitType[i].Text = dgCal1.Rows[i + startingNum].Cells[32].Value.ToString();
                unitTraining[i].Text = dgCal1.Rows[i + startingNum].Cells[4].Value.ToString();
                unitDisorganized[i].Text = dgCal1.Rows[i + startingNum].Cells[28].Value.ToString();
                unitNotes[i].Text = dgCal1.Rows[i + startingNum].Cells[29].Value.ToString();

                //cost + discipline
                int cost = 0;
                int discipline = 0;
                switch (dgCal1.Rows[i + startingNum].Cells[4].Value.ToString())
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
                        DevLog.LogItem("Traning cost error: " + unitDiscipline[i].Text);
                        break;
                }
                cost += Convert.ToInt32(dgCal1.Rows[i + startingNum].Cells[33].Value) - Convert.ToInt32(dgCal1.Rows[i + startingNum].Cells[5].Value);
                discipline += Convert.ToInt32(dgCal1.Rows[i + startingNum].Cells[34].Value);
                unitCost[i].Text = cost.ToString();
                unitDiscipline[i].Text = discipline.ToString();
                //abilities

                for (int x = 0; x < 18; x++)
                {
                    unitAbilitiesTextBox[i, x].Text = dgCal1.Rows[i + startingNum].Cells[6 + x].Value.ToString();
                }

                //armor + weapons
                DevLog.LogItem(dgCal1.Rows[i + startingNum].Cells[24].Value.ToString());
                int armorStart;
                if(dgCal1.Rows[i + startingNum].Cells[24].Value.ToString() == "True")
                {//Armor
                    chbArmor1.Checked = true;
                    armorStart = 39;
                } else {
                    chbArmor1.Checked = false;
                    armorStart = 40;
                }
                for(int x = 0;x<3;x++)
                {
                    unitArmorNum[i, x].Text = dgCal1.Rows[i + startingNum].Cells[armorStart+(x*2)].Value.ToString();
                }
                //calculated stats
                unitMaxHealth[i] = Convert.ToInt32(unitAbilitiesTextBox[i, 5].Text)*3;
                unitHealth[i].Text = Convert.ToString(unitMaxHealth[i]- Convert.ToInt32(dgCal1.Rows[i + startingNum].Cells[27].Value));
            }
        }
        
        ///// METHODS END //////////////////////////////////////////////////////////
        public PowerHolForm(int ID)
        {
            House = new House(ID);

            InitializeComponent();
            //array
            unitName = new TextBox[] { tbName1, tbName2, tbName3, tbName4 };
            unitType =  new Label[] { lbTypeText1, lbTypeText2, lbTypeText3, lbTypeText4 };
            unitCost = new Label[] { lbCostNumber1, lbCostNumber2, lbCostNumber3, lbCostNumber4 };
            unitDiscipline = new Label[] { lbDiscipText1, lbDiscipText2, lbDiscipText3, lbDiscipText4 };
            unitTraining = new ComboBox[] { cbTraining1, cbTraining2, cbTraining3, cbTraining4 };
            unitHealth = new NumericUpDown[] { nudHea1, nudHea2, nudHea3, nudHea4 };
            unitDisorganized = new NumericUpDown[] { nudDis1, nudDis2, nudDis3, nudDis4 };
            unitNotes = new RichTextBox[] { rtbNotes1, rtbNotes2, rtbNotes3, rtbNotes4 };

            unitAbilitiesLabel = new Label[,] { {lbAgi1, lbAni1, lbAth1,lbAwa1,lbCun1,lbEnd1,lbFig1,lbHea1,lbLan1,lbKno1,lbMar1,lbPer1,lbSta1,lbSte1,lbSur1,lbThi1,lbWar1,lbWil1 },{ lbAgi2, lbAni2, lbAth2, lbAwa2, lbCun2, lbEnd2, lbFig2, lbHea2, lbLan2, lbKno2, lbMar2, lbPer2, lbSta2, lbSte2, lbSur2, lbThi2, lbWar2, lbWil2 },{ lbAgi3, lbAni3, lbAth3, lbAwa3, lbCun3, lbEnd3, lbFig3, lbHea3, lbLan3, lbKno3, lbMar3, lbPer3, lbSta3, lbSte3, lbSur3, lbThi3, lbWar3, lbWil3 },{ lbAgi4, lbAni4, lbAth4, lbAwa4, lbCun4, lbEnd4, lbFig4, lbHea4, lbLan4, lbKno4, lbMar4, lbPer4, lbSta4, lbSte4, lbSur4, lbThi4, lbWar4, lbWil4 } };
            unitAbilitiesTextBox = new TextBox[,] { { tbAgi1, tbAni1, tbAth1, tbAwa1, tbCun1, tbEnd1, tbFig1, tbHea1, tbLan1, tbKno1, tbMar1, tbPer1, tbSta1, tbSte1, tbSur1, tbThi1, tbWar1, tbWil1 }, { tbAgi2, tbAni2, tbAth2, tbAwa2, tbCun2, tbEnd2, tbFig2, tbHea2, tbLan2, tbKno2, tbMar2, tbPer2, tbSta2, tbSte2, tbSur2, tbThi2, tbWar2, tbWil2 }, { tbAgi3, tbAni3, tbAth3, tbAwa3, tbCun3, tbEnd3, tbFig3, tbHea3, tbLan3, tbKno3, tbMar3, tbPer3, tbSta3, tbSte3, tbSur3, tbThi3, tbWar3, tbWil3 }, { tbAgi4, tbAni4, tbAth4, tbAwa4, tbCun4, tbEnd4, tbFig4, tbHea4, tbLan4, tbKno4, tbMar4, tbPer4, tbSta4, tbSte4, tbSur4, tbThi4, tbWar4, tbWil4 } }; ;

            unitDefense = new Label[] { lbDef1, lbDef2, lbDef3, lbDef4 };
            unitArmorNum = new Label[,] { { lbArmRTGNum1, lbArmPenNum1, lbBulNum1 }, { lbArmRTGNum2, lbArmPenNum2, lbBulNum2 }, { lbArmRTGNum3, lbArmPenNum3, lbBulNum3 }, { lbArmRTGNum4, lbArmPenNum4, lbBulNum4 } };

            dgCal1.DataSource = House.HouseQry("PowerHolding");
            UpdateUnits(0);
        }
        ///// EVENTS START //////////////////////////////////////////////////////////


        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
