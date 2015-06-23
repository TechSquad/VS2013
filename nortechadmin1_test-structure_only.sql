-- phpMyAdmin SQL Dump
-- version 4.2.5
-- http://www.phpmyadmin.net
--
-- Host: localhost:3306
-- Generation Time: Nov 30, 2014 at 10:11 PM
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
CREATE DATABASE IF NOT EXISTS `nortechadmin1_test` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `nortechadmin1_test`;

-- --------------------------------------------------------

--
-- Table structure for table `account_type`
--

CREATE TABLE IF NOT EXISTS `account_type` (
`acct_id` int(11) NOT NULL,
  `type` varchar(20) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE IF NOT EXISTS `category` (
`category_id` int(11) NOT NULL,
  `sub_category_id` int(11) DEFAULT NULL,
  `category_name` varchar(60) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COMMENT='contact details';

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `item_picture`
--

CREATE TABLE IF NOT EXISTS `item_picture` (
`picture_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `picture_location` varchar(1000) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `item_stock`
--

CREATE TABLE IF NOT EXISTS `item_stock` (
`stock_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `in_stock` int(11) NOT NULL,
  `supplier_stock` int(11) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `manufacturer`
--

CREATE TABLE IF NOT EXISTS `manufacturer` (
`manu_id` int(11) NOT NULL,
  `manu_name` varchar(100) NOT NULL,
  `manu_logo` varchar(255) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `notes`
--

CREATE TABLE IF NOT EXISTS `notes` (
`notes_id` int(11) NOT NULL,
  `cust_id` int(11) NOT NULL,
  `note` text NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `po_shipping`
--

CREATE TABLE IF NOT EXISTS `po_shipping` (
`ship_id` int(11) NOT NULL,
  `ship_type` varchar(60) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `po_terms`
--

CREATE TABLE IF NOT EXISTS `po_terms` (
  `po_terms_id` int(11) DEFAULT NULL,
  `po_terms` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `salutation`
--

CREATE TABLE IF NOT EXISTS `salutation` (
`salutation_id` int(11) NOT NULL,
  `title` varchar(10) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `service`
--

CREATE TABLE IF NOT EXISTS `service` (
`serv_id` int(11) NOT NULL,
  `cust_id` int(11) NOT NULL,
  `inv_id` int(11) DEFAULT NULL,
  `serv_desc` varchar(50) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE IF NOT EXISTS `supplier` (
`supplier_id` int(11) NOT NULL,
  `address_id` int(11) NOT NULL,
  `supplier_name` text NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
`user_id` int(11) NOT NULL,
  `user_name` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=utf8;

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
