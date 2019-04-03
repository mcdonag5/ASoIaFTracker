using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class House
    {
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();

        public object HouseQry(string information,int ID)
        {//makes a query to the database
            DevLog.LogItem(information + " sql run");
            if (mysqlConn.ConnOpen() == true)
            {
                string qry = "";
                switch(information)
                {
                    //tbl_PowerHoldings
                    case "PowerHolUnits":
                        qry = "SELECT `tbl_PowerHolding`.`Hou_ID`, `tbl_PowerHolding`.*, `tbl_UnitType`.`Uni_ID`, `tbl_UnitType`.*, `tbl_UnitTraning`.`Tra_Name`, `tbl_UnitTraning`.* "+
                            "FROM `tbl_PowerHolding`, `tbl_UnitType`, `tbl_UnitTraning` "+
                            "WHERE `tbl_PowerHolding`.`Hou_ID` = '"+ID+"' AND `tbl_UnitType`.`Uni_ID` = `tbl_PowerHolding`.`Uni_ID` AND `tbl_UnitTraning`.`Tra_Name` = `tbl_PowerHolding`.`PowHol_Training`;";
                        
                        break;
                    default:

                        break;
                }

                return mysqlConn.Qry(qry).Tables[0];
                //if (Qry != "") { dataGrid = mysqlConn.Qry(Qry).Tables[0]; }
            }
        }


    }
}
