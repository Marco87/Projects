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
-- Table structure for table `gerenciar_situacao_pagamento`
--

DROP TABLE IF EXISTS `gerenciar_situacao_pagamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gerenciar_situacao_pagamento` (
  `idGerenciarSituacaoPagamento` int(11) NOT NULL AUTO_INCREMENT,
  `idCliente` int(11) NOT NULL,
  `idVeiculo` int(11) NOT NULL,
  `idTipoPlanoEstacionamento` int(11) NOT NULL,
  `situacaoPagamento` varchar(45) DEFAULT NULL,
  `vencimentoPagamento` datetime DEFAULT NULL,
  `mesesPagos` int(11) DEFAULT NULL,
  PRIMARY KEY (`idGerenciarSituacaoPagamento`),
  KEY `idTipoPlanoEstacionamento_idx` (`idTipoPlanoEstacionamento`),
  KEY `id_Cliente_idx` (`idCliente`),
  KEY `id_Veiculo_idx` (`idVeiculo`),
  CONSTRAINT `idTipoPlanoEstacionamento` FOREIGN KEY (`idTipoPlanoEstacionamento`) REFERENCES `tipo_plano_estacionamento` (`idTipoEstacionamento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `id_Cliente` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `id_Veiculo` FOREIGN KEY (`idVeiculo`) REFERENCES `veiculo` (`idVeiculo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gerenciar_situacao_pagamento`
--

LOCK TABLES `gerenciar_situacao_pagamento` WRITE;
/*!40000 ALTER TABLE `gerenciar_situacao_pagamento` DISABLE KEYS */;
INSERT INTO `gerenciar_situacao_pagamento` VALUES (1,13,14,1,NULL,NULL,NULL);
/*!40000 ALTER TABLE `gerenciar_situacao_pagamento` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-06-12 20:57:47
