-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 13, 2019 at 04:27 PM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bdd_appcohisa`
--
-- https://www.youtube.com/watch?v=HZ1c25OIX4o		recuperar los archivos hechos commit
-- --------------------------------------------------------

--
-- Table structure for table `persona`
--

CREATE TABLE `persona` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `persona`
--

INSERT INTO `persona` (`id`, `nombre`, `apellido`) VALUES
(1, 'juan', 'males'),
(2, 'luis', 'perz'),
(3, 'pedro', 'diaz'),
(4, 'luisa', 'males'),
(5, '', '');

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `correo` varchar(100) NOT NULL,
  `password` varchar(50) NOT NULL,
  `confipassword` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`id`, `correo`, `password`, `confipassword`) VALUES
(1, 'lyon12189@gmail.com', '123', '123'),
(2, 'luis@gmail.com', '1234', '1234'),
(3, 'lyon12189@gmail.com', 'lyon', 'lyon'),
(4, 'lyon@gmail.com', '', ''),
(5, 'lyon12189@gmail.com', '123456', '123456'),
(6, 'maryesliss@hotmail.com', '123', '123'),
(7, 'lyon12189@gmail.co', 'System.Windows.Forms.TextBox, Text: 123', 'System.Windows.Forms.TextBox, Text: 123'),
(8, 'lyon12189@gmail.com', '123', '123'),
(9, 'lyon12189@gmail.com', '1', '1');

-- --------------------------------------------------------

--
-- Table structure for table `verificacion`
--

CREATE TABLE `verificacion` (
  `id` int(11) NOT NULL,
  `codigoverificacion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `verificacion`
--

INSERT INTO `verificacion` (`id`, `codigoverificacion`) VALUES
(1, 6358),
(2, 6441),
(3, 5221),
(4, 2595),
(5, 8181),
(6, 4122),
(7, 5141),
(8, 2696),
(9, 5019),
(10, 6448),
(11, 2502),
(12, 6305),
(13, 7906),
(14, 3916),
(15, 1756),
(16, 3331),
(17, 4851);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `verificacion`
--
ALTER TABLE `verificacion`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `persona`
--
ALTER TABLE `persona`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `verificacion`
--
ALTER TABLE `verificacion`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
