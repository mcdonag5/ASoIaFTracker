/*Structure for all tables*/

-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 16, 2019 at 08:42 AM
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

-- --------------------------------------------------------

--
-- Table structure for table `tbl_Banner`
--

CREATE TABLE `tbl_Banner` (
  `Ban_ID` int(11) NOT NULL,
  `HouLie_ID` int(11) NOT NULL,
  `HouBan_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_Defense`
--

CREATE TABLE `tbl_Defense` (
  `Def_ID` int(11) NOT NULL,
  `Def_Name` tinytext COLLATE utf8mb4_unicode_ci NOT NULL,
  `Def_DefenseCost` tinyint(2) NOT NULL,
  `Def_BuildTime` tinytext COLLATE utf8mb4_unicode_ci NOT NULL,
  `Def_Description` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `Def_Benefit` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `Def_Spaces` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_DefenseHolding`
--

CREATE TABLE `tbl_DefenseHolding` (
  `DefHol_ID` int(11) NOT NULL,
  `Def_ID` int(11) NOT NULL,
  `LanHol_ID` int(11) NOT NULL,
  `DefHol_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `DefHol_Notes` text COLLATE utf8mb4_unicode_ci,
  `DefHol_Discount` int(2) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_Heir`
--

CREATE TABLE `tbl_Heir` (
  `Hei_ID` int(11) NOT NULL,
  `Hou_ID` int(11) NOT NULL,
  `Hei_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Hei_Gender` varchar(1) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_HistoricalEvents`
--

CREATE TABLE `tbl_HistoricalEvents` (
  `His_ID` int(11) NOT NULL,
  `His_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `His_Description` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `His_FirstDescription` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `His_WealthMod` int(1) NOT NULL,
  `His_PowerMod` int(1) NOT NULL,
  `His_PopulationMod` int(1) NOT NULL,
  `His_LawMod` int(1) NOT NULL,
  `His_LandMod` int(1) NOT NULL,
  `His_InfluenceMod` int(1) NOT NULL,
  `His_DefenseMod` int(1) NOT NULL,
  `His_ResourceMod` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_House`
--

CREATE TABLE `tbl_House` (
  `Hou_ID` int(11) NOT NULL,
  `Hou_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Hou_Player` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Rea_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Hou_SeatOfPower` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Hou_LiegeLord` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Hou_Liege` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Hou_Wealth` smallint(3) NOT NULL,
  `Hou_Power` smallint(3) NOT NULL,
  `Hou_Population` smallint(3) NOT NULL,
  `Hou_Law` smallint(3) NOT NULL,
  `Hou_Lands` smallint(3) NOT NULL,
  `Hou_Influence` smallint(3) NOT NULL,
  `Hou_Defense` smallint(3) NOT NULL,
  `Hou_Founding` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Hou_HistoricalEvents` text COLLATE utf8mb4_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_HouseChanges`
--

CREATE TABLE `tbl_HouseChanges` (
  `HouCha_ID` int(11) NOT NULL,
  `Hou_ID` int(11) NOT NULL,
  `HouCha_Year` int(3) NOT NULL,
  `HouCha_Month` int(2) DEFAULT NULL,
  `HouCha_Roll` int(2) DEFAULT NULL,
  `HouCha_Fortune` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `HouCha_WealthHF` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_WealthOther` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_PowerHF` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_PowerOther` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_PopulationHF` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_PopulationOther` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_LawHF` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_LawOther` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_LandsHF` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_LandsOther` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_InfluenceHF` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_InfluenceOther` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_DefenseHF` smallint(2) NOT NULL DEFAULT '0',
  `HouCha_DefenseOther` smallint(2) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_Influence`
--

CREATE TABLE `tbl_Influence` (
  `Inf_ID` int(11) NOT NULL,
  `Inf_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Inf_InfluenceCost` int(2) NOT NULL,
  `Inf_Description` text COLLATE utf8mb4_unicode_ci,
  `Inf_Benefit` text COLLATE utf8mb4_unicode_ci,
  `Inf_DefenseGain` int(2) NOT NULL,
  `Inf_InfluenceGain` int(2) NOT NULL,
  `Inf_LandGain` int(2) NOT NULL,
  `Inf_LawGain` int(2) NOT NULL,
  `Inf_PopulationGain` int(2) NOT NULL,
  `Inf_PowerGain` int(2) NOT NULL,
  `Inf_WealthGain` int(2) NOT NULL,
  `Inf_LawPenaltyReduction` int(11) NOT NULL DEFAULT '0',
  `Inf_PopulationPenaltyReduction` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_InfluenceHoldingImprovement`
--

CREATE TABLE `tbl_InfluenceHoldingImprovement` (
  `InfHolImp_ID` int(11) NOT NULL,
  `InfImp_ID` int(11) NOT NULL,
  `InfHol_ID` int(11) NOT NULL,
  `InfHolImp_Built` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_InfluenceHoldings`
--

CREATE TABLE `tbl_InfluenceHoldings` (
  `InfHol_ID` int(11) NOT NULL,
  `Inf_ID` int(11) NOT NULL,
  `Hou_ID` int(11) NOT NULL,
  `InfHol_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `InfHol_Built` tinyint(1) DEFAULT NULL,
  `InfHol_Note` text COLLATE utf8mb4_unicode_ci,
  `InfHol_Discount` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_InfluenceImprovemnt`
--

CREATE TABLE `tbl_InfluenceImprovemnt` (
  `InfImp_ID` int(11) NOT NULL,
  `Inf_ID` int(11) NOT NULL,
  `InfImp_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `InfImp_InfluenceCost` int(2) NOT NULL,
  `InfImp_Description` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `InfImp_Benefit` text COLLATE utf8mb4_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_Land`
--

CREATE TABLE `tbl_Land` (
  `Lan_ID` int(11) NOT NULL,
  `Lan_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Lan_LandCost` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_LandFeature`
--

CREATE TABLE `tbl_LandFeature` (
  `LanFea_ID` int(11) NOT NULL,
  `LanFea_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `LanFea_LandCost` int(2) NOT NULL,
  `LanFea_PopulationCost` int(2) NOT NULL,
  `LanFea_Spaces` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_LandHolding`
--

CREATE TABLE `tbl_LandHolding` (
  `LanHol_ID` int(11) NOT NULL,
  `Hou_ID` int(11) NOT NULL,
  `Lan_ID` int(11) NOT NULL,
  `LanHol_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `LanHol_Note` text COLLATE utf8mb4_unicode_ci,
  `LanHol_Discount` int(2) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_LandHoldingFeature`
--

CREATE TABLE `tbl_LandHoldingFeature` (
  `LanHolFea_ID` int(11) NOT NULL,
  `LanFea_ID` int(11) NOT NULL,
  `LanHol_ID` int(11) NOT NULL,
  `LanHolFea_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `LanHolFea_Note` text COLLATE utf8mb4_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_PowerHolding`
--

CREATE TABLE `tbl_PowerHolding` (
  `PowHol_ID` int(11) NOT NULL,
  `Uni_ID` int(11) NOT NULL,
  `Hou_ID` int(11) NOT NULL,
  `PowHol_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `PowHol_Training` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `PowHol_Discount` int(2) NOT NULL,
  `PowHol_Agility` int(1) NOT NULL DEFAULT '2',
  `PowHol_AnimalHand` int(1) NOT NULL DEFAULT '2',
  `PowHol_Athletics` int(1) NOT NULL DEFAULT '2',
  `PowHol_Awareness` int(1) NOT NULL DEFAULT '2',
  `PowHol_Cunning` int(1) NOT NULL DEFAULT '2',
  `PowHol_Endurance` int(1) NOT NULL DEFAULT '2',
  `PowHol_Fighting` int(1) NOT NULL DEFAULT '2',
  `PowHol_Healing` int(1) NOT NULL DEFAULT '2',
  `PowHol_Language` int(1) NOT NULL DEFAULT '2',
  `PowHol_Knowledge` int(1) NOT NULL DEFAULT '2',
  `PowHol_Marksmanship` int(1) NOT NULL DEFAULT '2',
  `PowHol_Persuasion` int(1) NOT NULL DEFAULT '2',
  `PowHol_Status` int(1) NOT NULL DEFAULT '2',
  `PowHol_Stealth` int(1) NOT NULL DEFAULT '2',
  `PowHol_Survival` int(1) NOT NULL DEFAULT '2',
  `PowHol_Thievery` int(1) NOT NULL DEFAULT '2',
  `PowHol_Warfare` int(1) NOT NULL DEFAULT '2',
  `PowHol_Will` int(1) NOT NULL DEFAULT '2',
  `PowHol_ArmorUp` tinyint(1) DEFAULT NULL,
  `PowHol_FightingUp` tinyint(1) DEFAULT NULL,
  `PowHol_MarksmashipUp` tinyint(1) DEFAULT NULL,
  `PowHol_Damage` int(2) NOT NULL DEFAULT '0',
  `PowHol_Disorganized` int(2) NOT NULL DEFAULT '0',
  `PowHol_Notes` text COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_Qualities`
--

CREATE TABLE `tbl_Qualities` (
  `Qua_ID` int(11) NOT NULL,
  `Qua_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Qua_Type` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Qua_Description` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `Qua_Requirement` text COLLATE utf8mb4_unicode_ci,
  `Qua_Effects` text COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_Realms`
--

CREATE TABLE `tbl_Realms` (
  `Rea_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Rea_Liege` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Rea_Description` text COLLATE utf8mb4_unicode_ci,
  `Rea_WealthModifier` int(2) NOT NULL,
  `Rea_PowerModifier` int(2) NOT NULL,
  `Rea_PopulationModifier` int(2) NOT NULL,
  `Rea_LawModifier` int(2) NOT NULL,
  `Rea_LandsModifier` int(2) NOT NULL,
  `Rea_InfluenceModifier` int(2) NOT NULL,
  `Rea_DefenseModifier` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_UnitTraning`
--

CREATE TABLE `tbl_UnitTraning` (
  `Tra_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Tra_TrainingCost` int(2) NOT NULL,
  `Tra_Discipline` int(2) NOT NULL,
  `Tra_Experience` int(3) NOT NULL,
  `Tra_Description` text COLLATE utf8mb4_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_UnitType`
--

CREATE TABLE `tbl_UnitType` (
  `Uni_ID` int(11) NOT NULL,
  `Uni_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Uni_PowerCost` int(2) NOT NULL,
  `Uni_DisciplineModifier` int(3) NOT NULL,
  `Uni_KeyAbilities` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `Uni_KeyAbilitie2` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Uni_KeyAbilitie3` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Uni_Description` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `Uni_ArmorRating` int(2) NOT NULL,
  `Uni_UpArmorRating` int(2) NOT NULL,
  `Uni_ArmorPenalty` int(2) DEFAULT NULL,
  `Uni_UpArmorPenalty` int(2) DEFAULT NULL,
  `Uni_Bulk` int(2) DEFAULT NULL,
  `Uni_UpBulk` int(2) DEFAULT NULL,
  `Uni_FightingDamage` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Uni_UpFightingDamage` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Uni_MarksmanshipDamage` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Uni_UpMarksmanshipDamage` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Uni_MarksmanshipRange` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_Wealth`
--

CREATE TABLE `tbl_Wealth` (
  `Wea_ID` int(11) NOT NULL,
  `Wea_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Wea_Type` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Wea_TakesSpace` tinyint(1) DEFAULT NULL,
  `Wea_WealthCost` int(2) NOT NULL,
  `Wea_DefenseCost` int(2) NOT NULL,
  `Wea_LandCost` int(2) DEFAULT NULL,
  `Wea_PowerCost` int(2) DEFAULT NULL,
  `Wea_Time` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Wea_Requirement` text COLLATE utf8mb4_unicode_ci,
  `Wea_Description` text COLLATE utf8mb4_unicode_ci,
  `Wea_Benefits` text COLLATE utf8mb4_unicode_ci,
  `Wea_HouseFortune` int(2) NOT NULL,
  `Wea_WealthGain` int(2) NOT NULL,
  `Wea_PowerGain` int(2) NOT NULL,
  `Wea_PopulationGain` int(2) NOT NULL,
  `Wea_LawGain` int(2) NOT NULL,
  `Wea_LandsGain` int(2) NOT NULL,
  `Wea_InfluenceGain` int(2) NOT NULL,
  `Wea_DefenseGain` int(2) NOT NULL,
  `Wea_WealthLoss` int(2) NOT NULL,
  `Wea_PowerLoss` int(2) NOT NULL,
  `Wea_PopulationLoss` int(2) NOT NULL,
  `Wea_LawLoss` int(2) NOT NULL,
  `Wea_LandsLoss` int(2) NOT NULL,
  `Wea_InfluenceLoss` int(2) NOT NULL,
  `Wea_DefenseLoss` int(2) NOT NULL,
  `Wea_LawPenaltyReduction` int(2) NOT NULL,
  `Wea_PopulationPenaltyReduction` int(2) NOT NULL,
  `Wea_HouseAction` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_WealthHolding`
--

CREATE TABLE `tbl_WealthHolding` (
  `WeaHol_ID` int(11) NOT NULL,
  `Wea_ID` int(11) NOT NULL,
  `LanHol_ID` int(11) DEFAULT NULL,
  `DefHol_ID` int(11) DEFAULT NULL,
  `LanHolFea_ID` int(11) DEFAULT NULL,
  `WeaHol_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `WeaHol_Built` tinyint(1) DEFAULT NULL,
  `WeaHol_Note` text COLLATE utf8mb4_unicode_ci,
  `WeaHol_Discount` int(2) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_WealthHoldingImprovement`
--

CREATE TABLE `tbl_WealthHoldingImprovement` (
  `WeaHolImp_ID` int(11) NOT NULL,
  `WeaHol_ID` int(11) NOT NULL,
  `WeaImp_ID` int(11) NOT NULL,
  `WeaHolImp_Built` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_WealthImprovement`
--

CREATE TABLE `tbl_WealthImprovement` (
  `WeaImp_ID` int(11) NOT NULL,
  `Wea_ID` int(11) NOT NULL,
  `WeaImp_Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `WeaImp_Limit` tinyint(1) DEFAULT NULL,
  `WeaImp_WealthCost` int(2) NOT NULL,
  `WeaImp_DefenseCost` int(2) NOT NULL,
  `WeaImp_LandCost` int(2) NOT NULL,
  `WeaImp_PowerCost` int(2) NOT NULL,
  `WeaImp_InfluenceCost` int(2) DEFAULT NULL,
  `WeaImp_Time` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `WeaImp_Requirement` text COLLATE utf8mb4_unicode_ci,
  `WeaImp_Description` text COLLATE utf8mb4_unicode_ci,
  `WeaImp_Benefits` text COLLATE utf8mb4_unicode_ci,
  `WeaImp_HouseFortune` int(2) NOT NULL,
  `WeaImp_WealthGain` int(2) NOT NULL,
  `WeaImp_PowerGain` int(2) NOT NULL,
  `WeaImp_PopulationGain` int(2) NOT NULL,
  `WeaImp_LawGain` int(2) NOT NULL,
  `WeaImp_LandsGain` int(2) NOT NULL,
  `WeaImp_InfluenceGain` int(2) NOT NULL,
  `WeaImp_DefenseGain` int(2) NOT NULL,
  `WeaImp_WealthLoss` int(2) NOT NULL,
  `WeaImp_PowerLoss` int(2) NOT NULL,
  `WeaImp_PopulationLoss` int(2) NOT NULL,
  `WeaImp_LawLoss` int(2) NOT NULL,
  `WeaImp_LandsLoss` int(2) NOT NULL,
  `WeaImp_InfluenceLoss` int(2) NOT NULL,
  `WeaImp_DefenseLoss` int(2) NOT NULL,
  `WeaImp_LawPenaltyReduction` int(11) NOT NULL,
  `WeaImp_PopulationPenaltyReduction` int(11) NOT NULL,
  `WeaImp_HouseAction` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_Banner`
--
ALTER TABLE `tbl_Banner`
  ADD PRIMARY KEY (`Ban_ID`),
  ADD UNIQUE KEY `Ban_ID` (`Ban_ID`),
  ADD KEY `HouLie_ID` (`HouLie_ID`),
  ADD KEY `HouBan_ID` (`HouBan_ID`);

--
-- Indexes for table `tbl_Defense`
--
ALTER TABLE `tbl_Defense`
  ADD PRIMARY KEY (`Def_ID`);

--
-- Indexes for table `tbl_DefenseHolding`
--
ALTER TABLE `tbl_DefenseHolding`
  ADD PRIMARY KEY (`DefHol_ID`),
  ADD UNIQUE KEY `DefHol_ID` (`DefHol_ID`),
  ADD KEY `Def_ID` (`Def_ID`),
  ADD KEY `LanHol_ID` (`LanHol_ID`);

--
-- Indexes for table `tbl_Heir`
--
ALTER TABLE `tbl_Heir`
  ADD PRIMARY KEY (`Hei_ID`),
  ADD UNIQUE KEY `Hei_ID` (`Hei_ID`),
  ADD KEY `Hou_ID` (`Hou_ID`);

--
-- Indexes for table `tbl_HistoricalEvents`
--
ALTER TABLE `tbl_HistoricalEvents`
  ADD PRIMARY KEY (`His_ID`),
  ADD UNIQUE KEY `His_ID` (`His_ID`);

--
-- Indexes for table `tbl_House`
--
ALTER TABLE `tbl_House`
  ADD PRIMARY KEY (`Hou_ID`),
  ADD UNIQUE KEY `Hou_ID` (`Hou_ID`),
  ADD KEY `Rea_Name` (`Rea_Name`);

--
-- Indexes for table `tbl_HouseChanges`
--
ALTER TABLE `tbl_HouseChanges`
  ADD PRIMARY KEY (`HouCha_ID`),
  ADD UNIQUE KEY `Cha_ID` (`HouCha_ID`),
  ADD KEY `Hou_ID` (`Hou_ID`);

--
-- Indexes for table `tbl_Influence`
--
ALTER TABLE `tbl_Influence`
  ADD PRIMARY KEY (`Inf_ID`),
  ADD UNIQUE KEY `Inf_ID` (`Inf_ID`);

--
-- Indexes for table `tbl_InfluenceHoldingImprovement`
--
ALTER TABLE `tbl_InfluenceHoldingImprovement`
  ADD PRIMARY KEY (`InfHolImp_ID`),
  ADD UNIQUE KEY `InfHolImp_ID` (`InfHolImp_ID`),
  ADD KEY `InfImp_ID` (`InfImp_ID`),
  ADD KEY `InfHol_ID` (`InfHol_ID`);

--
-- Indexes for table `tbl_InfluenceHoldings`
--
ALTER TABLE `tbl_InfluenceHoldings`
  ADD PRIMARY KEY (`InfHol_ID`),
  ADD UNIQUE KEY `InfHol_ID` (`InfHol_ID`),
  ADD KEY `Inf_ID` (`Inf_ID`),
  ADD KEY `Hou_ID` (`Hou_ID`);

--
-- Indexes for table `tbl_InfluenceImprovemnt`
--
ALTER TABLE `tbl_InfluenceImprovemnt`
  ADD PRIMARY KEY (`InfImp_ID`),
  ADD UNIQUE KEY `InfImp_ID` (`InfImp_ID`),
  ADD KEY `Inf_ID` (`Inf_ID`);

--
-- Indexes for table `tbl_Land`
--
ALTER TABLE `tbl_Land`
  ADD PRIMARY KEY (`Lan_ID`),
  ADD UNIQUE KEY `Lan_ID` (`Lan_ID`);

--
-- Indexes for table `tbl_LandFeature`
--
ALTER TABLE `tbl_LandFeature`
  ADD PRIMARY KEY (`LanFea_ID`),
  ADD UNIQUE KEY `LanFea_ID` (`LanFea_ID`);

--
-- Indexes for table `tbl_LandHolding`
--
ALTER TABLE `tbl_LandHolding`
  ADD PRIMARY KEY (`LanHol_ID`),
  ADD UNIQUE KEY `LanHol_ID` (`LanHol_ID`),
  ADD KEY `Hou_ID` (`Hou_ID`),
  ADD KEY `Lan_ID` (`Lan_ID`);

--
-- Indexes for table `tbl_LandHoldingFeature`
--
ALTER TABLE `tbl_LandHoldingFeature`
  ADD PRIMARY KEY (`LanHolFea_ID`),
  ADD UNIQUE KEY `LanHolFea_ID` (`LanHolFea_ID`),
  ADD KEY `LanFea_ID` (`LanFea_ID`),
  ADD KEY `LanHol_ID` (`LanHol_ID`);

--
-- Indexes for table `tbl_PowerHolding`
--
ALTER TABLE `tbl_PowerHolding`
  ADD PRIMARY KEY (`PowHol_ID`),
  ADD UNIQUE KEY `PowHol_ID` (`PowHol_ID`),
  ADD KEY `Uni_ID` (`Uni_ID`),
  ADD KEY `Hou_ID` (`Hou_ID`),
  ADD KEY `PowHol_Training` (`PowHol_Training`);

--
-- Indexes for table `tbl_Qualities`
--
ALTER TABLE `tbl_Qualities`
  ADD PRIMARY KEY (`Qua_ID`),
  ADD UNIQUE KEY `Qua_ID` (`Qua_ID`);

--
-- Indexes for table `tbl_Realms`
--
ALTER TABLE `tbl_Realms`
  ADD PRIMARY KEY (`Rea_Name`),
  ADD UNIQUE KEY `Rea_Name` (`Rea_Name`);

--
-- Indexes for table `tbl_UnitTraning`
--
ALTER TABLE `tbl_UnitTraning`
  ADD PRIMARY KEY (`Tra_Name`);

--
-- Indexes for table `tbl_UnitType`
--
ALTER TABLE `tbl_UnitType`
  ADD PRIMARY KEY (`Uni_ID`),
  ADD UNIQUE KEY `Uni_ID` (`Uni_ID`);

--
-- Indexes for table `tbl_Wealth`
--
ALTER TABLE `tbl_Wealth`
  ADD PRIMARY KEY (`Wea_ID`),
  ADD UNIQUE KEY `Wea_ID` (`Wea_ID`);

--
-- Indexes for table `tbl_WealthHolding`
--
ALTER TABLE `tbl_WealthHolding`
  ADD PRIMARY KEY (`WeaHol_ID`),
  ADD UNIQUE KEY `WeaHol_ID` (`WeaHol_ID`),
  ADD KEY `Wea_ID` (`Wea_ID`),
  ADD KEY `LanHol_ID` (`LanHol_ID`),
  ADD KEY `DefHol_ID` (`DefHol_ID`),
  ADD KEY `tbl_WealthHolding_ibfk_3` (`LanHolFea_ID`);

--
-- Indexes for table `tbl_WealthHoldingImprovement`
--
ALTER TABLE `tbl_WealthHoldingImprovement`
  ADD PRIMARY KEY (`WeaHolImp_ID`),
  ADD UNIQUE KEY `WeaHolImp_ID` (`WeaHolImp_ID`),
  ADD KEY `WeaHol_ID` (`WeaHol_ID`),
  ADD KEY `WeaImp_ID` (`WeaImp_ID`);

--
-- Indexes for table `tbl_WealthImprovement`
--
ALTER TABLE `tbl_WealthImprovement`
  ADD PRIMARY KEY (`WeaImp_ID`),
  ADD UNIQUE KEY `WeaImp_ID` (`WeaImp_ID`),
  ADD KEY `Wea_ID` (`Wea_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_Banner`
--
ALTER TABLE `tbl_Banner`
  MODIFY `Ban_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_Defense`
--
ALTER TABLE `tbl_Defense`
  MODIFY `Def_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_DefenseHolding`
--
ALTER TABLE `tbl_DefenseHolding`
  MODIFY `DefHol_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_Heir`
--
ALTER TABLE `tbl_Heir`
  MODIFY `Hei_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_House`
--
ALTER TABLE `tbl_House`
  MODIFY `Hou_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_HouseChanges`
--
ALTER TABLE `tbl_HouseChanges`
  MODIFY `HouCha_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_Influence`
--
ALTER TABLE `tbl_Influence`
  MODIFY `Inf_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_InfluenceHoldingImprovement`
--
ALTER TABLE `tbl_InfluenceHoldingImprovement`
  MODIFY `InfHolImp_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_InfluenceHoldings`
--
ALTER TABLE `tbl_InfluenceHoldings`
  MODIFY `InfHol_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_InfluenceImprovemnt`
--
ALTER TABLE `tbl_InfluenceImprovemnt`
  MODIFY `InfImp_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_Land`
--
ALTER TABLE `tbl_Land`
  MODIFY `Lan_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_LandFeature`
--
ALTER TABLE `tbl_LandFeature`
  MODIFY `LanFea_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_LandHolding`
--
ALTER TABLE `tbl_LandHolding`
  MODIFY `LanHol_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_LandHoldingFeature`
--
ALTER TABLE `tbl_LandHoldingFeature`
  MODIFY `LanHolFea_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_PowerHolding`
--
ALTER TABLE `tbl_PowerHolding`
  MODIFY `PowHol_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_Qualities`
--
ALTER TABLE `tbl_Qualities`
  MODIFY `Qua_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_UnitType`
--
ALTER TABLE `tbl_UnitType`
  MODIFY `Uni_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_Wealth`
--
ALTER TABLE `tbl_Wealth`
  MODIFY `Wea_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_WealthHolding`
--
ALTER TABLE `tbl_WealthHolding`
  MODIFY `WeaHol_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_WealthHoldingImprovement`
--
ALTER TABLE `tbl_WealthHoldingImprovement`
  MODIFY `WeaHolImp_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_WealthImprovement`
--
ALTER TABLE `tbl_WealthImprovement`
  MODIFY `WeaImp_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_Banner`
--
ALTER TABLE `tbl_Banner`
  ADD CONSTRAINT `tbl_Banner_ibfk_1` FOREIGN KEY (`HouLie_ID`) REFERENCES `tbl_House` (`Hou_ID`),
  ADD CONSTRAINT `tbl_Banner_ibfk_2` FOREIGN KEY (`HouBan_ID`) REFERENCES `tbl_House` (`Hou_ID`);

--
-- Constraints for table `tbl_DefenseHolding`
--
ALTER TABLE `tbl_DefenseHolding`
  ADD CONSTRAINT `tbl_DefenseHolding_ibfk_1` FOREIGN KEY (`Def_ID`) REFERENCES `tbl_Defense` (`Def_ID`),
  ADD CONSTRAINT `tbl_DefenseHolding_ibfk_2` FOREIGN KEY (`LanHol_ID`) REFERENCES `tbl_LandHolding` (`LanHol_ID`);

--
-- Constraints for table `tbl_Heir`
--
ALTER TABLE `tbl_Heir`
  ADD CONSTRAINT `tbl_Heir_ibfk_1` FOREIGN KEY (`Hou_ID`) REFERENCES `tbl_House` (`Hou_ID`);

--
-- Constraints for table `tbl_House`
--
ALTER TABLE `tbl_House`
  ADD CONSTRAINT `tbl_House_ibfk_1` FOREIGN KEY (`Rea_Name`) REFERENCES `tbl_Realms` (`Rea_Name`);

--
-- Constraints for table `tbl_HouseChanges`
--
ALTER TABLE `tbl_HouseChanges`
  ADD CONSTRAINT `tbl_HouseChanges_ibfk_1` FOREIGN KEY (`Hou_ID`) REFERENCES `tbl_House` (`Hou_ID`);

--
-- Constraints for table `tbl_InfluenceHoldingImprovement`
--
ALTER TABLE `tbl_InfluenceHoldingImprovement`
  ADD CONSTRAINT `tbl_InfluenceHoldingImprovement_ibfk_1` FOREIGN KEY (`InfImp_ID`) REFERENCES `tbl_InfluenceImprovemnt` (`InfImp_ID`),
  ADD CONSTRAINT `tbl_InfluenceHoldingImprovement_ibfk_2` FOREIGN KEY (`InfHol_ID`) REFERENCES `tbl_InfluenceHoldings` (`InfHol_ID`);

--
-- Constraints for table `tbl_InfluenceHoldings`
--
ALTER TABLE `tbl_InfluenceHoldings`
  ADD CONSTRAINT `tbl_InfluenceHoldings_ibfk_1` FOREIGN KEY (`Inf_ID`) REFERENCES `tbl_Influence` (`Inf_ID`),
  ADD CONSTRAINT `tbl_InfluenceHoldings_ibfk_2` FOREIGN KEY (`Hou_ID`) REFERENCES `tbl_House` (`Hou_ID`);

--
-- Constraints for table `tbl_InfluenceImprovemnt`
--
ALTER TABLE `tbl_InfluenceImprovemnt`
  ADD CONSTRAINT `tbl_InfluenceImprovemnt_ibfk_1` FOREIGN KEY (`Inf_ID`) REFERENCES `tbl_Influence` (`Inf_ID`);

--
-- Constraints for table `tbl_LandHolding`
--
ALTER TABLE `tbl_LandHolding`
  ADD CONSTRAINT `tbl_LandHolding_ibfk_1` FOREIGN KEY (`Hou_ID`) REFERENCES `tbl_House` (`Hou_ID`),
  ADD CONSTRAINT `tbl_LandHolding_ibfk_2` FOREIGN KEY (`Lan_ID`) REFERENCES `tbl_Land` (`Lan_ID`);

--
-- Constraints for table `tbl_LandHoldingFeature`
--
ALTER TABLE `tbl_LandHoldingFeature`
  ADD CONSTRAINT `tbl_LandHoldingFeature_ibfk_1` FOREIGN KEY (`LanFea_ID`) REFERENCES `tbl_LandFeature` (`LanFea_ID`),
  ADD CONSTRAINT `tbl_LandHoldingFeature_ibfk_2` FOREIGN KEY (`LanHol_ID`) REFERENCES `tbl_LandHolding` (`LanHol_ID`);

--
-- Constraints for table `tbl_PowerHolding`
--
ALTER TABLE `tbl_PowerHolding`
  ADD CONSTRAINT `tbl_PowerHolding_ibfk_1` FOREIGN KEY (`Uni_ID`) REFERENCES `tbl_UnitType` (`Uni_ID`),
  ADD CONSTRAINT `tbl_PowerHolding_ibfk_2` FOREIGN KEY (`Hou_ID`) REFERENCES `tbl_House` (`Hou_ID`),
  ADD CONSTRAINT `tbl_PowerHolding_ibfk_3` FOREIGN KEY (`PowHol_Training`) REFERENCES `tbl_UnitTraning` (`Tra_Name`);

--
-- Constraints for table `tbl_WealthHolding`
--
ALTER TABLE `tbl_WealthHolding`
  ADD CONSTRAINT `tbl_WealthHolding_ibfk_1` FOREIGN KEY (`Wea_ID`) REFERENCES `tbl_Wealth` (`Wea_ID`),
  ADD CONSTRAINT `tbl_WealthHolding_ibfk_2` FOREIGN KEY (`LanHol_ID`) REFERENCES `tbl_LandHolding` (`LanHol_ID`),
  ADD CONSTRAINT `tbl_WealthHolding_ibfk_3` FOREIGN KEY (`LanHolFea_ID`) REFERENCES `tbl_LandHoldingFeature` (`LanHolFea_ID`),
  ADD CONSTRAINT `tbl_WealthHolding_ibfk_4` FOREIGN KEY (`DefHol_ID`) REFERENCES `tbl_DefenseHolding` (`DefHol_ID`);

--
-- Constraints for table `tbl_WealthHoldingImprovement`
--
ALTER TABLE `tbl_WealthHoldingImprovement`
  ADD CONSTRAINT `tbl_WealthHoldingImprovement_ibfk_1` FOREIGN KEY (`WeaHol_ID`) REFERENCES `tbl_WealthHolding` (`WeaHol_ID`),
  ADD CONSTRAINT `tbl_WealthHoldingImprovement_ibfk_2` FOREIGN KEY (`WeaImp_ID`) REFERENCES `tbl_WealthImprovement` (`WeaImp_ID`);

--
-- Constraints for table `tbl_WealthImprovement`
--
ALTER TABLE `tbl_WealthImprovement`
  ADD CONSTRAINT `tbl_WealthImprovement_ibfk_1` FOREIGN KEY (`Wea_ID`) REFERENCES `tbl_Wealth` (`Wea_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
