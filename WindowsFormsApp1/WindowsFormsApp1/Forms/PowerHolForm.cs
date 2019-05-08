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


        public PowerHolForm(int ID)
        {
            InitializeComponent();
            House = new House(ID);
        }

        private void PowerHolForm_Load(object sender, EventArgs e)
        {
            dgCal1.DataSource = House.HouseQry("PowerHolding");
        }
    }
}
