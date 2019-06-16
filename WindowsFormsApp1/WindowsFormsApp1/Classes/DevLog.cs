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
    class DevLog
    {
        public void LogItem(string logItem)
        {//Write development log to DevLog
            Form frm = Form.ActiveForm;
            using (StreamWriter devlog = new StreamWriter("DevLog.txt", append: true))
            { devlog.WriteLine(DateTime.Now + " "+ frm +" --- " + logItem); }//Concat current time and logItem and write to DevLog file
        }
        public void OpenLog()
        {
            Form devForm = new Form { Text = "DevLogs" };
            RichTextBox rtbDevLogs = new RichTextBox();
            Timer timerRefreshDevLogs = new Timer
            {
                Interval = 2500
            };
            timerRefreshDevLogs.Tick += new EventHandler(devRefreshTimer_Tick);
            timerRefreshDevLogs.Start();
            rtbDevLogs.Location = new Point(0, 0);
            rtbDevLogs.Size = new Size(300, 380);
            rtbDevLogs.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            devForm.Size = new Size(300, 400);
            devForm.Controls.Add(rtbDevLogs);
            LogItem("devlogs viewed");
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
                catch (Exception ex) { LogItem("ex: " + ex); LogItem("error reading devlogs"); }
            }
            devForm.Show();
        }
    }
}
