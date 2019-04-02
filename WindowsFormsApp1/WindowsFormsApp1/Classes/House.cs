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

        public void HouseQry(string information, object dataGrid)
        {//makes a query to the database
            DevLog.LogItem(information + " sql run to " + dataGrid);
            if (mysqlConn.ConnOpen() == true)
            {
                string Qry = "";
                switch(information)
                {
                    case "PowerHolUnits":

                        break;
                }
                if (Qry != "") { dataGrid = mysqlConn.Qry(Qry).Tables[0]; }
            }
        }


    }
}
