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

        public int houseID;

        ///// METHODS START ////////////////////////////////////////////////////////
        public void UpdateUnits(int startingNum)
        {
            int endNum;
            if(dgCal1.RowCount > startingNum+4) { endNum = 3; } else { endNum = dgCal1.RowCount - startingNum; }
            for(int i = 0; i< endNum;i++)
            {
                unitName[i].Text = dgCal1.Rows[i+startingNum].Cells[3].Value.ToString();

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

            dgCal1.DataSource = House.HouseQry("PowerHolding");
            UpdateUnits(0);
        }
        ///// EVENTS START //////////////////////////////////////////////////////////


        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
