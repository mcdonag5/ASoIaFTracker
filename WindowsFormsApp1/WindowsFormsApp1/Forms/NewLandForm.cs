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
    public partial class NewLandForm : Form
    {
        ///// VARIABLES START ////////////////////////////////////////////////////// 
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();
        House house = new House();
        public int houseID;


        public NewLandForm(int ID)
        {
            houseID = ID;
            InitializeComponent();
        }

        private void NewLandForm_Load(object sender, EventArgs e)
        {
            dgLand.DataSource = house.HouseQry("Land");
        }
    }
}
