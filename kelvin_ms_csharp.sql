-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 31, 2023 at 11:15 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hospital_ms_csharp`
--

-- --------------------------------------------------------

--
-- Table structure for table `doctor`
--

CREATE TABLE `doctor` (
  `pk` int(11) NOT NULL,
  `id` varchar(50) NOT NULL,
  `name` varchar(100) NOT NULL,
  `address` varchar(100) NOT NULL,
  `phone` int(100) NOT NULL,
  `gmail` varchar(100) NOT NULL,
  `specialization` varchar(100) NOT NULL,
  `qualifications` varchar(100) NOT NULL,
  `expertise` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `doctor`
--

INSERT INTO `doctor` (`pk`, `id`, `name`, `address`, `phone`, `gmail`, `specialization`, `qualifications`, `expertise`) VALUES
(1, '110', 'Mr.Nuhman', '10/2 love lane batticaloa', 715544933, '', 'general physician', 'MBBS', '');

-- --------------------------------------------------------

--
-- Table structure for table `doctor_with_patient_appointment_schedule`
--

CREATE TABLE `doctor_with_patient_appointment_schedule` (
  `id` int(11) NOT NULL,
  `doc_id` varchar(100) NOT NULL,
  `pat_id` varchar(100) NOT NULL,
  `date` date NOT NULL,
  `time_slot` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `doctor_with_patient_appointment_schedule`
--

INSERT INTO `doctor_with_patient_appointment_schedule` (`id`, `doc_id`, `pat_id`, `date`, `time_slot`) VALUES
(1, '110', '2', '2023-12-31', '11 AM   TO     12 PM');

-- --------------------------------------------------------

--
-- Table structure for table `medical_resource`
--

CREATE TABLE `medical_resource` (
  `id` int(11) NOT NULL,
  `equipment_type` varchar(100) NOT NULL,
  `model` varchar(100) NOT NULL,
  `menufectrurer` varchar(100) NOT NULL,
  `serial_number` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `medicine_detailes`
--

CREATE TABLE `medicine_detailes` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `dosage_formate` varchar(100) NOT NULL,
  `description` varchar(100) NOT NULL,
  `amount` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `medicine_detailes`
--

INSERT INTO `medicine_detailes` (`id`, `name`, `dosage_formate`, `description`, `amount`) VALUES
(1, 'Penedol', 'Solod', 'd', 50),
(3, 'Minoxidil', '250MG', 'asd', 200);

-- --------------------------------------------------------

--
-- Table structure for table `patient_medication_schedule`
--

CREATE TABLE `patient_medication_schedule` (
  `id` int(11) NOT NULL,
  `pat_id` varchar(100) NOT NULL,
  `medicine_name` varchar(100) NOT NULL,
  `dosage` varchar(100) NOT NULL,
  `duration` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patient_medication_schedule`
--

INSERT INTO `patient_medication_schedule` (`id`, `pat_id`, `medicine_name`, `dosage`, `duration`) VALUES
(1, '2', 'Penedol', '150mg', '3 days'),
(3, '1', 'Penedol', '250mg', '5 days');

-- --------------------------------------------------------

--
-- Table structure for table `patient_medicin_prescription`
--

CREATE TABLE `patient_medicin_prescription` (
  `id` int(11) NOT NULL,
  `pat_id` varchar(100) NOT NULL,
  `medicine_name` varchar(100) NOT NULL,
  `qty` double NOT NULL,
  `amount` double NOT NULL,
  `tot_amount` double NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patient_medicin_prescription`
--

INSERT INTO `patient_medicin_prescription` (`id`, `pat_id`, `medicine_name`, `qty`, `amount`, `tot_amount`, `date`) VALUES
(1, '1', 'Penedol', 2, 20, 40, '2023-12-30'),
(2, '1', 'Penedol', 2, 20, 40, '2023-12-30'),
(3, '1', 'Penedol', 2, 20, 40, '2023-12-30'),
(4, '1', 'Penedol', 2, 20, 40, '2023-12-30'),
(5, '1', 'Penedol', 2, 20, 40, '2023-12-30'),
(6, '1', 'Penedol', 2, 20, 40, '2023-12-30'),
(7, '1', 'Penedol', 2, 20, 40, '2023-12-30'),
(8, '1', 'Penedol', 2, 20, 40, '2023-12-30'),
(9, '1', 'Penedol', 2, 22, 44, '2023-12-30'),
(10, '1', 'Penedol', 2, 11, 22, '2023-12-30'),
(11, '1', 'Penedol', 23, 12, 276, '2023-12-30'),
(12, '1', 'Penedol', 2, 23, 46, '2023-12-30'),
(13, '1', 'Penedol', 11, 11, 121, '2023-12-30'),
(14, '1', 'Penedol', 1, 111, 111, '2023-12-30'),
(15, '1', 'Penedol', 2, 12, 24, '2023-12-30'),
(16, '1', 'Penedol', 111, 23234, 2578974, '2023-12-30'),
(17, '1', 'Penedol', 243, 143, 34749, '2023-12-30'),
(18, '1', 'Penedol', 435242, 53345, 0, '2023-12-30'),
(19, '1', 'Penedol', 23, 123, 2829, '2023-12-30'),
(20, '1', 'Penedol', 10, 500, 5000, '2023-12-30'),
(21, '1', 'Penedol', 52, 6000, 0, '2023-12-30'),
(22, '2', 'Penedol', 3, 100, 0, '2023-12-30'),
(23, '1', 'Penedol', 5, 50, 250, '2023-12-31'),
(24, '1', 'ROOM NO : 02', 5, 1000, 5000, '2023-12-31'),
(25, '1', 'Penedol', 5, 50, 250, '2023-12-31'),
(26, '1', 'ROOM NO : 02', 2, 1000, 2000, '2023-12-31'),
(27, '1', 'Penedol', 5, 50, 250, '2023-12-31'),
(28, '1', 'ROOM NO : 02', 2, 1000, 2000, '2023-12-31'),
(29, '1', 'Minoxidil', 2, 200, 400, '2023-12-31'),
(30, '1', 'ROOM NO : 02', 2, 1000, 2000, '2023-12-31'),
(31, '2', 'Penedol', 5, 50, 0, '2023-12-31'),
(32, '1', 'Minoxidil', 5, 200, 1000, '2023-12-31'),
(33, '1', 'ROOM NO : 02', 2, 1000, 2000, '2023-12-31'),
(34, '2', 'Penedol', 5, 50, 250, '2023-12-31'),
(35, '2', 'ROOM NO : 02', 1, 1000, 1000, '2023-12-31'),
(36, '1', 'Penedol', 4, 50, 200, '2023-12-31'),
(37, '1', 'ROOM NO : 01', 3, 500, 1500, '2023-12-31'),
(38, '2', 'Penedol', 6, 50, 300, '2023-12-31'),
(39, '2', 'ROOM NO : 02', 6, 1000, 6000, '2023-12-31'),
(40, '1', 'Penedol', 6, 50, 300, '2023-12-31'),
(41, '1', 'ROOM NO : 01', 6, 500, 3000, '2023-12-31');

-- --------------------------------------------------------

--
-- Table structure for table `patient_reg`
--

CREATE TABLE `patient_reg` (
  `pk` int(11) NOT NULL,
  `id` varchar(50) NOT NULL,
  `name` varchar(100) NOT NULL,
  `nic` varchar(50) NOT NULL,
  `address` varchar(100) NOT NULL,
  `phone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patient_reg`
--

INSERT INTO `patient_reg` (`pk`, `id`, `name`, `nic`, `address`, `phone`) VALUES
(1, '1', 'ef', 'ds', 'dsa', 1),
(2, '2', 'kelvin', '923201831v', '10/love lane, Batticaloa', 774567899);

-- --------------------------------------------------------

--
-- Table structure for table `room_schedule`
--

CREATE TABLE `room_schedule` (
  `id` int(11) NOT NULL,
  `pat_id` varchar(100) NOT NULL,
  `admission_date` date NOT NULL,
  `room_type` varchar(50) NOT NULL,
  `room_no` varchar(100) NOT NULL,
  `disarge_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `room_schedule`
--

INSERT INTO `room_schedule` (`id`, `pat_id`, `admission_date`, `room_type`, `room_no`, `disarge_date`) VALUES
(12, '1', '2024-02-01', 'AC', 'NO : 01', '2024-02-02');

-- --------------------------------------------------------

--
-- Table structure for table `room_with_amt`
--

CREATE TABLE `room_with_amt` (
  `room_no` varchar(100) NOT NULL,
  `descr` varchar(100) NOT NULL,
  `amnt` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `room_with_amt`
--

INSERT INTO `room_with_amt` (`room_no`, `descr`, `amnt`) VALUES
('ROOM NO : 01', 'df', 500),
('ROOM NO : 02', 'e', 1000);

-- --------------------------------------------------------

--
-- Table structure for table `staff_registration`
--

CREATE TABLE `staff_registration` (
  `id` int(11) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `phone` int(11) NOT NULL,
  `role` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `staff_registration`
--

INSERT INTO `staff_registration` (`id`, `first_name`, `last_name`, `email`, `phone`, `role`, `password`) VALUES
(2, 'wads', 'asd', '1', 1, 'DOCTOR', '1'),
(3, 'kelvin', 'crushano', 'kelvinmmx@gmail.com', 771445833, 'ADMIN', '123456');

-- --------------------------------------------------------

--
-- Table structure for table `theater_schedule`
--

CREATE TABLE `theater_schedule` (
  `id` int(11) NOT NULL,
  `pat_id` varchar(100) NOT NULL,
  `admission_date` date NOT NULL,
  `type` varchar(50) NOT NULL,
  `theater_no` varchar(100) NOT NULL,
  `disarge_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `theater_schedule`
--

INSERT INTO `theater_schedule` (`id`, `pat_id`, `admission_date`, `type`, `theater_no`, `disarge_date`) VALUES
(1, '1', '2023-12-30', 'INDERMEDIATE', 'NO : 01', '2023-12-30'),
(2, '1', '2023-12-30', 'NORMAL', 'NO : 02', '2023-12-30'),
(3, '1', '2023-12-31', 'NORMAL', 'NO : 02', '2023-12-30');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `doctor`
--
ALTER TABLE `doctor`
  ADD PRIMARY KEY (`pk`);

--
-- Indexes for table `doctor_with_patient_appointment_schedule`
--
ALTER TABLE `doctor_with_patient_appointment_schedule`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `medical_resource`
--
ALTER TABLE `medical_resource`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `medicine_detailes`
--
ALTER TABLE `medicine_detailes`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `patient_medication_schedule`
--
ALTER TABLE `patient_medication_schedule`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `patient_medicin_prescription`
--
ALTER TABLE `patient_medicin_prescription`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `patient_reg`
--
ALTER TABLE `patient_reg`
  ADD PRIMARY KEY (`pk`);

--
-- Indexes for table `room_schedule`
--
ALTER TABLE `room_schedule`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `room_with_amt`
--
ALTER TABLE `room_with_amt`
  ADD PRIMARY KEY (`room_no`);

--
-- Indexes for table `staff_registration`
--
ALTER TABLE `staff_registration`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `theater_schedule`
--
ALTER TABLE `theater_schedule`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `doctor`
--
ALTER TABLE `doctor`
  MODIFY `pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `doctor_with_patient_appointment_schedule`
--
ALTER TABLE `doctor_with_patient_appointment_schedule`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `medical_resource`
--
ALTER TABLE `medical_resource`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `medicine_detailes`
--
ALTER TABLE `medicine_detailes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `patient_medication_schedule`
--
ALTER TABLE `patient_medication_schedule`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `patient_medicin_prescription`
--
ALTER TABLE `patient_medicin_prescription`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `patient_reg`
--
ALTER TABLE `patient_reg`
  MODIFY `pk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `room_schedule`
--
ALTER TABLE `room_schedule`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `staff_registration`
--
ALTER TABLE `staff_registration`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `theater_schedule`
--
ALTER TABLE `theater_schedule`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
