using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class HouseViewForm : Form
    {
        ///// VARIABLES START ////////////////////////////////////////////////////// 
        DbConn mysqlConn = new DbConn();
        public int houseID;
        public int houWea;
        public int houPow;
        public int houPop;
        public int houLaw;
        public int houLan;
        public int houInf;
        public int houDef;
        public int houHF;
        public int houWeaGain;
        public int houPowGain;
        public int houPopGain;
        public int houLawGain;
        public int houLanGain;
        public int houInfGain;
        public int houDefGain;
        public int houWeaLoss;
        public int houPowLoss;
        public int houPopLoss;
        public int houLawLoss;
        public int houLanLoss;
        public int houInfLoss;
        public int houDefLoss;
        public int houPopMit;
        public int houLawMit;
        int[,] LawModifierArry = { { 0, 0, -20 }, { 1, 10, -10 }, { 11, 20, -5 }, { 21, 30, -2 }, { 31, 40, -1 }, { 41, 50, 0 }, { 51, 60, 1 }, { 61, 70, 2 }, { 71, 999, 5 } };
        int[,] PopModifierArry = { { 0, 0, -10 }, { 1, 10, -5 }, { 11, 20, 0 }, { 21, 30, 1 }, { 31, 40, 3 }, { 14, 50, 1 }, { 51, 60, 0 }, { 61, 70, -5 }, { 71, 999, -10 } };
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public HouseViewForm(int ID)
        {
            InitializeComponent();
        }
    }
}
