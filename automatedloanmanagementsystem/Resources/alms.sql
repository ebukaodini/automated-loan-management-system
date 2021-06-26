-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 11, 2017 at 04:32 PM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `alms`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `telephone` char(15) NOT NULL,
  `email` varchar(40) NOT NULL,
  `address` text NOT NULL,
  `acc_no` char(15) NOT NULL,
  `created` timestamp NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `emi`
--

CREATE TABLE `emi` (
  `id` int(11) NOT NULL,
  `loan_id` int(11) NOT NULL,
  `loan_emi_id` int(11) NOT NULL,
  `payment_id` int(11) DEFAULT NULL,
  `emi` decimal(10,2) DEFAULT NULL,
  `balance` decimal(10,2) DEFAULT NULL,
  `paid` tinyint(2) DEFAULT NULL,
  `next_payment` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `granted_loans`
--

CREATE TABLE `granted_loans` (
  `id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `guarantor_id` int(11) NOT NULL,
  `security_id` int(11) NOT NULL,
  `payment_id` int(11) DEFAULT NULL,
  `name` varchar(20) NOT NULL,
  `type` varchar(20) NOT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `tenure` int(11) NOT NULL,
  `issued` date NOT NULL,
  `expiration` date NOT NULL,
  `repay_date` date NOT NULL,
  `intr_rate` decimal(10,1) DEFAULT NULL,
  `cost` decimal(10,2) DEFAULT NULL,
  `emi` decimal(10,2) DEFAULT NULL,
  `no_emi` int(11) NOT NULL,
  `granted_by` varchar(20) NOT NULL,
  `paid` tinyint(2) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `guarantors`
--

CREATE TABLE `guarantors` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `telephone` char(15) NOT NULL,
  `email` varchar(40) NOT NULL,
  `address` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `interest_rates`
--

CREATE TABLE `interest_rates` (
  `intr_home` decimal(10,2) DEFAULT NULL,
  `intr_demand` decimal(10,2) DEFAULT NULL,
  `intr_student` decimal(10,2) DEFAULT NULL,
  `intr_bridge` decimal(10,2) DEFAULT NULL,
  `intr_bank` decimal(10,2) DEFAULT NULL,
  `intr_interbank` decimal(10,2) DEFAULT NULL,
  `intr_business` decimal(10,2) DEFAULT NULL,
  `intr_commercial` decimal(10,2) DEFAULT NULL,
  `intr_installation` decimal(10,2) DEFAULT NULL,
  `intr_personal` decimal(10,2) DEFAULT NULL,
  `intr_consumer` decimal(10,2) DEFAULT NULL,
  `intr_automobile` decimal(10,2) DEFAULT NULL,
  `intr_realestate` decimal(10,2) DEFAULT NULL,
  `intr_arrears` decimal(10,2) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `loan_security`
--

CREATE TABLE `loan_security` (
  `id` int(11) NOT NULL,
  `security` varchar(20) NOT NULL,
  `details` text NOT NULL,
  `value` decimal(10,2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `id` int(11) NOT NULL,
  `loan_id` int(11) NOT NULL,
  `emi_id` int(11) NOT NULL,
  `amount_due` decimal(10,2) DEFAULT NULL,
  `xtra_charges` decimal(10,2) DEFAULT NULL,
  `total_cost` decimal(10,2) DEFAULT NULL,
  `amount_paid` decimal(10,2) DEFAULT NULL,
  `balance` decimal(10,2) DEFAULT NULL,
  `date_recieved` timestamp NOT NULL,
  `recieved_by` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `date_created` timestamp NOT NULL,
  `role` set('admin','supervisor','cashier') NOT NULL,
  `barred` tinyint(2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user_logs`
--

CREATE TABLE `user_logs` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `user_login` timestamp NULL DEFAULT NULL,
  `user_logout` timestamp NULL DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`id`),
  ADD KEY `created` (`created`),
  ADD KEY `telephone` (`telephone`),
  ADD KEY `name` (`name`),
  ADD KEY `acc_no` (`acc_no`),
  ADD KEY `email` (`email`);

--
-- Indexes for table `emi`
--
ALTER TABLE `emi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `loan_id` (`loan_id`,`loan_emi_id`,`payment_id`,`emi`,`balance`,`paid`,`next_payment`);

--
-- Indexes for table `granted_loans`
--
ALTER TABLE `granted_loans`
  ADD PRIMARY KEY (`id`),
  ADD KEY `customer_id` (`customer_id`,`guarantor_id`,`security_id`,`payment_id`,`name`,`amount`,`tenure`,`issued`,`expiration`,`repay_date`,`intr_rate`,`cost`,`emi`,`no_emi`,`granted_by`,`paid`),
  ADD KEY `type` (`type`);

--
-- Indexes for table `guarantors`
--
ALTER TABLE `guarantors`
  ADD PRIMARY KEY (`id`),
  ADD KEY `name` (`name`),
  ADD KEY `telephone` (`telephone`),
  ADD KEY `email` (`email`);

--
-- Indexes for table `interest_rates`
--
ALTER TABLE `interest_rates`
  ADD KEY `intr_home` (`intr_home`,`intr_demand`,`intr_student`,`intr_bridge`,`intr_bank`,`intr_interbank`,`intr_business`,`intr_commercial`,`intr_installation`,`intr_personal`,`intr_consumer`,`intr_automobile`,`intr_realestate`,`intr_arrears`);

--
-- Indexes for table `loan_security`
--
ALTER TABLE `loan_security`
  ADD PRIMARY KEY (`id`),
  ADD KEY `security` (`security`),
  ADD KEY `value` (`value`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`id`),
  ADD KEY `loan_id` (`loan_id`,`emi_id`,`amount_due`,`xtra_charges`,`total_cost`,`amount_paid`,`balance`,`date_recieved`,`recieved_by`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `username` (`username`),
  ADD KEY `password` (`password`),
  ADD KEY `date_created` (`date_created`),
  ADD KEY `role` (`role`),
  ADD KEY `barred` (`barred`);

--
-- Indexes for table `user_logs`
--
ALTER TABLE `user_logs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id` (`id`),
  ADD KEY `id_2` (`id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `user_logout` (`user_logout`),
  ADD KEY `user_login` (`user_login`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `emi`
--
ALTER TABLE `emi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `granted_loans`
--
ALTER TABLE `granted_loans`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `guarantors`
--
ALTER TABLE `guarantors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `loan_security`
--
ALTER TABLE `loan_security`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `user_logs`
--
ALTER TABLE `user_logs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
