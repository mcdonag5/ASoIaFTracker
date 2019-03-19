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
                }

            }
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
            tbHouseName.Text = dgHouseDetails.Rows[0].Cells[1].Value.ToString();
            tbHouseSeatOfPower.Text = dgHouseDetails.Rows[0].Cells[4].Value.ToString();
            cbHouseRealm.Text = dgHouseDetails.Rows[0].Cells[3].Value.ToString();
            tbHouseLiegeLord.Text = dgHouseDetails.Rows[0].Cells[5].Value.ToString();
            lbHouseCurrent.Text = "Current" + Environment.NewLine +
                dgHouseDetails.Rows[0].Cells[7].Value + Environment.NewLine + 
                dgHouseDetails.Rows[0].Cells[8].Value + Environment.NewLine + 
                dgHouseDetails.Rows[0].Cells[9].Value + Environment.NewLine + 
                dgHouseDetails.Rows[0].Cells[10].Value + Environment.NewLine + 
                dgHouseDetails.Rows[0].Cells[11].Value + Environment.NewLine + 
                dgHouseDetails.Rows[0].Cells[12].Value + Environment.NewLine + 
                dgHouseDetails.Rows[0].Cells[13].Value + Environment.NewLine;
        }

        private void dgHouseDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        ///// EVENTS START //////////////////////////////////////////////////////////


        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
