/*data for tbl_Banner, tbl_DefenseHolding, tbl_Heir, tbl_House, tbl_HouseChanges, tbl_InfluenceHoldingImprovement, tbl_InfluenceHoldings, tbl_LandHolding, tbl_LandHoldingFeature, tbl_PowerHolding, tbl_WealthHolding, tbl_WealthHoldingImprovement*/

-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 02, 2019 at 09:31 AM
-- Server version: 5.7.25
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
-- Database: `mcdonag5_ASoIaF`
--

--
-- Dumping data for table `tbl_Banner`
--

INSERT INTO `tbl_Banner` (`Ban_ID`, `HouLie_ID`, `HouBan_ID`) VALUES
(1, 1, 2);

--
-- Dumping data for table `tbl_DefenseHolding`
--

INSERT INTO `tbl_DefenseHolding` (`DefHol_ID`, `Def_ID`, `LanHol_ID`, `DefHol_Name`, `DefHol_Notes`, `DefHol_Discount`) VALUES
(1, 3, 1, 'Castle Kestrel', NULL, 0),
(2, 3, 3, 'Broadhead Castle', NULL, 0),
(3, 3, 4, 'Testy Castle', NULL, 0),
(4, 1, 6, 'Test Tower', NULL, 0),
(5, 1, 7, 'Boneguard Bridge', NULL, 0);

--
-- Dumping data for table `tbl_Heir`
--

INSERT INTO `tbl_Heir` (`Hei_ID`, `Hou_ID`, `Hei_Name`, `Hei_Gender`) VALUES
(1, 3, 'Kyle Smith', 'M'),
(2, 1, 'Keaton Archyr', 'M'),
(3, 2, 'Blane Archyrath', 'M');

--
-- Dumping data for table `tbl_House`
--

INSERT INTO `tbl_House` (`Hou_ID`, `Hou_Name`, `Hou_Player`, `Rea_Name`, `Hou_SeatOfPower`, `Hou_LiegeLord`, `Hou_Liege`, `Hou_Wealth`, `Hou_Power`, `Hou_Population`, `Hou_Law`, `Hou_Lands`, `Hou_Influence`, `Hou_Defense`, `Hou_Founding`, `Hou_HistoricalEvents`) VALUES
(1, 'Archyr', 'Ross', 'The Stormlands', 'Castle Kestrel', 'Davis Archyr', 'Bararheon', 87, 49, 11, 42, 30, 32, 34, 'New', 'Ascent'),
(2, 'Archyrath', 'Ross', 'The Stormlands', 'Broadhead Castle', 'Danny Archyrath', 'Archyr', 25, 25, 15, 33, 22, 20, 30, 'New', 'Ascent'),
(3, 'Test', 'NPC', 'The North', 'Test Castle', 'John Smith', 'King of north', 120, 70, 80, 20, 98, 78, 145, 'Very Old', 'Good history stuff'),
(4, 'Westwatch-by-the-Bridge', 'Ross', 'The Wall', 'Boneguard Bridge', 'Daris Archyr', 'The Crown', 15, 18, 8, 12, 17, 10, 15, 'Ancient', ''),
(5, 'New', 'NPC', 'The Mountains of the Moon', 'New Hall', 'Sir Newman', 'Arryn', 20, 20, 7, 3, 18, 39, 45, 'Established', 'Event List\r\n1: Invasion/Revolt\r\n2: Decline\r\n3: Favor\r\n4: Villain\r\n'),
(6, 'Manul', 'NPC', 'The Riverlands', 'Mn Tower', 'Ross Lord', 'Tully', 25, 50, 80, 50, 65, 45, 25, 'Recent', 'Event List\r\n');

--
-- Dumping data for table `tbl_InfluenceHoldingImprovement`
--

INSERT INTO `tbl_InfluenceHoldingImprovement` (`InfHolImp_ID`, `InfImp_ID`, `InfHol_ID`, `InfHolImp_Built`) VALUES
(1, 2, 6, 1),
(3, 1, 6, 1);

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
(4, 3, 3, 'Test Hill', NULL, 0),
(5, 3, 1, 'Wet Test', NULL, 0),
(6, 3, 2, 'Plane Test', NULL, 0),
(7, 4, 4, 'The Wall', NULL, 9),
(8, 4, 2, 'The Gift 1', NULL, 0),
(9, 4, 2, 'The Gift 2', NULL, 0);

--
-- Dumping data for table `tbl_LandHoldingFeature`
--

INSERT INTO `tbl_LandHoldingFeature` (`LanHolFea_ID`, `LanFea_ID`, `LanHol_ID`, `LanHolFea_Name`, `LanHolFea_Note`) VALUES
(1, 1, 1, 'Apical Spot', 'Meaning: A visible spot near the outer tip of a feather.'),
(2, 8, 1, 'Ebbroc Road', NULL),
(3, 15, 2, 'Faint Woods', NULL),
(4, 14, 3, 'Arvern Coast', NULL),
(5, 3, 6, 'Test Town', NULL),
(6, 11, 6, 'Test River', NULL),
(7, 15, 4, 'Test Woods', NULL),
(8, 1, 3, 'Fletcher’s point 										', NULL),
(9, 16, 8, 'Gift Woods', NULL),
(10, 6, 9, 'Grass Gift', NULL);

--
-- Dumping data for table `tbl_PowerHolding`
--

INSERT INTO `tbl_PowerHolding` (`PowHol_ID`, `Uni_ID`, `Hou_ID`, `PowHol_Name`, `PowHol_Training`, `PowHol_Discount`, `PowHol_Agility`, `PowHol_AnimalHand`, `PowHol_Athletics`, `PowHol_Awareness`, `PowHol_Cunning`, `PowHol_Endurance`, `PowHol_Fighting`, `PowHol_Healing`, `PowHol_Language`, `PowHol_Knowledge`, `PowHol_Marksmanship`, `PowHol_Persuasion`, `PowHol_Status`, `PowHol_Stealth`, `PowHol_Survival`, `PowHol_Thievery`, `PowHol_Warfare`, `PowHol_Will`, `PowHol_ArmorUp`, `PowHol_FightingUp`, `PowHol_MarksmashipUp`, `PowHol_Damage`, `PowHol_Disorganized`) VALUES
(1, 6, 1, 'Gull', 'Trained', 0, 2, 2, 2, 3, 2, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, NULL, NULL, NULL, 0, 0),
(2, 11, 1, 'Blackbird', 'Elite', 0, 2, 2, 4, 2, 2, 5, 4, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, NULL, NULL, 0, 0),
(3, 8, 1, 'Sanderling', 'Green', 0, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, NULL, NULL, NULL, 0, 0),
(4, 1, 1, 'Sparrow', 'Green', 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, NULL, NULL, NULL, 0, 0),
(5, 6, 2, 'Goby', 'Veteran', 0, 2, 2, 2, 4, 2, 4, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, NULL, NULL, 0, 0),
(6, 17, 2, 'Hammerjaw', 'Trained', 0, 2, 2, 2, 3, 2, 2, 3, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 1, NULL, NULL, 0, 0),
(7, 1, 2, 'Sole Shots', 'Veteran', 0, 4, 2, 2, 2, 2, 2, 2, 2, 2, 2, 5, 2, 2, 2, 2, 2, 2, 2, NULL, NULL, 1, 0, 0),
(8, 6, 3, 'Testy Garud', 'Green', 0, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, NULL, 1, NULL, 0, 0),
(9, 2, 4, 'Dawns Glare', 'Veteran', 2, 4, 2, 2, 2, 2, 3, 4, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, NULL, 1, NULL, 0, 0),
(10, 14, 4, 'Abyess Seekers', 'Trained', 0, 2, 2, 2, 3, 2, 3, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, NULL, NULL, NULL, 0, 0),
(11, 6, 4, 'Boneguard', 'Trained', 0, 2, 2, 2, 3, 2, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, NULL, NULL, NULL, 0, 0);

--
-- Dumping data for table `tbl_WealthHolding`
--

INSERT INTO `tbl_WealthHolding` (`WeaHol_ID`, `Wea_ID`, `LanHol_ID`, `DefHol_ID`, `LanHolFea_ID`, `WeaHol_Name`, `WeaHol_Built`, `WeaHol_Note`, `WeaHol_Discount`) VALUES
(1, 44, NULL, 1, NULL, 'Maester Dasher', 1, NULL, 0),
(2, 46, NULL, 1, NULL, 'Ser Lucas Buck', 0, 'Will be finished in M3 277', 0),
(3, 38, NULL, 1, NULL, 'Archyr\'s Bows', 1, NULL, 0),
(4, 12, 1, NULL, NULL, 'Dragon Glass Mine', 1, 'Has Dragon Glass', 0),
(5, 22, 1, NULL, NULL, 'Arrows Flight', 1, 'Happen in M7.\r\nWant to run tournaments at the time.', 0),
(6, 53, NULL, 1, NULL, '', 1, NULL, 0),
(7, 55, NULL, NULL, 1, 'The Hawks', 1, 'Eyes Everywhere will be finished in M6 277', 0),
(8, 57, 2, NULL, NULL, 'Sept to the Crone', 1, NULL, 0),
(9, 5, 3, NULL, NULL, 'Arvern Fishery', 1, NULL, 0),
(10, 22, 3, NULL, NULL, 'Arrows Flight', 1, NULL, 0),
(11, 46, NULL, 2, NULL, 'PUT NAME', 1, NULL, 0),
(12, 28, NULL, 3, NULL, 'Test Bokks', 1, NULL, 0),
(13, 70, NULL, NULL, 5, 'Test Tourny', 1, NULL, 0),
(14, 7, 5, NULL, NULL, 'Wet Fur Test', 1, NULL, 0),
(15, 56, NULL, 4, NULL, 'Jeff Testy', 1, NULL, 2),
(16, 70, NULL, NULL, 8, 'Flectcher\'s Fields', 0, 'Will be built in M6 277', 0),
(17, 9, 9, NULL, NULL, 'Horse Gifts', 1, NULL, 0),
(18, 72, NULL, 5, NULL, 'Bone Gate', 0, 'Bulit in M8', 0),
(19, 66, NULL, NULL, 5, 'Testy Pipes', 1, NULL, 0);

--
-- Dumping data for table `tbl_WealthHoldingImprovement`
--

INSERT INTO `tbl_WealthHoldingImprovement` (`WeaHolImp_ID`, `WeaHol_ID`, `WeaImp_ID`, `WeaHolImp_Built`) VALUES
(1, 3, 60, 1),
(2, 2, 73, 0),
(3, 7, 87, 0),
(4, 13, 113, 1),
(5, 14, 18, 1),
(6, 17, 23, 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
