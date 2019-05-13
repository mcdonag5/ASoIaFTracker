using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class qryHelper : Form
    {
        DbConn DbConn = new DbConn();

        public qryHelper()
        {
            InitializeComponent();
            DbConn.DbConfig();
            DbConn.Connect();
        }

        private void btSendQry_Click(object sender, EventArgs e)
        {
            if (DbConn.ConnOpen() == true)
            {
                dataGridView1.DataSource = DbConn.Qry(richTextBox1.Text).Tables[0];

            }
        }

        private void btColumnNumbers_Click(object sender, EventArgs e)
        {
            File.WriteAllText("ColumnNumbers.txt", String.Empty);
            
            for (int i = 0; i< dataGridView1.ColumnCount;i++)
            {
                using (StreamWriter columnNumbers = new StreamWriter("DevLog.txt", append: true))
                { columnNumbers.WriteLine(i+": "+dataGridView1.Columns[i].Name); }
            }
        }
    }
}
