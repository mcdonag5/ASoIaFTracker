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
        dbConn mysqlConn = new dbConn();
        public int houseID;

        ///// VARIABLES END ////////////////////////////////////////////////////////
        
        ///// METHODS START ////////////////////////////////////////////////////////

        public void devLogs(string logItem)
        {//Write development log to DevLog
            using (StreamWriter devlog = new StreamWriter("DevLog.txt", append: true))
            { devlog.WriteLine(DateTime.Now + " --- " + logItem); }//Concat current time and logItem and write to DevLog file
        }

        public void dbReturn(string returnWhat, string dataGrid)
        {//makes a query to the database
            devLogs(returnWhat + " sql run to " + dataGrid);
            if (mysqlConn.connOpen() == true)
            {
                switch (dataGrid)
                {
                    case "house detail":
                        dgHouseDetails.DataSource = mysqlConn.qry(returnWhat).Tables[0];
                        break;
                    case "calculation":
                        dgCalculation.DataSource = mysqlConn.qry(returnWhat).Tables[0];
                        break;
                }

            }
        }

        public int SpareDeffense(int ID)
        {
            dbReturn("SELECT Hou_Defense FROM `tbl_House` WHERE Hou_ID = '"+ID+"'", "house detail");
            int start = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[0].Value);
            int sum = 0;
            dbReturn("SELECT * FROM `tbl_LandHolding` WHERE Hou_ID = '" + houseID + "'", "house detail");
            for (int i = 0; i < dgHouseDetails.RowCount-1; i++)
            {

                dbReturn("SELECT `tbl_DefenseHolding`.`LanHol_ID`, `tbl_Defense`.`Def_ID`, `tbl_Defense`.`Def_DefenseCost`,`tbl_DefenseHolding`.`DefHol_Discount` FROM `tbl_DefenseHolding`, `tbl_Defense` WHERE `tbl_DefenseHolding`.`LanHol_ID` = '" + Convert.ToUInt32(dgHouseDetails.Rows[i].Cells[0].Value)+"' AND `tbl_Defense`.`Def_ID` = `tbl_DefenseHolding`.`Def_ID`;", "calculation");
                devLogs("Times: "+i);
                for(int n = 0; i < dgCalculation.RowCount-1;i++)
                {
                    sum += Convert.ToInt32(dgCalculation.Rows[i].Cells[2].Value) - Convert.ToInt32(dgCalculation.Rows[i].Cells[3].Value);
                }
            }
            devLogs(start + "-"+sum +"="+(start - sum));
            return start-sum;
        }
        ///// METHODS END //////////////////////////////////////////////////////////

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.WriteAllText("DevLog.txt", String.Empty);//Clear contents of DevLog
            devLogs("Program started");
            mysqlConn.dbConfig(); //sets database settings
            mysqlConn.connect();
            dbReturn("SELECT * FROM `tbl_House`", "house detail");
            houseID = Convert.ToInt32(dgHouseDetails.Rows[0].Cells[0].Value);
            tbHouseName.Text = dgHouseDetails.Rows[0].Cells[1].Value.ToString();
            tbHouseSeatOfPower.Text = dgHouseDetails.Rows[0].Cells[4].Value.ToString();
            cbHouseRealm.Text = dgHouseDetails.Rows[0].Cells[3].Value.ToString(); devLogs(dgHouseDetails.Rows[0].Cells[3].Value.ToString());
            tbHouseLiegeLord.Text = dgHouseDetails.Rows[0].Cells[5].Value.ToString();
            lbHouseCurrent.Text = "Current" + Environment.NewLine +
                dgHouseDetails.Rows[0].Cells[7].Value + Environment.NewLine + 
                dgHouseDetails.Rows[0].Cells[8].Value + Environment.NewLine + 
                dgHouseDetails.Rows[0].Cells[9].Value + Environment.NewLine + 
                dgHouseDetails.Rows[0].Cells[10].Value + Environment.NewLine + 
                dgHouseDetails.Rows[0].Cells[11].Value + Environment.NewLine + 
                dgHouseDetails.Rows[0].Cells[12].Value + Environment.NewLine + 
                dgHouseDetails.Rows[0].Cells[13].Value + Environment.NewLine;
            
            lbHouseSpare.Text = "Spare" + Environment.NewLine +
                SpareDeffense(houseID)

                ;
        }
        ///// EVENTS START //////////////////////////////////////////////////////////
        private void devLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form devForm = new Form();
            devForm.Text = "DevLogs";
            RichTextBox rtbDevLogs = new RichTextBox();
            Timer timerRefreshDevLogs = new Timer();
            timerRefreshDevLogs.Interval = 2500;
            timerRefreshDevLogs.Tick += new EventHandler(devRefreshTimer_Tick);
            timerRefreshDevLogs.Start();
            rtbDevLogs.Location = new Point(0, 0);
            rtbDevLogs.Size = new Size(300, 380);
            rtbDevLogs.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            devForm.Size = new Size(300, 400);
            devForm.Controls.Add(rtbDevLogs);
            devLogs("devlogs viewed");
            void devRefreshTimer_Tick(object timer, EventArgs args)
            {
                rtbDevLogs.Text = "";
                string line;
                try
                {
                    StreamReader sr = new StreamReader("DevLog.txt");
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        rtbDevLogs.Text += line + "\r\n";
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception ex) { devLogs("ex: " + ex); devLogs("error reading devlogs"); }
            }
            devForm.Show();
        }

        


        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
