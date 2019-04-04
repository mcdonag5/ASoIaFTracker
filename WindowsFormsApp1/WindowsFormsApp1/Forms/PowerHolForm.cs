using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PowerHolForm : Form
    {
        ///// VARIABLES START ////////////////////////////////////////////////////// 
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();
        Classes.House house = new Classes.House();
        public int houseID;


        public PowerHolForm(int ID)
        {
            InitializeComponent();
            houseID = ID;
        }

        private void PowerHolForm_Load(object sender, EventArgs e)
        {
            mysqlConn.DbConfig(); //sets database settings
            mysqlConn.Connect();

            dgCal1.DataSource = house.HouseQry("PowerHolUnits", houseID);
            tbName1.Text = dgCal1.Rows[0].Cells[4].Value.ToString();
            lbCostNumber1.Text = Convert.ToString(Convert.ToInt32(dgCal1.Rows[0].Cells[34].Value) + Convert.ToInt32(dgCal1.Rows[0].Cells[52].Value) - Convert.ToInt32(dgCal1.Rows[0].Cells[6].Value));
            lbDiscipText1.Text = Convert.ToString(Convert.ToInt32(dgCal1.Rows[0].Cells[35].Value) + Convert.ToInt32(dgCal1.Rows[0].Cells[53].Value));
            lbTypeText1.Text = dgCal1.Rows[0].Cells[33].Value.ToString();
            cbTraining1.Text = dgCal1.Rows[0].Cells[5].Value.ToString();
        }
    }
}
