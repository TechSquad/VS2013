-- phpMyAdmin SQL Dump
-- version 4.2.5
-- http://www.phpmyadmin.net
--
-- Host: localhost:3306
-- Generation Time: Nov 30, 2014 at 10:07 PM
-- Server version: 5.5.41
-- PHP Version: 5.5.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `nortechadmin1_test`
--

-- --------------------------------------------------------

--
-- Table structure for table `account_type`
--

CREATE TABLE IF NOT EXISTS `account_type` (
`acct_id` int(11) NOT NULL,
  `type` varchar(20) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `account_type`
--

INSERT INTO `account_type` (`acct_id`, `type`) VALUES
(1, 'Customer'),
(2, 'Trade'),
(3, 'Staff');

-- --------------------------------------------------------

--
-- Table structure for table `address`
--

CREATE TABLE IF NOT EXISTS `address` (
`address_id` int(11) NOT NULL,
  `cust_id` int(11) DEFAULT NULL,
  `add_1` varchar(40) NOT NULL,
  `add_2` varchar(40) NOT NULL,
  `town` varchar(40) NOT NULL,
  `city` varchar(40) NOT NULL,
  `postcode` varchar(10) NOT NULL,
  `in_use` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `address`
--

INSERT INTO `address` (`address_id`, `cust_id`, `add_1`, `add_2`, `town`, `city`, `postcode`, `in_use`) VALUES
(1, 1, '1 Conference Avenue', '', 'Portishead', 'Avon', 'BS20 6EW', 0),
(2, 2, '10 High Street', '', 'Portishead', 'Bristol', 'BS20 6EW', 0),
(3, 3, '1 Any Street', '', 'Anytown', 'Anywhere', 'AW1 1AW', 0),
(4, 4, '10 Any Street', '', 'Anytown', '', 'BS20 1AW', 0),
(5, 5, '10 Barrie Street', '', 'Barrie Island', 'Barrie', 'BR1 1IE', 1),
(6, 6, '1 Conference Avenue', '', 'Portishead', 'Bristol', 'BS20 6EW', 0),
(7, NULL, 'Unit 5 Pioneer Way', 'Pioneer Business Park', 'Castleford', '', 'WF10 5QU', 1);

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE IF NOT EXISTS `category` (
`category_id` int(11) NOT NULL,
  `sub_category_id` int(11) DEFAULT NULL,
  `category_name` varchar(60) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`category_id`, `sub_category_id`, `category_name`) VALUES
(1, NULL, 'Nortech Test'),
(2, NULL, 'Nortech Test 2');

-- --------------------------------------------------------

--
-- Table structure for table `contact`
--

CREATE TABLE IF NOT EXISTS `contact` (
`contact_id` int(11) NOT NULL,
  `cust_id` int(11) NOT NULL,
  `home_tel` text NOT NULL,
  `work_tel` text NOT NULL,
  `mobile_tel` text NOT NULL,
  `email` text NOT NULL,
  `fax` text NOT NULL,
  `in_use` tinyint(1) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COMMENT='contact details' AUTO_INCREMENT=7 ;

--
-- Dumping data for table `contact`
--

INSERT INTO `contact` (`contact_id`, `cust_id`, `home_tel`, `work_tel`, `mobile_tel`, `email`, `fax`, `in_use`) VALUES
(1, 1, '01275 817730', '01275 818699', '0781 206 9773', 'roger@iapbb.net', '', 0),
(2, 2, '', '01275 818699', '', '', '', 0),
(3, 3, '01275 ', '01275', '0780', 'a.a@aw.com', '', 0),
(4, 4, '', '', '', '', '', 0),
(5, 5, '01275 818699', '', '', 'barrie@barrietest.com', '', 1),
(6, 6, '01275 817730', '', '', 'caroline@iapbb.net', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE IF NOT EXISTS `customer` (
`cust_id` int(11) NOT NULL,
  `address_id` int(11) NOT NULL,
  `contact_id` int(11) NOT NULL,
  `membership` varchar(20) NOT NULL,
  `acct_type` varchar(20) NOT NULL,
  `title` varchar(10) NOT NULL,
  `first_name` varchar(20) NOT NULL,
  `last_name` varchar(20) NOT NULL,
  `company_name` varchar(40) NOT NULL,
  `date_of_birth` varchar(60) NOT NULL,
  `is_company` tinyint(1) NOT NULL,
  `mailing_list` tinyint(1) NOT NULL,
  `vip` tinyint(1) NOT NULL,
  `in_use` tinyint(1) NOT NULL,
  `date_created` timestamp NULL DEFAULT NULL,
  `date_changed` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`cust_id`, `address_id`, `contact_id`, `membership`, `acct_type`, `title`, `first_name`, `last_name`, `company_name`, `date_of_birth`, `is_company`, `mailing_list`, `vip`, `in_use`, `date_created`, `date_changed`) VALUES
(1, 0, 0, '', 'Staff', 'Mr', 'Roger', 'Whitfield', 'Nortech Computers', '09/06/1965', 1, 0, 1, 1, '2014-11-05 17:16:52', '2014-11-20 21:33:32'),
(2, 0, 0, '', 'Customer', 'Mr', 'Roger', 'Whitfield', '', '19/06/1965', 0, 0, 1, 1, '2014-11-05 18:07:55', '2014-11-20 21:33:12'),
(3, 0, 0, '', 'Customer', 'Mr', 'Andrew', 'Test', '', '  /  /', 0, 1, 0, 1, '2014-11-05 18:33:24', '2014-11-05 18:44:59'),
(4, 0, 0, '', 'Customer', 'Mr', 'Roger', 'Whitehead', '', '  /  /', 0, 1, 0, 1, '2014-11-05 19:32:03', '2014-11-16 19:10:17'),
(5, 0, 0, '', 'Customer', 'Mr', 'Barrie', 'Test', '', '  /  /', 0, 1, 0, 1, '2014-11-07 16:56:31', '2014-11-07 16:56:31'),
(6, 0, 0, '', 'Customer', 'Mrs', 'Caroline', 'Whitfield', '', '16/10/1967', 0, 1, 1, 1, '2014-11-08 18:12:11', '2014-11-20 21:32:40');

-- --------------------------------------------------------

--
-- Table structure for table `invoice`
--

CREATE TABLE IF NOT EXISTS `invoice` (
`inv_number` int(11) NOT NULL,
  `cust_id` int(11) NOT NULL,
  `inv_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `address_id` int(11) NOT NULL,
  `total_tax` decimal(10,2) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

-- --------------------------------------------------------

--
-- Table structure for table `invoice_item`
--

CREATE TABLE IF NOT EXISTS `invoice_item` (
`inv_item_id` int(11) NOT NULL,
  `inv_number` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `quantity` decimal(10,0) NOT NULL,
  `line_number` int(11) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE IF NOT EXISTS `item` (
`item_id` int(11) NOT NULL,
  `item_desc` int(11) NOT NULL,
  `item_price` decimal(10,0) NOT NULL,
  `item_description` text NOT NULL,
  `item_longdescription` text NOT NULL,
  `item_specifications` text NOT NULL,
  `item_manufacturer` text NOT NULL,
  `item_model` text NOT NULL,
  `item_stockcode` varchar(50) CHARACTER SET latin1 COLLATE latin1_general_cs NOT NULL,
  `item_cat_id` int(11) NOT NULL,
  `item_weight` decimal(10,0) NOT NULL,
  `item_barcode` varchar(50) CHARACTER SET latin1 COLLATE latin1_general_cs NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`item_id`, `item_desc`, `item_price`, `item_description`, `item_longdescription`, `item_specifications`, `item_manufacturer`, `item_model`, `item_stockcode`, `item_cat_id`, `item_weight`, `item_barcode`) VALUES
(1, 0, '300', 'GT X4 Quad Core Gaming PC', 'GT X4 Quad Core Gaming PC 4.2GHz 4GB 120GB SSD 1000GB HDD DVD RW R7 240', 'AMD Piledriver Quad Core 4.2GHz CPU \n4 GB DDR3 1600MHz Memory \n120GB SATA III Solid State Drive \n1000GB SATA III Hard Disk Drive \nDVD Rewriter Drive \nRadeon R7 240 2GB Graphics Card \nInternal 300Mbps WiFi Integrated \n7.1 Audio \nWired or Wireless Keyboard and Mouse \n2.5" SSD/HDD Docking Station with Card Reader \nGenuine Windows 7 or Windows 8.1 Operating System \nFree 12 months Bullguard Internet Security \n3 Year Nortech Warranty (RTB) \nFree Lifetime Annual Healthcheck \nFree Data Transfer\n', 'Tech Squad', 'unused', 'GT0914', 1, '4', 'GT0914'),
(2, 0, '400', 'GT X6 Hex Core Gaming PC', 'GT X6 Hes Core Gaming PC 3.9GHz 8GB 240GB SSD 2000GB HDD DVD RW R7 250', 'AMD Piledriver Six Core 3.9GHz CPU 8 GB DDR3 1600MHz Memory 240GB STAT III Solid State Drive 2000GB SATA III Hard Disk Drive DVD Rewriter Drive Radeon R7 250 2GB Graphics Card Internel 300Mbps WiFi Integrated 7.1 Audio Wired or Wireless Keyboard and Mouse 2.5" SSD/HDD Docking Station with Card Reader Genuine Windows 7 or Windows 8.1 Operating System Free 12 months Bullguard Internet Security 3 Year Nortech Warranty (RTB) Free Lifetime Annual Healthcheck Free Data Transfer\n', 'Tech Squad', 'unused', 'GT0914P', 1, '6', 'GT0914P');

-- --------------------------------------------------------

--
-- Table structure for table `item_picture`
--

CREATE TABLE IF NOT EXISTS `item_picture` (
`picture_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `picture_location` varchar(1000) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `item_picture`
--

INSERT INTO `item_picture` (`picture_id`, `item_id`, `picture_location`) VALUES
(1, 1, 'http://nortechcomputers.co.uk/images/GT0914.jpg'),
(2, 2, 'http://80.249.110.100/productimages/PRAMD-SD2650JAHM-lg.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `item_price`
--

CREATE TABLE IF NOT EXISTS `item_price` (
`it_price_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `price_1` float NOT NULL,
  `price_2` float NOT NULL,
  `price_3` float NOT NULL,
  `price_4` float NOT NULL,
  `price_5` float NOT NULL,
  `ti_price_1` float NOT NULL,
  `ti_price_2` float NOT NULL,
  `ti_price_3` float NOT NULL,
  `ti_price_4` float NOT NULL,
  `ti_price_5` float NOT NULL,
  `date_created` datetime DEFAULT NULL,
  `date_updated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `item_price`
--

INSERT INTO `item_price` (`it_price_id`, `item_id`, `price_1`, `price_2`, `price_3`, `price_4`, `price_5`, `ti_price_1`, `ti_price_2`, `ti_price_3`, `ti_price_4`, `ti_price_5`, `date_created`, `date_updated`) VALUES
(1, 1, 499.167, 474, 399, 0, 0, 599, 568.8, 478.8, 0, 0, '0000-00-00 00:00:00', '2014-11-13 14:03:01'),
(2, 2, 582.5, 0, 0, 0, 0, 699, 0, 0, 0, 0, '2014-11-13 16:39:00', '2014-11-17 11:44:47');

-- --------------------------------------------------------

--
-- Table structure for table `item_stock`
--

CREATE TABLE IF NOT EXISTS `item_stock` (
`stock_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `in_stock` int(11) NOT NULL,
  `supplier_stock` int(11) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `item_stock`
--

INSERT INTO `item_stock` (`stock_id`, `item_id`, `in_stock`, `supplier_stock`) VALUES
(1, 1, 6, 0),
(2, 2, 3, 0);

-- --------------------------------------------------------

--
-- Table structure for table `manufacturer`
--

CREATE TABLE IF NOT EXISTS `manufacturer` (
`manu_id` int(11) NOT NULL,
  `manu_name` varchar(100) NOT NULL,
  `manu_logo` varchar(255) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `manufacturer`
--

INSERT INTO `manufacturer` (`manu_id`, `manu_name`, `manu_logo`) VALUES
(1, 'Tech Squad', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `notes`
--

CREATE TABLE IF NOT EXISTS `notes` (
`notes_id` int(11) NOT NULL,
  `cust_id` int(11) NOT NULL,
  `note` text NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `notes`
--

INSERT INTO `notes` (`notes_id`, `cust_id`, `note`) VALUES
(1, 1, 'Managing Director'),
(2, 6, 'Rogers Wife');

-- --------------------------------------------------------

--
-- Table structure for table `po_item`
--

CREATE TABLE IF NOT EXISTS `po_item` (
`po_item_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `po_item_cost` decimal(10,2) NOT NULL,
  `po_id` int(11) NOT NULL,
  `item_quantity` float NOT NULL,
  `line_number` int(11) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=75 ;

--
-- Dumping data for table `po_item`
--

INSERT INTO `po_item` (`po_item_id`, `item_id`, `po_item_cost`, `po_id`, `item_quantity`, `line_number`) VALUES
(29, 1, '299.98', 3, 1, 1),
(30, 2, '342.71', 3, 1, 2),
(41, 1, '198.23', 3, 1, 3),
(43, 1, '128.32', 6, 1, 5),
(48, 2, '400.00', 5, 1, 1),
(49, 2, '400.00', 3, 1, 4),
(50, 1, '0.00', 3, 1, 1),
(51, 1, '258.72', 13, 4, 1),
(52, 1, '250.00', 14, 1, 1),
(53, 2, '400.00', 15, 1, 1),
(54, 2, '300.00', 16, 2, 1),
(61, 1, '228.32', 24, 1, 1),
(67, 2, '400.00', 17, 1, 1),
(68, 1, '300.00', 17, 1, 2),
(69, 1, '133.00', 17, 1, 3),
(70, 2, '400.00', 17, 1, 4),
(71, 2, '400.00', 17, 1, 5),
(72, 2, '400.00', 17, 1, 6),
(73, 1, '0.00', 0, 1, 1),
(74, 1, '0.00', 0, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `po_shipping`
--

CREATE TABLE IF NOT EXISTS `po_shipping` (
`ship_id` int(11) NOT NULL,
  `ship_type` varchar(60) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `po_shipping`
--

INSERT INTO `po_shipping` (`ship_id`, `ship_type`) VALUES
(1, 'Courier'),
(2, 'Royal Mail 1st Class'),
(3, 'Royal Mail 2nd Class');

-- --------------------------------------------------------

--
-- Table structure for table `po_terms`
--

CREATE TABLE IF NOT EXISTS `po_terms` (
  `po_terms_id` int(11) DEFAULT NULL,
  `po_terms` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `po_terms`
--

INSERT INTO `po_terms` (`po_terms_id`, `po_terms`) VALUES
(NULL, 'Payment on Order'),
(NULL, '30 Day Credit Account');

-- --------------------------------------------------------

--
-- Table structure for table `purchase_order`
--

CREATE TABLE IF NOT EXISTS `purchase_order` (
`po_id` int(11) NOT NULL,
  `po_supplier` varchar(80) DEFAULT NULL,
  `po_status` varchar(20) NOT NULL,
  `po_shipping` varchar(20) DEFAULT NULL,
  `po_terms` varchar(20) DEFAULT NULL,
  `po_shipto` varchar(20) DEFAULT NULL,
  `po_note` text,
  `po_date_ordered` datetime DEFAULT NULL,
  `po_date_expected` datetime DEFAULT NULL,
  `po_date_received` datetime DEFAULT NULL,
  `po_carriage` decimal(10,4) DEFAULT NULL,
  `po_carriage_tax` decimal(10,4) DEFAULT NULL,
  `po_total` decimal(10,4) DEFAULT NULL,
  `po_tax` decimal(10,4) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=25 ;

--
-- Dumping data for table `purchase_order`
--

INSERT INTO `purchase_order` (`po_id`, `po_supplier`, `po_status`, `po_shipping`, `po_terms`, `po_shipto`, `po_note`, `po_date_ordered`, `po_date_expected`, `po_date_received`, `po_carriage`, `po_carriage_tax`, `po_total`, `po_tax`) VALUES
(3, 'Vision Technologies', 'complete', 'Courier', '30 Day Credit Accoun', '5', 'new note rw 221114', '2014-11-23 16:55:29', '2014-11-24 15:48:52', '2014-11-24 16:55:41', '0.0000', '0.0000', '1240.9200', '248.1840'),
(5, 'Target Components', 'complete', 'Courier', 'Payment on Order', 'Nortech Computers', '', '2014-11-23 17:08:20', '2014-11-27 16:46:34', '2014-11-23 17:08:48', '10.0000', '2.0000', '410.0000', '80.0000'),
(6, 'Target Components', 'complete', 'Courier', 'Payment on Order', 'Nortech Computers', '', '2014-11-23 16:59:43', '2014-11-24 09:39:56', '2014-11-23 17:07:12', '10.0000', '2.0000', '138.3200', '25.6640'),
(13, 'Target Components', 'complete', 'Courier', 'Payment on Order', '0', '', '2014-11-23 18:04:36', '2014-11-25 18:03:50', '2014-11-25 18:04:45', '10.0000', '2.0000', '268.7200', '51.7440'),
(14, 'Target Components', 'complete', 'Courier', 'Payment on Order', '0', '', '2014-11-23 18:06:22', '2014-11-25 18:06:11', '2014-11-25 18:06:28', '0.0000', '0.0000', '250.0000', '50.0000'),
(15, 'Target Components', 'complete', 'Courier', 'Payment on Order', '0', '', '2014-11-23 18:43:40', '2014-11-25 18:20:36', '2014-11-25 18:43:52', '0.0000', '0.0000', '400.0000', '80.0000'),
(16, 'Target Components', 'complete', 'Courier', 'Payment on Order', '0', '', '2014-11-23 18:50:29', '2014-11-25 18:49:48', '2014-11-23 18:50:32', '10.0000', '2.0000', '310.0000', '60.0000'),
(17, 'Target Components', 'pending', 'Courier', 'Payment on Order', '0', '', NULL, '2014-11-26 20:15:34', NULL, '0.0000', '0.0000', '2033.0000', '406.6000'),
(24, 'Target Components', 'complete', 'Courier', 'Payment on Order', '0', 'new note at order time', '2014-11-26 12:53:04', '2014-11-26 12:50:53', '2014-11-26 12:52:20', '10.0000', '2.0000', '238.3200', '45.6640');

-- --------------------------------------------------------

--
-- Table structure for table `salutation`
--

CREATE TABLE IF NOT EXISTS `salutation` (
`salutation_id` int(11) NOT NULL,
  `title` varchar(10) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `salutation`
--

INSERT INTO `salutation` (`salutation_id`, `title`) VALUES
(1, 'Mr'),
(2, 'Mrs'),
(3, 'Ms'),
(4, 'Miss');

-- --------------------------------------------------------

--
-- Table structure for table `service`
--

CREATE TABLE IF NOT EXISTS `service` (
`serv_id` int(11) NOT NULL,
  `cust_id` int(11) NOT NULL,
  `inv_id` int(11) DEFAULT NULL,
  `serv_desc` varchar(50) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `service`
--

INSERT INTO `service` (`serv_id`, `cust_id`, `inv_id`, `serv_desc`) VALUES
(1, 1, 1, 'Test MOT');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE IF NOT EXISTS `supplier` (
`supplier_id` int(11) NOT NULL,
  `address_id` int(11) NOT NULL,
  `supplier_name` text NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`supplier_id`, `address_id`, `supplier_name`) VALUES
(1, 0, 'All'),
(2, 7, 'Target Components'),
(3, 0, 'Vision Technologies'),
(4, 0, 'Tech Squad');

-- --------------------------------------------------------

--
-- Table structure for table `terms`
--

CREATE TABLE IF NOT EXISTS `terms` (
`terms_id` int(11) NOT NULL,
  `cust_id` int(11) NOT NULL,
  `cash` tinyint(1) NOT NULL,
  `exchange` tinyint(1) NOT NULL,
  `account` tinyint(1) NOT NULL,
  `statements` tinyint(1) NOT NULL,
  `days_credit` int(11) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `terms`
--

INSERT INTO `terms` (`terms_id`, `cust_id`, `cash`, `exchange`, `account`, `statements`, `days_credit`) VALUES
(1, 1, 0, 0, 1, 1, 30),
(2, 2, 0, 0, 1, 1, 0),
(3, 3, 0, 0, 1, 1, 0),
(4, 4, 1, 0, 0, 1, 0),
(5, 5, 0, 0, 1, 1, 0),
(6, 6, 0, 0, 1, 1, 14);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
`user_id` int(11) NOT NULL,
  `user_name` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `user_name`, `password`) VALUES
(1, 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account_type`
--
ALTER TABLE `account_type`
 ADD PRIMARY KEY (`acct_id`);

--
-- Indexes for table `address`
--
ALTER TABLE `address`
 ADD UNIQUE KEY `add_id` (`address_id`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
 ADD PRIMARY KEY (`category_id`);

--
-- Indexes for table `contact`
--
ALTER TABLE `contact`
 ADD PRIMARY KEY (`contact_id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
 ADD PRIMARY KEY (`cust_id`), ADD UNIQUE KEY `cust_id` (`cust_id`), ADD KEY `first_name` (`first_name`), ADD KEY `last_name` (`last_name`);

--
-- Indexes for table `invoice`
--
ALTER TABLE `invoice`
 ADD PRIMARY KEY (`inv_number`);

--
-- Indexes for table `invoice_item`
--
ALTER TABLE `invoice_item`
 ADD PRIMARY KEY (`inv_item_id`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
 ADD PRIMARY KEY (`item_id`);

--
-- Indexes for table `item_picture`
--
ALTER TABLE `item_picture`
 ADD PRIMARY KEY (`picture_id`);

--
-- Indexes for table `item_price`
--
ALTER TABLE `item_price`
 ADD PRIMARY KEY (`it_price_id`);

--
-- Indexes for table `item_stock`
--
ALTER TABLE `item_stock`
 ADD PRIMARY KEY (`stock_id`);

--
-- Indexes for table `manufacturer`
--
ALTER TABLE `manufacturer`
 ADD PRIMARY KEY (`manu_id`);

--
-- Indexes for table `notes`
--
ALTER TABLE `notes`
 ADD PRIMARY KEY (`notes_id`);

--
-- Indexes for table `po_item`
--
ALTER TABLE `po_item`
 ADD PRIMARY KEY (`po_item_id`);

--
-- Indexes for table `po_shipping`
--
ALTER TABLE `po_shipping`
 ADD PRIMARY KEY (`ship_id`);

--
-- Indexes for table `purchase_order`
--
ALTER TABLE `purchase_order`
 ADD PRIMARY KEY (`po_id`);

--
-- Indexes for table `salutation`
--
ALTER TABLE `salutation`
 ADD PRIMARY KEY (`salutation_id`);

--
-- Indexes for table `service`
--
ALTER TABLE `service`
 ADD PRIMARY KEY (`serv_id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
 ADD PRIMARY KEY (`supplier_id`);

--
-- Indexes for table `terms`
--
ALTER TABLE `terms`
 ADD PRIMARY KEY (`terms_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
 ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account_type`
--
ALTER TABLE `account_type`
MODIFY `acct_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `address`
--
ALTER TABLE `address`
MODIFY `address_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
MODIFY `category_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `contact`
--
ALTER TABLE `contact`
MODIFY `contact_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
MODIFY `cust_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `invoice`
--
ALTER TABLE `invoice`
MODIFY `inv_number` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `invoice_item`
--
ALTER TABLE `invoice_item`
MODIFY `inv_item_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `item_picture`
--
ALTER TABLE `item_picture`
MODIFY `picture_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `item_price`
--
ALTER TABLE `item_price`
MODIFY `it_price_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `item_stock`
--
ALTER TABLE `item_stock`
MODIFY `stock_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `manufacturer`
--
ALTER TABLE `manufacturer`
MODIFY `manu_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `notes`
--
ALTER TABLE `notes`
MODIFY `notes_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `po_item`
--
ALTER TABLE `po_item`
MODIFY `po_item_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=75;
--
-- AUTO_INCREMENT for table `po_shipping`
--
ALTER TABLE `po_shipping`
MODIFY `ship_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `purchase_order`
--
ALTER TABLE `purchase_order`
MODIFY `po_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT for table `salutation`
--
ALTER TABLE `salutation`
MODIFY `salutation_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `service`
--
ALTER TABLE `service`
MODIFY `serv_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `terms`
--
ALTER TABLE `terms`
MODIFY `terms_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
