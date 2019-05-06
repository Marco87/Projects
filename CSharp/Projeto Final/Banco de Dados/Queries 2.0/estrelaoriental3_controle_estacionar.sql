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
-- Table structure for table `controle_estacionar`
--

DROP TABLE IF EXISTS `controle_estacionar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `controle_estacionar` (
  `idControle_Registro` int(11) NOT NULL AUTO_INCREMENT,
  `dataHoraEntrada` datetime DEFAULT NULL,
  `dataHoraSaida` datetime DEFAULT NULL,
  `valor` float DEFAULT NULL,
  `idVaga` int(11) DEFAULT NULL,
  `idGerenciarSituacaoPagamento` int(11) DEFAULT NULL,
  PRIMARY KEY (`idControle_Registro`),
  KEY `idVaga_idx` (`idVaga`),
  KEY `idGerenciarSituacaoPagamento_idx` (`idGerenciarSituacaoPagamento`),
  CONSTRAINT `idGerenciarSituacaoPagamento` FOREIGN KEY (`idGerenciarSituacaoPagamento`) REFERENCES `gerenciar_situacao_pagamento` (`idGerenciarSituacaoPagamento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `idVaga` FOREIGN KEY (`idVaga`) REFERENCES `vaga` (`idVaga`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controle_estacionar`
--

LOCK TABLES `controle_estacionar` WRITE;
/*!40000 ALTER TABLE `controle_estacionar` DISABLE KEYS */;
/*!40000 ALTER TABLE `controle_estacionar` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-06-12 20:57:53
