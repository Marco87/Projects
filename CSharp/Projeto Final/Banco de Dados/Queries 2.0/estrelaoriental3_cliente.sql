CREATE DATABASE  IF NOT EXISTS `estrelaoriental3` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `estrelaoriental3`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: 186.202.152.106    Database: estrelaoriental3
-- ------------------------------------------------------
-- Server version	5.1.70-rel14.7-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `telefone` varchar(45) DEFAULT NULL,
  `Celular` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `endereco` varchar(45) DEFAULT NULL,
  `tipoCliente` varchar(2) DEFAULT NULL,
  `login` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'MARCO','(  )     -','(  )      -','','','PF',NULL),(2,'JOÃO','(  )     -','(  )      -','','','PF',NULL),(3,'JOSÉ','(  )     -','(  )      -','','','PF',NULL),(4,'SAMIR','(  )     -','(  )      -','','','PF',NULL),(5,'PACO','(  )     -','(  )      -','','','PF',NULL),(6,'ALLEJO','(  )     -','(  )      -','','','PF',NULL),(7,'KIMI','(  )     -','(  )      -','','','PF',NULL),(8,'CLODOALDO','(  )     -','(  )      -','','','PF',NULL),(9,'MIRO','(  )     -','(  )      -','','','PF',NULL),(10,'CECI','(  )     -','(  )      -','','','PF',NULL),(11,'CELIO','(11) 3344-5566','(11) 98877-8877','','','PF','CEL-0012'),(12,'JOSE','(  )     -','(  )      -','','','PF','JOS-3254'),(13,'FÁBRICA DE SABÃO','(21) 2522-4543','(21) 98760-9877','','','PJ','FSB-3287'),(14,'JOÃO','(21) 2535-3656','(21) 98398-8213','','RUA DO PAO DE QUEIJO, 32 - VILA ISABEL','PF','CCC-1111'),(15,'BOENTE','(21) 3456-7899','(21) 99999-9999','BOENTE@GMAIL.COM','','PF','BOE-1234'),(16,'GUSTAVO','(  )     -','(  )      -','','','PF','GUS-3322'),(17,'MATOS','(43) 2233-2123','(43) 98848-4748','','','PF','MAT-1122'),(18,'SANTOS','(  )     -','(  )      -','','','PF','SAN-5454'),(19,'SOUZA','(  )     -','(  )      -','','','PF','SOU-2323'),(20,'SILVIO SILVA','(  )     -','(  )      -','','','PF','SIL-4321');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-06-12 20:57:55
