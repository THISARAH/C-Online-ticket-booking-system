-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 14, 2020 at 08:25 AM
-- Server version: 10.1.25-MariaDB
-- PHP Version: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `esoftdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_name` varchar(30) NOT NULL,
  `admin_ID` varchar(15) NOT NULL,
  `admin_Telno:` int(12) NOT NULL,
  `admin_password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_name`, `admin_ID`, `admin_Telno:`, `admin_password`) VALUES
('Thisara', '001', 718907506, '123a'),
('madusha', '002', 778952146, '123b');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `customer_name` varchar(30) NOT NULL,
  `customer_ID` varchar(15) NOT NULL,
  `NIC` varchar(15) NOT NULL,
  `customer_TelNo` int(12) NOT NULL,
  `customer_Password` varchar(15) NOT NULL,
  `customer_Address` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`customer_name`, `customer_ID`, `NIC`, `customer_TelNo`, `customer_Password`, `customer_Address`) VALUES
('Chamith Sir', '21', '992862725V', 718907506, '789c', 'Beli');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `employee_user_name` varchar(30) NOT NULL,
  `employee_Reg_No` varchar(15) NOT NULL,
  `NIC` varchar(15) NOT NULL,
  `employee_Address` varchar(12) NOT NULL,
  `employee_Tel_No` int(15) NOT NULL,
  `employee_Password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`employee_user_name`, `employee_Reg_No`, `NIC`, `employee_Address`, `employee_Tel_No`, `employee_Password`) VALUES
('Kasun', '10', '992862736V', 'jafna', 715228794, '456a'),
('Supun', '11', '992862734V', 'Tangalle', 718907500, '456b'),
('Haritha', '12', '992862740V', 'Trinko', 778523649, '456c');

-- --------------------------------------------------------

--
-- Table structure for table `musicalshow`
--

CREATE TABLE `musicalshow` (
  `showname` varchar(20) NOT NULL,
  `venue` varchar(30) NOT NULL,
  `date` varchar(10) NOT NULL,
  `time` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `musicalshow`
--

INSERT INTO `musicalshow` (`showname`, `venue`, `date`, `time`) VALUES
('BnS', 'Galle face', '2020-02-12', '10.00 A.M'),
('Derena Attack Show', 'Tangalle(Kotugodalla)', '2020-03-20', '04.00 P.M'),
('Flash Back', 'Galle', '2020/02/05', '03.00 P.M.'),
('Purple range', 'Tangalle', '2020/12/12', '08.00 A.M.');

-- --------------------------------------------------------

--
-- Table structure for table `tickets`
--

CREATE TABLE `tickets` (
  `dbtype` varchar(30) NOT NULL,
  `dbprice` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tickets`
--

INSERT INTO `tickets` (`dbtype`, `dbprice`) VALUES
('Gold', '20,000'),
('Normal', '5,000'),
('Premium', '10,000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`admin_ID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customer_ID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`employee_Reg_No`);

--
-- Indexes for table `musicalshow`
--
ALTER TABLE `musicalshow`
  ADD PRIMARY KEY (`showname`);

--
-- Indexes for table `tickets`
--
ALTER TABLE `tickets`
  ADD PRIMARY KEY (`dbtype`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
