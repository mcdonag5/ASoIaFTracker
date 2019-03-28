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
            using (StreamWriter devlog = new StreamWriter("DevLog.txt", append: true))
            { devlog.WriteLine(DateTime.Now + " --- " + logItem); }//Concat current time and logItem and write to DevLog file
        }
        public void OpenLog()
        {
            Form devForm = new Form { Text = "DevLog.LogItem" };
            RichTextBox rtbDevLog.DevLog = new RichTextBox();
            Timer timerRefreshDevLog.DevLog = new Timer { Interval = 2500 };
            timerRefreshDevLog.LogItem.Tick += new EventHandler(devRefreshTimer_Tick);
            timerRefreshDevLog.LogItem.Start();
            rtbDevLog.LogItem.Location = new Point(0, 0);
            rtbDevLog.LogItem.Size = new Size(300, 380);
            rtbDevLog.LogItem.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            devForm.Size = new Size(300, 400);
            devForm.Controls.Add(rtbDevLog.LogItem);
            DevLog.LogItem("DevLog.LogItem viewed");
            void devRefreshTimer_Tick(object timer, EventArgs args)
            {
                rtbDevLog.LogItem.Text = "";
                string line;
                try
                {
                    StreamReader sr = new StreamReader("DevLog.txt");
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        rtbDevLog.LogItem.Text += line + "\r\n";
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception ex) { DevLog.LogItem("ex: " + ex); DevLog.LogItem("error reading DevLog.LogItem"); }
            }
            devForm.Show();
        }
    }
}
