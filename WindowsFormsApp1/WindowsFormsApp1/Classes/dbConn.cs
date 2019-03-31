using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class DbConn
    {
        //Notes//

        //DB config//
        private string VarConfigServer { get; set; }
        private string VarConfigDatabase { get; set; }
        private string VarConfigUser { get; set; }
        private string VarConfigPass { get; set; }

        private string connString;
        public MySqlConnection conn;
        public MySqlDataAdapter mySQLda;

        public bool LogIn(string username, string password)
        {
            bool correct = false;
            VarConfigUser = "mcdonag5_" + username;
            VarConfigPass = password;
            Connect();
            correct = ConnOpen();
            ConnClose();
            return correct;
        }

        public void DbConfig()
        {
            VarConfigServer = "mcdonag5.z14it.cucstudents.org";
            VarConfigDatabase = "mcdonag5_ASoIaF";
            VarConfigUser = "mcdonag5_IaFuser";
            VarConfigPass = "8Kl-H1?cwSn[";
        }
        public void Connect()
        {//Connect to database (insecure, not using SSL or stored procedures)
            connString = "SERVER=" + VarConfigServer + ";" +
                "DATABASE=" + VarConfigDatabase + ";" +
                "UID=" + VarConfigUser + ";" +
                "PASSWORD=" + VarConfigPass + ";" +
                "SslMode=None;";
            conn = new MySqlConnection(connString);

        }
        public bool ConnOpen()
        {
            try { conn.Open(); return true; }
            catch (MySqlException err)
            {//Connection error handling control statement
                switch (err.Number)
                {
                    case 0:
                        MessageBox.Show("Server connection failure");
                        break;
                    case 1045:
                        MessageBox.Show("User/Password Error");
                        break;
                    default:
                        MessageBox.Show(err.Message);
                        break;
                }
                return false;
            }
        }
        public bool ConnClose()
        {//Connection close with error handling
            try { conn.Close(); return true; }
            catch (MySqlException err) { MessageBox.Show("Error: " + err.Message); return false; }
        }
        public DataSet Qry(string sql)
        {//Run sql qry in argument and return dataset
            mySQLda = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            mySQLda.Fill(ds);
            ConnClose();
            
            return ds;

        }

    }
}
