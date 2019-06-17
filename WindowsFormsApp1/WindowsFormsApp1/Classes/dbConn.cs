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
            VarConfigUser = "mcdonag_" + username;
            VarConfigPass = password;
            Connect();
            bool correct = ConnOpen();
            ConnClose();
            return correct;
        }

        public void DbConfig()
        {
            VarConfigServer = "mcdonag5.cucstudents.org";
            VarConfigDatabase = "mcdonag_ASoIaF";
            VarConfigUser = "mcdonag_User";
            VarConfigPass = "JVi5Rd~[FMp$";
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

        //Insert 

        public void InsertHouse(string Hou_Name, string Hou_Player, string Rea_Name, string Hou_SeatOfPower, string Hou_LiegeLord, string Hou_Liege, string Hou_Wealth, string hou_Power, string Hou_Population, string hou_Law, string hou_Lands, string Hou_Influence, string Hou_Defense, string Hou_Founding, string Hou_HistoricalEvents)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tbl_House` (`Hou_Name`, `Hou_Player`, `Rea_Name`, `Hou_SeatOfPower`, `Hou_LiegeLord`, `Hou_Liege`, `Hou_Wealth`, `hou_Power`,`Hou_Population`,`hou_Law`,`hou_Lands`,`Hou_Influence`,`Hou_Defense`,`Hou_Founding`,`Hou_HistoricalEvents`) VALUES (@Hou_Name, @Hou_Player, @Rea_Name, @Hou_SeatOfPower, @Hou_LiegeLord, @Hou_Liege, @Hou_Wealth, @hou_Power,@Hou_Population,@hou_Law,@hou_Lands,@Hou_Influence,@Hou_Defense,@Hou_Founding,@Hou_HistoricalEvents);";
            comm.Parameters.AddWithValue("@Hou_Name", Hou_Name);
            comm.Parameters.AddWithValue("@Hou_Player", Hou_Player);
            comm.Parameters.AddWithValue("@Rea_Name", Rea_Name);
            comm.Parameters.AddWithValue("@Hou_SeatOfPower", Hou_SeatOfPower);
            comm.Parameters.AddWithValue("@Hou_LiegeLord", Hou_LiegeLord);
            comm.Parameters.AddWithValue("@Hou_Liege", Hou_Liege);
            comm.Parameters.AddWithValue("@Hou_Wealth", Hou_Wealth);
            comm.Parameters.AddWithValue("@hou_Power", hou_Power);
            comm.Parameters.AddWithValue("@Hou_Population", Hou_Population);
            comm.Parameters.AddWithValue("@hou_Law", hou_Law);
            comm.Parameters.AddWithValue("@hou_Lands", hou_Lands);
            comm.Parameters.AddWithValue("@Hou_Influence", Hou_Influence);
            comm.Parameters.AddWithValue("@Hou_Defense", Hou_Defense);
            comm.Parameters.AddWithValue("@Hou_Founding", Hou_Founding);
            comm.Parameters.AddWithValue("@Hou_HistoricalEvents", Hou_HistoricalEvents);
            comm.ExecuteNonQuery();
            ConnClose();
        }

    }
}
