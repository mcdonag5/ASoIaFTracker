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
    public partial class Form1 : Form
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


        ///// METHODS END //////////////////////////////////////////////////////////

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ///// EVENTS START //////////////////////////////////////////////////////////


        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
