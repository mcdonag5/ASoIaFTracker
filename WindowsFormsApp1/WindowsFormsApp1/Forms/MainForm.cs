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
    public partial class FormMain : Form
    {

        /// <sumary>
        /// NOTES
        /// 
        /// </summary>


        ///// VARIABLES START ////////////////////////////////////////////////////// 
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();
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
        int[,] LawModifierArry = { {0,0,-20 }, { 1,10,-10},{ 11, 20, -5 },{21,30,-2 },{31,40,-1 },{ 41,50,0},{51,60,1 },{61,70,2 },{71,999,5 } };
        int[,] PopModifierArry = { { 0, 0, -10 }, { 1, 10, -5 } ,{11,20,0 },{21,30,1 },{31,40,3 },{14,50,1 },{51,60,0 },{61,70,-5 },{ 71, 999, -10 } };
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////

        

        public void DbReturn(string returnWhat, string dataGrid)
        {//makes a query to the database
            DevLog.LogItem(returnWhat + " sql run to " + dataGrid);
            if (mysqlConn.ConnOpen() == true)
            {
                switch (dataGrid)
                {
                    case "house detail":
                        dgHouseDetails.DataSource = mysqlConn.Qry(returnWhat).Tables[0];
                        break;
                }

            }
        }
        
        public void ResetViewHouse(string player)
        {
            DevLog.LogItem("Reset House and view " + player + " Houses");
            string qry = "SELECT `tbl_House`.`Hou_ID` AS ID, `tbl_House`.`Hou_Name` AS Name, `tbl_House`.`Hou_Player` AS `Player`, `tbl_House`.`Rea_Name` AS `Realm`, `tbl_House`.`Hou_SeatOfPower` AS `Seat of Power`, `tbl_House`.`Hou_LiegeLord` AS `Liege Lord`, `tbl_House`.`Hou_Liege` AS `Liege` FROM `tbl_House`";
            if(player != "all") { qry += " WHERE hou_Player = '" + player + "'"; }
            qry += ";";
            DbReturn(qry, "house detail");
            dgHouseDetails.Visible = true;
           
        }
        public string HouseLawModifier(int lawMod)
        {
            string text ="";
            int modifier = 0;
            for( int i = 0;i < LawModifierArry.GetLength(0);i++ )
            {
                if (Between(lawMod, LawModifierArry[i, 0], LawModifierArry[i,1])) { modifier = LawModifierArry[i, 2]; }
            }
            if(modifier>0) { text += "+"; }
            else if (modifier < 0)
            {
                modifier += houLawMit;
                if (modifier>0) { modifier = 0; }
            }
            text += modifier.ToString();
            return text;
        }

        public string HousePopModifier(int popMod)
        {
            string text = "";
            int modifier = 0;
            for (int i = 0; i < LawModifierArry.GetLength(0); i++)
            {
                if (Between(popMod, PopModifierArry[i, 0], PopModifierArry[i, 1])) { modifier = PopModifierArry[i, 2]; }
            }
            if (modifier > 0) { text += "+"; }
            else if (modifier < 0)
            {
                modifier += houPopMit;
                if (modifier > 0) { modifier = 0; }
            }
            text += modifier.ToString();
            return text;
        }
        public bool Between(int x, int y,int z)
        {
            if(x>=y&&x<=z) { return true; }
            else { return false; }
        }
        ///// METHODS END //////////////////////////////////////////////////////////

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.WriteAllText("DevLog.txt", String.Empty);//Clear contents of DevLog
            DevLog.LogItem("Program started");
            mysqlConn.DbConfig(); //sets database settings
            mysqlConn.Connect();
            DbReturn("SELECT `tbl_House`.`Hou_ID` AS ID, `tbl_House`.`Hou_Name` AS Name, `tbl_House`.`Hou_Player` AS `Player`, `tbl_House`.`Rea_Name` AS `Realm`, `tbl_House`.`Hou_SeatOfPower` AS `Seat of Power`, `tbl_House`.`Hou_LiegeLord` AS `Liege Lord`, `tbl_House`.`Hou_Liege` AS `Liege` FROM `tbl_House`; ", "house detail");
        }
        ///// EVENTS START //////////////////////////////////////////////////////////

        private void DgHouseDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int x;
            if (dgHouseDetails.Columns[0].Name == "ID")
            {
                x = (Convert.ToInt32(dgHouseDetails.Rows[e.RowIndex].Cells[0].Value));
            }
            else
            {
                x = (Convert.ToInt32(dgHouseDetails.Rows[e.RowIndex].Cells[1].Value));
            }
            HouseViewForm houseForm = new HouseViewForm(x);
            houseForm.ShowDialog();
            //switch (dgHouseDetails.Columns[0].Name)
            //{

            //    case "ID":
            //        UpdateHouse(Convert.ToInt32(dgHouseDetails.Rows[e.RowIndex].Cells[0].Value));
            //        dgHouseDetails.Visible = false;
            //        break;
            //    case "Lie ID":

            //        break;
            //}
        }

        private void AllHousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetViewHouse("NPC");
        }

        private void PlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetViewHouse("Ross");
        }

        private void KyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetViewHouse("Kyle");
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            ResetViewHouse("all");
        }

        private void DevLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevLog.OpenLog();
        }

        private void TsbMenuDevLog(object sender, EventArgs e)
        {
            DevLog.OpenLog();
        }

        private void TsbCreateHouse_Click(object sender, EventArgs e)
        {
            CreateHouseForm createHouseForm = new CreateHouseForm();
            createHouseForm.ShowDialog();
        }

        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
