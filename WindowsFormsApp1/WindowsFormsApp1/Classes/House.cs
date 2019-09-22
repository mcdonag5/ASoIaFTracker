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
        ///// VARIABLES START ///////////////////////////////////////////////////////
        DbConn mysqlConn = new DbConn();
        DevLog DevLog = new DevLog();
        public readonly int ID;
        public string name;
        readonly char apostrophe = Convert.ToChar("'");
        ///// VARIABLES END /////////////////////////////////////////////////////////

        ///// INITIALIZER ///////////////////////////////////////////////////////////
        public House()
        {
            mysqlConn.DbConfig(); //sets database settings
            mysqlConn.Connect();
        }
        public House(int houseID)
        {
            ID = houseID;
            mysqlConn.DbConfig(); //sets database settings
            mysqlConn.Connect();
        }

        public House(int houseID, string houseName)
        {
            ID = houseID;
            name = houseName;
            mysqlConn.DbConfig(); //sets database settings
            mysqlConn.Connect();
        }

        public string SanitizingInput(string text)
        {
            if (text.IndexOf("'") !=-1|| text.IndexOf('"') !=-1)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == apostrophe || text[i] == '"')
                    {
                        text = text.Insert(i, @"\");
                        i++;
                    }
                }
            }
            return text;
        }

        ///// LOGIN /////////////////////////////////////////////////////////////////
        public bool LogIn(string username, string password)
        {
            string qry = "SELECT `Use_Name` " +
                    "FROM `tbl_User` " +
                    "WHERE `tbl_User`.`Use_Name` = '" + username + "' AND `tbl_User`.`Use_Password` = '"+password+"';";
            DevLog.LogItem(qry);
            return mysqlConn.Qry(qry).Tables[0].Rows.Count>0;
        }

        ///// SELECT ////////////////////////////////////////////////////////////////
        public object HouseQry(string information)
        {//makes a query to the database
            DevLog.LogItem(information + " sql run");
            string qry = "";
            
            if (mysqlConn.ConnOpen())
            {
                switch (information)
                {
                    //tbl_House
                    case "House":
                        qry = "SELECT * FROM `tbl_House` " +
                            "ORDER BY `tbl_House`.`Hou_Name` ASC";
                        break;
                    case "ThisHouse":
                        qry = "SELECT * FROM `tbl_House` WHERE `Hou_ID` = '"+ID+"'";
                        break;
                    case "OtherHouse":
                        qry = "SELECT * FROM `tbl_House` WHERE `Hou_ID` != '" + ID + "' " +
                            "ORDER BY `tbl_House`.`Hou_Name` ASC";
                        break;
                    //tbl_LandHolding
                    case "LandHolding":
                        qry = "SELECT `tbl_LandHolding`.`Hou_ID`, `tbl_LandHolding`.*, `tbl_Land`.`Lan_ID`, `tbl_Land`.* "+
                            "FROM `tbl_LandHolding`, `tbl_Land` "+
                            "WHERE `tbl_LandHolding`.`Hou_ID` = '" + ID + "' AND `tbl_Land`.`Lan_ID` = `tbl_LandHolding`.`Lan_ID`; ";
                        break;
                    //tbl_InfluenceHoldings
                    case "InfluenceHoldings":
                        qry = "SELECT `tbl_InfluenceHoldings`.`Hou_ID`, `tbl_InfluenceHoldings`.*, `tbl_Influence`.`Inf_ID`, `tbl_Influence`.* "+
                            "FROM `tbl_InfluenceHoldings`, `tbl_Influence` "+
                            "WHERE `tbl_InfluenceHoldings`.`Hou_ID` = '" + ID + "' AND `tbl_Influence`.`Inf_ID` = `tbl_InfluenceHoldings`.`Inf_ID`;";
                        break;
                    //tbl_Heir
                    case "Heir":
                        qry = "SELECT * FROM `tbl_Heir` WHERE `Hou_ID` = '"+ID+"'";
                        break;
                    //tbl_PowerHolding
                    case "PowerHolding":
                        qry = "SELECT `tbl_PowerHolding`.*, `tbl_UnitType`.`Uni_ID`, `tbl_UnitType`.*" +
                            "FROM `tbl_PowerHolding`, `tbl_UnitType` " +
                            "WHERE `tbl_PowerHolding`.`Hou_ID` = '" + ID + "' AND `tbl_UnitType`.`Uni_ID` = `tbl_PowerHolding`.`Uni_ID`; ";
                        break;
                    //tbl_Banner
                    case "Banner":
                        qry = "SELECT `tbl_Banner`.`HouLie_ID`, `tbl_House`.*"+
                            "FROM `tbl_Banner`, `tbl_House` "+
                            "WHERE `tbl_Banner`.`HouLie_ID` = '" + ID + "' AND `tbl_House`.`Hou_ID` = `tbl_Banner`.`HouBan_ID`;";
                        break;
                    case "ViewBanner":
                        qry = "SELECT `tbl_Banner`.`HouBan_ID` AS `ID`, `tbl_House`.`Hou_Name` AS `Name`, `tbl_House`.`Hou_Player` AS `Player`, `tbl_House`.`Hou_SeatOfPower` AS `Seat Of Power`, `tbl_House`.`Hou_LiegeLord` AS `Liege Lord`, `tbl_House`.`Hou_Wealth` AS `Wealth`, `tbl_House`.`Hou_Power` AS `Power`, `tbl_House`.`Hou_Population` AS `Population`, `tbl_House`.`Hou_Law` AS `Law`, `tbl_House`.`Hou_Lands` AS `Lands`, `tbl_House`.`Hou_Influence` AS `Influence`, `tbl_House`.`Hou_Defense` AS `Defense`"+
                            "FROM `tbl_Banner`, `tbl_House`"+
                            "WHERE `tbl_Banner`.`HouLie_ID` = '"+ID+"' AND `tbl_House`.`Hou_ID` = `tbl_Banner`.`HouBan_ID`; ";
                        break;
                    //tbl_HouseChanges
                    case "HouseChanges":
                        qry = "SELECT * FROM `tbl_HouseChanges` WHERE `Hou_ID` = '" + ID + "'" +
                            "ORDER BY `HouCha_Year`, `HouCha_Month`; ";
                        break;

                    //Lookup tables
                    //tbl_Land
                    case "Land":
                        qry = "SELECT * FROM `tbl_Land`";
                        break;
                    //tbl_LandFeature
                    case "Land Features":
                        qry = "SELECT * FROM `tbl_LandFeature`";
                        break;
                    case "Land Features Community":
                        qry = "SELECT * FROM `tbl_LandFeature` " +
                            "WHERE `tbl_LandFeature`.`LanFea_Spaces` > '0';";
                        break;
                    //tbl_Defense
                    case "Defense":
                        qry = "SELECT * FROM `tbl_Defense`" +
                            "ORDER BY `tbl_Defense`.`Def_DefenseCost` ASC";
                        break;
                    //tblWealth
                    case "Estate":
                        qry = "SELECT * FROM `tbl_Wealth` " +
                            "WHERE `Wea_Type` = 'Estate' " +
                            "ORDER BY `tbl_Wealth`.`Wea_Name` ASC";
                        break;
                    case "Lifestyle":
                        qry = "SELECT * FROM `tbl_Wealth` " +
                            "WHERE `Wea_Type` = 'Lifestyle' " +
                            "ORDER BY `tbl_Wealth`.`Wea_Name` ASC";
                        break;
                    case "Personage":
                        qry = "SELECT * FROM `tbl_Wealth` " +
                            "WHERE `Wea_Type` = 'Personage' " +
                            "ORDER BY `tbl_Wealth`.`Wea_Name` ASC";
                        break;
                    case "Settlement":
                        qry = "SELECT * FROM `tbl_Wealth` " +
                            "WHERE `Wea_Type` = 'Settlement' " +
                            "ORDER BY `tbl_Wealth`.`Wea_Name` ASC";
                        break;
                    //tbl_UnitType
                    case "Unit Type":
                        qry = "SELECT * FROM `tbl_UnitType` " +
                            "ORDER BY `tbl_UnitType`.`Uni_Name` ASC";
                        break;
                    //tbl_UnitTraning
                    case "UnitTraining":
                        qry = "SELECT * FROM `tbl_UnitTraning` " +
                            "ORDER BY `tbl_UnitTraning`.`Tra_TrainingCost` ASC";
                        break;
                    //tbl_Influence
                    case "Influence":
                        qry = "SELECT * FROM `tbl_Influence` " +
                            "ORDER BY `tbl_Influence`.`Inf_Name` ASC";
                        break;
                }
                DevLog.LogItem(qry);
                return mysqlConn.Qry(qry).Tables[0];
            }
            return mysqlConn.Qry(qry).Tables[0];
        }

        public object HouseQry(string information, string holdingID)
        {//makes a query to the database
            DevLog.LogItem(information + " sql run");
            string qry = "";
            if (mysqlConn.ConnOpen())
            {
                switch (information)
                {
                    //tbl_LandHolding
                    case "LandHolding":
                        qry = "SELECT `tbl_LandHolding`.`Hou_ID`, `tbl_LandHolding`.*, `tbl_Land`.`Lan_ID`, `tbl_Land`.* " +
                            "FROM `tbl_LandHolding`, `tbl_Land` " +
                            "WHERE `tbl_LandHolding`.`Hou_ID` = '" + holdingID + "' AND `tbl_Land`.`Lan_ID` = `tbl_LandHolding`.`Lan_ID`; ";
                        break;
                    //tbl_InfluenceHoldings
                    case "InfluenceHolding":
                        qry = "SELECT `tbl_InfluenceHoldingImprovement`.*, `tbl_InfluenceImprovemnt`.* "+
                            "FROM `tbl_InfluenceHoldingImprovement`, `tbl_InfluenceImprovemnt` "+
                            "WHERE `tbl_InfluenceHoldingImprovement`.`InfHol_ID` = '" + holdingID + "' AND `tbl_InfluenceImprovemnt`.`InfImp_ID` = `tbl_InfluenceHoldingImprovement`.`InfImp_ID`;";
                        break;
                    //tbl_LandHoldingFeature No Community
                    case "LandHoldingFeature":
                        qry = "SELECT `tbl_LandHoldingFeature`.*, `tbl_LandFeature`.* "+
                            "FROM `tbl_LandHoldingFeature`, `tbl_LandFeature` "+
                            "WHERE `tbl_LandHoldingFeature`.`LanHol_ID` = '" + holdingID + "' AND `tbl_LandFeature`.`LanFea_ID` = `tbl_LandHoldingFeature`.`LanFea_ID` AND `tbl_LandFeature`.`LanFea_Spaces` = '0'; ";
                        break;
                    //tbl_LandHoldingFeature Community only
                    case "LandHoldingCommunity":
                        qry = "SELECT `tbl_LandHoldingFeature`.*, `tbl_LandFeature`.* " +
                            "FROM `tbl_LandHoldingFeature`, `tbl_LandFeature` " +
                            "WHERE `tbl_LandHoldingFeature`.`LanHol_ID` = '" + holdingID + "' AND `tbl_LandFeature`.`LanFea_ID` = `tbl_LandHoldingFeature`.`LanFea_ID` AND `tbl_LandFeature`.`LanFea_Spaces` > '0'; ";
                        break;
                    case "UpDown Community":
                        qry = "SELECT `tbl_LandHoldingFeature`.*, `tbl_LandFeature`.* " +
                            "FROM `tbl_LandHoldingFeature` LEFT JOIN `tbl_LandFeature` ON `tbl_LandHoldingFeature`.`LanFea_ID` = `tbl_LandFeature`.`LanFea_ID` " +
                            "WHERE `tbl_LandHoldingFeature`.`LanHolFea_ID` = '" + holdingID + "' AND `tbl_LandFeature`.`LanFea_ID` = `tbl_LandHoldingFeature`.`LanFea_ID`";
                        break;
                    //tbl_WealthHoldingImprovement
                    case "WealthHoldingImprovement":
                        qry = "SELECT `tbl_WealthHoldingImprovement`.`WeaHol_ID`, `tbl_WealthHoldingImprovement`.*, `tbl_WealthImprovement`.`WeaImp_ID`, `tbl_WealthImprovement`.* "+
                            "FROM `tbl_WealthHoldingImprovement`, `tbl_WealthImprovement` "+
                            "WHERE `tbl_WealthHoldingImprovement`.`WeaHol_ID` = '" + holdingID + "' AND `tbl_WealthImprovement`.`WeaImp_ID` = `tbl_WealthHoldingImprovement`.`WeaImp_ID`; ";
                        break;
                    //tbl_DefenseHolding
                    case "DefenseHolding":
                        qry = "SELECT `tbl_DefenseHolding`.*, `tbl_Defense`.`Def_ID`, `tbl_Defense`.* "+
                            "FROM `tbl_DefenseHolding`, `tbl_Defense` "+
                            "WHERE `tbl_DefenseHolding`.`LanHol_ID` = '" + holdingID + "' AND `tbl_Defense`.`Def_ID` = `tbl_DefenseHolding`.`Def_ID`; ";
                        break;
                    case "UpDown Defense":
                        qry = "SELECT  `tbl_DefenseHolding`.*, `tbl_Defense`.* " +
                            "FROM `tbl_DefenseHolding` LEFT JOIN `tbl_Defense` ON `tbl_DefenseHolding`.`Def_ID` = `tbl_Defense`.`Def_ID` " +
                            "WHERE `tbl_DefenseHolding`.`DefHol_ID` = '"+holdingID+"' AND `tbl_Defense`.`Def_ID` = `tbl_DefenseHolding`.`Def_ID`; ";
                        break;
                    //tbl_Trade
                    case "Trade":
                        qry = "SELECT `tbl_Trade`.*, `tbl_LandHolding`.`LanHol_ID`, `tbl_LandHolding`.`Hou_ID`, `tbl_House`.`Hou_ID`, `tbl_House`.`Hou_Name`, `tbl_LandHolding`.`LanHol_Name` " +
                            "FROM `tbl_Trade`  LEFT JOIN `tbl_LandHolding` ON `tbl_Trade`.`LanHol_ID` = `tbl_LandHolding`.`LanHol_ID` LEFT JOIN `tbl_House` ON `tbl_LandHolding`.`Hou_ID` = `tbl_House`.`Hou_ID` " +
                            "WHERE `tbl_Trade`.`WeaHol_ID` = '"+ holdingID+ "'  AND `tbl_LandHolding`.`LanHol_ID` = `tbl_Trade`.`LanHol_ID` AND `tbl_House`.`Hou_ID` = `tbl_LandHolding`.`Hou_ID`; ";
                        break;
                    case "TradeBackwards":
                        qry = "SELECT `tbl_Trade`.*, `tbl_WealthHolding`.`WeaHol_ID`, `tbl_WealthHolding`.`LanHolFea_ID`, `tbl_LandHoldingFeature`.`LanHolFea_ID`, `tbl_LandHoldingFeature`.`LanHol_ID`, `tbl_LandHolding`.`LanHol_ID`, `tbl_LandHolding`.`Hou_ID`, `tbl_House`.`Hou_ID`, `tbl_House`.`Hou_Name` " +
                            "FROM `tbl_Trade` LEFT JOIN `tbl_WealthHolding` ON `tbl_Trade`.`WeaHol_ID` = `tbl_WealthHolding`.`WeaHol_ID` LEFT JOIN `tbl_LandHoldingFeature` ON `tbl_WealthHolding`.`LanHolFea_ID` = `tbl_LandHoldingFeature`.`LanHolFea_ID` LEFT JOIN `tbl_LandHolding` ON `tbl_LandHoldingFeature`.`LanHol_ID` = `tbl_LandHolding`.`LanHol_ID` LEFT JOIN `tbl_House` ON `tbl_LandHolding`.`Hou_ID` = `tbl_House`.`Hou_ID` " +
                            "WHERE `tbl_Trade`.`LanHol_ID` = '" + holdingID + "' AND `tbl_WealthHolding`.`WeaHol_ID` = `tbl_Trade`.`WeaHol_ID` AND `tbl_LandHoldingFeature`.`LanHolFea_ID` = `tbl_WealthHolding`.`LanHolFea_ID` AND `tbl_LandHolding`.`LanHol_ID` = `tbl_LandHoldingFeature`.`LanHol_ID` AND `tbl_House`.`Hou_ID` = `tbl_LandHolding`.`Hou_ID`";
                        break;
                    //Lookup Table
                    //tbl_Wealth
                    case "Wealth":
                        qry = "SELECT * FROM `tbl_Wealth` " +
                            "WHERE `Wea_ID` = '" + holdingID + "'";
                        break;
                    //tbl_Influence
                    case "Influence":
                        qry = "SELECT * FROM `tbl_Influence` " +
                            "WHERE `Inf_ID` = '" + holdingID + "'";
                        break;
                    //tbl_Defense
                    case "Defense":
                        qry = "SELECT * FROM `tbl_Defense` " +
                            "WHERE `Def_ID` = '" + holdingID + "'";
                        break;
                    //tbl_WealthImprovement
                    case "WealthImprovement":
                        qry = "SELECT * FROM `tbl_WealthImprovement` "+
                            "WHERE `Wea_ID` = '"+ holdingID+"'";
                        break;
                    case "WealthImprovementLimit":
                        qry = "SELECT * FROM `tbl_WealthImprovement` " +
                            "WHERE `Wea_ID` = '" + holdingID + "' AND `WeaImp_Limit` = 0";
                        break;
                    case "WealthImprovementEdit":
                        qry = "SELECT * FROM `tbl_WealthImprovement` " +
                            "WHERE `WeaImp_ID` = '" + holdingID + "'";
                        break;
                    //tbl_InfluenceImprovemnt
                    case "ImprovementImprovement":
                        qry = "SELECT * FROM `tbl_InfluenceImprovemnt` " +
                            "WHERE `Inf_ID` = '" + holdingID + "'";
                        break;
                    case "InfluenceImprovemntEdit":
                        qry = "SELECT * FROM `tbl_InfluenceImprovemnt` " +
                            "WHERE `InfImp_ID` = '" + holdingID + "'";
                        break;
                    //tbl_UnitType
                    case "UnitType":
                        qry = "SELECT * FROM `tbl_UnitType` " +
                            "WHERE `Uni_ID` = '" + holdingID + "'";
                        break;
                }
                DevLog.LogItem(qry);
                return mysqlConn.Qry(qry).Tables[0];
            }
            return mysqlConn.Qry(qry).Tables[0];
        }
        //tbl_House
        public object HouseTableQry()
        {
            DevLog.LogItem("Wealth Holding sql run");
            string qry = "";
            if (mysqlConn.ConnOpen())
            {
                qry = "SELECT `tbl_House`.`Hou_ID` AS ID, `tbl_House`.`Hou_Name` AS Name, `tbl_House`.`Hou_Player` AS `Player`, `tbl_House`.`Rea_Name` AS `Realm`, `tbl_House`.`Hou_SeatOfPower` AS `Seat of Power`, `tbl_House`.`Hou_LiegeLord` AS `Liege Lord`, `tbl_House`.`Hou_Liege` AS `Liege` " +
                    "FROM `tbl_House`"+
                    "WHERE `Hou_Player` != 'Test' " +
                    "ORDER BY `tbl_House`.`Hou_Name` ASC";
                DevLog.LogItem(qry);
                return mysqlConn.Qry(qry).Tables[0];
            }
            return mysqlConn.Qry(qry).Tables[0];
        }

        public object HouseTableQry(string column, string condition)
        {
            DevLog.LogItem("Wealth Holding sql run");
            string qry = "";
            if (mysqlConn.ConnOpen())
            {
                qry = "SELECT `tbl_House`.`Hou_ID` AS ID, `tbl_House`.`Hou_Name` AS Name, `tbl_House`.`Hou_Player` AS `Player`, `tbl_House`.`Rea_Name` AS `Realm`, `tbl_House`.`Hou_SeatOfPower` AS `Seat of Power`, `tbl_House`.`Hou_LiegeLord` AS `Liege Lord`, `tbl_House`.`Hou_Liege` AS `Liege` " +
                    "FROM `tbl_House`" +
                    "WHERE `" + column + "` = '" + condition + "' " +
                    "ORDER BY `tbl_House`.`Hou_Name` ASC";
                DevLog.LogItem(qry);
                return mysqlConn.Qry(qry).Tables[0];
            }
            return mysqlConn.Qry(qry).Tables[0];
        }
        //tbl_WealthHolding
        public object WealthHolding(string place, string ID)
        {
            DevLog.LogItem("Wealth Holding sql run");
            string qry = "";
            if (mysqlConn.ConnOpen())
            {
                qry = "SELECT `tbl_WealthHolding`.`LanHol_ID`, `tbl_WealthHolding`.*, `tbl_Wealth`.`Wea_ID`, `tbl_Wealth`.* " +
                    "FROM `tbl_WealthHolding`, `tbl_Wealth` " +
                    "WHERE `tbl_WealthHolding`.`" + place + "` = '" + ID + "' AND `tbl_Wealth`.`Wea_ID` = `tbl_WealthHolding`.`Wea_ID`;";
                DevLog.LogItem(qry);
                return mysqlConn.Qry(qry).Tables[0];
            }
            return mysqlConn.Qry(qry).Tables[0];
        }

        public object WealthHolding(string place, string ID, string nameOfHolding)
        {
            DevLog.LogItem("Wealth Holding sql run");
            string qry = "";
            if (mysqlConn.ConnOpen())
            {
                qry = "SELECT `tbl_WealthHolding`.`LanHol_ID`, `tbl_WealthHolding`.*, `tbl_Wealth`.`Wea_ID`, `tbl_Wealth`.* " +
                    "FROM `tbl_WealthHolding`, `tbl_Wealth` " +
                    "WHERE `tbl_WealthHolding`.`" + place + "` = '" + ID + "' AND `tbl_Wealth`.`Wea_ID` = `tbl_WealthHolding`.`Wea_ID` AND `tbl_Wealth`.`Wea_Name` = '"+ nameOfHolding + "';";
                DevLog.LogItem(qry);
                return mysqlConn.Qry(qry).Tables[0];
            }
            return mysqlConn.Qry(qry).Tables[0];
        }

        public object WealthHolding(string place, string ID, int space)
        {
            DevLog.LogItem("Wealth Holding sql run");
            string qry = "";
            if (mysqlConn.ConnOpen())
            {
                qry = "SELECT `tbl_WealthHolding`.`LanHol_ID`, `tbl_WealthHolding`.*, `tbl_Wealth`.`Wea_ID`, `tbl_Wealth`.* " +
                    "FROM `tbl_WealthHolding`, `tbl_Wealth` " +
                    "WHERE `tbl_WealthHolding`.`" + place + "` = '" + ID + "' AND `tbl_Wealth`.`Wea_ID` = `tbl_WealthHolding`.`Wea_ID` AND `tbl_Wealth`.`Wea_TakesSpace` = '" + space + "';";
                DevLog.LogItem(qry);
                return mysqlConn.Qry(qry).Tables[0];
            }
            return mysqlConn.Qry(qry).Tables[0];
        }

        ///// INSERT ////////////////////////////////////////////////////////////////
        //tbl_LandHolding
        public void InsertLandHolding(string landID, string name, string note, string discount)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Land Holding");
                name = SanitizingInput(name); note = SanitizingInput(note);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_LandHolding` (`Hou_ID`, `Lan_ID`, `LanHol_Name`, `LanHol_Note`, `LanHol_Discount`) "+
                    "VALUES ('"+ID+"', '"+ landID+"', '"+name+"', '"+note+"', '"+discount+"');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_LandHoldingFeature
        public void InsertLandFeatureHolding (string landFeaID,string landHolID, string name, string notes)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Land Feature Holding");
                name = SanitizingInput(name); notes = SanitizingInput(notes);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_LandHoldingFeature` (`LanFea_ID`, `LanHol_ID`, `LanHolFea_Name`, `LanHolFea_Note`) "+
                    "VALUES ('"+landFeaID+"', '"+landHolID+"', '"+name+"', '"+notes+"');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_DefenseHolding
        public void InsertDefenseHolding(string defID, string landHolID, string name, string built, string notes, string discount)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Defense Holding");
                built = built == "True" ? "1" : "0";
                name = SanitizingInput(name); notes = SanitizingInput(notes);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_DefenseHolding` (`Def_ID`, `LanHol_ID`, `DefHol_Name`, `DefHol_Built`, `DefHol_Notes`, `DefHol_Discount`) "+
                    "VALUES ('"+defID+"', '"+landHolID+"', '"+name+"', '"+ built+"', '"+notes+"', '"+discount+"');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_WealthHolding
        public void InsertWealthHolding(string WeaID, string place, string placeID, string name, string built, string notes, string discount)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Wealth Holding");
                built = built == "True" ? "1" : "0";
                name = SanitizingInput(name); notes = SanitizingInput(notes);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_WealthHolding` (`Wea_ID`, `"+place+"`, `WeaHol_Name`, `WeaHol_Built`, `WeaHol_Note`, `WeaHol_Discount`) "+
                    "VALUES ('"+WeaID+"', '"+placeID+"', '"+name+"', '"+built+"', '"+notes+"', '"+ discount+"');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_WealthHoldingImprovement
        public void InsertWealthImprovementHolding(string WeaHolID, string weaImpID, string built)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Wealth Improvement Holding");
                built = built == "True" ? "1" : "0";
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_WealthHoldingImprovement` (`WeaHol_ID`, `WeaImp_ID`, `WeaHolImp_Built`) "+
                    "VALUES ('"+WeaHolID+"', '"+weaImpID+"', '"+built+"');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_InfluenceHoldings
        public void InsertInfluenceHolding(string infID, string name, string note, string discount)
        {
            if (mysqlConn.ConnOpen()) 
            {
                DevLog.LogItem("Insert Influence Holding");
                name = SanitizingInput(name); note = SanitizingInput(note);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_InfluenceHoldings` (`Hou_ID`, `Inf_ID`, `InfHol_Name`, `InfHol_Note`, `InfHol_Discount`) " +
                    "VALUES ('" + ID + "','" + infID + "', '" + name + "', '" + note + "', '" + discount + "');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_InfluenceHoldingImprovement
        public void InsertInfluenceImprovementHolding(string infImpID, string infHolID, string discount)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Influence Improvement Holding");
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_InfluenceHoldingImprovement` (`InfImp_ID`, `InfHol_ID`, `InfHolImp_Discount`) " +
                    "VALUES ('" + infImpID + "','" + infHolID + "', '" + discount + "');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_Heir
        public void InsertHeir(string name, string gender, string note)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Heir Holding");
                name = SanitizingInput(name); note = SanitizingInput(note);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_Heir` (`Hou_ID`, `Hei_Name`, `Hei_Gender`, `Hei_Note`) " +
                    "VALUES ('"+ID+"','" + name + "', '" + gender + "', '" + note + "');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_PowerHolding
        public void InsertPower(string unitID, string name, string discount, string training, string notes, string armorUpg, string fightUpg, string marksUpg, string agility, string animal, string athletics, string awareness, string cunning, string endurance, string fighting, string healing, string language, string knowledge, string marksmanship, string persuasion, string status, string stealth, string survival, string thievery, string warfare, string will)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Power Holding");
                armorUpg = armorUpg == "True" ? "1" : "0";
                fightUpg = fightUpg == "True" ? "1" : "0";
                marksUpg = marksUpg == "True" ? "1" : "0";
                name = SanitizingInput(name); notes = SanitizingInput(notes);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_PowerHolding` (`Uni_ID`,`Hou_ID`,`PowHol_Name`,`PowHol_Discount`, `PowHol_Training`, `PowHol_Notes`, `PowHol_ArmorUp`, `PowHol_FightingUp`, `PowHol_MarksmashipUp`,`PowHol_Agility`, `PowHol_AnimalHand`, `PowHol_Athletics`, `PowHol_Awareness`, `PowHol_Cunning`, `PowHol_Endurance`, `PowHol_Fighting`, `PowHol_Healing`, `PowHol_Language`, `PowHol_Knowledge`, `PowHol_Marksmanship`, `PowHol_Persuasion`, `PowHol_Status`, `PowHol_Stealth`, `PowHol_Survival`, `PowHol_Thievery`, `PowHol_Warfare`, `PowHol_Will`)" +
                    "VALUES('"+unitID+ "','" + ID + "','" + name + "','" + discount + "','" + training + "','" + notes + "','" + armorUpg + "','" + fightUpg + "','" + marksUpg + "','" + agility + "','" + animal + "','" + athletics + "','" + awareness + "','" + cunning + "','" + endurance + "','" + fighting + "','" + healing + "','" + language + "','" + knowledge + "','" + marksmanship + "','" + persuasion + "','" + status + "','" + stealth + "','" + survival + "','" + thievery + "','" + warfare + "','" + will + "')";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_Banner
        public void InsertBanners(int bannerHouse)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Banner Holding");
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_Banner` (`HouLie_ID`, `HouBan_ID`) "+
                    "VALUES ('"+ID+"', '"+ bannerHouse+"');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_HouseChanges
        public void InsertHouseChanges (int year, int month,string roll, string fortune,int wealthHF,int wealthOther,int powerHF, int powerOther,int populationHF,int populationOther, int lawHF,int lawOther, int landsHF,int landsOther,int influenceHF,int influenceOther,int defenseHF,int defenseOther)
        {

            if (roll == "") { roll = "null"; } else { roll = "'" + roll + "'"; }
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert House Change");
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_HouseChanges` (`Hou_ID`,`HouCha_Year`,`HouCha_Month`,`HouCha_Roll`,`HouCha_Fortune`,`HouCha_WealthHF`,`HouCha_WealthOther`,`HouCha_PowerHF`,`HouCha_PowerOther`,`HouCha_PopulationHF`,`HouCha_PopulationOther`,`HouCha_LawHF`,`HouCha_LawOther`,`HouCha_LandsHF`,`HouCha_LandsOther`,`HouCha_InfluenceHF`,`HouCha_InfluenceOther`,`HouCha_DefenseHF`,`HouCha_DefenseOther`) "+
                    "VALUES ('"+ID+ "','"+year+"', '"+month+"', "+roll+", '"+fortune+"', '"+wealthHF+"', '"+wealthOther+"', '"+powerHF+"', '"+powerOther+"', '"+populationHF+"', '"+populationOther+"', '"+lawHF+"', '"+lawOther+"', '"+landsHF+"', '"+landsOther+"', '"+influenceHF+"', '"+influenceOther+"', '"+defenseHF+"', '"+defenseOther+"');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_Trade
        public void InsertTrade(string weaHolID, string lanHolID,string ownLand, string built)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Trade");
                built = built == "True" ? "1" : "0";
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_Trade` (`WeaHol_ID`, `LanHol_ID`, `Tra_OwnLand`,`Tra_Built`) " +
                    "VALUES ('" + weaHolID + "', '" + lanHolID + "', '" + ownLand + "','"+built+"');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //Lookuptables
        //tbl_Wealth
        public void InsertWealth(string name, string type, string takeSpace, string wealthCost, string defenseCost, string landCost, string powerCost, string time, string requirement, string description, string benfit, string houseFortune, string wealthGain, string powerGain, string populationGain, string lawGain, string landGain, string influenceGain, string defenseGain, string wealthLoss, string powerLoss, string populationLoss, string lawLoss, string landLoss, string influenceLoss, string defenseLoss, string lawPenaltyReduction, string populationPenaltyReduction, string houseAction)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Wealth");
                takeSpace = takeSpace == "True" ? "1" : "0";
                name = SanitizingInput(name); time = SanitizingInput(time); requirement = SanitizingInput(requirement); description = SanitizingInput(description); benfit = SanitizingInput(benfit); houseAction = SanitizingInput(houseAction); 
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_Wealth` (`Wea_Name`, `Wea_Type`, `Wea_TakesSpace`,`Wea_WealthCost`,`Wea_DefenseCost`,`Wea_LandCost`,`Wea_PowerCost`,`Wea_Time`,`Wea_Requirement`,`Wea_Description`,`Wea_Benefits`,`Wea_HouseFortune`,`Wea_WealthGain`,`Wea_PowerGain`,`Wea_PopulationGain`,`Wea_LawGain`,`Wea_LandsGain`,`Wea_InfluenceGain`,`Wea_DefenseGain`,`Wea_WealthLoss`,`Wea_PowerLoss`,`Wea_PopulationLoss`,`Wea_LawLoss`,`Wea_LandsLoss`,`Wea_InfluenceLoss`,`Wea_DefenseLoss`,`Wea_LawPenaltyReduction`,`Wea_PopulationPenaltyReduction`,`Wea_HouseAction`) " +
                    "VALUES ('" + name + "', '" + type + "', '" + takeSpace + "','" + wealthCost + "','" + defenseCost + "','" + landCost + "','" + powerCost + "','" + time + "','" + requirement + "','" + description + "','" + benfit + "','" + houseFortune + "','" + wealthGain + "','" + powerGain + "','" + populationGain + "','" + lawGain + "','" + landGain + "','" + influenceGain + "','" + defenseGain + "','" + wealthLoss + "','" + powerLoss + "','" + populationLoss + "','" + lawLoss + "','" + landLoss + "','" + influenceLoss + "','" + defenseLoss + "','" + lawPenaltyReduction + "','" + populationPenaltyReduction + "','" + houseAction + "');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }

        public void InsertWealthImprovement(string weaID, string name, string limit, string wealthCost, string defenseCost, string landCost, string powerCost, string influenceCost, string time, string requirement, string description, string benfit, string houseFortune, string wealthGain, string powerGain, string populationGain, string lawGain, string landGain, string influenceGain, string defenseGain, string wealthLoss, string powerLoss, string populationLoss, string lawLoss, string landLoss, string influenceLoss, string defenseLoss, string lawPenaltyReduction, string populationPenaltyReduction, string houseAction, string repeatable)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert WealthImprovement");
                limit = limit == "True" ? "1" : "0";
                repeatable = repeatable == "True" ? "1" : "0";
                name = SanitizingInput(name); time = SanitizingInput(time); requirement = SanitizingInput(requirement); description = SanitizingInput(description); benfit = SanitizingInput(benfit); houseAction = SanitizingInput(houseAction);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_WealthImprovement` (`Wea_ID`, `WeaImp_Name`, `WeaImp_Limit`, `WeaImp_WealthCost`, `WeaImp_DefenseCost`, `WeaImp_LandCost`, `WeaImp_PowerCost`, `WeaImp_InfluenceCost`, `WeaImp_Time`, `WeaImp_Requirement`, `WeaImp_Description`, `WeaImp_Benefits`, `WeaImp_HouseFortune`, `WeaImp_WealthGain`, `WeaImp_PowerGain`, `WeaImp_PopulationGain`, `WeaImp_LawGain`, `WeaImp_LandsGain`, `WeaImp_InfluenceGain`, `WeaImp_DefenseGain`, `WeaImp_WealthLoss`, `WeaImp_PowerLoss`, `WeaImp_PopulationLoss`, `WeaImp_LawLoss`, `WeaImp_LandsLoss`, `WeaImp_InfluenceLoss`, `WeaImp_DefenseLoss`, `WeaImp_LawPenaltyReduction`, `WeaImp_PopulationPenaltyReduction`, `WeaImp_HouseAction`, `WeaImp_Repeatable`) " +
                    "VALUES ('" + weaID + "', '" + name + "', '" + limit + "','" + wealthCost + "','" + defenseCost + "','" + landCost + "','" + powerCost + "','" + influenceCost + "','" + time + "','" + requirement + "','" + description + "','" + benfit + "','" + houseFortune + "','" + wealthGain + "','" + powerGain + "','" + populationGain + "','" + lawGain + "','" + landGain + "','" + influenceGain + "','" + defenseGain + "','" + wealthLoss + "','" + powerLoss + "','" + populationLoss + "','" + lawLoss + "','" + landLoss + "','" + influenceLoss + "','" + defenseLoss + "','" + lawPenaltyReduction + "','" + populationPenaltyReduction + "','" + houseAction + "','" + repeatable + "');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }

        public void InsertInfluence(string name, string influenceCost, string description, string benfit, string wealthGain, string powerGain, string populationGain, string lawGain, string landGain, string influenceGain, string defenseGain, string lawPenaltyReduction, string populationPenaltyReduction)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Influence");
                name = SanitizingInput(name); description = SanitizingInput(description); benfit = SanitizingInput(benfit); 
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_Influence` (`Inf_Name`, `Inf_InfluenceCost`, `Inf_Description`, `Inf_Benefit`, `Inf_DefenseGain`, `Inf_InfluenceGain`, `Inf_LandGain`, `Inf_LawGain`, `Inf_PopulationGain`, `Inf_PowerGain`, `Inf_WealthGain`, `Inf_LawPenaltyReduction`, `Inf_PopulationPenaltyReduction`) " +
                    "VALUES ('" + name + "', '" + influenceCost + "','" + description + "','" + benfit + "','" + defenseGain + "','" + influenceGain + "','" + landGain + "','" + lawGain + "','" + populationGain + "','" + powerGain + "','" + wealthGain + "','" + lawPenaltyReduction + "','" + populationPenaltyReduction + "');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }

        public void InsertInfluenceImprovment(string infID, string name, string influenceCost, string description, string benfit, string wealthGain, string powerGain, string populationGain, string lawGain, string landGain, string influenceGain, string defenseGain, string lawPenaltyReduction, string populationPenaltyReduction)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert InfluenceImprovment");
                name = SanitizingInput(name); description = SanitizingInput(description); benfit = SanitizingInput(benfit);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_InfluenceImprovemnt` (`Inf_ID`, `InfImp_Name`, `InfImp_InfluenceCost`, `InfImp_Description`, `InfImp_Benefit`, `InfImp_WealthGain`, `InfImp_PowerGain`, `InfImp_PopulationGain`, `InfImp_LawGain`, `InfImp_LandsGain`, `InfImp_InfluenceGain`, `InfImp_DefenseGain`, `InfImp_LawPenaltyReduction`, `InfImp_PopulationPenaltyReduction`) " +
                    "VALUES ('" + infID + "', '" + name + "','" + influenceCost + "','" + description + "','" + benfit + "','" + wealthGain + "','" + powerGain + "','" + populationGain + "','" + lawGain + "','" + landGain + "','" + influenceGain + "','" + defenseGain + "','" + lawPenaltyReduction + "','" + populationPenaltyReduction + "');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }

        public void InsertDefense(string name, string defenseCost, string time, string description, string benfit, string spaces)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert InfluenceImprovment");
                name = SanitizingInput(name); description = SanitizingInput(description); benfit = SanitizingInput(benfit);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_Defense` (`Def_Name`, `Def_DefenseCost`, `Def_BuildTime`, `Def_Description`, `Def_Benefit`, `Def_Spaces`) " +
                    "VALUES ('" + name + "', '" + defenseCost + "','" + time + "','" + description + "','" + benfit + "','" + spaces + "');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }

        public void InsertUnitType(string name, string powerCost, string disciplineModifier, string keyAbilitie1, string keyAbilitie2, string keyAbilitie3, string description, string armorRating, string armorRatingUpg, string armorPenalty, string armorPenaltyUpg, string bulk, string bulkUpg, string fightingDamage, string fightingDamageUpg, string marksmanshipDamage, string marksmanshipDamageUpg, string marksmanshipRange, string movement)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert InfluenceImprovment");
                name = SanitizingInput(name); description = SanitizingInput(description);
                if (armorPenalty == "") { armorPenalty = "null"; } else { armorPenalty = "'" + armorPenalty + "'"; }
                if (armorPenaltyUpg == "") { armorPenaltyUpg = "null"; } else { armorPenaltyUpg = "'" + armorPenaltyUpg + "'"; }
                if (bulk == "") { bulk = "null"; } else { bulk = "'" + bulk + "'"; }
                if (bulkUpg == "") { bulkUpg = "null"; } else { bulkUpg = "'" + bulkUpg + "'"; }
                if (marksmanshipDamage == "") { marksmanshipDamage = "null"; } else { marksmanshipDamage = "'" + marksmanshipDamage + "'"; }
                if (marksmanshipDamageUpg == "") { marksmanshipDamageUpg = "null"; } else { marksmanshipDamageUpg = "'" + marksmanshipDamageUpg + "'"; }
                if (marksmanshipRange == " ") { marksmanshipRange = "null"; } else { marksmanshipRange = "'" + marksmanshipRange + "'"; }
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_UnitType` (`Uni_Name`, `Uni_PowerCost`, `Uni_DisciplineModifier`, `Uni_KeyAbilities`, `Uni_KeyAbilitie2`, `Uni_KeyAbilitie3`, `Uni_Description`, `Uni_ArmorRating`, `Uni_UpArmorRating`, `Uni_ArmorPenalty`, `Uni_UpArmorPenalty`, `Uni_Bulk`, `Uni_UpBulk`, `Uni_FightingDamage`, `Uni_UpFightingDamage`, `Uni_MarksmanshipDamage`, `Uni_UpMarksmanshipDamage`, `Uni_MarksmanshipRange`, `Uni_Movement`) " +
                    "VALUES ('" + name + "', '" + powerCost + "','" + disciplineModifier + "','" + keyAbilitie1 + "','" + keyAbilitie2 + "','" + keyAbilitie3 + "','" + description + "','" + armorRating + "','" + armorRatingUpg + "'," + armorPenalty + "," + armorPenaltyUpg + "," + bulk + "," + bulkUpg + ",'" + fightingDamage + "','" + fightingDamageUpg + "'," + marksmanshipDamage + "," + marksmanshipDamageUpg + "," + marksmanshipRange + ",'" + movement + "');";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        ///// UPDATE ////////////////////////////////////////////////////////////////
        //tbl_House
        public void UpdateHouseDetails(string name, string player, string realm, string seatOfPower, string liegeLord,string liege)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update House Details ID: "+ID);
                name = SanitizingInput(name); player = SanitizingInput(player); seatOfPower = SanitizingInput(seatOfPower); liegeLord = SanitizingInput(liegeLord); liege = SanitizingInput(liege);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_House` " +
                    "SET `Hou_Name` = '" + name + "', `Hou_Player` = '" + player + "', `Rea_Name` = '" + realm + "', `Hou_SeatOfPower` = '" + seatOfPower + "', `Hou_LiegeLord` = '" + liegeLord + "', `Hou_Liege` = '" + liege + "' " +
                    "WHERE `Hou_ID` = '" + ID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }

        public void UpdateHouseResources (int wealth, int power,int population, int law, int lands, int influence, int defense)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update House Resources ID: "+ID);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_House` " +
                    "SET `Hou_Wealth` = '"+wealth+"', `Hou_Power` = '"+power+"', `Hou_Population` = '"+population+"', `Hou_Law` = '"+law+"', `Hou_Lands` = '"+lands+"', `Hou_Influence` = '"+influence+"', `Hou_Defense` = '"+defense+"' "+
                    "WHERE `Hou_ID` = '"+ID+"'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_HouseChanges
        public void UpdateHouseChanges(int houChaID,int roll, string fortune, int wealthHF, int wealthOther, int powerHF, int powerOther, int populationHF, int populationOther, int lawHF, int lawOther, int landsHF, int landsOther, int influenceHF, int influenceOther, int defenseHF, int defenseOther)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update House Change ID: "+ houChaID);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_HouseChanges` " +
                    "SET `HouCha_Roll` = '" + roll + "', `HouCha_Fortune` = '" + fortune + "', `HouCha_WealthHF` = '" + wealthHF + "', `HouCha_WealthOther` = '" + wealthOther + "', `HouCha_PowerHF` = '" + powerHF + "', `HouCha_PowerOther` = '" + powerOther + "', `HouCha_PopulationHF` = '" + populationHF + "', `HouCha_PopulationOther` = '" + populationOther + "', `HouCha_LawHF` = '" + lawHF + "', `HouCha_LawOther` = '" + lawOther + "', `HouCha_LandsHF` = '" + landsHF + "', `HouCha_LandsOther` = '" + landsOther + "', `HouCha_InfluenceHF` = '" + influenceHF + "', `HouCha_InfluenceOther` = '" + influenceOther + "', `HouCha_DefenseHF` = '" + defenseHF + "', `HouCha_DefenseOther` = '" + defenseOther + "' " +
                    "WHERE `HouCha_ID` = '" + houChaID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_LandHolding
        public void UpdateLandDetails(int lanHolID, string name, string notes)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update land Holding ID: "+ lanHolID);
                name = SanitizingInput(name); notes = SanitizingInput(notes);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_LandHolding` " +
                    "SET `LanHol_Name` = '" + name + "', `LanHol_Note` = '" + notes + "' " +
                    "WHERE `LanHol_ID` = '" + lanHolID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_LandHoldingFeature
        public void UpdateLandFeatureDetails(string lanHolFeaID, string name)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update land Feature Holding with notes ID: " + lanHolFeaID);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                name = SanitizingInput(name);
                comm.CommandText = "UPDATE `tbl_LandHoldingFeature` " +
                    "SET `LanHolFea_Name` = '" + name + "' " +
                    "WHERE `LanHolFea_ID` = '" + lanHolFeaID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_DefenseHolding
        public void UpdateDefenseDetails(string defHolID, string name, string notes, string built)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update Defense Holding ID: "+ defHolID);
                built = built == "True" ? "1" : "0";
                name = SanitizingInput(name); notes = SanitizingInput(notes);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_DefenseHolding` " +
                    "SET `DefHol_Name` = '" + name + "', `DefHol_Notes` = '" + notes + "', `DefHol_Built` = '" + built + "' " +
                    "WHERE `DefHol_ID` = '" + defHolID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }

        public void UpdateDefenseUpgradeDowngrade(string defHolID, string newDefID)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update Defense Holding ID: " + defHolID);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_DefenseHolding` " +
                    "SET `Def_ID` = '" + newDefID + "' " +
                    "WHERE `DefHol_ID` = '" + defHolID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_LandHoldingFeature
        public void UpdateLandFeatureDetails(string lanHolFeaID, string name, string notes)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update land Holding with out notes ID: " + lanHolFeaID);
                name = SanitizingInput(name); notes = SanitizingInput(notes);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_LandHoldingFeature` " +
                    "SET `LanHolFea_Name` = '" + name + "', `LanHolFea_Note` = '" + notes + "' " +
                    "WHERE `LanHolFea_ID` = '" + lanHolFeaID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }

        public void UpdateLandFeatureUpgradeDowngrade(string lanHolFeaID, string lanFeaID)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update land Holding with out notes ID: " + lanHolFeaID);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_LandHoldingFeature` " +
                    "SET `LanFea_ID` = '" + lanFeaID + "' " +
                    "WHERE `LanHolFea_ID` = '" + lanHolFeaID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_WealthHolding
        public void UpdateWealthDetails(string weaHolID, string name, string notes, string built)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update Wealth Holding ID: "+ weaHolID);
                built = built == "True" ? "1" : "0";
                name = SanitizingInput(name); notes = SanitizingInput(notes);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_WealthHolding` " +
                    "SET `WeaHol_Name` = '" + name + "', `WeaHol_Note` = '" + notes + "', `WeaHol_Built` = '" + built + "' " +
                    "WHERE `WeaHol_ID` = '" + weaHolID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_WealthHoldingImprovement
        public void UpdateWealthImprovementDetails(string WeaHolImpID, string built)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update Wealth Improvement Holding ID: "+ WeaHolImpID);
                built = built == "True" ? "1" : "0";
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_WealthHoldingImprovement` " +
                    "SET `WeaHolImp_Built` = '" + built + "' " +
                    "WHERE `WeaHolImp_ID` = '" + WeaHolImpID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_Trade
        public void UpdateTrade(string TraID, string built)
        {
            built = built == "True" ? "1" : "0";
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update Wealth Trade Improvement Holding ID: " + TraID);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_Trade` " +
                    "SET `Tra_Built` = '" + built + "' " +
                    "WHERE `Tra_ID` = '" + TraID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_InfluenceHoldings
        public void UpdateInfluenceHoldings(string infHolID, string name, string notes)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update Influence Holding ID: "+infHolID);
                name = SanitizingInput(name); notes = SanitizingInput(notes);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_InfluenceHoldings` " +
                    "SET `InfHol_Name` = '" + name + "', `InfHol_Note` = '" + notes + "' " +
                    "WHERE `InfHol_ID` = '" + infHolID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_Heir
        public void UpdateHeir(string heirID, string name, string notes)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update Heir Holding ID: "+heirID);
                name = SanitizingInput(name); notes = SanitizingInput(notes);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_Heir` " +
                    "SET `Hei_Name` = '" + name + "', `Hei_Note` = '" + notes + "' " +
                    "WHERE `Hei_ID` = '" + heirID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_PowerHolding
        public void UpdatePowerHolding(string powHolID, string name, string training, string damage, string disorganized, string notes, string armorUpg, string fightUpg, string marksUpg, string agility, string animal, string athletics, string awareness, string cunning, string endurance, string fighting, string healing, string language, string knowledge, string marksmanship, string persuasion, string status, string stealth, string survival, string thievery, string warfare, string will)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update Power Holding ID: " + powHolID);
                armorUpg = armorUpg == "True" ? "1" : "0";
                fightUpg = fightUpg == "True" ? "1" : "0";
                marksUpg = marksUpg == "True" ? "1" : "0";
                name = SanitizingInput(name); notes = SanitizingInput(notes);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_PowerHolding` " +
                    "SET `PowHol_Name` = '" + name + "', `PowHol_Training` = '" + training + "', `PowHol_Damage` = '" + damage + "', `PowHol_Disorganized` = '" + disorganized + "', `PowHol_Notes` = '" + notes + "', `PowHol_ArmorUp` = '" + armorUpg + "', `PowHol_FightingUp` = '" + fightUpg + "', `PowHol_MarksmashipUp` = '" + marksUpg + "', " +
                    "`PowHol_Agility` = '" + agility + "', `PowHol_AnimalHand` = '" + animal + "', `PowHol_Athletics` = '" + athletics + "', `PowHol_Awareness` = '" + awareness + "', `PowHol_Cunning` = '" + cunning + "', `PowHol_Endurance` = '" + endurance + "', `PowHol_Fighting` = '" + fighting + "', `PowHol_Healing` = '" + healing + "', `PowHol_Language` = '" + language + "', `PowHol_Knowledge` = '" + knowledge + "', `PowHol_Marksmanship` = '" + marksmanship + "', `PowHol_Persuasion` = '" + persuasion + "', `PowHol_Status` = '" + status + "', `PowHol_Stealth` = '" + stealth + "', `PowHol_Survival` = '" + survival + "', `PowHol_Thievery` = '" + thievery + "', `PowHol_Warfare` = '" + warfare + "', `PowHol_Will` = '" + will + "' " +
                    "WHERE `PowHol_ID` = '" + powHolID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //Update Tables
        //tbl_Wealth
        public void UpdateWealth(string WeaID, string name, string type, string takeSpace, string wealthCost, string defenseCost, string landCost, string powerCost, string time, string requirement, string description, string benfit, string houseFortune, string wealthGain, string powerGain, string populationGain, string lawGain, string landGain, string influenceGain, string defenseGain, string wealthLoss, string powerLoss, string populationLoss, string lawLoss, string landLoss, string influenceLoss, string defenseLoss, string lawPenaltyReduction, string populationPenaltyReduction, string houseAction)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update Wealth ID: " + WeaID);
                takeSpace = takeSpace == "True" ? "1" : "0";
                name = SanitizingInput(name); time = SanitizingInput(time); requirement = SanitizingInput(requirement); description = SanitizingInput(description); benfit = SanitizingInput(benfit); houseAction = SanitizingInput(houseAction);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_Wealth` " +
                    "SET `Wea_Name` = '" + name + "', `Wea_Type` = '" + type + "', `Wea_TakesSpace` = '" + takeSpace + "', `Wea_WealthCost` = '" + wealthCost + "', `Wea_DefenseCost` = '" + defenseCost + "', `Wea_LandCost` = '" + landCost + "', `Wea_PowerCost` = '" + powerCost + "', `Wea_Time` = '" + time + "', `Wea_Requirement` = '" + requirement + 
                    "', `Wea_Description` = '" + description + "', `Wea_Benefits` = '" + benfit + "', `Wea_HouseFortune` = '" + houseFortune + 
                    "', `Wea_WealthGain` = '" + wealthGain + "', `Wea_PowerGain` = '" + powerGain + "', `Wea_PopulationGain` = '" + populationGain + "', `Wea_LawGain` = '" + lawGain + "', `Wea_LandsGain` = '" + landGain + "', `Wea_InfluenceGain` = '" + influenceGain + "', `Wea_DefenseGain` = '" + defenseGain +
                    "', `Wea_WealthLoss` = '" + wealthLoss + "', `Wea_PowerLoss` = '" + powerLoss + "', `Wea_PopulationLoss` = '" + populationLoss + "', `Wea_LawLoss` = '" + lawLoss + "', `Wea_LandsLoss` = '" + landLoss + "', `Wea_InfluenceLoss` = '" + influenceLoss + "', `Wea_DefenseLoss` = '" + defenseLoss + 
                    "', `Wea_LawPenaltyReduction` = '" + lawPenaltyReduction + "', `Wea_PopulationPenaltyReduction` = '" + populationPenaltyReduction + "', `Wea_HouseAction` = '" + houseAction + "' " +
                    "WHERE `Wea_ID` = '" + WeaID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_WealthImprovement
        public void UpdateWealthImprovement(string weaImpID, string name, string limit, string wealthCost, string defenseCost, string landCost, string powerCost, string influenceCost, string time, string requirement, string description, string benfit, string houseFortune, string wealthGain, string powerGain, string populationGain, string lawGain, string landGain, string influenceGain, string defenseGain, string wealthLoss, string powerLoss, string populationLoss, string lawLoss, string landLoss, string influenceLoss, string defenseLoss, string lawPenaltyReduction, string populationPenaltyReduction, string houseAction, string repeatable)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert WealthImprovement");
                limit = limit == "True" ? "1" : "0";
                repeatable = repeatable == "True" ? "1" : "0";
                name = SanitizingInput(name); time = SanitizingInput(time); requirement = SanitizingInput(requirement); description = SanitizingInput(description); benfit = SanitizingInput(benfit); houseAction = SanitizingInput(houseAction);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_WealthImprovement` " +
                    "SET `WeaImp_Name` = '" + name + "', `WeaImp_Limit` = '" + limit + "', `WeaImp_WealthCost` = '" + wealthCost + "', `WeaImp_DefenseCost` = '" + defenseCost + "', `WeaImp_LandCost` = '" + landCost + "', `WeaImp_PowerCost` = '" + powerCost + "', `WeaImp_InfluenceCost` = '" + influenceCost + "', `WeaImp_Time` = '" + time + "', `WeaImp_Requirement` = '" + requirement +
                    "', `WeaImp_Description` = '" + description + "', `WeaImp_Benefits` = '" + benfit + "', `WeaImp_HouseFortune` = '" + houseFortune +
                    "', `WeaImp_WealthGain` = '" + wealthGain + "', `WeaImp_PowerGain` = '" + powerGain + "', `WeaImp_PopulationGain` = '" + populationGain + "', `WeaImp_LawGain` = '" + lawGain + "', `WeaImp_LandsGain` = '" + landGain + "', `WeaImp_InfluenceGain` = '" + influenceGain + "', `WeaImp_DefenseGain` = '" + defenseGain +
                    "', `WeaImp_WealthLoss` = '" + wealthLoss + "', `WeaImp_PowerLoss` = '" + powerLoss + "', `WeaImp_PopulationLoss` = '" + populationLoss + "', `WeaImp_LawLoss` = '" + lawLoss + "', `WeaImp_LandsLoss` = '" + landLoss + "', `WeaImp_InfluenceLoss` = '" + influenceLoss + "', `WeaImp_DefenseLoss` = '" + defenseLoss +
                    "', `WeaImp_LawPenaltyReduction` = '" + lawPenaltyReduction + "', `WeaImp_PopulationPenaltyReduction` = '" + populationPenaltyReduction + "', `WeaImp_HouseAction` = '" + houseAction + "', `WeaImp_Repeatable` = '" + repeatable + "' " +
                    "WHERE `WeaImp_ID` = '" + weaImpID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_Influence
        public void UpdateInfluence(string InfID, string name, string influenceCost, string description, string benfit, string wealthGain, string powerGain, string populationGain, string lawGain, string landGain, string influenceGain, string defenseGain, string lawPenaltyReduction, string populationPenaltyReduction)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert Influence");
                name = SanitizingInput(name); description = SanitizingInput(description); benfit = SanitizingInput(benfit);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_Influence` " +
                    "SET `Inf_Name` = '" + name + "', `Inf_InfluenceCost` = '" + influenceCost + "', `Inf_Description` = '" + description + "', `Inf_Benefit` = '" + benfit + 
                    "', `Inf_DefenseGain` = '" + defenseGain + "', `Inf_InfluenceGain` = '" + influenceGain + "', `Inf_LandGain` = '" + landGain + "', `Inf_LawGain` = '" + lawGain + "', `Inf_PopulationGain` = '" + populationGain + "', `Inf_PowerGain` = '" + powerGain + "', `Inf_WealthGain` = '" + wealthGain + "', `Inf_LawPenaltyReduction` = '" + lawPenaltyReduction + "', `Inf_PopulationPenaltyReduction` = '" + populationPenaltyReduction + "' " +
                    "WHERE `Inf_ID` = '" + InfID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_InfluenceImprovemnt
        public void UpdateInfluenceImprovment(string infImpID, string name, string influenceCost, string description, string benfit, string wealthGain, string powerGain, string populationGain, string lawGain, string landGain, string influenceGain, string defenseGain, string lawPenaltyReduction, string populationPenaltyReduction)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert InfluenceImprovment");
                name = SanitizingInput(name); description = SanitizingInput(description); benfit = SanitizingInput(benfit);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_InfluenceImprovemnt` " +
                    "SET `InfImp_Name` = '" + name + "', `InfImp_InfluenceCost` = '" + influenceCost + "', `InfImp_Description` = '" + description + "', `InfImp_Benefit` = '" + benfit +
                    "', `InfImp_DefenseGain` = '" + defenseGain + "', `InfImp_InfluenceGain` = '" + influenceGain + "', `InfImp_LandsGain` = '" + landGain + "', `InfImp_LawGain` = '" + lawGain + "', `InfImp_PopulationGain` = '" + populationGain + "', `InfImp_PowerGain` = '" + powerGain + "', `InfImp_WealthGain` = '" + wealthGain + "', `InfImp_LawPenaltyReduction` = '" + lawPenaltyReduction + "', `InfImp_PopulationPenaltyReduction` = '" + populationPenaltyReduction + "' " +
                    "WHERE `InfImp_ID` = '" + infImpID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_Defense
        public void UpdateDefense(string defID, string name, string defenseCost, string time, string description, string benfit, string spaces)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert InfluenceImprovment");
                name = SanitizingInput(name); description = SanitizingInput(description); benfit = SanitizingInput(benfit);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_Defense` " +
                    "SET `Def_Name` = '" + name + "', `Def_DefenseCost` = '" + defenseCost + "', `Def_BuildTime` = '" + time + "', `Def_Description` = '" + description + "', `Def_Benefit` = '" + benfit + "', `Def_Spaces` = '" + spaces + "' " +
                    "WHERE `Def_ID` = '" + defID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_UnitType
        public void UpdateUnitType(string uniID, string name, string powerCost, string disciplineModifier, string keyAbilitie1, string keyAbilitie2, string keyAbilitie3, string description, string armorRating, string armorRatingUpg, string armorPenalty, string armorPenaltyUpg, string bulk, string bulkUpg, string fightingDamage, string fightingDamageUpg, string marksmanshipDamage, string marksmanshipDamageUpg, string marksmanshipRange, string movement)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Insert InfluenceImprovment");
                name = SanitizingInput(name); description = SanitizingInput(description);
                if (armorPenalty == "") { armorPenalty = "null"; } else { armorPenalty = "'" + armorPenalty + "'"; }
                if (armorPenaltyUpg == "") { armorPenaltyUpg = "null"; } else { armorPenaltyUpg = "'" + armorPenaltyUpg + "'"; }
                if (bulk == "") { bulk = "null"; } else { bulk = "'" + bulk + "'"; }
                if (bulkUpg == "") { bulkUpg = "null"; } else { bulkUpg = "'" + bulkUpg + "'"; }
                if (marksmanshipDamage == "") { marksmanshipDamage = "null"; } else { marksmanshipDamage = "'" + marksmanshipDamage + "'"; }
                if (marksmanshipDamageUpg == "") { marksmanshipDamageUpg = "null"; } else { marksmanshipDamageUpg = "'" + marksmanshipDamageUpg + "'"; }
                if (marksmanshipRange == " ") { marksmanshipRange = "null"; } else { marksmanshipRange = "'" + marksmanshipRange + "'"; }
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_UnitType` " +
                    "SET `Uni_Name` = '" + name + "', `Uni_PowerCost` = '" + powerCost + "', `Uni_DisciplineModifier` = '" + disciplineModifier + "', `Uni_KeyAbilities` = '" + keyAbilitie1 + "', `Uni_KeyAbilitie2` = '" + keyAbilitie2 + "', `Uni_KeyAbilitie3` = '" + keyAbilitie3 + "', `Uni_Description` = '" + description +
                    "', `Uni_ArmorRating` = '" + armorRating + "', `Uni_UpArmorRating` = '" + armorRatingUpg + "', `Uni_ArmorPenalty` = " + armorPenalty + ", `Uni_UpArmorPenalty` = " + armorPenaltyUpg + ", `Uni_Bulk` = " + bulk + ", `Uni_UpBulk` = " + bulkUpg +
                    ", `Uni_FightingDamage` = '" + fightingDamage + "', `Uni_UpFightingDamage` = '" + fightingDamageUpg + "', `Uni_MarksmanshipDamage` = " + marksmanshipDamage + ", `Uni_UpMarksmanshipDamage` = " + marksmanshipDamageUpg + ", `Uni_MarksmanshipRange` = " + marksmanshipRange + ", `Uni_Movement` = '" + movement  + "' " +
                    "WHERE `Uni_ID` = '" + uniID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //Users
        //tbl_Users
        public void UpdatePassword(string username, string password)
        {
            if (mysqlConn.ConnOpen())
            {
                DevLog.LogItem("Update password: " + username);
                password = SanitizingInput(password);
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_User` " +
                    "SET `Use_Password` = '" + password + "' " +
                    "WHERE `Use_Name` = '" + username + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        ///// DELETE ////////////////////////////////////////////////////////////////
        //tbl_LandHolding
        public void DeleteLand(string lanID)
        {
            DevLog.LogItem("Deleting from tbl_LandHolding ID: " + lanID);
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "DELETE FROM `tbl_LandHolding`" +
                    "WHERE `LanHol_ID` = '" + lanID + "';";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_LandHoldingFeature
        public void DeleteLandFeature(string landFeaID)
        {
            DevLog.LogItem("Deleting from tbl_LandHoldingFeature ID: " + landFeaID);
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "DELETE FROM `tbl_LandHoldingFeature`" +
                    "WHERE `LanHolFea_ID` = '" + landFeaID + "';";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_WealthHolding
        public void DeleteWealth(string WeaHolID)
        {
            DevLog.LogItem("Deleting from tbl_WealthHolding ID: " + WeaHolID);
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "DELETE FROM `tbl_WealthHolding`" +
                    "WHERE `WeaHol_ID` = '" + WeaHolID + "';";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_WealthHoldingImprovement
        public void DeleteWealthImprovement(string WeaImpID)
        {
            DevLog.LogItem("Deleting from tbl_LandHoldingFeature ID: " + WeaImpID);
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "DELETE FROM `tbl_WealthHoldingImprovement`" +
                    "WHERE `WeaHolImp_ID` = '" + WeaImpID + "';";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_Trade
        public void DeleteTrade(string TraID)
        {
            DevLog.LogItem("Deleting from tbl_Trade ID: " + TraID);
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "DELETE FROM `tbl_Trade`" +
                    "WHERE `Tra_ID` = '" + TraID + "';";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_DefenseHolding
        public void DeleteDefense(string defHolID)
        {
            DevLog.LogItem("Deleting from tbl_DefenseHolding ID: " + defHolID);
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "DELETE FROM `tbl_DefenseHolding`" +
                    "WHERE `DefHol_ID` = '" + defHolID + "';";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_InfluenceHoldings
        public void DeleteInfluence(string infHolID)
        {
            DevLog.LogItem("Deleting from tbl_InfluenceHoldings ID: " + infHolID);
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "DELETE FROM `tbl_InfluenceHoldings`" +
                    "WHERE `InfHol_ID` = '" + infHolID + "';";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_InfluenceHoldingImprovement
        public void DeleteInfluenceImprovement(string infImpID)
        {
            DevLog.LogItem("Deleting from tbl_Heir ID: " + infImpID);
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "DELETE FROM `tbl_InfluenceHoldingImprovement`" +
                    "WHERE `InfHolImp_ID` = '" + infImpID + "';";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_Heir
        public void DeleteHeir(string heirID)
        {
            DevLog.LogItem("Deleting from tbl_Heir ID: " + heirID);
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "DELETE FROM `tbl_Heir`" +
                    "WHERE `Hei_ID` = '" + heirID + "';";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_Banner
        public void DeleteBanner(int bannerHouse)
        {
            DevLog.LogItem("Deleting from tbl_Banner ID: " + bannerHouse);
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "DELETE FROM `tbl_Banner`" +
                    "WHERE `HouLie_ID` = '"+ID+"' AND `HouBan_ID` = '"+ bannerHouse+"';";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_PowerHolding
        public void DeletePower(string power)
        {
            DevLog.LogItem("Deleting from tbl_PowerHolding ID: " + power);
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "DELETE FROM `tbl_PowerHolding`" +
                    "WHERE `PowHol_ID` = '" + power + "';";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        ///// VARIABLES START ///////////////////////////////////////////////////////

        ///// VARIABLES END /////////////////////////////////////////////////////////

        ///// METHODS START /////////////////////////////////////////////////////////

        ///// METHODS END ///////////////////////////////////////////////////////////
        
        ///// EVENTS START //////////////////////////////////////////////////////////

        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
