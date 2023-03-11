-- MySqlBackup.NET 2.3.8.0
-- Dump Time: 2023-03-11 04:08:36
-- --------------------------------------
-- Server version 8.0.32 MySQL Community Server - GPL


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of booking_backup
-- 

DROP TABLE IF EXISTS `booking_backup`;
CREATE TABLE IF NOT EXISTS `booking_backup` (
  `id` int NOT NULL AUTO_INCREMENT,
  `date` datetime DEFAULT NULL,
  `discount` int DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `id_client` int DEFAULT NULL,
  `id_employee` int DEFAULT NULL,
  `id_service` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_client_idx` (`id_client`),
  KEY `employee_idx` (`id_employee`),
  KEY `service_idx` (`id_service`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 
-- Dumping data for table booking_backup
-- 

/*!40000 ALTER TABLE `booking_backup` DISABLE KEYS */;
INSERT INTO `booking_backup`(`id`,`date`,`discount`,`status`,`id_client`,`id_employee`,`id_service`) VALUES(34,'2023-03-11 00:00:00',2,'я статус',1,1,1),(35,'2023-03-11 00:00:00',0,'в работе',1,1,1),(36,'2023-03-11 00:00:00',0,'закрыт',1,1,1);
/*!40000 ALTER TABLE `booking_backup` ENABLE KEYS */;

-- 
-- Definition of client
-- 

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `adress` varchar(45) DEFAULT NULL,
  `phone_number` varchar(16) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 
-- Dumping data for table client
-- 

/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client`(`id`,`name`,`adress`,`phone_number`) VALUES(1,'Иван','ул Московская','+79991112233'),(2,'Николая','ул Победы','+79991112244'),(3,'ООО \"Победа\"','ул Свободы','+79881112244');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;

-- 
-- Definition of employee
-- 

DROP TABLE IF EXISTS `employee`;
CREATE TABLE IF NOT EXISTS `employee` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `login` varchar(20) DEFAULT NULL,
  `password` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 
-- Dumping data for table employee
-- 

/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee`(`id`,`name`,`login`,`password`) VALUES(1,'Вячеслав','1','1');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;

-- 
-- Definition of service
-- 

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `price` float DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 
-- Dumping data for table service
-- 

/*!40000 ALTER TABLE `service` DISABLE KEYS */;
INSERT INTO `service`(`id`,`name`,`price`) VALUES(1,'починка',1000),(2,'обслуживание',2000),(3,'осмотр',3000);
/*!40000 ALTER TABLE `service` ENABLE KEYS */;

-- 
-- Definition of booking
-- 

DROP TABLE IF EXISTS `booking`;
CREATE TABLE IF NOT EXISTS `booking` (
  `id` int NOT NULL AUTO_INCREMENT,
  `date` datetime DEFAULT NULL,
  `discount` int DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `id_client` int DEFAULT NULL,
  `id_employee` int DEFAULT NULL,
  `id_service` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_client_idx` (`id_client`),
  KEY `employee_idx` (`id_employee`),
  KEY `service_idx` (`id_service`),
  CONSTRAINT `client` FOREIGN KEY (`id_client`) REFERENCES `client` (`id`),
  CONSTRAINT `employee` FOREIGN KEY (`id_employee`) REFERENCES `employee` (`id`),
  CONSTRAINT `service` FOREIGN KEY (`id_service`) REFERENCES `service` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 
-- Dumping data for table booking
-- 

/*!40000 ALTER TABLE `booking` DISABLE KEYS */;
INSERT INTO `booking`(`id`,`date`,`discount`,`status`,`id_client`,`id_employee`,`id_service`) VALUES(37,'2023-03-11 00:00:00',0,'в работе',1,1,1);
/*!40000 ALTER TABLE `booking` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2023-03-11 04:08:36
-- Total time: 0:0:0:0:213 (d:h:m:s:ms)
