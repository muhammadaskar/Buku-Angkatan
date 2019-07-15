-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 15 Jul 2019 pada 15.02
-- Versi server: 10.1.39-MariaDB
-- Versi PHP: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `buku_angkatan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `mhs_filkom`
--

CREATE TABLE `mhs_filkom` (
  `nim` varchar(16) NOT NULL,
  `nama` char(30) NOT NULL,
  `jenis_kelamin` varchar(20) NOT NULL,
  `prodi` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `mhs_filkom`
--

INSERT INTO `mhs_filkom` (`nim`, `nama`, `jenis_kelamin`, `prodi`) VALUES
('185150201111005', 'Agus Fajri', 'Laki-laki', 'Teknik Informatika'),
('185150301111009', 'Bayu Saptaji', 'Laki-laki', 'Teknik Komputer'),
('185150401111020', 'Sinta Jojo', 'Perempuan', 'Sistem Informasi'),
('185150601111002', 'Muhammad Askar', 'Laki-laki', 'Teknik Informatika'),
('185150601111003', 'Baco', 'Laki-laki', 'Pendidikan Teknologi Informasi'),
('185150701111002', 'Akbar Al Gazali', 'Laki-laki', 'Teknologi Informasi'),
('as', 'as', 'Laki-laki', 'Teknik Komputer');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `mhs_filkom`
--
ALTER TABLE `mhs_filkom`
  ADD PRIMARY KEY (`nim`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
