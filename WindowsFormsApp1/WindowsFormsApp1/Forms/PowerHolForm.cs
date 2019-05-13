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

        public int houseID;

        ///// METHODS START ////////////////////////////////////////////////////////
        public void UpdateUnits(int startingNum)
        {
            for()
        }
        
        ///// METHODS END //////////////////////////////////////////////////////////
        public PowerHolForm(int ID)
        {
            House = new House(ID);

            InitializeComponent();
            //arry
            object[] unitName = { tbName1, tbName2, tbName3, tbName4 };
            object[] unitType = { lbTypeText1, lbTypeText2, lbTypeText3, lbTypeText4 };

            dgCal1.DataSource = House.HouseQry("PowerHolding");
        }
        ///// EVENTS START //////////////////////////////////////////////////////////


        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
