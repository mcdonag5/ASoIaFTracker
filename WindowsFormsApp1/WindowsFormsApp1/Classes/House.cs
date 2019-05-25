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
        public readonly int ID;
        public string name;

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
                        qry = "SELECT * FROM `tbl_House`";
                        break;
                    case "ThisHouse":
                        qry = "SELECT * FROM `tbl_House` WHERE `Hou_ID` = '"+ID+"';";
                        break;
                    case "OtherHouse":
                        qry = "SELECT * FROM `tbl_House` WHERE `Hou_ID` != '" + ID + "';";
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
                    case "LandFeature":
                        qry = "SELECT * FROM `tbl_LandFeature`";
                        break;
                    //tbl_Defense
                    case "Defense":
                        qry = "SELECT * FROM `tbl_Defense`";
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
                }

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
                    //Lookup Table
                    //tbl_WealthImprovement
                    case "WealthImprovement":
                        qry = "SELECT * FROM `tbl_WealthImprovement` "+
                            "WHERE `Wea_ID` = '"+ holdingID+"'";
                        break;
                }

                return mysqlConn.Qry(qry).Tables[0];
            }
            return mysqlConn.Qry(qry).Tables[0];
        }

        public object HouseTableQry()
        {
            DevLog.LogItem("Wealth Holding sql run");
            string qry = "";
            if (mysqlConn.ConnOpen())
            {
                qry = "SELECT `tbl_House`.`Hou_ID` AS ID, `tbl_House`.`Hou_Name` AS Name, `tbl_House`.`Hou_Player` AS `Player`, `tbl_House`.`Rea_Name` AS `Realm`, `tbl_House`.`Hou_SeatOfPower` AS `Seat of Power`, `tbl_House`.`Hou_LiegeLord` AS `Liege Lord`, `tbl_House`.`Hou_Liege` AS `Liege` " +
                    "FROM `tbl_House`"+
                    "WHERE `Hou_Player` != 'Test'";
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
                    "WHERE `" + column + "` = '" + condition + "';";

                return mysqlConn.Qry(qry).Tables[0];
            }
            return mysqlConn.Qry(qry).Tables[0];
        }
        public object WealthHolding(string place, string ID)
        {
            DevLog.LogItem("Wealth Holding sql run");
            string qry = "";
            if (mysqlConn.ConnOpen())
            {
                qry = "SELECT `tbl_WealthHolding`.`LanHol_ID`, `tbl_WealthHolding`.*, `tbl_Wealth`.`Wea_ID`, `tbl_Wealth`.* " +
                    "FROM `tbl_WealthHolding`, `tbl_Wealth` " +
                    "WHERE `tbl_WealthHolding`.`" + place + "` = '" + ID + "' AND `tbl_Wealth`.`Wea_ID` = `tbl_WealthHolding`.`Wea_ID`;";

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

                return mysqlConn.Qry(qry).Tables[0];
            }
            return mysqlConn.Qry(qry).Tables[0];
        }

        ///// INSERT ////////////////////////////////////////////////////////////////
        public void InsertLandHolding(string landID, string name, string note, string discount)
        {
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_LandHolding` (`Hou_ID`, `Lan_ID`, `LanHol_Name`, `LanHol_Note`, `LanHol_Discount`) "+
                    "VALUES ('"+ID+"', '"+ landID+"', '"+name+"', '"+note+"', '"+discount+"');";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        public void InsertLandFeatureHolding (string landFeaID,string landHolID, string name, string notes)
        {
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_LandHoldingFeature` (`LanFea_ID`, `LanHol_ID`, `LanHolFea_Name`, `LanHolFea_Note`) "+
                    "VALUES ('"+landFeaID+"', '"+landHolID+"', '"+name+"', '"+notes+"');";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        public void InsertDefenseHolding(string defID, string landHolID, string name, string built, string notes, string discount)
        {
            built = built == "True" ? "1" : "0";
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_DefenseHolding` (`Def_ID`, `LanHol_ID`, `DefHol_Name`, `DefHol_Built`, `DefHol_Notes`, `DefHol_Discount`) "+
                    "VALUES ('"+defID+"', '"+landHolID+"', '"+name+"', '"+ built+"', '"+notes+"', '"+discount+"');";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        public void InsertWealthHolding(string WeaID, string place, string placeID, string name, string built, string notes, string discount)
        {
            built = built == "True" ? "1" : "0";
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_WealthHolding` (`Wea_ID`, `"+place+"`, `WeaHol_Name`, `WeaHol_Built`, `WeaHol_Note`, `WeaHol_Discount`) "+
                    "VALUES ('"+WeaID+"', '"+placeID+"', '"+name+"', '"+built+"', '"+notes+"', '"+ discount+"');";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        public void InsertWealthImprovementHolding(string WeaHolID, string weaImpID, string built)
        {
            built = built == "True" ? "1" : "0";
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_WealthHoldingImprovement` (`WeaHol_ID`, `WeaImp_ID`, `WeaHolImp_Built`) "+
                    "VALUES ('"+WeaHolID+"', '"+weaImpID+"', '"+built+"');";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        public void InsertHeir(string name, string gender, string note)
        {
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_Heir` (`Hou_ID`, `Hei_Name`, `Hei_Gender`, `Hei_Note`) " +
                    "VALUES ('"+ID+"','" + name + "', '" + gender + "', '" + note + "');";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        public void InsertBanners(int bannerHouse)
        {
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_Banner` (`HouLie_ID`, `HouBan_ID`) "+
                    "VALUES ('"+ID+"', '"+ bannerHouse+"');";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        public void InsertHouseChanges (int year, int month,int roll, string fortune,int wealthHF,int wealthOther,int powerHF, int powerOther,int populationHF,int populationOther, int lawHF,int lawOther, int landsHF,int landsOther,int influenceHF,int influenceOther,int defenseHF,int defenseOther)
        {
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "INSERT INTO `tbl_HouseChanges` (`Hou_ID`,`HouCha_Year`,`HouCha_Month`,`HouCha_Roll`,`HouCha_Fortune`,`HouCha_WealthHF`,`HouCha_WealthOther`,`HouCha_PowerHF`,`HouCha_PowerOther`,`HouCha_PopulationHF`,`HouCha_PopulationOther`,`HouCha_LawHF`,`HouCha_LawOther`,`HouCha_LandsHF`,`HouCha_LandsOther`,`HouCha_InfluenceHF`,`HouCha_InfluenceOther`,`HouCha_DefenseHF`,`HouCha_DefenseOther`) "+
                    "VALUES ('"+ID+ "','"+year+"', '"+month+"', '"+roll+"', '"+fortune+"', '"+wealthHF+"', '"+wealthOther+"', '"+powerHF+"', '"+powerOther+"', '"+populationHF+"', '"+populationOther+"', '"+lawHF+"', '"+lawOther+"', '"+landsHF+"', '"+landsOther+"', '"+influenceHF+"', '"+influenceOther+"', '"+defenseHF+"', '"+defenseOther+"');";
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
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_House` " +
                    "SET `Hou_Name` = '" + name + "', `Hou_Player` = '" + player + "', `Rea_Name` = '" + realm + "', `Hou_SeatOfPower` = '" + seatOfPower + "', `Hou_LiegeLord` = '" + liegeLord + "', `Hou_Liege` = '" + liege + "' " +
                    "WHERE `Hou_ID` = '" + ID + "'";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }

        public void UpdateHouseResources (int wealth, int power,int population, int law, int lands, int influence, int defense)
        {
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_House` " +
                    "SET `Hou_Wealth` = '"+wealth+"', `Hou_Power` = '"+power+"', `Hou_Population` = '"+population+"', `Hou_Law` = '"+law+"', `Hou_Lands` = '"+lands+"', `Hou_Influence` = '"+influence+"', `Hou_Defense` = '"+defense+"' "+
                    "WHERE `Hou_ID` = '"+ID+"'";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }

        //tbl_HouseChanges
        public void UpdateHouseChanges(int HouChaID,int roll, string fortune, int wealthHF, int wealthOther, int powerHF, int powerOther, int populationHF, int populationOther, int lawHF, int lawOther, int landsHF, int landsOther, int influenceHF, int influenceOther, int defenseHF, int defenseOther)
        {
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_HouseChanges` " +
                    "SET `HouCha_Roll` = '" + roll + "', `HouCha_Fortune` = '" + fortune + "', `HouCha_WealthHF` = '" + wealthHF + "', `HouCha_WealthOther` = '" + wealthOther + "', `HouCha_PowerHF` = '" + powerHF + "', `HouCha_PowerOther` = '" + powerOther + "', `HouCha_PopulationHF` = '" + populationHF + "', `HouCha_PopulationOther` = '" + populationOther + "', `HouCha_LawHF` = '" + lawHF + "', `HouCha_LawOther` = '" + lawOther + "', `HouCha_LandsHF` = '" + landsHF + "', `HouCha_LandsOther` = '" + landsOther + "', `HouCha_InfluenceHF` = '" + influenceHF + "', `HouCha_InfluenceOther` = '" + influenceOther + "', `HouCha_DefenseHF` = '" + defenseHF + "', `HouCha_DefenseOther` = '" + defenseOther + "' " +
                    "WHERE `HouCha_ID` = '" + HouChaID + "'";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }

        //tbl_LandHolding
        public void UpdateLandDetails(int LanHolID, string name, string notes)
        {
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_LandHolding` " +
                    "SET `LanHol_Name` = '" + name + "', `LanHol_Note` = '" + notes + "' " +
                    "WHERE `LanHol_ID` = '" + LanHolID + "'";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_DefenseHolding
        public void UpdateDefenseDetails(string DefHolID, string name, string notes, string built)
        {
            built = built == "True" ? "1" : "0";
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_DefenseHolding` " +
                    "SET `DefHol_Name` = '" + name + "', `DefHol_Notes` = '" + notes + "', `DefHol_Built` = '" + built + "' " +
                    "WHERE `DefHol_ID` = '" + DefHolID + "'";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_LandHoldingFeature
        public void UpdateLandFeatureDetails(string LanHolFeaID, string name, string notes)
        {
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_LandHoldingFeature` " +
                    "SET `LanHolFea_Name` = '" + name + "', `LanHolFea_Note` = '" + notes + "' " +
                    "WHERE `LanHolFea_ID` = '" + LanHolFeaID + "'";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_WealthHolding
        public void UpdateWealthDetails(string WeaHolID, string name, string notes, string built)
        {
            built = built == "True" ? "1" : "0";
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_WealthHolding` " +
                    "SET `WeaHol_Name` = '" + name + "', `WeaHol_Note` = '" + notes + "', `WeaHol_Built` = '" + built + "' " +
                    "WHERE `WeaHol_ID` = '" + WeaHolID + "'";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_Heir
        public void UpdateHeir(string heirID, string name, string notes)
        {
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_Heir` " +
                    "SET `Hei_Name` = '" + name + "', `Hei_Note` = '" + notes + "' " +
                    "WHERE `Hei_ID` = '" + heirID + "'";
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        //tbl_PowerHolding
        public void UpdatePowerHolding(string PowHolID, string name, string training, string damage, string disorganized, string notes, string armorUpg, string fightUpg, string marksUpg, string agility, string animal, string athletics, string awareness, string cunning, string endurance, string fighting, string healing, string language, string knowledge, string marksmanship, string persuasion, string status, string stealth, string survival, string thievery, string warfare, string will)
        {
            armorUpg = armorUpg == "True" ? "1" : "0";
            fightUpg = fightUpg == "True" ? "1" : "0";
            marksUpg = marksUpg == "True" ? "1" : "0";
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "UPDATE `tbl_PowerHolding` " +
                    "SET `PowHol_Name` = '" + name + "', `PowHol_Training` = '" + training + "', `PowHol_Damage` = '" + damage + "', `PowHol_Disorganized` = '" + disorganized + "', `PowHol_Notes` = '" + notes + "', `PowHol_ArmorUp` = '" + armorUpg + "', `PowHol_FightingUp` = '" + fightUpg + "', `PowHol_MarksmashipUp` = '" + marksUpg + "', " +
                    "`PowHol_Agility` = '" + agility + "', `PowHol_AnimalHand` = '" + animal + "', `PowHol_Athletics` = '" + athletics + "', `PowHol_Awareness` = '" + awareness + "', `PowHol_Cunning` = '" + cunning + "', `PowHol_Endurance` = '" + endurance + "', `PowHol_Fighting` = '" + fighting + "', `PowHol_Healing` = '" + healing + "', `PowHol_Language` = '" + language + "', `PowHol_Knowledge` = '" + knowledge + "', `PowHol_Marksmanship` = '" + marksmanship + "', `PowHol_Persuasion` = '" + persuasion + "', `PowHol_Status` = '" + status + "', `PowHol_Stealth` = '" + stealth + "', `PowHol_Survival` = '" + survival + "', `PowHol_Thievery` = '" + thievery + "', `PowHol_Warfare` = '" + warfare + "', `PowHol_Will` = '" + will + "' " +
                    "WHERE `PowHol_ID` = '" + PowHolID + "'";
                DevLog.LogItem(comm.CommandText);
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        ///// DELETE ////////////////////////////////////////////////////////////////
        //tbl_Heir
        public void DeleteHeir(int heir)
        {
            DevLog.LogItem("Deleting from tbl_Heir ID: " + heir);
            if (mysqlConn.ConnOpen())
            {
                MySqlCommand comm = mysqlConn.conn.CreateCommand();
                comm.CommandText = "DELETE FROM `tbl_Heir`" +
                    "WHERE `Hei_ID` = '" + heir + "';";
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
                comm.ExecuteNonQuery();
                mysqlConn.ConnClose();
            }
        }
        ///// VARIABLES START //////////////////////////////////////////////////////

        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////

        ///// METHODS END //////////////////////////////////////////////////////////
        
        ///// EVENTS START //////////////////////////////////////////////////////////

        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
