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


-- Membuang struktur basisdata untuk transaksi
CREATE DATABASE IF NOT EXISTS `transaksi` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `transaksi`;

-- membuang struktur untuk table transaksi.pengiriman_detail
CREATE TABLE IF NOT EXISTS `pengiriman_detail` (
  `id` int(11) NOT NULL,
  `itemdesc` char(50) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `satuan` char(50) DEFAULT NULL,
  `goodcategory` char(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel transaksi.pengiriman_detail: ~0 rows (lebih kurang)
/*!40000 ALTER TABLE `pengiriman_detail` DISABLE KEYS */;
/*!40000 ALTER TABLE `pengiriman_detail` ENABLE KEYS */;

-- membuang struktur untuk table transaksi.pengiriman_header
CREATE TABLE IF NOT EXISTS `pengiriman_header` (
  `pengirimanid` char(50) NOT NULL,
  `requesttype` char(50) DEFAULT NULL,
  `portorigin` char(50) DEFAULT NULL,
  `portdestination` char(50) DEFAULT NULL,
  `shipmenmode` char(50) DEFAULT NULL,
  `weight` int(11) DEFAULT NULL,
  `dimension` char(50) DEFAULT NULL,
  `requestdate` date DEFAULT NULL,
  `requestby` char(50) DEFAULT NULL,
  PRIMARY KEY (`pengirimanid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel transaksi.pengiriman_header: ~1 rows (lebih kurang)
/*!40000 ALTER TABLE `pengiriman_header` DISABLE KEYS */;
/*!40000 ALTER TABLE `pengiriman_header` ENABLE KEYS */;

-- membuang struktur untuk table transaksi.port_list
CREATE TABLE IF NOT EXISTS `port_list` (
  `port_id` char(50) NOT NULL,
  `port_country` char(50) DEFAULT NULL,
  `port_name` char(50) DEFAULT NULL,
  PRIMARY KEY (`port_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel transaksi.port_list: ~11 rows (lebih kurang)
/*!40000 ALTER TABLE `port_list` DISABLE KEYS */;
INSERT INTO `port_list` (`port_id`, `port_country`, `port_name`) VALUES
	('BNE', 'AUTRALIA', 'BRISBANE'),
	('CGK', 'INDONESIA', 'SOEKARNO HATTA'),
	('DPS', 'INDONESIA', 'NGURAH RAI INTENATIONAL'),
	('DUB', 'IRELAND', 'DUBLIN AIRPOT'),
	('HND', 'JAPAN', 'HANEDA INTERNATIONAL'),
	('JED', 'ARAB SAUDI', 'KING ABDUL AZIZ'),
	('LGB', 'USA', 'LONG BEACH MINUCIPAL'),
	('MED', 'ARA SAUDI', 'PRINCE MOHAMMED'),
	('ORD', 'USA', 'OHAREINTERNATIONAL'),
	('SAC', 'USA', 'SACRAMENTO EXECUTIVE'),
	('SYD', 'AUSTRALIA', 'SYDNEY');
/*!40000 ALTER TABLE `port_list` ENABLE KEYS */;

-- membuang struktur untuk table transaksi.user
CREATE TABLE IF NOT EXISTS `user` (
  `userid` char(50) NOT NULL,
  `name` char(50) DEFAULT NULL,
  `level` char(50) DEFAULT NULL,
  `password` char(50) DEFAULT NULL,
  PRIMARY KEY (`userid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Membuang data untuk tabel transaksi.user: ~0 rows (lebih kurang)
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
