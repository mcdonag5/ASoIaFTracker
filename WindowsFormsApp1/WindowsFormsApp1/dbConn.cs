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
    class dbConn
    {
        //Notes//

        //DB config//
        private string varConfigServer { get; set; }
        private string varConfigDatabase { get; set; }
        private string varConfigUser { get; set; }
        private string varConfigPass { get; set; }

        private string connString;
        public MySqlConnection conn;
        public MySqlDataAdapter mySQLda;

        public bool logIn(string username, string password)
        {
            bool correct = false;
            varConfigUser = "mcdonag5_" + username;
            varConfigPass = password;
            connect();
            correct = connOpen();
            connClose();
            return correct;
        }

        public void dbConfig()
        {
            varConfigServer = "mcdonag5.z14it.cucstudents.org";
            varConfigDatabase = "mcdonag5_CUEsys120IT";
            varConfigUser = "mcdonag5_CUadmin";
            varConfigPass = "M+ox&S%mL{#a6u%st5";
        }
        public void connect()
        {//Connect to database (insecure, not using SSL or stored procedures)
            connString = "SERVER=" + varConfigServer + ";" +
                "DATABASE=" + varConfigDatabase + ";" +
                "UID=" + varConfigUser + ";" +
                "PASSWORD=" + varConfigPass + ";" +
                "SslMode=None;";
            conn = new MySqlConnection(connString);

        }
        public bool connOpen()
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
        public bool connClose()
        {//Connection close with error handling
            try { conn.Close(); return true; }
            catch (MySqlException err) { MessageBox.Show("Error: " + err.Message); return false; }
        }
        public DataSet qry(string sql)
        {//Run sql qry in argument and return dataset
            mySQLda = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            mySQLda.Fill(ds);
            connClose();
            return ds;

        }

    }
}
