/*data for tbl_Banner, tbl_DefenseHolding, tbl_Heir, tbl_House, tbl_HouseChanges, tbl_InfluenceHoldingImprovement, tbl_InfluenceHoldings, tbl_LandHolding, tbl_LandHoldingFeature, tbl_PowerHolding, tbl_WealthHolding, tbl_WealthHoldingImprovement*/

-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jun 17, 2019 at 11:43 AM
-- Server version: 5.7.26
-- PHP Version: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mcdonag_ASoIaF`
--

--
-- Dumping data for table `tbl_Banner`
--

INSERT INTO `tbl_Banner` (`Ban_ID`, `HouLie_ID`, `HouBan_ID`) VALUES
(1, 1, 2),
(5, 3, 7),
(7, 3, 5);

--
-- Dumping data for table `tbl_DefenseHolding`
--

INSERT INTO `tbl_DefenseHolding` (`DefHol_ID`, `Def_ID`, `LanHol_ID`, `DefHol_Name`, `DefHol_Built`, `DefHol_Notes`, `DefHol_Discount`) VALUES
(1, 3, 1, 'Castle Kestrel', 1, NULL, 0),
(2, 3, 3, 'Broadhead Castle', 1, NULL, 0),
(4, 1, 6, 'Test Tower 1', 1, '', 0),
(5, 1, 7, 'Boneguard Bridge', 1, NULL, 0),
(6, 2, 15, 'High Castle', 1, 'dqw', 0),
(7, 5, 16, 'High Castle', 1, 'dqw', 0);

--
-- Dumping data for table `tbl_House`
--

INSERT INTO `tbl_House` (`Hou_ID`, `Hou_Name`, `Hou_Player`, `Rea_Name`, `Hou_SeatOfPower`, `Hou_LiegeLord`, `Hou_Liege`, `Hou_Wealth`, `Hou_Power`, `Hou_Population`, `Hou_Law`, `Hou_Lands`, `Hou_Influence`, `Hou_Defense`, `Hou_Founding`, `Hou_HistoricalEvents`) VALUES
(1, 'Archyr', 'Ross', 'The Stormlands', 'Castle Kestrel', 'Davis Archyr', 'Bararheon', 89, 49, 11, 42, 30, 32, 34, 'New', '1: Ascent'),
(2, 'Archyrath', 'Ross', 'The Stormlands', 'Broadhead Castle', 'Danny Archyrath', 'Archyr', 27, 25, 15, 33, 22, 20, 30, 'New', '1: Ascent'),
(3, 'Test 1', 'Test', 'The North', 'Test Castle 1', 'John Smith 1', 'King of north 1', 120, 73, 80, 20, 98, 91, 145, 'Very Old', 'Good history stuff'),
(4, 'Westwatch-by-the-Bridge', 'Ross', 'The Wall', 'Boneguard Bridge', 'Daris Archyr', 'The Crown', 15, 18, 8, 12, 17, 10, 15, 'Ancient', ''),
(5, 'New', 'Test', 'The Mountains of the Moon', 'New Hall', 'Sir Newman', 'Arryn', 20, 20, 7, 3, 18, 39, 45, 'Established', '1: Invasion/Revolt\r\n2: Decline\r\n3: Favor\r\n4: Villain\r\n'),
(6, 'Manul', 'Test', 'The Riverlands', 'Mn Tower', 'Ross Lord', 'Tully', 25, 50, 80, 50, 65, 45, 25, 'Recent', ''),
(7, 'Even Better Name', 'Test', 'Dorne', 'Sunplacegs[g', 'Sunone', 'Martell', 32, 56, 26, 23, 54, 29, 31, 'Very Old', '1: Ascent\r\n2: Treachery\r\n3: Ascent\r\n4: Ascent\r\n5: Infrastructure\r\n6: Victory\r\n');

--
-- Dumping data for table `tbl_HouseChanges`
--

INSERT INTO `tbl_HouseChanges` (`HouCha_ID`, `Hou_ID`, `HouCha_Year`, `HouCha_Month`, `HouCha_Roll`, `HouCha_Fortune`, `HouCha_WealthHF`, `HouCha_WealthOther`, `HouCha_PowerHF`, `HouCha_PowerOther`, `HouCha_PopulationHF`, `HouCha_PopulationOther`, `HouCha_LawHF`, `HouCha_LawOther`, `HouCha_LandsHF`, `HouCha_LandsOther`, `HouCha_InfluenceHF`, `HouCha_InfluenceOther`, `HouCha_DefenseHF`, `HouCha_DefenseOther`) VALUES
(1, 1, 275, 1, NULL, 'Growth', 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0),
(2, 1, 275, 2, NULL, 'Blessing ', 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0),
(3, 1, 275, 3, NULL, 'Blessing', 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0),
(4, 1, 275, 4, NULL, 'Curse', -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0),
(5, 1, 275, 5, NULL, 'Curse', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0),
(6, 1, 275, 6, NULL, 'Boon', 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0),
(7, 1, 275, 7, NULL, 'Blessing ', 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0),
(8, 1, 275, 8, NULL, 'Growth', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(9, 1, 275, 9, NULL, 'Boon ', 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(10, 1, 275, 10, 17, 'Curse', 0, 0, -1, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(11, 1, 275, 11, 15, 'Curse', 0, 0, -1, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(12, 1, 275, 12, 22, 'Blessing', 1, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(13, 1, 276, 1, 39, 'Blessing', 0, 0, 0, 15, 0, -15, 0, 0, 0, 0, 0, 0, 0, 0),
(14, 1, 276, 2, 23, 'Blessing ', 0, 0, 0, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(15, 1, 276, 3, NULL, 'Blessing', 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(16, 1, 276, 4, 18, 'Blessing', 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(17, 1, 276, 5, 17, 'Decline', -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(18, 1, 276, 6, NULL, 'Take Growth', 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0),
(19, 1, 276, 7, 30, 'Blessing', 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0),
(20, 1, 276, 8, 30, 'Blessing', 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(21, 1, 276, 9, 37, 'Growth', 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(22, 1, 276, 10, 29, 'Blessing', 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(24, 1, 276, 11, 42, 'Blessing', 6, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(25, 1, 276, 12, 30, 'Blessing', 4, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(26, 1, 277, 1, NULL, 'Blessing', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0),
(27, 1, 277, 2, 31, 'Growth', 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(28, 7, 275, 2, 26, 'Blessing', 1, 0, 0, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(29, 7, 275, 3, 25, 'Growth', 1, 0, 0, 1, 1, 0, 1, 0, 0, 2, 1, 0, 0, 1),
(30, 7, 275, 4, 20, 'Blessing', 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, -2),
(31, 7, 275, 5, 20, 'Blessing', 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0),
(32, 7, 275, 6, 2, 'Disaster', -3, 0, 0, 0, 0, 2, 0, 0, -1, 0, 0, 0, 0, 0),
(33, 3, 275, 1, 0, 'Disaster', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 0, 0, 0),
(34, 3, 275, 2, 20, 'Blessing', 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(35, 3, 275, 3, NULL, 'Blessing', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 4, 0, 0);

--
-- Dumping data for table `tbl_InfluenceHoldings`
--

INSERT INTO `tbl_InfluenceHoldings` (`InfHol_ID`, `Inf_ID`, `Hou_ID`, `InfHol_Name`, `InfHol_Built`, `InfHol_Note`, `InfHol_Discount`) VALUES
(2, 9, 1, 'Jarrad Sargen', 1, NULL, 0),
(5, 13, 3, 'Test Townhouse', 1, 'In King\'s Landing', 0),
(6, 4, 3, 'Archy Test', 1, NULL, 0);

--
-- Dumping data for table `tbl_LandHolding`
--

INSERT INTO `tbl_LandHolding` (`LanHol_ID`, `Hou_ID`, `Lan_ID`, `LanHol_Name`, `LanHol_Note`, `LanHol_Discount`) VALUES
(1, 1, 3, 'Grejyt Hills', NULL, 0),
(2, 1, 2, 'Scatterd Plains', NULL, 0),
(3, 2, 2, 'Arvern Plains', NULL, 0),
(5, 3, 1, 'Wet Test1', '', 0),
(6, 3, 2, 'Plane Test', NULL, 0),
(7, 4, 4, 'The Wall', 'asojkix', 9),
(8, 4, 2, 'The Gift 1', NULL, 0),
(9, 4, 2, 'The Gift 2', NULL, 0),
(10, 5, 3, 'New Land Holdings', 'Hills are best', 1),
(11, 5, 1, 'New Land Holdings', 'Tis wet HA', 0),
(12, 5, 4, 'New Land Holdings', 'Very Very high 420', 2),
(15, 7, 2, 'Down Low :)', 'uhguyhgvuyofgyuig', 1),
(16, 7, 3, 'Up High rg', 'Diffref note\n\n\ntyjnwtyh', 0);

--
-- Dumping data for table `tbl_LandHoldingFeature`
--

INSERT INTO `tbl_LandHoldingFeature` (`LanHolFea_ID`, `LanFea_ID`, `LanHol_ID`, `LanHolFea_Name`, `LanHolFea_Note`) VALUES
(1, 1, 1, 'Apical Spot', 'Meaning: A visible spot near the outer tip of a feather.'),
(2, 8, 1, 'Ebbroc Road', NULL),
(3, 15, 2, 'Faint Woods', NULL),
(5, 3, 6, 'Test Town 1', ''),
(6, 11, 6, 'Test River', NULL),
(8, 1, 3, 'Fletcher’s Point				', NULL),
(9, 16, 8, 'Gift Woods', NULL),
(10, 6, 9, 'Grass Gift', NULL),
(13, 2, 16, 'Fuck People ', '');

--
-- Dumping data for table `tbl_PowerHolding`
--

INSERT INTO `tbl_PowerHolding` (`PowHol_ID`, `Uni_ID`, `Hou_ID`, `PowHol_Name`, `PowHol_Training`, `PowHol_Discount`, `PowHol_Agility`, `PowHol_AnimalHand`, `PowHol_Athletics`, `PowHol_Awareness`, `PowHol_Cunning`, `PowHol_Endurance`, `PowHol_Fighting`, `PowHol_Healing`, `PowHol_Language`, `PowHol_Knowledge`, `PowHol_Marksmanship`, `PowHol_Persuasion`, `PowHol_Status`, `PowHol_Stealth`, `PowHol_Survival`, `PowHol_Thievery`, `PowHol_Warfare`, `PowHol_Will`, `PowHol_ArmorUp`, `PowHol_FightingUp`, `PowHol_MarksmashipUp`, `PowHol_Damage`, `PowHol_Disorganized`, `PowHol_Notes`) VALUES
(1, 6, 1, 'Gull', 'Trained', 0, 2, 2, 2, 3, 2, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 0, 0, 0, 0, ''),
(2, 11, 1, 'Blackbird', 'Elite', 0, 2, 2, 4, 2, 2, 5, 4, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 0, 0, 0, ''),
(3, 8, 1, 'Sanderling', 'Green', 0, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 1, 0, 0, 0, ''),
(4, 1, 1, 'Sparrow', 'Green', 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 0, 0, 1, 0, 0, ''),
(5, 6, 2, 'Goby', 'Veteran', 0, 2, 2, 2, 4, 2, 4, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 0, 0, 0, 0, ''),
(6, 17, 2, 'Hammerjaw', 'Trained', 0, 2, 2, 2, 3, 2, 2, 3, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 1, 0, 0, 0, 0, ''),
(7, 1, 2, 'Sole Shots', 'Veteran', 0, 4, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 2, 2, 2, 2, 2, 2, 2, 0, 0, 1, 0, 0, ''),
(8, 6, 3, 'Testy Garud', 'Trained', 0, 2, 2, 2, 3, 2, 2, 4, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 2, 0, ''),
(9, 2, 4, 'Dawns Glare', 'Veteran', 2, 4, 2, 2, 2, 2, 3, 4, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 1, 0, 0, 0, ''),
(10, 14, 4, 'Abyess Seekers', 'Trained', 0, 2, 2, 2, 3, 2, 3, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 0, 0, 0, 0, 0, ''),
(11, 6, 4, 'Boneguard', 'Trained', 0, 2, 2, 2, 3, 2, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, ''),
(12, 1, 3, 'Test Arrow', 'Trained', 0, 6, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 1, 0, 0, 0, 0, 'Tis bows'),
(13, 8, 3, 'Army', 'Green', 0, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, ''),
(14, 11, 3, 'Gaurd', 'Green', 0, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, 'GACSIUG'),
(15, 17, 3, 'Watersip', 'Trained', 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, ''),
(18, 8, 7, 'STRONG', 'Elite', 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 0, 0, 0, 0, 0, 'LOTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTSSS NOTES'),
(19, 17, 7, 'Discount Testy', 'Elite', 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 0, 1, 0, 0, ''),
(20, 13, 3, 'wef', 'Trained', 0, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, '');

--
-- Dumping data for table `tbl_WealthHolding`
--

INSERT INTO `tbl_WealthHolding` (`WeaHol_ID`, `Wea_ID`, `LanHol_ID`, `DefHol_ID`, `LanHolFea_ID`, `WeaHol_Name`, `WeaHol_Built`, `WeaHol_Note`, `WeaHol_Discount`) VALUES
(1, 44, NULL, 1, NULL, 'Maester Dasher', 1, '', 0),
(2, 46, NULL, 1, NULL, 'Ser Lucas Buck', 1, 'Will be finished in M3 277', 0),
(3, 38, NULL, 1, NULL, 'Archyr\'s Bows', 1, NULL, 0),
(4, 12, 1, NULL, NULL, 'Dragon Glass Mine', 1, 'Has Dragon Glass', 0),
(5, 22, 1, NULL, NULL, 'Arrows Flight', 1, 'Happen in M7.\nWant to run tournaments at the time.', 0),
(6, 53, NULL, 1, NULL, '', 1, 'Spy 1 - The Citdale\nSpy 2 - Kings Landing\nSpy 3 - Dead - Back in M4 277', 0),
(7, 55, NULL, NULL, 1, 'The Hawks', 1, 'Eyes Everywhere will be finished in M6 277', 0),
(8, 57, 2, NULL, NULL, 'Sept to the Crone', 1, NULL, 0),
(9, 5, 3, NULL, NULL, 'Arvern Fishery', 1, NULL, 0),
(10, 22, 3, NULL, NULL, 'Arrows Flight', 1, NULL, 0),
(11, 46, NULL, 2, NULL, 'Lartel Shepherd', 1, NULL, 0),
(13, 70, NULL, NULL, 5, 'Test Tourny 3', 1, '', 0),
(15, 56, NULL, 4, NULL, 'Jeff Testy', 1, '', 2),
(16, 70, NULL, NULL, 8, 'Flectcher\'s Fields', 0, 'Will be built in M6 277', 0),
(17, 9, 9, NULL, NULL, 'Skeletal Steeds', 1, '', 0),
(18, 72, NULL, 5, NULL, 'Bone Gate', 0, 'Bulit in M8', 0),
(19, 66, NULL, NULL, 5, 'Testy Pipes 3', 0, '', 0),
(20, 22, NULL, 7, NULL, 'High Party', 0, 'Woooooooooooooooo Party', 0),
(21, 10, 16, NULL, NULL, 'Cloud Mine', 1, 'Ti hi', 0),
(22, 57, 16, NULL, NULL, 'High Ab', 0, 'icvhwoefvuir', 2),
(23, 9, 15, NULL, NULL, '', 1, '', 0),
(24, 5, 6, NULL, NULL, '', 0, '', 0),
(35, 40, NULL, NULL, 5, '', 0, '', 0);

--
-- Dumping data for table `tbl_WealthHoldingImprovement`
--

INSERT INTO `tbl_WealthHoldingImprovement` (`WeaHolImp_ID`, `WeaHol_ID`, `WeaImp_ID`, `WeaHolImp_Built`) VALUES
(1, 3, 60, 1),
(2, 2, 73, 1),
(3, 7, 87, 0),
(4, 13, 113, 1),
(6, 17, 23, 1),
(7, 21, 27, 0),
(8, 22, 91, 0),
(11, 23, 24, 1),
(15, 35, 68, 0),
(16, 35, 67, 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
