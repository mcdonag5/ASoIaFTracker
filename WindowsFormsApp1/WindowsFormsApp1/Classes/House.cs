using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Classes
{
    class House
    {
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();

        //SELECT
        public object HouseQry(string information, int ID)
        {//makes a query to the database
            DevLog.LogItem(information + " sql run");
            string qry = "";
            mysqlConn.DbConfig(); //sets database settings
            mysqlConn.Connect();
            if (mysqlConn.ConnOpen() == true)
            {
                switch (information)
                {
                    //tbl_PowerHoldings
                    case "PowerHolUnits":
                        qry = "SELECT `tbl_PowerHolding`.`Hou_ID`, `tbl_PowerHolding`.*, `tbl_UnitType`.`Uni_ID`, `tbl_UnitType`.*, `tbl_UnitTraning`.`Tra_Name`, `tbl_UnitTraning`.* " +
                            "FROM `tbl_PowerHolding`, `tbl_UnitType`, `tbl_UnitTraning` " +
                            "WHERE `tbl_PowerHolding`.`Hou_ID` = '" + ID + "' AND `tbl_UnitType`.`Uni_ID` = `tbl_PowerHolding`.`Uni_ID` AND `tbl_UnitTraning`.`Tra_Name` = `tbl_PowerHolding`.`PowHol_Training`;";

                        break;
                    default:

                        break;
                }

                return mysqlConn.Qry(qry).Tables[0];
                //if (Qry != "") { dataGrid = mysqlConn.Qry(Qry).Tables[0]; }
            }
            return mysqlConn.Qry(qry).Tables[0];
        }
        public object HouseQry(string information)
        {//makes a query to the database
            DevLog.LogItem(information + " sql run");
            string qry = "";
            mysqlConn.DbConfig(); //sets database settings
            mysqlConn.Connect();
            if (mysqlConn.ConnOpen() == true)
            {
                switch (information)
                {
                    //tbl_Land
                    case "Land":
                        qry = "SELECT * FROM `tbl_Land`";

                        break;
                    default:

                        break;
                }

                return mysqlConn.Qry(qry).Tables[0];
                //if (Qry != "") { dataGrid = mysqlConn.Qry(Qry).Tables[0]; }
            }
            return mysqlConn.Qry(qry).Tables[0];
        }

        //INSERT
        public void InsertLandHolding(string houseID,string landID, string name, string note, string discount)
        {
            if (mysqlConn.ConnOpen() == true)
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tblLandHoldings` (`Hou_ID`, `Lan_ID`, `LanHol_Name`, `LanHol_Note`, `LanHol_Discount`) VALUES (@Hou_ID, @Lan_ID, @LanHol_Name, @LanHol_Note, @LanHol_Discount);";
                comm.Parameters.AddWithValue("@Hou_ID", houseID);
                comm.Parameters.AddWithValue("@Lan_ID", landID);
                comm.Parameters.AddWithValue("@LanHol_Name", name);
                comm.Parameters.AddWithValue("@LanHol_Note", note);
                comm.Parameters.AddWithValue("@LanHol_Discount", discount);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
    }
}
