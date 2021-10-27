-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 11, 2021 at 12:22 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `biznessbuddy`
--

-- --------------------------------------------------------

--
-- Table structure for table `asset`
--

CREATE TABLE `asset` (
  `AssetName` varchar(50) NOT NULL,
  `AssetAmount` int(50) NOT NULL,
  `AssetID` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `asset`
--

INSERT INTO `asset` (`AssetName`, `AssetAmount`, `AssetID`) VALUES
('Equipment', 48000, '007'),
('Cash', 12100, '008');

-- --------------------------------------------------------

--
-- Table structure for table `capital`
--

CREATE TABLE `capital` (
  `CapitalName` varchar(50) NOT NULL,
  `CapitalAmount` varchar(50) NOT NULL,
  `CapitalId` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `capital`
--

INSERT INTO `capital` (`CapitalName`, `CapitalAmount`, `CapitalId`) VALUES
('Openning Capital', '30000', '005'),
('Investment', '10000', '006');

-- --------------------------------------------------------

--
-- Table structure for table `expenses`
--

CREATE TABLE `expenses` (
  `ExpenseName` varchar(50) NOT NULL,
  `ExpenseAmount` int(50) NOT NULL,
  `ExpenseID` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `expenses`
--

INSERT INTO `expenses` (`ExpenseName`, `ExpenseAmount`, `ExpenseID`) VALUES
('Advertising', 4500, '003'),
('Salaries', 3500, '004');

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `InventoryName` varchar(50) NOT NULL,
  `InventoryID` varchar(50) NOT NULL,
  `InventoryAmount` int(50) NOT NULL,
  `InventoryQuantity` varchar(50) NOT NULL,
  `InventoryType` varchar(50) NOT NULL,
  `InventoryDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`InventoryName`, `InventoryID`, `InventoryAmount`, `InventoryQuantity`, `InventoryType`, `InventoryDate`) VALUES
('Sales', '001', 18700, 'N/A', 'Revenue', '2021-05-11'),
('Notes Payable', '0010', 2400, 'N/A', 'Liability', '2021-05-10'),
('Rent Income', '002', 6000, 'N/A', 'Revenue', '2021-05-11'),
('Advertising', '003', 4500, 'N/A', 'Expenses', '2021-05-11'),
('Salaries', '004', 3500, 'N/A', 'Expenses', '2021-05-11'),
('Openning Capital', '005', 30000, 'N/A ', 'Capital', '2021-05-11'),
('Investment', '006', 10000, 'N/A', 'Capital', '2021-05-11'),
('Equipment', '007', 48000, '500', 'Asset', '2021-05-11'),
('Cash', '008', 12100, 'N/A', 'Asset', '2021-05-11'),
('Accounts Payable', '009', 1000, 'N/A', 'Liability', '2021-05-04');

-- --------------------------------------------------------

--
-- Table structure for table `liability`
--

CREATE TABLE `liability` (
  `LiabilityName` varchar(50) NOT NULL,
  `LiabilityAmount` varchar(50) NOT NULL,
  `LiabilityID` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `liability`
--

INSERT INTO `liability` (`LiabilityName`, `LiabilityAmount`, `LiabilityID`) VALUES
('Notes Payable', '2400', '0010'),
('Accounts Payable', '1000', '009');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `Name` varchar(50) NOT NULL,
  `Id` varchar(50) NOT NULL,
  `Phone` int(11) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `UserType` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`Name`, `Id`, `Phone`, `Password`, `UserType`) VALUES
('Nazmuj Shakib', '181014053', 1763051676, 'BB103', 'Admin'),
('Afraim Bin Zahangir', '181014080', 1633188750, 'BB420', 'Manager'),
('Shiam Prodhan', '181014123', 1744650142, 'BB103', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `revenue`
--

CREATE TABLE `revenue` (
  `RevenueName` varchar(50) NOT NULL,
  `RevenueAmount` int(50) NOT NULL,
  `RevenueID` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `revenue`
--

INSERT INTO `revenue` (`RevenueName`, `RevenueAmount`, `RevenueID`) VALUES
('Sales', 18700, '001'),
('Rent Income', 6000, '002');

-- --------------------------------------------------------

--
-- Table structure for table `totalcalculation`
--

CREATE TABLE `totalcalculation` (
  `Title` varchar(50) NOT NULL,
  `Amount` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `totalcalculation`
--

INSERT INTO `totalcalculation` (`Title`, `Amount`) VALUES
('Net Income', 16700),
('Owners Equity', 56700),
('Total Asset', 60100),
('Total Liability', 3400),
('Total Revenue', 24700);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asset`
--
ALTER TABLE `asset`
  ADD PRIMARY KEY (`AssetID`);

--
-- Indexes for table `capital`
--
ALTER TABLE `capital`
  ADD PRIMARY KEY (`CapitalId`);

--
-- Indexes for table `expenses`
--
ALTER TABLE `expenses`
  ADD PRIMARY KEY (`ExpenseID`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`InventoryID`);

--
-- Indexes for table `liability`
--
ALTER TABLE `liability`
  ADD PRIMARY KEY (`LiabilityID`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `revenue`
--
ALTER TABLE `revenue`
  ADD PRIMARY KEY (`RevenueID`);

--
-- Indexes for table `totalcalculation`
--
ALTER TABLE `totalcalculation`
  ADD PRIMARY KEY (`Title`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
