-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versi server:                 10.1.21-MariaDB - mariadb.org binary distribution
-- OS Server:                    Win32
-- HeidiSQL Versi:               9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Membuang struktur basisdata untuk member
CREATE DATABASE IF NOT EXISTS `member` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `member`;

-- membuang struktur untuk table member.ini_member
CREATE TABLE IF NOT EXISTS `ini_member` (
  `member_id` varchar(50) NOT NULL,
  `nama_lengkap` varchar(50) DEFAULT NULL,
  `jenis_kelamin` enum('pria','wanita') DEFAULT NULL,
  `tanggal_lahir` date DEFAULT NULL,
  `telepon` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `kota` varchar(50) DEFAULT NULL,
  `kode_pos` char(50) DEFAULT NULL,
  `catatan` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`member_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel member.ini_member: ~0 rows (lebih kurang)
/*!40000 ALTER TABLE `ini_member` DISABLE KEYS */;
INSERT INTO `ini_member` (`member_id`, `nama_lengkap`, `jenis_kelamin`, `tanggal_lahir`, `telepon`, `email`, `alamat`, `kota`, `kode_pos`, `catatan`) VALUES
	('mbr0000001', '2', '', '1999-12-02', '', '', '', NULL, NULL, NULL),
	('mbr0000002', '2', '', '1999-12-02', '', '', '', NULL, NULL, NULL),
	('mbr0000003', '2', '', '1999-12-02', '', '', '', NULL, NULL, NULL),
	('mbr0000004', '2', '', '1999-12-02', '', '', '', NULL, NULL, NULL),
	('mbr0000005', '2', '', '1999-12-02', '', '', '', NULL, NULL, NULL);
/*!40000 ALTER TABLE `ini_member` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
