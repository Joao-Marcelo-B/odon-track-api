CREATE DATABASE  IF NOT EXISTS `odon_track` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `odon_track`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 100.100.193.67    Database: odon_track
-- ------------------------------------------------------
-- Server version	8.4.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `alternativas`
--

DROP TABLE IF EXISTS `alternativas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `alternativas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_pergunta` int DEFAULT NULL,
  `alternativa` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=239 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alternativas`
--

LOCK TABLES `alternativas` WRITE;
/*!40000 ALTER TABLE `alternativas` DISABLE KEYS */;
INSERT INTO `alternativas` VALUES (4,4,'Sim'),(5,4,'Nega'),(6,4,'N√£o sei'),(8,8,'Tranquilo'),(9,8,'Agitado'),(10,8,'Dorme muito'),(11,27,'Sim'),(12,27,'Nega'),(13,27,'N√£o sei'),(14,26,'Sim'),(15,26,'Nega'),(16,26,'N√£o sei'),(17,4,'Sim'),(18,4,'Nega'),(19,4,'N√£o sei'),(20,5,'Ignora'),(21,5,'Bate'),(22,5,'Grita'),(23,5,'Priva de atitudes desejadas'),(24,6,'Birrento'),(25,6,'Extrovertido'),(26,6,'Desconfiado'),(27,6,'Ansioso'),(28,6,'Mimado'),(29,6,'Inseguro'),(30,6,'Com fobias'),(31,6,'Agressivo'),(32,6,'Calmo'),(33,6,'T√≠mido'),(34,6,'Manhoso'),(35,6,'Outros'),(36,15,'Sim'),(37,15,'Nega'),(38,15,'N√£o sei'),(39,18,'Sim'),(40,18,'Nega'),(41,18,'N√£o sei'),(42,19,'Sim'),(43,19,'Nega'),(44,19,'N√£o sei'),(45,22,'Sim'),(46,22,'Nega'),(47,22,'N√£o sei'),(48,23,'Sim'),(49,23,'Nega'),(50,23,'N√£o sei'),(51,24,'Sim'),(52,24,'Nega'),(53,24,'N√£o sei'),(54,29,'Sim'),(55,29,'Nega'),(56,29,'N√£o sei'),(57,30,'Sim'),(58,30,'Nega'),(59,30,'N√£o sei'),(60,33,'Sim'),(61,33,'Nega'),(62,33,'N√£o sei / Qual(is)?'),(63,35,'Sim'),(64,35,'Nega'),(65,35,'N√£o sei'),(66,35,'Antibi√≥tico'),(67,35,'C√°lcio'),(68,35,'Fl√∫or'),(69,35,'Outro'),(70,37,'Normal'),(71,37,'Cesariana'),(72,37,'F√≥rceps'),(73,37,'Com atraso'),(74,37,'Prematuro'),(75,37,'N√£o sei'),(76,38,'Sim'),(77,38,'Nega'),(78,38,'N√£o sei / Qual(is)?'),(79,40,'Sim'),(80,40,'Nega'),(81,40,'N√£o sei / Motivo:'),(82,43,'Sim'),(83,43,'Nega'),(84,43,'N√£o sei'),(85,43,'Am√≠gdalas'),(86,43,'Adenoides'),(87,43,'Outras'),(88,45,'Sim'),(89,45,'Nega'),(90,45,'N√£o sei / Medicamentos / Qual(is)?'),(91,47,'Sim'),(92,47,'N√£o'),(93,47,'N√£o sei'),(94,48,'Sim'),(95,48,'N√£o'),(96,48,'N√£o sei'),(97,49,'Sim'),(98,49,'N√£o'),(99,49,'N√£o sei'),(100,50,'Sim'),(101,50,'N√£o'),(102,50,'N√£o sei'),(103,51,'Sim'),(104,51,'N√£o'),(105,51,'N√£o sei'),(106,52,'Sim'),(107,52,'N√£o'),(108,52,'N√£o sei'),(109,53,'Sim'),(110,53,'N√£o'),(111,53,'N√£o sei'),(112,54,'Sim'),(113,54,'N√£o'),(114,54,'N√£o sei'),(115,55,'Sim'),(116,55,'N√£o'),(117,55,'N√£o sei'),(118,56,'Sim'),(119,56,'N√£o'),(120,56,'N√£o sei'),(121,57,'Sim'),(122,57,'N√£o'),(123,57,'N√£o sei'),(124,58,'Sim'),(125,58,'N√£o'),(126,58,'N√£o sei'),(127,59,'Sim'),(128,59,'N√£o'),(129,59,'N√£o sei'),(130,60,'Sim'),(131,60,'N√£o'),(132,60,'N√£o sei'),(133,61,'Sim'),(134,61,'N√£o'),(135,61,'N√£o sei'),(136,62,'Sim'),(137,62,'N√£o'),(138,62,'N√£o sei'),(139,63,'Sim'),(140,63,'N√£o'),(141,63,'N√£o sei'),(142,64,'Sim'),(143,64,'N√£o'),(144,64,'N√£o sei'),(145,65,'Sim'),(146,65,'N√£o'),(147,65,'N√£o sei'),(148,66,'Sim'),(149,66,'N√£o'),(150,66,'N√£o sei'),(151,67,'Sim'),(152,67,'N√£o'),(153,67,'N√£o sei'),(154,68,'Sim'),(155,68,'N√£o'),(156,68,'N√£o sei'),(157,69,'Sim'),(158,69,'N√£o'),(159,69,'N√£o sei'),(160,12,'Periapical'),(161,12,'Interproximal'),(162,12,'Oclusal'),(163,12,'Panor√¢mica'),(164,213,'Plano'),(165,213,'Mesial'),(166,213,'Distal'),(167,186,'Superior'),(168,186,'Inferior'),(169,188,'Mista'),(170,188,'Permanente'),(171,189,'Reto'),(172,189,'Convexo'),(173,189,'C√¥ncavo'),(174,193,'Anterior'),(175,193,'Posterior'),(176,195,'Anterior'),(177,195,'Posterior'),(178,197,'T√≠pica'),(179,197,'At√≠pica'),(180,198,'Normal'),(181,198,'At√≠pica'),(182,200,'Normal'),(183,200,'At√≠pica'),(184,202,'Normal'),(185,202,'Desviada'),(186,204,'Normal'),(187,204,'Desviada'),(188,206,'Possu√≠?'),(189,208,'Possu√≠?'),(190,210,'Sim'),(191,210,'N√£o'),(192,214,'Sim'),(193,214,'Nega'),(194,215,'Sim'),(195,215,'Nega'),(196,218,'Sim'),(197,218,'Nega'),(198,219,'Sim'),(199,219,'Nega'),(200,219,'√Äs vezes'),(201,220,'Diurna'),(202,220,'Noturna'),(203,224,'Diurna'),(204,224,'Noturna'),(205,228,'Leite'),(206,228,'Ch√°'),(207,228,'Suco natural'),(208,228,'Suco artificial'),(209,228,'Refrigerantes'),(210,228,'Outros'),(211,235,'Doces caseiros'),(212,235,'Chocolate'),(213,235,'Bolachas'),(214,235,'Balas'),(215,235,'Danone'),(216,235,'Salgadinho'),(217,235,'Leite condensado'),(218,235,'Chicletes'),(219,235,'Yakult'),(220,237,'Chupeta'),(221,237,'Dedo'),(222,237,'Respirador bucal'),(223,237,'Morde objetos'),(224,237,'Morde l√°bios'),(225,237,'R√≥i unhas'),(226,237,'Interposi√ß√£o lingual'),(227,237,'Bruxismo'),(228,249,'C√°rie'),(229,249,'Doen√ßa periodontal'),(230,249,'Outros'),(231,273,'Selecionado'),(232,274,'Selecionado'),(233,276,'Selecionado'),(234,278,'Selecionado'),(235,280,'Selecionado'),(236,282,'Selecionado'),(237,283,'Selecionado'),(238,285,'Selecionado');
/*!40000 ALTER TABLE `alternativas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `codigo_seguranca`
--

DROP TABLE IF EXISTS `codigo_seguranca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `codigo_seguranca` (
  `id` int NOT NULL,
  `email` varchar(150) NOT NULL,
  `codigo` int NOT NULL,
  `validade` datetime NOT NULL,
  `usado` tinyint NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `codigo_seguranca`
--

LOCK TABLES `codigo_seguranca` WRITE;
/*!40000 ALTER TABLE `codigo_seguranca` DISABLE KEYS */;
INSERT INTO `codigo_seguranca` VALUES (1,'joao.pfernandes@aluno.unifenas.br',918574,'2024-05-31 21:02:54',0),(2,'joao.pfernandes@aluno.unifenas.br',138334,'2024-05-31 21:03:25',0),(3,'felipe.araujo@aluno.unifenas.br',536525,'2024-05-31 21:04:01',0),(4,'joao.pfernandes@aluno.unifenas.br',389953,'2024-05-31 21:12:15',0),(5,'joao.pfernandes@aluno.unifenas.br',340920,'2024-05-31 21:13:53',0),(6,'joao.pfernandes@aluno.unifenas.br',990368,'2024-05-31 21:17:34',0),(7,'joao.pfernandes@aluno.unifenas.br',601649,'2024-05-31 21:18:05',0),(8,'joao.pfernandes@aluno.unifenas.br',853040,'2024-05-31 21:19:44',0),(9,'joao.pfernandes@aluno.unifenas.br',648896,'2024-05-31 21:20:20',0),(10,'joao.pfernandes@aluno.unifenas.br',265379,'2024-05-31 21:25:16',0),(11,'joao.pfernandes@aluno.unifenas.br',232496,'2024-05-31 21:25:58',0),(12,'joao.pfernandes@aluno.unifenas.br',916766,'2024-05-31 21:49:48',0),(13,'joao.pfernandes@aluno.unifenas.br',772967,'2024-05-31 21:50:26',0),(14,'joao.pfernandes@aluno.unifenas.br',858764,'2024-05-31 21:53:30',0),(15,'joao.pfernandes@aluno.unifenas.br',541353,'2024-05-31 21:56:22',0),(16,'joao.pfernandes@aluno.unifenas.br',435841,'2024-05-31 21:57:11',0),(17,'joao.pfernandes@aluno.unifenas.br',932444,'2024-05-31 22:09:54',0),(18,'joao.pfernandes@aluno.unifenas.br',993817,'2024-05-31 22:38:39',0),(19,'joao.pfernandes@aluno.unifenas.br',547632,'2024-05-31 22:42:10',0),(20,'joao.pfernandes@aluno.unifenas.br',849727,'2024-05-31 22:44:35',0),(21,'joao.pfernandes@aluno.unifenas.br',315496,'2024-05-31 22:50:02',0),(22,'joao.pfernandes@aluno.unifenas.br',654358,'2024-06-01 00:01:24',0),(23,'joao.pfernandes@aluno.unifenas.br',922363,'2024-06-01 14:52:29',0),(24,'joao.pfernandes@aluno.unifenas.br',151153,'2024-06-01 15:14:47',0),(25,'joao.pfernandes@aluno.unifenas.br',281116,'2024-06-01 15:18:51',0),(26,'joao.pfernandes@aluno.unifenas.br',675712,'2024-06-01 15:20:29',0),(27,'joao.pfernandes@aluno.unifenas.br',798327,'2024-06-01 15:29:11',0),(28,'joao.narciso@aluno.unifenas.br',894729,'2024-06-01 16:01:40',0),(29,'joao.narciso@aluno.unifenas.br',403219,'2024-06-02 02:04:04',0),(30,'felipe.araujo@aluno.unifenas.br',408023,'2024-06-02 02:07:50',0),(31,'joao.narciso@aluno.unifenas.br',399908,'2024-06-02 02:08:01',0),(32,'joao.narciso@aluno.unifenas.br',612147,'2024-06-02 02:09:08',0),(33,'joao.narciso@aluno.unifenas.br',733593,'2024-06-02 02:10:27',0),(34,'joao.pfernandes@aluno.unifenas.br',262152,'2024-06-02 13:28:05',0),(35,'joao.pfernandes@aluno.unifenas.br',466036,'2024-06-02 20:02:58',0),(36,'joao.pfernandes@aluno.unifenas.br',793045,'2024-06-02 20:17:29',0),(37,'joao.pfernandes@aluno.unifenas.br',555346,'2024-06-02 20:20:00',0),(38,'joao.pfernandes@aluno.unifenas.br',872387,'2024-06-02 20:22:02',0),(39,'joao.pfernandes@aluno.unifenas.br',821097,'2024-06-02 20:28:45',0),(40,'joao.pfernandes@aluno.unifenas.br',547003,'2024-06-02 20:30:37',0),(41,'joao.pfernandes@aluno.unifenas.br',621549,'2024-06-02 23:35:03',0),(42,'joao.pfernandes@aluno.unifenas.br',170732,'2024-06-02 20:35:48',0),(43,'joao.pfernandes@aluno.unifenas.br',630700,'2024-06-02 20:37:51',0),(44,'joao.pfernandes@aluno.unifenas.br',770819,'2024-06-02 20:45:53',0),(45,'joao.pfernandes@aluno.unifenas.br',736135,'2024-06-02 20:51:02',0),(46,'joao.pfernandes@aluno.unifenas.br',923621,'2024-06-02 20:53:25',0),(47,'joao.pfernandes@aluno.unifenas.br',233948,'2024-06-02 20:57:13',0),(48,'joao.pfernandes@aluno.unifenas.br',289341,'2024-06-02 21:14:07',0),(49,'joao.pfernandes@aluno.unifenas.br',556751,'2024-06-02 21:15:13',0),(50,'joao.pfernandes@aluno.unifenas.br',796661,'2024-06-02 21:23:28',1),(51,'joao.pfernandes@aluno.unifenas.br',708832,'2024-06-03 01:00:41',1),(52,'joao.narciso@aluno.unifenas.br',291608,'2024-06-03 01:02:30',1),(53,'joao.pfernandes@aluno.unifenas.br',746406,'2024-06-03 11:31:27',1),(54,'joao.pfernandes@aluno.unifenas.br',756081,'2024-06-03 12:48:02',0),(55,'felipe.araujo@aluno.unifenas.br',471580,'2024-06-03 22:46:33',1),(56,'joao.pfernandes@aluno.unifenas.br',923728,'2024-06-04 23:43:42',1),(57,'joao.pfernandes@aluno.unifenas.br',312635,'2024-06-06 15:06:35',1),(58,'joao.narciso@aluno.unifenas.br',664318,'2024-06-08 17:29:42',1),(59,'joao.narciso@aluno.unifenas.br',261445,'2024-06-10 20:14:24',1),(60,'joao.pfernandes@aluno.unifenas.br',622075,'2024-06-14 23:07:08',1),(61,'joao.pfernandes@aluno.unifenas.br',845195,'2024-06-20 19:10:31',1),(62,'joao.pfernandes@aluno.unifenas.br',249720,'2024-06-24 02:11:02',0),(63,'joao.pfernandes@aluno.unifenas.br',348682,'2024-06-24 02:15:36',0),(64,'joao.pfernandes@aluno.unifenas.br',768991,'2024-06-26 05:44:21',1);
/*!40000 ALTER TABLE `codigo_seguranca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conduta_pronto_atendimento`
--

DROP TABLE IF EXISTS `conduta_pronto_atendimento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conduta_pronto_atendimento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_prontuario_pronto_atendimento` int NOT NULL,
  `cod_sus` varchar(45) NOT NULL,
  `conduta` varchar(200) NOT NULL,
  PRIMARY KEY (`id`,`id_prontuario_pronto_atendimento`),
  KEY `id_prontuario_pronto_atendimento` (`id_prontuario_pronto_atendimento`),
  CONSTRAINT `conduta_pronto_atendimento_ibfk_1` FOREIGN KEY (`id_prontuario_pronto_atendimento`) REFERENCES `prontuario_pronto_atendimento` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=81 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conduta_pronto_atendimento`
--

LOCK TABLES `conduta_pronto_atendimento` WRITE;
/*!40000 ALTER TABLE `conduta_pronto_atendimento` DISABLE KEYS */;
INSERT INTO `conduta_pronto_atendimento` VALUES (1,8,'123123','teste'),(2,8,'123','teste'),(3,9,'123123','teste'),(4,9,'123','teste'),(5,10,'123123','teste'),(6,10,'123','teste'),(7,11,'123123','teste'),(8,11,'123','teste'),(9,12,'123123','teste'),(10,12,'123','teste'),(11,13,'123123','teste'),(12,13,'123','teste'),(13,14,'123123','teste'),(14,14,'123','teste'),(15,15,'123123','teste'),(16,15,'123','teste'),(17,16,'123123','teste'),(18,16,'123','teste'),(19,17,'123123','teste'),(20,17,'123','teste'),(21,18,'123123','teste'),(22,18,'123','teste'),(23,19,'123123','teste'),(24,19,'123','teste'),(25,20,'123123','teste'),(26,20,'123','teste'),(27,21,'123123','teste'),(28,21,'123','teste'),(29,22,'123123','teste'),(30,22,'123','teste'),(31,23,'123123','teste'),(32,23,'123','teste'),(33,24,'123123','teste'),(34,24,'123','teste'),(35,25,'123123','teste'),(36,25,'123','teste'),(37,26,'123123','teste'),(38,26,'123','teste'),(39,27,'123123','teste'),(40,27,'123','teste'),(41,28,'123123','teste'),(42,28,'123','teste'),(43,29,'123123','teste'),(44,29,'123','teste'),(45,30,'123123','Matar'),(46,31,'123123','Matar'),(47,32,'123123','Matar'),(48,33,'123123','Matar'),(49,33,'123','Kill'),(50,33,'123123','Killing Spree'),(51,33,'123','Kill'),(52,36,'123123','Killing Spree'),(53,36,'123','Kill'),(54,36,'0000','Matar'),(55,36,'123','Kill'),(56,37,'0000','Matar'),(57,37,'123','Kill'),(58,37,'28072002','Jo√£o'),(59,37,'28072002','Jo√£o'),(60,37,'28072002','Jo√£o'),(61,37,'28072002','Jo√£o'),(62,38,'0000','Matar'),(63,38,'123','Kill'),(64,38,'28072002','Jo√£o'),(65,40,'0000','Matar'),(66,40,'123','Kill'),(67,40,'28072002','Jo√£o'),(68,40,'0asdasdasd000','asdasdasd'),(69,40,'1asdasdasdas23','asdasdasdasd'),(70,40,'asdasd','asdas'),(71,38,'0asdasdasd000','asdasdasd'),(72,38,'1asdasdasdas23','asdasdasdasd'),(73,38,'asdasd','asdas'),(74,41,'0asdasdasd000','asdasdasd'),(75,41,'1asdasdasdas23','asdasdasdasd'),(76,41,'asdasd','asdas'),(77,41,'teste','teste'),(78,43,'0asdasdasd000','asdasdasd'),(79,43,'1asdasdasdas23','asdasdasdasd'),(80,43,'asdasd','asdas');
/*!40000 ALTER TABLE `conduta_pronto_atendimento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consulta`
--

DROP TABLE IF EXISTS `consulta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consulta` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_paciente` int NOT NULL,
  `data_hora_consulta` datetime NOT NULL,
  `descricao` varchar(245) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `realizacao` enum('PACIENTE FALTOU','REALIZADA','A REALIZAR','REMARCADA','NADA CONSTA') NOT NULL DEFAULT 'A REALIZAR',
  `bloqueada` tinyint NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `paciente_FK_idx` (`id_paciente`),
  CONSTRAINT `paciente_FK` FOREIGN KEY (`id_paciente`) REFERENCES `paciente` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consulta`
--

LOCK TABLES `consulta` WRITE;
/*!40000 ALTER TABLE `consulta` DISABLE KEYS */;
INSERT INTO `consulta` VALUES (1,18,'2024-06-17 09:30:00','Teste 1','2024-06-16 17:35:53','NADA CONSTA',1),(2,16,'2024-06-27 07:00:00','teste asda','2024-06-16 22:46:52','NADA CONSTA',0),(3,17,'2024-06-27 10:30:00','tasvxiaosc','2024-06-17 01:57:50','NADA CONSTA',0),(4,19,'2024-06-28 15:45:00','Carie','2024-06-17 02:11:28','NADA CONSTA',0),(5,18,'2024-07-31 17:10:00','retorno para limpeza','2024-06-17 02:18:12','REALIZADA',1),(6,19,'2024-07-30 10:20:00','Retorno 12','2024-06-17 02:31:56','REMARCADA',1),(7,19,'2024-06-18 19:44:00','Retorno','2024-06-17 22:44:25','REALIZADA',1),(8,19,'2024-06-24 15:30:00','Carie asdasdASd','2024-06-22 15:36:57','NADA CONSTA',1),(9,19,'2024-06-22 16:00:00','ASDASDA','2024-06-22 15:43:21','REMARCADA',1),(10,17,'2024-06-22 17:50:00','Motivo 2','2024-06-22 15:50:08','REALIZADA',1),(11,19,'2024-06-22 15:52:00','Consulta Normal','2024-06-22 15:50:51','PACIENTE FALTOU',1),(12,19,'2024-06-23 15:53:00','dfgafgdfgsdf','2024-06-22 15:52:20','REALIZADA',1),(13,19,'2024-06-22 20:06:00','qweqwe','2024-06-22 16:02:16','REALIZADA',1),(14,19,'2024-06-24 22:58:00','123123','2024-06-23 22:57:50','REALIZADA',1),(15,20,'2024-06-27 21:41:00','dor no dente','2024-06-25 21:38:27','REMARCADA',1),(16,21,'2024-06-27 15:00:00','Limpeza Dental','2024-06-26 00:07:34','PACIENTE FALTOU',1);
/*!40000 ALTER TABLE `consulta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `disciplina`
--

DROP TABLE IF EXISTS `disciplina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `disciplina` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `disciplina`
--

LOCK TABLES `disciplina` WRITE;
/*!40000 ALTER TABLE `disciplina` DISABLE KEYS */;
INSERT INTO `disciplina` VALUES (1,'Disciplina A'),(2,'Disciplina B'),(4,'Disciplina D'),(18,'Disciplina X'),(20,'teste 1');
/*!40000 ALTER TABLE `disciplina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `disciplinas_professor`
--

DROP TABLE IF EXISTS `disciplinas_professor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `disciplinas_professor` (
  `id_disciplinas` int NOT NULL,
  `id_professor` int NOT NULL,
  PRIMARY KEY (`id_disciplinas`,`id_professor`),
  KEY `id_professor` (`id_professor`),
  CONSTRAINT `disciplinas_professor_ibfk_1` FOREIGN KEY (`id_disciplinas`) REFERENCES `disciplina` (`id`),
  CONSTRAINT `disciplinas_professor_ibfk_2` FOREIGN KEY (`id_professor`) REFERENCES `professor` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `disciplinas_professor`
--

LOCK TABLES `disciplinas_professor` WRITE;
/*!40000 ALTER TABLE `disciplinas_professor` DISABLE KEYS */;
INSERT INTO `disciplinas_professor` VALUES (2,1),(18,2),(1,5),(2,6),(1,7),(18,15),(4,21);
/*!40000 ALTER TABLE `disciplinas_professor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `endereco`
--

DROP TABLE IF EXISTS `endereco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `endereco` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_paciente` int NOT NULL,
  `numero_casa` varchar(10) NOT NULL,
  `logradouro` varchar(100) NOT NULL,
  `bairro` varchar(50) NOT NULL,
  `cidade` varchar(100) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `cep` varchar(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_paciente` (`id_paciente`),
  CONSTRAINT `endereco_ibfk_1` FOREIGN KEY (`id_paciente`) REFERENCES `paciente` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endereco`
--

LOCK TABLES `endereco` WRITE;
/*!40000 ALTER TABLE `endereco` DISABLE KEYS */;
INSERT INTO `endereco` VALUES (1,4,'123','Rua das Flores','Jardim das Rosas','S√£o Paulo','SP','01234-567'),(2,5,'123','Rua das Flores','Jardim das Rosas','S√£o Paulo','SP','01234-567'),(3,3,'123','Rua das Flores','Jardim das Rosas','S√£o Paulo','SP','01234-567'),(5,6,'123','Rua das Flores','Jardim das Rosas','S√£o Paulo','SP','01234-567'),(6,7,'GWER','EARGW','AWEF','WARGET','MG','ARGE'),(7,8,'116','Rua Jo√£o Machado Rocha','Santa Lu√≠za','Campo do Meio','MG','37165000'),(9,16,'305A','S√£o Benedito','centro','Campos gerais','MG','37160000'),(10,18,'1372','Casa','S√£o Benedito','Campos Gerais','MG','37160000'),(11,19,'1234','teste','teste','Areado','MG','37160000'),(13,21,'41','Rua Bar√£o de Alfenas','Vila Santa Luzia','Alfenas','MG','37139-999'),(14,22,'169','Sandoval Marinho ','JK','Campo do Meio','MG','37165-000'),(15,23,'169','antonio marques do nascimento','centro','campo do meio','MG','37165-000'),(16,24,'100','antonio candido machado','centro','Campo do Meio','MG','37165-000'),(17,25,'170','Antonio marques do nascimento','centro','Campo do Meio','MG','37165-000');
/*!40000 ALTER TABLE `endereco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `endereco_responsavel`
--

DROP TABLE IF EXISTS `endereco_responsavel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `endereco_responsavel` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_responsavel` int DEFAULT NULL,
  `logradouro` varchar(245) DEFAULT NULL,
  `bairro` varchar(245) DEFAULT NULL,
  `cidade` varchar(245) DEFAULT NULL,
  `uf` varchar(2) DEFAULT NULL,
  `cep` varchar(45) DEFAULT NULL,
  `numero_casa` varchar(245) DEFAULT NULL,
  `id_paciente` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_idx` (`id_responsavel`),
  KEY `id_paciente_idx` (`id_paciente`),
  CONSTRAINT `id` FOREIGN KEY (`id_responsavel`) REFERENCES `responsavel` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endereco_responsavel`
--

LOCK TABLES `endereco_responsavel` WRITE;
/*!40000 ALTER TABLE `endereco_responsavel` DISABLE KEYS */;
INSERT INTO `endereco_responsavel` VALUES (7,19,'123123','3123','123','MG','13212-31','123',19),(9,22,'Rua Bar√£o de Alfenas','Vila Santa Luzia','Alfenas','MG','37139-999','41',21);
/*!40000 ALTER TABLE `endereco_responsavel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `endodontia`
--

DROP TABLE IF EXISTS `endodontia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `endodontia` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_prontuario` int NOT NULL,
  `dente` text,
  `numero_de_canais` int DEFAULT NULL,
  `diagnostico_pulpar_normal` tinyint(1) DEFAULT NULL,
  `pulpite_reversivel` tinyint(1) DEFAULT NULL,
  `pulpite_irreversivel` tinyint(1) DEFAULT NULL,
  `necrose` tinyint(1) DEFAULT NULL,
  `dente_ja_tratado` tinyint(1) DEFAULT NULL,
  `insensivel` tinyint(1) DEFAULT NULL,
  `sensivel` tinyint(1) DEFAULT NULL,
  `muito_sensivel` tinyint(1) DEFAULT NULL,
  `presenca_de_abcesso` tinyint(1) DEFAULT NULL,
  `intra_bucal` tinyint(1) DEFAULT NULL,
  `extra_bucal` tinyint(1) DEFAULT NULL,
  `com_fistula` tinyint(1) DEFAULT NULL,
  `sem_fistula` tinyint(1) DEFAULT NULL,
  `regio_periapical_normal` tinyint(1) DEFAULT NULL,
  `com_lesao` tinyint(1) DEFAULT NULL,
  `difusa` tinyint(1) DEFAULT NULL,
  `circunscrita` tinyint(1) DEFAULT NULL,
  `ausente` tinyint(1) DEFAULT NULL,
  `claro` tinyint(1) DEFAULT NULL,
  `hemorragico` tinyint(1) DEFAULT NULL,
  `purulento` tinyint(1) DEFAULT NULL,
  `dor_entre_as_sessoes` tinyint(1) DEFAULT NULL,
  `hipoclorito_de_sodio_porcentagem` tinyint(1) DEFAULT NULL,
  `outras_solucao_irrigadora` text,
  `cimento_obturador` text,
  `condensacao_lateral` tinyint(1) DEFAULT NULL,
  `outra_tecnica_de_obturacao` text,
  `material_restaurador_provisorio` text,
  `quantidade_de_sodio_a_porcentagem` varchar(245) DEFAULT NULL,
  `inicio_tratamento` date DEFAULT NULL,
  `termino_tratamento` date DEFAULT NULL,
  `curativo_sessao_1` text,
  `curativo_sessao_2` text,
  `curativo_sessao_3` text,
  `curativo_sessao_4` text,
  `curativo_sessao_5` text,
  `curativo_sessao_6` text,
  `numero_de_sessoes_realizadas` varchar(250) DEFAULT NULL,
  `restauracao_definitiva_do_dente` text,
  `observacoes` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=143 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endodontia`
--

LOCK TABLES `endodontia` WRITE;
/*!40000 ALTER TABLE `endodontia` DISABLE KEYS */;
INSERT INTO `endodontia` VALUES (112,9,'teste 38',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(113,9,'teste 2',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2024-06-24',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(114,9,'teste 3',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2024-06-24',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(115,9,'teste 45',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2024-06-24',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(140,12,'fef',12,0,1,0,0,0,1,0,0,1,0,1,0,0,1,0,NULL,NULL,0,0,1,0,1,0,'1','1',1,NULL,'1',NULL,'2024-06-27',NULL,'1','1','1','1','1','1','1','1','1'),(141,13,'tete',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2024-06-26','2024-06-26','','','','','','',NULL,'',NULL),(142,13,'testre24',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'','','','','','',NULL,'',NULL);
/*!40000 ALTER TABLE `endodontia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estudante`
--

DROP TABLE IF EXISTS `estudante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estudante` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_usuario` int NOT NULL,
  `nome` varchar(50) NOT NULL,
  `periodo_atual` int DEFAULT NULL,
  `eh_modular` tinyint DEFAULT NULL,
  `ativo` tinyint NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_usuario` (`id_usuario`),
  CONSTRAINT `estudante_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estudante`
--

LOCK TABLES `estudante` WRITE;
/*!40000 ALTER TABLE `estudante` DISABLE KEYS */;
INSERT INTO `estudante` VALUES (1,16,'Jo√£o Marcelo Batista Narciso',2,NULL,1),(2,23,'Joao Aluno',3,NULL,0),(3,28,'Teste Aprimorado',7,NULL,0),(4,31,'Kariny ',6,NULL,1),(5,33,'juaijgrke',1,NULL,1),(6,37,'felipe estudante',0,NULL,1),(7,41,'Ana Clara',1,NULL,1),(8,42,'Larissa Milani Mezavila',0,NULL,1),(9,43,'Roberto augusto',0,NULL,1),(10,44,'D√©bora Eliza Braga Damasceno ',0,NULL,1),(11,45,'Clara Gabriella Batista',0,NULL,1),(12,53,'zezz',1,NULL,1),(13,54,'Rafael estudante',1,NULL,1),(14,55,'Caio Cesar Nascimento Centi Junior ',1,NULL,1);
/*!40000 ALTER TABLE `estudante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grupo`
--

DROP TABLE IF EXISTS `grupo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grupo` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupo`
--

LOCK TABLES `grupo` WRITE;
/*!40000 ALTER TABLE `grupo` DISABLE KEYS */;
INSERT INTO `grupo` VALUES (1,'Geral'),(2,'Perfil Psicologico / Hist√≥rico Odontol√≥gico'),(3,'Gesta√ß√£o'),(4,'Crian√ßa'),(5,'Hist√≥rico M√©dico'),(6,'H√°bitos de Higiene'),(7,'H√°bitos Alimentares'),(8,'H√°bitos Nocivos'),(9,'H√°bitos Familiares'),(10,'Exame F√≠sico'),(11,'Exame de Denti√ß√£o'),(12,'Sec√ß√£o de Identifica√ß√£o Legal e Diagn√≥stico'),(14,'Plano de Tratamento'),(15,'Sequ√™ncia Favor√°vel do Plano de Tratamento'),(16,'Terapia Pulpar'),(17,'Solicita√ß√£o de exames'),(18,'Procedimentos');
/*!40000 ALTER TABLE `grupo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horario_disponivel_atendimento`
--

DROP TABLE IF EXISTS `horario_disponivel_atendimento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `horario_disponivel_atendimento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_triagem` int NOT NULL,
  `sete_meia` tinyint DEFAULT NULL,
  `nove_meia` tinyint DEFAULT NULL,
  `uma_meia` tinyint DEFAULT NULL,
  `tres_meia` tinyint DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_triagem` (`id_triagem`),
  CONSTRAINT `horario_disponivel_atendimento_ibfk_1` FOREIGN KEY (`id_triagem`) REFERENCES `triagem` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horario_disponivel_atendimento`
--

LOCK TABLES `horario_disponivel_atendimento` WRITE;
/*!40000 ALTER TABLE `horario_disponivel_atendimento` DISABLE KEYS */;
INSERT INTO `horario_disponivel_atendimento` VALUES (1,3,1,1,1,0),(2,4,0,1,1,1),(3,5,1,0,1,1),(4,6,1,1,1,1),(5,2,1,1,1,1),(6,7,1,1,1,1),(7,9,0,0,1,0),(8,10,1,1,0,0);
/*!40000 ALTER TABLE `horario_disponivel_atendimento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `imagens_prontuario`
--

DROP TABLE IF EXISTS `imagens_prontuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `imagens_prontuario` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_prontuario` int DEFAULT NULL,
  `tipo_imagem` varchar(245) DEFAULT NULL,
  `path` varchar(512) DEFAULT NULL,
  `content_type` varchar(45) DEFAULT NULL,
  `filename` varchar(245) DEFAULT NULL,
  `e_crianca` tinyint DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `imagens_prontuario`
--

LOCK TABLES `imagens_prontuario` WRITE;
/*!40000 ALTER TABLE `imagens_prontuario` DISABLE KEYS */;
INSERT INTO `imagens_prontuario` VALUES (8,8,'outros','/app/imagens-prontuario/8_outros_2024-06-24-05-34-28.jpeg','image/jpeg','8_outros_2024-06-24-05-34-28.jpeg',0),(9,9,'mapa_periodontal','/app/imagens-prontuario/9_mapa_periodontal_2024-06-24-20-39-12.png','image/png','9_mapa_periodontal_2024-06-24-20-39-12.png',0),(10,9,'mapa_periodontal','/app/imagens-prontuario/9_mapa_periodontal_2024-06-24-20-41-52.jpeg','image/jpeg','9_mapa_periodontal_2024-06-24-20-41-52.jpeg',0),(11,8,'outros','/app/imagens-prontuario/8_outros_2024-06-24-22-07-45.jpeg','image/jpeg','8_outros_2024-06-24-22-07-45.jpeg',0),(14,9,'outros','/app/imagens-prontuario/9_outros_2024-06-24-22-35-31.jpeg','image/jpeg','9_outros_2024-06-24-22-35-31.jpeg',0),(15,9,'outros','/app/imagens-prontuario/9_outros_2024-06-24-22-37-35.jpeg','image/jpeg','9_outros_2024-06-24-22-37-35.jpeg',0),(18,9,'mapa_periodontal','/app/imagens-prontuario/9_mapa_periodontal_2024-06-24-22-45-46.png','image/png','9_mapa_periodontal_2024-06-24-22-45-46.png',0),(19,9,'mapa_periodontal','/app/imagens-prontuario/9_mapa_periodontal_2024-06-24-22-45-52.jpeg','image/jpeg','9_mapa_periodontal_2024-06-24-22-45-52.jpeg',0),(22,9,'controle_placa_bacteriana','/app/imagens-prontuario/9_controle_placa_bacteriana_2024-06-25-00-59-42.jpeg','image/jpeg','9_controle_placa_bacteriana_2024-06-25-00-59-42.jpeg',0),(23,8,'mapa_periodontal','/app/imagens-prontuario/8_mapa_periodontal_2024-06-25-04-03-45.jpeg','image/jpeg','8_mapa_periodontal_2024-06-25-04-03-45.jpeg',0),(24,12,'mapa_periodontal','/app/imagens-prontuario/12_mapa_periodontal_2024-06-25-14-50-06.jpeg','image/jpeg','12_mapa_periodontal_2024-06-25-14-50-06.jpeg',0),(25,12,'outros','/app/imagens-prontuario/12_outros_2024-06-25-14-49-56.jpeg','image/jpeg','12_outros_2024-06-25-14-49-56.jpeg',0),(26,12,'controle_placa_bacteriana','/app/imagens-prontuario/12_controle_placa_bacteriana_2024-06-25-14-50-06.jpeg','image/jpeg','12_controle_placa_bacteriana_2024-06-25-14-50-06.jpeg',0),(27,12,'mapa_periodontal','/app/imagens-prontuario/12_mapa_periodontal_2024-06-25-19-52-33.jpeg','image/jpeg','12_mapa_periodontal_2024-06-25-19-52-33.jpeg',0),(28,12,'controle_placa_bacteriana','/app/imagens-prontuario/12_controle_placa_bacteriana_2024-06-25-19-54-00.jpeg','image/jpeg','12_controle_placa_bacteriana_2024-06-25-19-54-00.jpeg',0),(29,12,'outros','/app/imagens-prontuario/12_outros_2024-06-25-19-54-06.jpeg','image/jpeg','12_outros_2024-06-25-19-54-06.jpeg',0),(30,15,'mapa_periodontal','/app/imagens-prontuario/15_mapa_periodontal_2024-06-26-00-15-36.png','image/png','15_mapa_periodontal_2024-06-26-00-15-36.png',0),(31,1,'outros_crianca','/app/imagens-prontuario/1_outros_crianca_2024-06-26-02-47-48.jpeg','image/jpeg','1_outros_crianca_2024-06-26-02-47-48.jpeg',0),(32,1,'outros_crianca','/app/imagens-prontuario/1_outros_crianca_2024-06-26-02-52-24.jpeg','image/jpeg','1_outros_crianca_2024-06-26-02-52-24.jpeg',0),(33,1,'foto_denticao_crianca','/app/imagens-prontuario/1_foto_denticao_crianca_2024-06-26-02-53-53.jpeg','image/jpeg','1_foto_denticao_crianca_2024-06-26-02-53-53.jpeg',0),(35,2,'outros_crianca','/app/imagens-prontuario/2_outros_crianca_2024-06-26-06-05-35.jpeg','image/jpeg','2_outros_crianca_2024-06-26-06-05-35.jpeg',1),(36,2,'foto_denticao_crianca','/app/imagens-prontuario/2_foto_denticao_crianca_2024-06-26-06-05-44.jpeg','image/jpeg','2_foto_denticao_crianca_2024-06-26-06-05-44.jpeg',1),(37,2,'foto_denticao_crianca','/app/imagens-prontuario/2_foto_denticao_crianca_2024-06-26-12-12-09.jpeg','image/jpeg','2_foto_denticao_crianca_2024-06-26-12-12-09.jpeg',1),(38,2,'outros_crianca','/app/imagens-prontuario/2_outros_crianca_2024-06-26-12-12-10.jpeg','image/jpeg','2_outros_crianca_2024-06-26-12-12-10.jpeg',1);
/*!40000 ALTER TABLE `imagens_prontuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `necessidade_tratamento`
--

DROP TABLE IF EXISTS `necessidade_tratamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `necessidade_tratamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_triagem` int NOT NULL,
  `tratamento` enum('endodontia','periodontia','dentistica','cirurgia','protese') DEFAULT NULL,
  `descricao` text,
  PRIMARY KEY (`id`),
  KEY `id_triagem` (`id_triagem`),
  CONSTRAINT `necessidade_tratamento_ibfk_1` FOREIGN KEY (`id_triagem`) REFERENCES `triagem` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `necessidade_tratamento`
--

LOCK TABLES `necessidade_tratamento` WRITE;
/*!40000 ALTER TABLE `necessidade_tratamento` DISABLE KEYS */;
INSERT INTO `necessidade_tratamento` VALUES (2,3,'periodontia','Tratamento de gengivite'),(3,3,'cirurgia','Extra√ß√£o de dente'),(12,4,'cirurgia','teste tes'),(13,4,'endodontia','teste edi√ß√£o '),(14,4,'protese','teste edi√ß√£o '),(15,4,'periodontia','teste edi√ß√£o'),(24,2,'periodontia','teste'),(30,9,'periodontia','teste'),(33,7,'cirurgia','Cirurgia de Pr√≥stata'),(39,6,'periodontia','gyhrsertgergs'),(40,6,'cirurgia','sertrthessrth'),(41,5,'cirurgia','remo√ß√£o do dente siso '),(42,5,'protese','protese dente canino');
/*!40000 ALTER TABLE `necessidade_tratamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odontometria`
--

DROP TABLE IF EXISTS `odontometria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odontometria` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_prontuario` int DEFAULT NULL,
  `id_endodontia` int DEFAULT NULL,
  `canal` varchar(245) DEFAULT NULL,
  `cad` varchar(245) DEFAULT NULL,
  `crd` varchar(245) DEFAULT NULL,
  `crt` varchar(245) DEFAULT NULL,
  `diametro_anatomico` varchar(245) DEFAULT NULL,
  `diametro_cirurgico` varchar(245) DEFAULT NULL,
  `ponto_de_referencia` varchar(245) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odontometria`
--

LOCK TABLES `odontometria` WRITE;
/*!40000 ALTER TABLE `odontometria` DISABLE KEYS */;
INSERT INTO `odontometria` VALUES (1,1,NULL,'ntyntyntuyntynuyuny',NULL,NULL,NULL,NULL,NULL,NULL),(2,1,NULL,'bgtrbntynuynyutn',NULL,NULL,NULL,NULL,NULL,NULL),(10,9,8,'1','2','3','4','5','6','7'),(11,12,116,'1','1','1','1','1','1','1'),(12,12,128,'1','1','1','1','1','1','1'),(13,12,133,'1','1','1','1','1','1','1'),(15,12,140,'1','1','1','1','1','1','1'),(16,12,140,'1','1','1','1','1','1','1'),(17,12,140,'1','2','3','4','5','6','7');
/*!40000 ALTER TABLE `odontometria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paciente` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_paciente_status` int NOT NULL,
  `id_usuario_cadastro` int DEFAULT NULL,
  `nome` varchar(245) DEFAULT NULL,
  `data_cadastro` datetime DEFAULT NULL,
  `naturalidade` varchar(45) NOT NULL,
  `uf_naturalidade` varchar(2) NOT NULL,
  `profissao` varchar(45) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `rg` varchar(15) NOT NULL,
  `nome_pai` varchar(45) DEFAULT NULL,
  `nome_mae` varchar(45) DEFAULT NULL,
  `telefone` varchar(15) DEFAULT NULL,
  `cartao_regional_sus` varchar(45) DEFAULT NULL,
  `cartao_nacional_sus` varchar(45) DEFAULT NULL,
  `data_nascimento` date NOT NULL,
  `ativo` tinyint DEFAULT '0',
  `precisa_responsavel` tinyint DEFAULT '0',
  `sexo` varchar(45) DEFAULT NULL,
  `sexo_outro` varchar(245) DEFAULT NULL,
  `grupo_etnico` varchar(245) DEFAULT NULL,
  `data_expedicao_rg` date DEFAULT NULL,
  `indicacao` varchar(245) DEFAULT NULL,
  `estado_civil` varchar(45) DEFAULT NULL,
  `mora_com` varchar(45) DEFAULT NULL,
  `escola` varchar(245) DEFAULT NULL,
  `serie` varchar(45) DEFAULT NULL,
  `turno` varchar(45) DEFAULT NULL,
  `mora_com_outro` varchar(245) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `paicente_usuario_idx` (`id_usuario_cadastro`),
  CONSTRAINT `paicente_usuario` FOREIGN KEY (`id_usuario_cadastro`) REFERENCES `usuario` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES (3,3000,27,'Felipe','2024-05-31 16:14:12','S√£o Paulo','SP','Engenheiro','12345678900','123456789','Jos√© da Silva','Maria da Silva','(11) 98765-4321','132','12','1980-05-15',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(4,2000,27,'Renato','2024-05-31 16:15:06','S√£o Paulo','SP','Engenheiro','13543533245','123456789','Jos√© da Silva','Maria da Silva','1198765-4321','12','123','1980-05-15',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(5,3000,27,'Jo√£o Marcelo','2024-05-31 16:15:51','S√£o Paulo','SP','Engenheiro','12312342341','123456789','Jos√© da Silva','Maria da Silva','1198765-4321','1234567890','0987654321','1980-05-15',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(6,3000,27,'Jo√£o Pedro','2024-05-31 16:16:45','S√£o Paulo','SP','Engenheiro','12432242341','123456789','Jos√© da Silva','Maria da Silva','1198765-4321','1234567890','0987654321','1980-05-15',1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(7,3000,36,'sdfhg','2024-06-03 02:05:19','efarsgth','MG','awfergs','12345678910','eafwrgs','ewafrg','QWEDF','RGSEDT','AREGTR','AWEGR','2003-05-07',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(8,3000,6,'Jo√£o Pedro Fernandes Reis','2024-06-05 00:44:26','Alfenas','MG','Cientista da Computa√ß√£o','16750213685','MG11123123','Eduardo Megda Reis','Camila Aparecida Fernandes Reis','35984164532','123098345','423094842','2002-07-28',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(9,1000,4,'Renato Araujo','2024-06-15 00:58:16','Nepomuceno','mg','Estudante','92812912911','192556421','Ricardo Marciano Araujo','Eliane Raquel de C. Araujo','35920005547','123456787652222','123456787652222','2007-10-24',1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(10,1000,4,'FELIPE C ARAUJO','2024-06-15 02:34:35','Nepomuceno','MG','','91231321232','123456782','FELIPE C ARAUJO','FELIPE C ARAUJO','35920005547','098721839012312','098721839012312','2004-05-07',1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(11,1000,4,'FELIPE C ARAUJO','2024-06-15 02:34:35','sdfgbvcs','AS','','12345665643','123456784','asddfghnn','ascvdgf','35920005547','123456786543212','123456786543212','2004-05-07',0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(12,1000,4,'FELIPE C ARAUJO','2024-06-15 02:36:33','wasfdgh','AS','','12345654321','213456543','wfsdbg','asfdfbg','35920005547','123456765432123','123456765432123','2024-06-15',0,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(13,1000,4,'sdfgbn','2024-06-15 02:39:59','dsfgsf','RE','','12345643423','123456753','dsfghg','sdfgds','35920005547','1234567','123456','2004-05-07',0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(14,1000,4,'wefghfds','2024-06-15 02:45:17','dwef','VD','','67876576454','132457343','fgedf','sdgs','35920005547','1234656786','1324576342','2012-12-12',1,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(15,1000,4,'wqertyuthgfdq','2024-06-15 02:47:36','12345y6','AS','','54621345642','312456785','dasfdghg','awesfrgthy','12324564344','1234656845432','32456853215','2024-06-10',1,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(16,1000,4,'Kaju Araujo Correa','2024-06-15 20:37:10','brasileiro','MG','Apoio Emocional ','15887770655','675544543','Felipe Araujo','Kariny Maria','35920024811','6766664355436','564453342557','2024-03-24',1,1,'MASCULINO','','Laranja','2024-06-07',NULL,'SOLTEIRO','OUTROS','Coronel jJoaquim Ribeiro','7¬∞ ano','MANH√É','teste outros'),(17,1000,4,'Jaguatirica','2024-06-16 11:15:02','Brasileiro','MG','','25670709990','22540555','Felipe de Carvalho Araujo','Kariny Maria Correa','35998275936','999999999999999','999999999999999','2021-02-26',1,1,'MASCULINO','','Laranja','2021-05-10',NULL,'SOLTEIRO','M√ÉE','','','',''),(18,1000,4,'Linda Maria de Araujo','2024-06-16 12:20:04','Brasileiro','MG','Apoio emotivo ','37160561111','665342137','Kariny Maria','FELIPE C ARAUJO','359200023333','MG','55564432334567','2003-12-02',1,0,'FEMININO','','Escaminha','2005-12-10',NULL,'DIVORCIADO','','','','',''),(19,3000,32,'Rafael Fernandes','2024-06-16 18:18:52','Minas Gerais','MG','Estudante','22222222222','222222222','teste 1','teste 1','33333333333','343242424132421','45435546546','2003-02-14',1,0,'','','','2024-06-29',NULL,'','','','','',''),(20,1000,54,'Rafael','2024-06-25 21:29:22','Minas Gerais','MG','Estudante','11111111111','222222222','aaaaaaa','bbbbbb','35998438463','2432431234134','12341241234234','2003-02-14',1,0,'MASCULINO','','aeeeaeaf','2011-11-10','professor','VI√öVO','','','','',''),(21,3000,54,'Jo√£o Batista Alzevedo','2024-06-25 23:53:58','Minas Gerais','MG','Estudante','32121232444','435432534','Jos√© Batista de Carlos','Maria de Alzevedo Pereira','35998763456','800234463532343','800234463532343','2010-03-18',1,1,'MASCULINO','','Branco','2022-07-13','Professor','SOLTEIRO','AMBOS','Col√©gio Atenas','7¬∞ S√©rie','MANH√É',''),(22,1000,50,'L√≠via','2024-06-26 12:25:07','Campo do Meio','MG','Balconista','17054100654','21868182','Ramiro Fernando Morais','Gilda Rosa Corr√™a','35984293466','425631289752365','756984230153698','2002-11-06',1,0,'FEMININO','','Branco','2016-05-02','','SOLTEIRO','','','','',''),(23,1000,50,'Rafael Marinho','2024-06-26 12:31:26','Campo do Meio','MG','Estudante','13485674592','15326749','Nathan Marinho','Andrelina Ferreira','35984273041','756921536845321','452368991254789','2004-04-10',1,0,'MASCULINO','','Branco','2015-02-08','','SOLTEIRO','','','','',''),(24,1000,50,'Larissa Morais ','2024-06-26 12:34:20','Campos Gerais','MG','Nutricionista','52365712569','85632111','Ramiro','Gilda','35984414864','756123335489564','789542163568974','1986-10-25',1,0,'FEMININO','','Branca','2000-06-17','','CASADO','','','','',''),(25,1000,50,'Grazielle Fernanda','2024-06-26 12:37:08','Campos Gerais','MG','Assistente ','78523465421','78845251','Matheus','Lais','35984192721','15642658971156','789456213456987','2000-10-06',1,0,'FEMININO','','Branco','2006-01-14','','CASADO','','','','','');
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente_estudante`
--

DROP TABLE IF EXISTS `paciente_estudante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paciente_estudante` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_estudante` int NOT NULL,
  `id_paciente` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_estudante` (`id_estudante`),
  KEY `id_paciente` (`id_paciente`),
  CONSTRAINT `paciente_estudante_ibfk_1` FOREIGN KEY (`id_estudante`) REFERENCES `estudante` (`id`),
  CONSTRAINT `paciente_estudante_ibfk_2` FOREIGN KEY (`id_paciente`) REFERENCES `paciente` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente_estudante`
--

LOCK TABLES `paciente_estudante` WRITE;
/*!40000 ALTER TABLE `paciente_estudante` DISABLE KEYS */;
/*!40000 ALTER TABLE `paciente_estudante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente_status`
--

DROP TABLE IF EXISTS `paciente_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paciente_status` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(245) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3001 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente_status`
--

LOCK TABLES `paciente_status` WRITE;
/*!40000 ALTER TABLE `paciente_status` DISABLE KEYS */;
INSERT INTO `paciente_status` VALUES (1000,'cadastro_incompleto'),(2000,'triagem_incompleta'),(3000,'prontuario_incompleto');
/*!40000 ALTER TABLE `paciente_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perguntas`
--

DROP TABLE IF EXISTS `perguntas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perguntas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_grupo` int DEFAULT NULL,
  `tipo_pergunta` varchar(50) NOT NULL,
  `pergunta` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=311 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perguntas`
--

LOCK TABLES `perguntas` WRITE;
/*!40000 ALTER TABLE `perguntas` DISABLE KEYS */;
INSERT INTO `perguntas` VALUES (1,1,'aberta','Queixa principal'),(2,1,'aberta','Hist√≥ria da doen√ßa atual'),(4,2,'alternativa','J√° foi ao dentista?'),(5,2,'alternativa','Qual sua atitude com rela√ß√£o ao mau comportamento?'),(6,2,'alternativa','Considera seu filho'),(7,2,'aberta','Especifique'),(8,2,'alternativa','Sono'),(9,2,'aberta','Nome dos irm√£os e idade'),(10,2,'aberta','Nome dos amigos e idade'),(11,2,'aberta','Faz amizade com facilidade?'),(12,2,'aberta','Hist√≥rias que gosta de ouvir'),(13,2,'aberta','Brinquedos preferidos'),(14,2,'aberta','A crian√ßa tem apelido que gosta de ser chamado? Qual?'),(15,2,'alternativa','J√° foi ao dentista?'),(16,2,'aberta','Idade da 1¬™ visita'),(17,2,'aberta','Por que procurou o dentista?'),(18,2,'alternativa','J√° realizou tratamento odontol√≥gico?'),(19,2,'alternativa','Concluiu o tratamento?'),(20,2,'aberta','Se a resposta for negativa, por qu√™?'),(21,2,'aberta','Como acha que seu filho(a) reagir√° nessa consulta?'),(22,2,'alternativa','Tomou anestesia local?'),(23,2,'alternativa','Teve alguma rea√ß√£o?'),(24,2,'alternativa','Algum problema no tratamento?'),(25,2,'aberta','Qual?'),(26,2,'alternativa','Fl√∫or sist√™mico?'),(27,2,'alternativa','Fl√∫or t√≥pico?'),(28,2,'aberta','Quantas vezes?'),(29,2,'alternativa','Aftas frequentes'),(30,2,'alternativa','Herpes frequentes'),(31,2,'aberta','Estado civil dos pais'),(32,2,'aberta','Com quem fica a maior parte do tempo?'),(33,3,'alternativa','Alguma doen√ßa da m√£e na gesta√ß√£o?'),(34,3,'aberta','Quais doen√ßas?'),(35,3,'alternativa','Tomou algum medicamento na gesta√ß√£o?'),(36,3,'aberta','Quais medicamentos?'),(37,3,'alternativa','Parto'),(38,4,'alternativa','Problemas com a sa√∫de da crian√ßa'),(39,4,'aberta','Quais problemas?'),(40,4,'alternativa','Est√° sob tratamento m√©dico?'),(41,4,'aberta','Motivo do tratamento'),(42,4,'aberta','Faz uso de medicamentos atualmente'),(43,4,'alternativa','J√° fez interven√ß√µes cir√∫rgicas'),(44,4,'aberta','Quais interven√ß√µes?'),(45,4,'alternativa','Alergias'),(46,4,'aberta','Quais alergias'),(47,5,'alternativa','Sarampo: '),(48,5,'alternativa','Est√¥mago: '),(49,5,'alternativa','Epilepsia: '),(50,5,'alternativa','Am√≠gdalas: '),(51,5,'alternativa','Cora√ß√£o: '),(52,5,'alternativa','Anemia: '),(53,5,'alternativa','Hemorragia: '),(54,5,'alternativa','Pele: '),(55,5,'alternativa','Diabetes: '),(56,5,'alternativa','Tireoide: '),(57,5,'alternativa','Audi√ß√£o: '),(58,5,'alternativa','Catapora: '),(59,5,'alternativa','Adenoides: '),(60,5,'alternativa','Pulm√µes: '),(61,5,'alternativa','Coqueluche: '),(62,5,'alternativa','Bexiga: '),(63,5,'alternativa','Vis√£o: '),(64,5,'alternativa','Caxumba: '),(65,5,'alternativa','Intestino: '),(66,5,'alternativa','Bronquite: '),(67,5,'alternativa','F√≠gado: '),(68,5,'alternativa','Rins: '),(69,5,'alternativa','Asma: '),(70,5,'aberta','Outros problemas'),(71,4,'aberta','√öltima visita da crian√ßa ao m√©dico'),(72,4,'aberta','Observa√ß√µes'),(73,4,'aberta','Vacinas'),(74,4,'aberta','Altura'),(75,4,'aberta','Peso'),(76,4,'aberta','Existe alguma outra informa√ß√£o que acha importante?'),(77,14,'aberta','Inicio'),(78,14,'aberta','T√©rmino'),(79,14,'aberta','1. Urg√™ncia'),(80,14,'aberta','2. Fase Sist√™mica'),(81,14,'alternativa','3. Fase Preparat√≥ria - a) Etapa preventiva:'),(82,14,'aberta','b) Raspagem:'),(83,14,'aberta','Aplica√ß√£o t√≥pica de fl√∫or gel:'),(84,14,'aberta','Aplica√ß√£o de verniz fluoretado:'),(85,14,'aberta','Tratamento de choque:'),(86,14,'aberta','Cariost√°tico:'),(87,14,'aberta','Cura√ß√£o:'),(88,14,'aberta','Selante provis√≥rio:'),(89,14,'aberta','Selante n√£o invasivo:'),(90,14,'aberta','Selante de superf√≠cie:'),(91,14,'aberta','Exodontia:'),(92,14,'aberta','Capeamento pulpar indireto:'),(93,14,'aberta','Pulpotomia:'),(94,14,'aberta','Biopulpectomia:'),(95,14,'aberta','Necropulpectomia I:'),(96,14,'aberta','Necropulpectomia II:'),(97,14,'aberta','Remo√ß√£o de iatrogenia:'),(98,14,'aberta','4. Fase Restauradora - Tratamento Restaurador Atraum√°tico:'),(99,14,'aberta','Restaura√ß√£o preventiva:'),(100,14,'aberta','Am√°lgama:'),(101,14,'aberta','Resina:'),(102,14,'aberta','Ion√¥mero de vidro convencional:'),(103,14,'aberta','Ion√¥mero de vidro de alta viscosidade:'),(104,14,'aberta','Ion√¥mero de vidro modificado por resina:'),(105,14,'aberta','Pr√≥tese:'),(106,14,'aberta','Cirurgia:'),(107,14,'aberta','Acabamento e polimento das restaura√ß√µes:'),(108,14,'aberta','Aplica√ß√£o t√≥pica de fl√∫or:'),(109,14,'aberta','5. Fase de Manuten√ß√£o:'),(110,14,'aberta','Orienta√ß√£o ortod√¥ntica:'),(111,14,'alternativa','Encaminhado para ortodontia corretiva:'),(147,4,'aberta','Antecedentes familiares'),(148,12,'alternativa','T√©cnica(s) Radiogr√°fica(s):'),(149,12,'aberta','Outras:'),(150,12,'aberta','18 -'),(151,12,'aberta','17 -'),(152,12,'aberta','16 -'),(153,12,'aberta','15/55 -'),(154,12,'aberta','14/54 -'),(155,12,'aberta','13/53 -'),(156,12,'aberta','12/52 -'),(157,12,'aberta','11/51 -'),(158,12,'aberta','21/61 -'),(159,12,'aberta','22/62 -'),(160,12,'aberta','23/63 -'),(161,12,'aberta','24/64 -'),(162,12,'aberta','25/65 -'),(163,12,'aberta','26 -'),(164,12,'aberta','27 -'),(165,12,'aberta','28 -'),(166,12,'aberta','38 -'),(167,12,'aberta','37 -'),(168,12,'aberta','36 -'),(169,12,'aberta','35/75 -'),(170,12,'aberta','34/74 -'),(171,12,'aberta','33/73 -'),(172,12,'aberta','32/72 -'),(173,12,'aberta','31/71 -'),(174,12,'aberta','41/81 -'),(175,12,'aberta','42/82 -'),(176,12,'aberta','43/83 -'),(177,12,'aberta','44/84 -'),(178,12,'aberta','45/85 -'),(179,12,'aberta','46 -'),(180,12,'aberta','47 -'),(181,12,'aberta','48 -'),(182,12,'aberta','Observa√ß√µes:'),(183,11,'alternativa','Denti√ß√£o dec√≠dua - Arco de Baume:'),(184,11,'aberta','Rela√ß√£o canina - Direita:'),(185,11,'aberta','Rela√ß√£o canina - Esquerda:'),(186,11,'alternativa','Espa√ßo primata:'),(187,11,'aberta','Altera√ß√µes:'),(188,11,'alternativa','Denti√ß√£o:'),(189,11,'alternativa','Perfil:'),(190,11,'aberta','Ter√ßo Facial Inferior:'),(191,11,'aberta','Exposi√ß√£o Incisivo Repouso:'),(192,11,'aberta','Exposi√ß√£o Incisivo Sorriso:'),(193,11,'alternativa','Mordida Aberta:'),(194,11,'aberta','Mordida Aberta Observa√ß√£o:'),(195,11,'alternativa','Mordida Cruzada:'),(196,11,'aberto','Mordida Cruzada Observa√ß√µes:'),(197,11,'alternativa','Degluti√ß√£o:'),(198,11,'alternativa','Respira√ß√£o:'),(199,11,'aberta','Respira√ß√£o Observa√ß√µes:'),(200,11,'alternativa','Fona√ß√£o:'),(201,11,'aberta','Fona√ß√£o Observa√ß√µes:'),(202,11,'alternativa','Linha Mediana - Superior:'),(203,11,'aberta','Linha Mediana - Superior Observa√ß√£o:'),(204,11,'alternativa','Linha Mediana - Inferior:'),(205,11,'aberta','Linha Mediana - Inferior Observa√ß√£o:'),(206,11,'alternativa','Sobremordida:'),(207,11,'aberta','Sobremordida Observa√ß√£o:'),(208,11,'alternativa','Sobressali√™ncia:'),(209,11,'aberta','Sobressali√™ncia Observa√ß√£o:'),(210,11,'alternativa','Faz uso de aparelho ortod√¥ntico?'),(211,11,'aberta','Tipo:'),(212,11,'aberta','Quanto tempo de uso?'),(213,11,'aberta','Rela√ß√£o terminal dos 2¬∫ molares:'),(214,6,'alternativa','Seu filho escova os dentes sozinho?'),(215,6,'alternativa','Limpa os dentes de seu filho?'),(216,6,'aberta','Quantas vezes ao dia?'),(217,6,'aberta','Quando?'),(218,6,'alternativa','Usa fio dental?'),(219,6,'aberta','√Äs vezes  Quando?'),(220,7,'alternativa','Amamenta√ß√£o materna'),(221,7,'aberta','Frequ√™ncia amamenta√ß√£o diurna'),(222,7,'aberta','Frequ√™ncia amamenta√ß√£o noturna'),(223,7,'aberta','Amamentou at√© que idade?'),(224,7,'alternativa','Mamadeira'),(225,7,'aberta','Frequ√™ncia mamadeira diurna'),(226,7,'aberta','Frequ√™ncia mamadeira noturna'),(227,7,'aberta','Mamou at√© que idade?'),(228,7,'alternativa','Quantas vezes a crian√ßa ingere os alimentos abaixo'),(229,7,'aberta','Leite'),(230,7,'aberta','Ch√°'),(231,7,'aberta','Suco natural'),(232,7,'aberta','Suco artificial'),(233,7,'aberta','Refrigerantes'),(234,7,'aberta','Outros'),(235,7,'alternativa','A crian√ßa faz uso de'),(236,7,'aberta','Frequ√™ncia'),(237,8,'alternativa','H√°bitos Nocivos'),(238,8,'aberta','Outros h√°bitos nocivos'),(239,8,'aberta','Frequ√™ncia h√°bitos nocivos'),(240,9,'aberta','Quando foi a √∫ltima visita ao dentista?'),(241,9,'aberta','Pai'),(242,9,'aberta','Motivo'),(243,9,'aberta','M√£e'),(244,9,'aberta','Motivo'),(245,9,'aberta','Frequ√™ncia de escova√ß√£o do pai'),(246,9,'aberta','Fio dental pai'),(247,9,'aberta','Frequ√™ncia de escova√ß√£o da m√£e'),(248,9,'aberta','Fio dental m√£e'),(249,9,'alternativa','A m√£e apresentou problemas de sa√∫de bucal durante a gesta√ß√£o?'),(250,9,'aberta','Quais problemas?'),(251,10,'aberta','Ectoscopia (Exame Extra-bucal)'),(252,10,'aberta','M√£os'),(253,10,'aberta','Cabe√ßa'),(254,10,'aberta','G√¢nglios'),(255,10,'aberta','Face'),(256,10,'aberta','Cabelo'),(257,10,'aberta','ATM'),(258,10,'aberta','Nariz'),(259,10,'aberta','Olhos'),(260,10,'aberta','Oroscopia (Exame Intra-bucal)'),(261,10,'aberta','L√°bio'),(262,10,'aberta','Mucosa'),(263,10,'aberta','Assoalho Bucal'),(264,10,'aberta','Palato'),(265,10,'aberta','Am√≠gdalas'),(266,10,'aberta','Gengiva'),(267,10,'aberta','Freio Labial'),(268,10,'aberta','Freio Lingual'),(269,10,'aberta','L√≠ngua'),(270,10,'aberta','Bochecha'),(271,9,'aberta','Observa√ß√µes'),(272,15,'aberta','Sequ√™nca favor√°vel do plano de tratamento'),(273,16,'alternativa','Pulpotomia'),(274,16,'alternativa','M.T.A'),(275,16,'aberta','M.T.A Observa√ß√£o:'),(276,16,'alternativa','Hidr√≥xido de C√°lcio'),(277,16,'aberta','Hidr√≥xido de C√°lcio Observa√ß√µes:'),(278,16,'alternativa','Formocresol'),(279,16,'aberta','Formocresol Observa√ß√µes:'),(280,16,'alternativa','Biopulpectomia'),(281,16,'aberta','Biopulpectomia Observa√ß√£o'),(282,16,'alternativa','Necropulpectomia'),(283,16,'alternativa','Necropulpectomia sem les√£o:'),(284,16,'aberta','Necropulpectomia sem les√£o observa√ß√£o:'),(285,16,'alternativa','Necropulpectomia com les√£o:'),(286,16,'aberta','Necropulpectomia com les√£o observa√ß√£o:'),(287,16,'aberta','Inicio'),(288,16,'aberta','Dente'),(289,16,'aberta','N√∫mero de canais'),(290,16,'aberta','Aspecto Cl√≠nico'),(291,16,'aberta','Aspecto radiogr√°fico'),(292,16,'aberta','Grampo'),(293,16,'aberta','Aspecto macrosc√≥pico do tecido pulpar'),(294,16,'aberta','Solu√ß√£o irrigadora'),(295,16,'aberta','Prepato qu√≠mico'),(296,16,'aberta','Curativo de demora'),(297,16,'aberta','Odontometria'),(298,16,'aberta','Pasta obturadora'),(299,16,'aberta','Rest. Provis√≥ria'),(300,16,'aberta','Rest. Definitiva'),(301,16,'aberta','Intercorr√™ncias'),(302,16,'aberta','T√©rmino'),(303,16,'aberta','Controle radiogr√°fico'),(304,16,'aberta','Observa√ß√µes'),(305,17,'aberta','Solicita√ß√£o de exames especializados, laboratoriais, encaminhamentos, ocorr√™ncias cl√≠nicas, terap√™uticas e prescri√ß√µes.'),(306,18,'aberta','Data'),(307,18,'aberta','Dente'),(308,18,'aberta','Procedimentos'),(309,18,'aberta','Aluno'),(310,18,'aberta','Professor');
/*!40000 ALTER TABLE `perguntas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `professor`
--

DROP TABLE IF EXISTS `professor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `professor` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_usuario` int NOT NULL,
  `nome` varchar(100) NOT NULL,
  `ativo` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  KEY `id_usuario` (`id_usuario`),
  CONSTRAINT `professor_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `professor`
--

LOCK TABLES `professor` WRITE;
/*!40000 ALTER TABLE `professor` DISABLE KEYS */;
INSERT INTO `professor` VALUES (1,2,'Jo√£o Marcelo Batista Narciso',1),(2,3,'Jo√£o Pedro Fernandes',1),(5,4,'Felipe Ara√∫jo ',1),(6,5,'Jo√£o Marcelo Batista Narciso',1),(7,6,'Jo√£o Pedro Fernandes',1),(8,7,'Jo√£o Marcelo Batista',0),(9,8,'Jo√£o ',0),(10,15,'JoaoNinguem',0),(11,22,'Joao Adm',0),(12,24,'joao Professor',0),(13,27,'Jo√£o Marcelo Batista Narciso',0),(14,29,'livia',0),(15,30,'Celso ',1),(16,32,'Rafael',0),(17,34,'13427658',0),(18,35,'Joao Marcelo',0),(19,36,'Joao Marcelo',1),(20,38,'Jose ',0),(21,39,'Fl√°via Santos ',1),(22,40,'F√°bio',0),(23,46,'Jo√£o Pedro',0),(24,50,'L√≠via Morais',0),(25,52,'joao pedro',0);
/*!40000 ALTER TABLE `professor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prontuario`
--

DROP TABLE IF EXISTS `prontuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prontuario` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_paciente` int NOT NULL,
  `id_professor_vinculado` int DEFAULT NULL,
  `id_estudante_vinculado` int DEFAULT NULL,
  `id_prontuario_status` int DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `queixa_principal` varchar(400) DEFAULT NULL,
  `historia_doenca_atual` varchar(600) DEFAULT NULL,
  `teve_catapora` tinyint DEFAULT NULL,
  `teve_caxumba` tinyint DEFAULT NULL,
  `teve_sarampo` tinyint DEFAULT NULL,
  `teve_amigdalite` tinyint DEFAULT NULL,
  `outras_doenca_infancia` varchar(200) DEFAULT NULL,
  `teve_febre_reumatica` tinyint DEFAULT NULL,
  `teve_sopros` tinyint DEFAULT NULL,
  `teve_patologias_de_valvulas` tinyint DEFAULT NULL,
  `teve_anomalias_congenitas_cardiacas` tinyint DEFAULT NULL,
  `teve_hipertensao` tinyint DEFAULT NULL,
  `teve_arritmias` tinyint DEFAULT NULL,
  `teve_infarto_do_miocardio` tinyint DEFAULT NULL,
  `teve_angina_ou_dor_torax` tinyint DEFAULT NULL,
  `fez_cirurgias_cardiacas` tinyint DEFAULT NULL,
  `marca_passo` tinyint DEFAULT NULL,
  `teve_avc` tinyint DEFAULT NULL,
  `outros_disturbios_cardiovasculares` text,
  `asma` tinyint DEFAULT NULL,
  `doenca_pulmonares` tinyint DEFAULT NULL,
  `sinusite` tinyint DEFAULT NULL,
  `rinite` tinyint DEFAULT NULL,
  `outros_disturbios_respiratorios` text,
  `diabetes` tinyint DEFAULT NULL,
  `disfuncao_tireoide` tinyint DEFAULT NULL,
  `menarca` int DEFAULT NULL,
  `menopausa` int DEFAULT NULL,
  `gravidez` int DEFAULT NULL,
  `partos` int DEFAULT NULL,
  `outros_disturbios_endocrinos` text,
  `desmaios` tinyint DEFAULT NULL,
  `convulsoes` tinyint DEFAULT NULL,
  `enxaquecas` tinyint DEFAULT NULL,
  `cefaleias` tinyint DEFAULT NULL,
  `nevralgia_na_face` tinyint DEFAULT NULL,
  `outros_disturbios_neurologicos` text,
  `anemia` tinyint DEFAULT NULL,
  `hemorragia` tinyint DEFAULT NULL,
  `hemofilia` tinyint DEFAULT NULL,
  `leucemia` tinyint DEFAULT NULL,
  `outros_disturbios_hematologicos` text,
  `doou_ou_recebeu_sangue` tinyint DEFAULT NULL,
  `data_doacao_sangue` date DEFAULT NULL,
  `tratamento_psiquiatrico` tinyint DEFAULT NULL,
  `depressao` tinyint DEFAULT NULL,
  `ansiedade` tinyint DEFAULT NULL,
  `outros_disturbios_psiquiatricos` text,
  `ja_sofreu_traumatismo_na_face` tinyint DEFAULT NULL,
  `artrite` tinyint DEFAULT NULL,
  `reumatismo` tinyint DEFAULT NULL,
  `osteoporose` tinyint DEFAULT NULL,
  `outros_disturbios_articulacoes_ou_ossos` text,
  `bruxismo_centrico` tinyint DEFAULT NULL,
  `bruxismo_excentrico` tinyint DEFAULT NULL,
  `mastigacao_unilateral` tinyint DEFAULT NULL,
  `dor_regiao_dos_ouvidos` tinyint DEFAULT NULL,
  `estalido_na_abertura_e_fechamento_bucal` tinyint DEFAULT NULL,
  `outros_disturbios_articulacao_temporamandibular` text,
  `hepatite` tinyint DEFAULT NULL,
  `herpes` tinyint DEFAULT NULL,
  `hiv` tinyint DEFAULT NULL,
  `tuberculose` tinyint DEFAULT NULL,
  `doenca_sexualmente_transmissivel` tinyint DEFAULT NULL,
  `quais_doenca_transmissiveis` text,
  `outras_doencas_transmissiveis` text,
  `anestesia` tinyint DEFAULT NULL,
  `alimentos` tinyint DEFAULT NULL,
  `cosmeticos` tinyint DEFAULT NULL,
  `urticaria` tinyint DEFAULT NULL,
  `quais_alergias` text,
  `medicamentos` tinyint DEFAULT NULL,
  `quais_medicamentos` text,
  `outras_alergias` text,
  `faz_uso_de_medicamentos` tinyint DEFAULT NULL,
  `visitas_medicas` text,
  `descricao_medicamentos` text,
  `hospitalizacoes` text,
  `observacoes` text,
  `dados_relevantes_historia_medica` text,
  `pai` varchar(245) DEFAULT NULL,
  `mae` varchar(245) DEFAULT NULL,
  `irmaos` varchar(245) DEFAULT NULL,
  `cardiopatias` tinyint DEFAULT NULL,
  `hipertensao` tinyint DEFAULT NULL,
  `diabete_hereditaria` tinyint DEFAULT NULL,
  `asma_hereditaria` tinyint DEFAULT NULL,
  `disturbio_sangramento` tinyint DEFAULT NULL,
  `alergias_hereditaria` tinyint DEFAULT NULL,
  `neoplastias_malignas` tinyint DEFAULT NULL,
  `doenca_neurologicas` tinyint DEFAULT NULL,
  `tuberculose_hereditaria` tinyint DEFAULT NULL,
  `complemento` text,
  `outras_doencas_hereditarias` text,
  `habito_alcool` tinyint DEFAULT NULL,
  `frequencia_alcool` varchar(245) DEFAULT NULL,
  `habito_fumo` tinyint DEFAULT NULL,
  `frequencia_fumo` varchar(245) DEFAULT NULL,
  `outros_habitos_nocivos` text,
  `escovacao` varchar(245) DEFAULT NULL,
  `fio_dental` varchar(245) DEFAULT NULL,
  `enxaguatorio_bucal` varchar(245) DEFAULT NULL,
  `observacoes_dentes` text,
  `observacoes_diagnostico_dentes` text,
  `plano_cronologico_tratamento` text,
  `restauracao_definitica_do_dente` text,
  `numero_de_sessoes_realizadas` int DEFAULT NULL,
  `path_mapa_periodental` varchar(245) DEFAULT NULL,
  `gastrite` tinyint DEFAULT NULL,
  `ulceras` tinyint DEFAULT NULL,
  `cirrose` tinyint DEFAULT NULL,
  `outros_disturbios_gastrointestinais` text,
  `infeccoes_do_trato_urinario` tinyint DEFAULT NULL,
  `doenca_ginecologicas` tinyint DEFAULT NULL,
  `insuficiencia_renal` tinyint DEFAULT NULL,
  `faz_hemodialise` tinyint DEFAULT NULL,
  `quais_hemodialises` text,
  `outros_disturbios_genitourinarias` text,
  `nefrite` tinyint DEFAULT NULL,
  `pressao_arterial` varchar(255) DEFAULT NULL,
  `frequencia_respiratoria` varchar(255) DEFAULT NULL,
  `pulso` varchar(255) DEFAULT NULL,
  `temperatura_axilar` varchar(255) DEFAULT NULL,
  `ectoscopia` varchar(255) DEFAULT NULL,
  `oroscopia` varchar(255) DEFAULT NULL,
  `exames_complementares_solicitados` varchar(255) DEFAULT NULL,
  `pedido_avaliacao_medica` tinyint(1) DEFAULT NULL,
  `motivo` varchar(255) DEFAULT NULL,
  `data_pedido_avaliacao_medica` datetime DEFAULT NULL,
  `parecer_medico` varchar(255) DEFAULT NULL,
  `paciente_portador_de` varchar(255) DEFAULT NULL,
  `necessita_de_cuidados_especiais_relacao` varchar(255) DEFAULT NULL,
  `observacoes_exame_fisico` text,
  `quantidade_de_sodio_a_porcentagem` varchar(245) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_paciente` (`id_paciente`),
  KEY `id_professor_vinculado` (`id_professor_vinculado`),
  KEY `estudante_idx` (`id_estudante_vinculado`),
  KEY `status_idx` (`id_prontuario_status`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario`
--

LOCK TABLES `prontuario` WRITE;
/*!40000 ALTER TABLE `prontuario` DISABLE KEYS */;
INSERT INTO `prontuario` VALUES (8,19,5,7,1000,'2024-06-24 04:28:38','dor','',1,NULL,NULL,1,'ASDA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(9,18,5,7,2000,'2024-06-24 19:56:26','teste dor','',1,1,0,NULL,'verifica',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'asd','asd','asd','asd',NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(10,16,5,NULL,1000,'2024-06-24 23:39:01','','',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(11,17,NULL,2,1000,'2024-06-25 01:02:23',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(12,6,19,7,2000,'2024-06-25 04:12:47','dor teste solid√£o','teste',1,1,1,1,'todas',1,1,1,1,1,1,1,1,1,1,1,'todas',1,1,1,1,'todas',1,1,1,1,1,1,'todas',1,1,1,1,1,'todas',1,1,1,1,'todas',1,'2024-06-25',1,1,1,'teste',1,1,1,1,'todas',1,1,1,1,1,'todas',1,1,1,1,1,'todas','todas',1,1,1,1,'todas',1,'todos','todos',1,NULL,NULL,NULL,'todos','todos','todo','toda','todos',1,1,1,1,1,1,1,1,1,'tudo','todas',1,'sempre',1,'sempre','todos','sempre','sempre','sempres','t','teste','teste',NULL,NULL,NULL,1,1,1,'todas',1,1,1,1,'teste','todas',1,'teste','testet','teste','teste','teste','tetse','teste',1,'teste','2024-06-29 03:00:00','teste','teste','teste','teste',NULL),(13,9,7,7,2000,'2024-06-25 21:34:20','Queixada','doen√ßa bem ruim',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(14,20,NULL,13,1000,'2024-06-25 21:37:27','dor no dente','nenhuma',0,0,0,0,NULL,0,0,0,0,0,0,0,0,0,0,0,NULL,0,0,0,0,NULL,0,0,NULL,NULL,NULL,NULL,NULL,0,0,0,0,0,NULL,0,0,0,0,NULL,0,NULL,0,0,0,NULL,0,0,0,0,NULL,0,0,0,0,0,NULL,NULL,NULL,NULL,NULL,0,NULL,NULL,0,0,0,0,NULL,NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,0,0,0,0,0,0,0,0,NULL,NULL,0,NULL,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,NULL,0,0,0,NULL,0,0,0,0,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(15,21,NULL,13,1000,'2024-06-26 00:06:39','Dentes n√£o cuidados','Paciente n√£o apresenta um bom cuidado dental',0,0,0,0,NULL,0,0,0,0,0,0,0,0,0,0,0,NULL,0,0,0,0,NULL,0,0,0,0,0,0,NULL,0,0,0,0,0,NULL,0,0,0,0,NULL,0,NULL,0,0,0,NULL,0,0,0,0,NULL,0,0,0,0,0,NULL,0,0,0,0,0,NULL,NULL,0,0,0,0,NULL,0,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,'0','0','0',0,0,0,0,0,0,0,0,0,NULL,NULL,0,NULL,0,NULL,NULL,'Fraco','Fraco','Fraco',NULL,NULL,'',NULL,NULL,NULL,0,0,0,NULL,0,0,0,0,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `prontuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prontuario_assinatura_usuario`
--

DROP TABLE IF EXISTS `prontuario_assinatura_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prontuario_assinatura_usuario` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_usuario` int DEFAULT NULL,
  `id_prontuario` int DEFAULT NULL,
  `id_prontuario_menor` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario_assinatura_usuario`
--

LOCK TABLES `prontuario_assinatura_usuario` WRITE;
/*!40000 ALTER TABLE `prontuario_assinatura_usuario` DISABLE KEYS */;
INSERT INTO `prontuario_assinatura_usuario` VALUES (1,4,9,NULL),(2,4,9,NULL),(3,41,9,NULL),(4,23,0,NULL),(5,23,11,NULL),(6,41,8,NULL),(7,41,0,NULL),(8,41,12,NULL),(9,41,12,NULL),(10,41,12,NULL),(11,41,12,NULL),(12,41,12,NULL),(13,41,12,NULL),(14,41,12,NULL),(15,41,12,NULL),(16,41,12,NULL),(17,41,12,NULL),(18,41,12,NULL),(19,41,12,NULL),(20,41,12,NULL),(21,41,12,NULL),(22,41,12,NULL),(23,41,12,NULL),(24,41,12,NULL),(25,41,12,NULL),(26,41,12,NULL),(27,41,12,NULL),(28,41,12,NULL),(29,36,12,NULL),(30,36,12,NULL),(31,36,12,NULL),(32,36,12,NULL),(33,36,12,NULL),(34,36,12,NULL),(35,36,12,NULL),(36,36,12,NULL),(37,36,12,NULL),(38,36,12,NULL),(39,36,12,NULL),(40,36,12,NULL),(41,6,13,NULL),(42,54,0,NULL),(43,54,14,NULL),(44,54,0,NULL),(45,54,15,NULL),(46,54,15,NULL),(47,41,13,NULL),(48,41,13,NULL),(49,41,13,NULL),(50,41,13,NULL),(51,41,13,NULL),(52,41,13,NULL),(53,41,13,0),(54,41,0,2);
/*!40000 ALTER TABLE `prontuario_assinatura_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prontuario_descricao_dente`
--

DROP TABLE IF EXISTS `prontuario_descricao_dente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prontuario_descricao_dente` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_prontuario` int DEFAULT NULL,
  `numero_dente` varchar(45) DEFAULT NULL,
  `descricao_dente` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=162 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario_descricao_dente`
--

LOCK TABLES `prontuario_descricao_dente` WRITE;
/*!40000 ALTER TABLE `prontuario_descricao_dente` DISABLE KEYS */;
INSERT INTO `prontuario_descricao_dente` VALUES (1,1,'_18','ghnrhbntmym hnedrhnjyrht'),(130,9,'_18','1'),(131,9,'_17','2'),(132,9,'_16','3'),(133,12,'_18','test'),(134,12,'_17','test'),(135,12,'_16','teste'),(136,12,'_15_55','testet'),(137,12,'_14_54','t'),(138,12,'_12_52','t'),(139,12,'_11_51','t'),(140,12,'_22_62','tt'),(141,12,'_23_63','t'),(142,12,'_24_64','t'),(143,12,'_25_65','t'),(144,12,'_27','tt'),(145,12,'_28','t'),(146,12,'_38','t'),(147,12,'_37','t'),(148,12,'_36','tt'),(149,12,'_35_75','t'),(150,12,'_34_74','t'),(151,12,'_33_73','t'),(152,12,'_32_72','t'),(153,12,'_31_71','t'),(154,12,'_41_81','t'),(155,12,'_42_82','t'),(156,12,'_43_83','t'),(157,12,'_44_84','t'),(158,12,'_45_85','t'),(159,12,'_46','t'),(160,12,'_47','t'),(161,12,'_48','t');
/*!40000 ALTER TABLE `prontuario_descricao_dente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prontuario_diagnostico_dentes`
--

DROP TABLE IF EXISTS `prontuario_diagnostico_dentes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prontuario_diagnostico_dentes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_prontuario` int DEFAULT NULL,
  `tipo_diagnostico` varchar(245) DEFAULT NULL,
  `dentes` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario_diagnostico_dentes`
--

LOCK TABLES `prontuario_diagnostico_dentes` WRITE;
/*!40000 ALTER TABLE `prontuario_diagnostico_dentes` DISABLE KEYS */;
INSERT INTO `prontuario_diagnostico_dentes` VALUES (1,1,'Gengivite','_18'),(2,1,'PeriodontiteLeve','_17,_11'),(3,1,'PeriodontiteGrave',''),(4,1,'EComplicada',''),(21,8,'Gengivite',''),(22,8,'PeriodontiteLeve',''),(23,8,'PeriodontiteGrave',''),(24,8,'EComplicada',''),(25,9,'Gengivite','_12,_11,_42,_41'),(26,9,'PeriodontiteLeve','_13,_12,_43,_42'),(27,9,'PeriodontiteGrave','_15'),(28,9,'EComplicada',''),(29,10,'Gengivite',''),(30,10,'PeriodontiteLeve',''),(31,10,'PeriodontiteGrave',''),(32,10,'EComplicada',''),(33,11,'Gengivite',''),(34,11,'PeriodontiteLeve',''),(35,11,'PeriodontiteGrave',''),(36,11,'EComplicada',''),(37,12,'Gengivite','_16,_15,_46,_45'),(38,12,'PeriodontiteLeve','_16,_15,_46,_45'),(39,12,'PeriodontiteGrave','_16,_15,_46,_45'),(40,12,'EComplicada','_16,_15,_46'),(41,13,'Gengivite',''),(42,13,'PeriodontiteLeve',''),(43,13,'PeriodontiteGrave',''),(44,13,'EComplicada',''),(45,14,'Gengivite',''),(46,14,'PeriodontiteLeve',''),(47,14,'PeriodontiteGrave',''),(48,14,'EComplicada',''),(49,15,'Gengivite',''),(50,15,'PeriodontiteLeve',''),(51,15,'PeriodontiteGrave',''),(52,15,'EComplicada','');
/*!40000 ALTER TABLE `prontuario_diagnostico_dentes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prontuario_estudante`
--

DROP TABLE IF EXISTS `prontuario_estudante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prontuario_estudante` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_prontuario` int NOT NULL,
  `id_estudante` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_prontuario` (`id_prontuario`),
  CONSTRAINT `prontuario_estudante_ibfk_1` FOREIGN KEY (`id_prontuario`) REFERENCES `prontuario` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario_estudante`
--

LOCK TABLES `prontuario_estudante` WRITE;
/*!40000 ALTER TABLE `prontuario_estudante` DISABLE KEYS */;
/*!40000 ALTER TABLE `prontuario_estudante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prontuario_menor`
--

DROP TABLE IF EXISTS `prontuario_menor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prontuario_menor` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_paciente` varchar(45) DEFAULT NULL,
  `id_estudante_vinculado` int DEFAULT NULL,
  `id_professor_vinculado` int DEFAULT NULL,
  `id_prontuario_status` int DEFAULT NULL,
  `data_cadastro` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `professorafa_idx` (`id_professor_vinculado`),
  KEY `estudantealuno_idx` (`id_estudante_vinculado`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario_menor`
--

LOCK TABLES `prontuario_menor` WRITE;
/*!40000 ALTER TABLE `prontuario_menor` DISABLE KEYS */;
INSERT INTO `prontuario_menor` VALUES (1,'19',7,36,2000,NULL),(2,'18',41,36,2000,NULL);
/*!40000 ALTER TABLE `prontuario_menor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prontuario_menor_observacoes`
--

DROP TABLE IF EXISTS `prontuario_menor_observacoes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prontuario_menor_observacoes` (
  `id` int NOT NULL,
  `id_prontuario` int DEFAULT NULL,
  `observacoes` text,
  `descricao_observacao` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario_menor_observacoes`
--

LOCK TABLES `prontuario_menor_observacoes` WRITE;
/*!40000 ALTER TABLE `prontuario_menor_observacoes` DISABLE KEYS */;
/*!40000 ALTER TABLE `prontuario_menor_observacoes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prontuario_pm_estudante`
--

DROP TABLE IF EXISTS `prontuario_pm_estudante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prontuario_pm_estudante` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_estudante` int NOT NULL,
  `id_prontuario_pm` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_estudante` (`id_estudante`),
  KEY `id_prontuario_pm` (`id_prontuario_pm`),
  CONSTRAINT `prontuario_pm_estudante_ibfk_2` FOREIGN KEY (`id_prontuario_pm`) REFERENCES `prontuario_pronto_atendimento` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario_pm_estudante`
--

LOCK TABLES `prontuario_pm_estudante` WRITE;
/*!40000 ALTER TABLE `prontuario_pm_estudante` DISABLE KEYS */;
INSERT INTO `prontuario_pm_estudante` VALUES (3,7,28),(4,7,29);
/*!40000 ALTER TABLE `prontuario_pm_estudante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prontuario_pronto_atendimento`
--

DROP TABLE IF EXISTS `prontuario_pronto_atendimento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prontuario_pronto_atendimento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_paciente` int NOT NULL,
  `id_professor_vinculado` int DEFAULT NULL,
  `queixa_principal` varchar(400) NOT NULL,
  `historia_molestia_atual` varchar(500) NOT NULL,
  `ja_tomou_anestesia_odontologica` tinyint NOT NULL,
  `teve_alguma_reacao_indesejavel` tinyint NOT NULL,
  `esta_sob_tratamento_medico` tinyint NOT NULL,
  `motivo_tratamento_medico` varchar(150) DEFAULT NULL,
  `esta_tomando_algum_medicamento` tinyint NOT NULL,
  `qual_medicamento` varchar(150) DEFAULT NULL,
  `alergia_algum_medicamento_substancia` tinyint NOT NULL,
  `qual_medicamento_substancia` varchar(150) DEFAULT NULL,
  `e_diabetico` tinyint NOT NULL,
  `esta_gravida` tinyint NOT NULL,
  `sofre_disturbios_cardiovasculares` tinyint NOT NULL,
  `qual_disturbio_cardiovascular` varchar(150) DEFAULT NULL,
  `tem_hipertensao` tinyint NOT NULL,
  `faz_uso_protese_cardiaca` tinyint NOT NULL,
  `outros` varchar(150) DEFAULT NULL,
  `apresenta_historia_hemorragia` tinyint NOT NULL,
  `apresenta_historia_febre_reumatica` tinyint NOT NULL,
  `bronquite` tinyint NOT NULL,
  `asma` tinyint NOT NULL,
  `outros_disturbios_respiratorios` varchar(150) DEFAULT NULL,
  `sofre_disturbio_gastro_intestinal` tinyint NOT NULL,
  `gastrite` tinyint NOT NULL,
  `ulcera` tinyint NOT NULL,
  `hepatite` tinyint NOT NULL,
  `cirrose` tinyint NOT NULL,
  `teve_doenca_infecto_contagiosa` tinyint NOT NULL,
  `qual_doenca_infecto_contagiosa` varchar(150) DEFAULT NULL,
  `existe_doenca_predominante_familia` tinyint NOT NULL,
  `qual_doenca_predominante` varchar(150) DEFAULT NULL,
  `outras_informacoes_habitos_vicios` varchar(150) DEFAULT NULL,
  `observacoes` varchar(150) DEFAULT NULL,
  `pressao_arterial_mm_mmHg` varchar(10) NOT NULL,
  `diagnostico` varchar(150) NOT NULL,
  `aluno_assinou` tinyint DEFAULT NULL,
  `cidade_ficha_feita` varchar(100) DEFAULT NULL,
  `data_ficha_feita` datetime NOT NULL,
  `professor_assinou` tinyint DEFAULT NULL,
  `paciente_assinou` tinyint DEFAULT NULL,
  `id_estudante` int DEFAULT NULL,
  `status` enum('Pendente','Aprovado','Reprovado') DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_paciente` (`id_paciente`),
  KEY `id_professor_vinculado` (`id_professor_vinculado`),
  KEY `prontuario_pronto_atendimento_estudante_idx` (`id_estudante`),
  CONSTRAINT `prontuario_pronto_atendimento_ibfk_1` FOREIGN KEY (`id_paciente`) REFERENCES `paciente` (`id`),
  CONSTRAINT `prontuario_pronto_atendimento_ibfk_2` FOREIGN KEY (`id_professor_vinculado`) REFERENCES `professor` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario_pronto_atendimento`
--

LOCK TABLES `prontuario_pronto_atendimento` WRITE;
/*!40000 ALTER TABLE `prontuario_pronto_atendimento` DISABLE KEYS */;
INSERT INTO `prontuario_pronto_atendimento` VALUES (1,4,1,'dor','sei la',1,1,1,'dor',1,'pacetamol',1,'sei la',1,1,1,'sei la',1,1,'outros',1,1,1,1,'sim',1,1,1,1,1,1,'sei la',1,'sei la','nenhum','nenhuma','12','morrendo',1,'Alfenas','2024-06-02 00:00:00',1,1,0,'Aprovado'),(2,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 00:43:45',NULL,NULL,NULL,'Aprovado'),(3,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 00:46:46',NULL,NULL,NULL,'Aprovado'),(4,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 00:47:44',NULL,NULL,NULL,'Aprovado'),(5,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 00:49:08',NULL,NULL,NULL,'Aprovado'),(6,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 00:53:37',NULL,NULL,NULL,'Aprovado'),(7,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 00:59:12',NULL,NULL,NULL,'Aprovado'),(8,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 01:04:31',NULL,NULL,NULL,'Aprovado'),(9,19,6,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 01:39:18',1,NULL,NULL,'Aprovado'),(10,19,6,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 01:57:21',1,NULL,NULL,'Aprovado'),(11,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 01:58:51',NULL,NULL,NULL,'Aprovado'),(12,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 01:59:02',NULL,NULL,NULL,'Aprovado'),(13,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:00:59',NULL,NULL,NULL,'Aprovado'),(14,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:03:23',NULL,NULL,NULL,'Aprovado'),(15,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:04:14',NULL,NULL,NULL,'Aprovado'),(16,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:05:46',NULL,NULL,NULL,'Aprovado'),(17,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:06:30',NULL,NULL,NULL,'Aprovado'),(18,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:07:05',NULL,NULL,NULL,'Aprovado'),(19,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:09:20',NULL,NULL,NULL,'Aprovado'),(20,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:11:25',NULL,NULL,NULL,'Aprovado'),(21,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:12:51',NULL,NULL,NULL,'Aprovado'),(22,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:17:26',NULL,NULL,NULL,'Aprovado'),(23,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:18:14',NULL,NULL,NULL,'Aprovado'),(24,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:19:47',NULL,NULL,NULL,'Aprovado'),(25,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:22:14',NULL,NULL,NULL,'Aprovado'),(26,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:24:19',NULL,NULL,NULL,'Aprovado'),(27,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:26:36',NULL,NULL,NULL,'Aprovado'),(28,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:28:49',NULL,NULL,NULL,'Aprovado'),(29,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',1,NULL,'2024-06-25 02:30:46',NULL,NULL,NULL,'Aprovado'),(30,19,NULL,'TESTE','TESTE',1,0,0,'TESTE',0,NULL,0,'TESTE',0,0,0,'TESTE',0,0,'TESTE',0,1,0,0,'TESTE',0,0,0,0,0,0,'TESTE',0,'TESTE','TESTE','TESTE','TESTE','TESTE',NULL,NULL,'2024-06-25 20:32:25',1,NULL,7,'Pendente'),(31,19,NULL,'TESTE','TESTE',1,0,0,'TESTE',0,NULL,0,'TESTE',0,0,0,'TESTE',0,0,'TESTE',0,1,0,0,'TESTE',0,0,0,0,0,0,'TESTE',0,'TESTE','TESTE','TESTE','TESTE','TESTE',NULL,NULL,'2024-06-25 20:36:39',1,NULL,7,'Pendente'),(32,19,7,'TESTE','TESTE',1,0,0,'TESTE',0,NULL,0,'TESTE',0,0,0,'TESTE',0,0,'TESTE',0,1,0,0,'TESTE',0,0,0,0,0,0,'TESTE',0,'TESTE','TESTE','TESTE','TESTE','TESTE',NULL,NULL,'2024-06-25 20:43:20',1,NULL,NULL,'Aprovado'),(33,19,7,'Jo√£o Marcelo Feio','TESTE',1,0,0,'TESTE',0,NULL,0,'TESTE',0,0,0,'TESTE',0,0,'TESTE',0,1,0,0,'TESTE',0,0,0,0,0,0,'TESTE',0,'TESTE','TESTE','TESTE','TESTE','TESTE',NULL,NULL,'2024-06-25 21:53:27',1,NULL,NULL,'Aprovado'),(35,6,5,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',0,0,1,'teste',1,1,'teste',1,1,0,0,'tete',1,1,0,0,0,1,'teste',1,'teste','tete','teste','tete','teste',NULL,NULL,'2024-06-26 01:06:48',1,NULL,NULL,'Aprovado'),(36,19,5,'Jo√£o Marcelo Feio','TESTE',1,0,0,'TESTE',0,NULL,0,'TESTE',0,0,0,'TESTE',0,0,'TESTE',0,1,0,0,'TESTE',0,0,0,0,0,0,'TESTE',0,'TESTE','TESTE','TESTE','TESTE','TESTE',NULL,NULL,'2024-06-26 03:18:11',1,NULL,NULL,'Aprovado'),(37,19,5,'Jo√£o Marcelo Bob√£o','TESTE',1,0,0,'TESTE',0,NULL,0,'TESTE',0,0,0,'TESTE',0,0,'TESTE',0,1,0,0,'TESTE',0,0,0,0,0,0,'TESTE',0,'TESTE','TESTE','TESTE','TESTE','TESTE',NULL,NULL,'2024-06-26 03:18:19',1,NULL,NULL,'Aprovado'),(38,19,5,'Felipe','TESTE',1,0,0,'TESTE',0,NULL,0,'TESTE',0,0,0,'TESTE',0,0,'TESTE',0,1,0,0,'TESTE',0,0,0,0,0,0,'TESTE',0,'TESTE','TESTE','TESTE','TESTE','TESTE',NULL,NULL,'2024-06-26 03:18:07',1,NULL,NULL,'Aprovado'),(39,19,7,'Jo√£o Marcelo Bob√£o','TESTE',1,0,0,'TESTE',0,NULL,0,'TESTE',0,0,0,'TESTE',0,0,'TESTE',0,1,0,0,'TESTE',0,0,0,0,0,0,'TESTE',0,'TESTE','TESTE','TESTE','TESTE','TESTE',NULL,NULL,'2024-06-25 23:15:23',1,NULL,7,'Aprovado'),(40,19,7,'Jo√£o Marcelo Bob√£o','TESTE',1,0,0,'TESTE',0,NULL,0,'TESTE',0,0,0,'TESTE',0,0,'TESTE',0,1,0,0,'TESTE',0,0,0,0,0,0,'TESTE',0,'TESTE','TESTE','TESTE','TESTE','TESTE',NULL,NULL,'2024-06-25 23:21:50',1,NULL,NULL,'Aprovado'),(41,19,NULL,'EUuuu','TESTE',1,0,0,'TESTE',0,NULL,0,'TESTE',0,0,0,'TESTE',0,0,'TESTE',0,1,0,0,'TESTE',0,0,0,0,0,0,'TESTE',0,'TESTE','TESTE','TESTE','TESTE','TESTE',NULL,NULL,'2024-06-26 03:20:01',0,NULL,7,'Pendente'),(42,6,NULL,'teste','tes',1,1,0,'ytrew',0,NULL,1,'',0,1,1,'',0,0,'',1,1,0,1,'',1,0,0,1,0,0,'',1,'','','','','',NULL,NULL,'2024-06-26 03:28:34',0,NULL,7,'Pendente'),(43,19,7,'Felipe','TESTE',1,0,0,'TESTE',0,NULL,0,'TESTE',0,0,0,'TESTE',0,0,'TESTE',0,1,0,0,'TESTE',0,0,0,0,0,0,'TESTE',0,'TESTE','TESTE','TESTE','TESTE','TESTE',NULL,NULL,'2024-06-26 02:52:45',0,NULL,NULL,'Reprovado');
/*!40000 ALTER TABLE `prontuario_pronto_atendimento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prontuario_status`
--

DROP TABLE IF EXISTS `prontuario_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prontuario_status` (
  `id` int NOT NULL,
  `descricao` varchar(245) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario_status`
--

LOCK TABLES `prontuario_status` WRITE;
/*!40000 ALTER TABLE `prontuario_status` DISABLE KEYS */;
INSERT INTO `prontuario_status` VALUES (1000,'prontuario_incompleto'),(2000,'aprovado'),(3000,'reprovado');
/*!40000 ALTER TABLE `prontuario_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reavaliacao_anamnese`
--

DROP TABLE IF EXISTS `reavaliacao_anamnese`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reavaliacao_anamnese` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_prontuario` int NOT NULL,
  `id_estudante_vinculado` int DEFAULT NULL,
  `id_professor_responsavel` int DEFAULT NULL,
  `data` date DEFAULT NULL,
  `pressao_arterial` varchar(245) DEFAULT NULL,
  `frequencia_respiratoria` varchar(245) DEFAULT NULL,
  `temperatura_axilar` varchar(245) DEFAULT NULL,
  `pulso` varchar(245) DEFAULT NULL,
  `medicamentos` varchar(300) DEFAULT NULL,
  `observacoes` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reavaliacao_anamnese`
--

LOCK TABLES `reavaliacao_anamnese` WRITE;
/*!40000 ALTER TABLE `reavaliacao_anamnese` DISABLE KEYS */;
INSERT INTO `reavaliacao_anamnese` VALUES (6,12,NULL,19,'2024-06-25','1','1','1','1','1','1'),(7,12,NULL,19,'2024-06-27','1e121','12312','123123','1231','132123','123123'),(8,12,NULL,19,'2024-06-30','1','3','4','2','5','6');
/*!40000 ALTER TABLE `reavaliacao_anamnese` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `responsavel`
--

DROP TABLE IF EXISTS `responsavel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `responsavel` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_paciente` int DEFAULT NULL,
  `nome` varchar(245) DEFAULT NULL,
  `telefone1` varchar(245) DEFAULT NULL,
  `email` varchar(245) DEFAULT NULL,
  `cpf` varchar(245) DEFAULT NULL,
  `telefone2` varchar(245) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `responsavel_paciente_idx` (`id_paciente`),
  CONSTRAINT `responsavel_paciente` FOREIGN KEY (`id_paciente`) REFERENCES `paciente` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `responsavel`
--

LOCK TABLES `responsavel` WRITE;
/*!40000 ALTER TABLE `responsavel` DISABLE KEYS */;
INSERT INTO `responsavel` VALUES (1,3,'Ana da Silva','(11) 91234-5678','ana.silva@example.com','987.654.321-00',NULL),(2,3,'Carlos de Souza','(11) 93456-7890','carlos.souza@example.com','456.123.789-00',NULL),(3,4,'Ana da Silva','(11) 91234-5678','ana.silva@example.com','987.654.321-00',NULL),(4,4,'Carlos de Souza','(11) 93456-7890','carlos.souza@example.com','456.123.789-00',NULL),(5,5,'Ana da Silva','(11) 91234-5678','ana.silva@example.com','987.654.321-00',NULL),(6,5,'Carlos de Souza','(11) 93456-7890','carlos.souza@example.com','456.123.789-00',NULL),(7,6,'Ana da Silva','(11) 91234-5678','ana.silva@example.com','987.654.321-00',NULL),(8,6,'Carlos de Souza','(11) 93456-7890','carlos.souza@example.com','456.123.789-00',NULL),(13,16,'Kariny Maria','(35) 9999-29201','kariny@gmail.com','098.765.456-70',NULL),(18,17,'JOAO PEDRO FERNANDES REIS','(12) 3123-1233','joaofernandesreis32@gmail.com','123.123.123-12',NULL),(19,19,'JOAO PEDRO FERNANDES REIS','(12) 3123-1232','joaofernandesreis32@gmail.com','123.123.123-12',NULL),(22,21,'Jos√© Batista de Carlos','(35) 99364-8502','josebatista@gmail.com','546.546.363-42','(35) 9984-4325');
/*!40000 ALTER TABLE `responsavel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `respostas_abertas`
--

DROP TABLE IF EXISTS `respostas_abertas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `respostas_abertas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_prontuario` int NOT NULL,
  `id_pergunta` int DEFAULT NULL,
  `resposta` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=392 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `respostas_abertas`
--

LOCK TABLES `respostas_abertas` WRITE;
/*!40000 ALTER TABLE `respostas_abertas` DISABLE KEYS */;
INSERT INTO `respostas_abertas` VALUES (2,1,2,'Boraaaaa'),(3,1,1,'Deu certooooo'),(4,2,1,'Deu certooooo'),(5,2,2,'Boraaaaa'),(6,1,77,''),(7,1,7,''),(8,1,9,''),(9,1,10,''),(10,1,11,''),(11,1,12,''),(12,1,13,''),(13,1,14,''),(14,1,16,''),(15,1,17,''),(16,1,20,''),(17,1,21,''),(18,1,25,''),(19,1,28,''),(20,1,31,''),(21,1,32,''),(22,1,34,''),(23,1,36,''),(24,1,39,''),(25,1,41,''),(26,1,42,''),(27,1,44,''),(28,1,46,''),(29,1,70,''),(30,1,71,''),(31,1,72,''),(32,1,73,''),(33,1,74,''),(34,1,75,''),(35,1,76,''),(36,1,78,''),(37,1,79,''),(38,1,80,''),(39,1,82,''),(40,1,83,''),(41,1,84,''),(42,1,85,''),(43,1,86,''),(44,1,87,''),(45,1,88,''),(46,1,89,''),(47,1,90,''),(48,1,91,''),(49,1,92,''),(50,1,93,''),(51,1,94,''),(52,1,95,''),(53,1,96,''),(54,1,97,''),(55,1,98,''),(56,1,99,''),(57,1,100,''),(58,1,101,''),(59,1,102,''),(60,1,103,''),(61,1,104,''),(62,1,105,''),(63,1,106,''),(64,1,107,''),(65,1,108,''),(66,1,109,''),(67,1,110,''),(68,1,147,''),(69,1,149,''),(70,1,150,''),(71,1,151,''),(72,1,152,''),(73,1,153,''),(74,1,154,''),(75,1,155,''),(76,1,156,''),(77,1,157,''),(78,1,158,''),(79,1,159,''),(80,1,160,''),(81,1,161,''),(82,1,162,''),(83,1,163,''),(84,1,164,''),(85,1,165,''),(86,1,166,''),(87,1,167,''),(88,1,168,''),(89,1,169,''),(90,1,170,''),(91,1,171,''),(92,1,172,''),(93,1,173,''),(94,1,174,''),(95,1,175,''),(96,1,176,''),(97,1,177,''),(98,1,178,''),(99,1,179,''),(100,1,180,''),(101,1,181,''),(102,1,182,''),(103,1,184,''),(104,1,185,''),(105,1,187,''),(106,1,190,''),(107,1,191,''),(108,1,192,''),(109,1,194,''),(110,1,199,''),(111,1,201,''),(112,1,203,''),(113,1,205,''),(114,1,207,''),(115,1,209,''),(116,1,211,''),(117,1,212,''),(118,1,213,''),(119,1,216,''),(120,1,217,''),(121,1,219,''),(122,1,221,''),(123,1,222,''),(124,1,223,''),(125,1,225,''),(126,1,226,''),(127,1,227,''),(128,1,229,''),(129,1,230,''),(130,1,231,''),(131,1,232,''),(132,1,233,''),(133,1,234,''),(134,1,236,''),(135,1,238,''),(136,1,239,''),(137,1,240,''),(138,1,241,''),(139,1,242,''),(140,1,243,''),(141,1,244,''),(142,1,245,''),(143,1,246,''),(144,1,247,''),(145,1,248,''),(146,1,250,''),(147,1,251,''),(148,1,252,''),(149,1,253,''),(150,1,254,''),(151,1,255,''),(152,1,256,''),(153,1,257,''),(154,1,258,''),(155,1,259,''),(156,1,260,''),(157,1,261,''),(158,1,262,''),(159,1,263,''),(160,1,264,''),(161,1,265,''),(162,1,266,''),(163,1,267,''),(164,1,268,''),(165,1,269,''),(166,1,270,''),(167,1,271,''),(168,1,272,''),(169,1,275,''),(170,1,277,''),(171,1,279,''),(172,1,281,''),(173,1,284,''),(174,1,286,''),(175,1,287,''),(176,1,288,''),(177,1,289,''),(178,1,290,''),(179,1,291,''),(180,1,292,''),(181,1,293,''),(182,1,294,''),(183,1,295,''),(184,1,296,''),(185,1,297,''),(186,1,298,''),(187,1,299,''),(188,1,300,''),(189,1,301,''),(190,1,302,''),(191,1,303,''),(192,1,304,''),(193,1,305,''),(194,1,306,''),(195,1,307,''),(196,1,308,''),(197,1,309,''),(198,1,310,''),(199,2,7,''),(200,2,9,''),(201,2,10,''),(202,2,11,''),(203,2,12,''),(204,2,13,''),(205,2,14,'32'),(206,2,16,'123'),(207,2,17,'ar232'),(208,2,20,'aa'),(209,2,21,'aaa'),(210,2,25,''),(211,2,28,''),(212,2,31,''),(213,2,32,''),(214,2,34,''),(215,2,36,''),(216,2,39,''),(217,2,41,''),(218,2,42,''),(219,2,44,''),(220,2,46,''),(221,2,70,''),(222,2,71,''),(223,2,72,''),(224,2,73,''),(225,2,74,''),(226,2,75,''),(227,2,76,''),(228,2,77,''),(229,2,78,''),(230,2,79,''),(231,2,80,''),(232,2,82,''),(233,2,83,''),(234,2,84,''),(235,2,85,''),(236,2,86,''),(237,2,87,''),(238,2,88,''),(239,2,89,''),(240,2,90,''),(241,2,91,''),(242,2,92,''),(243,2,93,''),(244,2,94,''),(245,2,95,''),(246,2,96,''),(247,2,97,''),(248,2,98,''),(249,2,99,''),(250,2,100,''),(251,2,101,''),(252,2,102,''),(253,2,103,''),(254,2,104,''),(255,2,105,''),(256,2,106,''),(257,2,107,''),(258,2,108,''),(259,2,109,''),(260,2,110,''),(261,2,147,''),(262,2,149,''),(263,2,150,''),(264,2,151,''),(265,2,152,''),(266,2,153,''),(267,2,154,''),(268,2,155,''),(269,2,156,''),(270,2,157,''),(271,2,158,''),(272,2,159,''),(273,2,160,''),(274,2,161,''),(275,2,162,''),(276,2,163,''),(277,2,164,''),(278,2,165,''),(279,2,166,''),(280,2,167,''),(281,2,168,''),(282,2,169,''),(283,2,170,''),(284,2,171,''),(285,2,172,''),(286,2,173,''),(287,2,174,''),(288,2,175,''),(289,2,176,''),(290,2,177,''),(291,2,178,''),(292,2,179,''),(293,2,180,''),(294,2,181,''),(295,2,182,''),(296,2,184,''),(297,2,185,''),(298,2,187,''),(299,2,190,''),(300,2,191,''),(301,2,192,''),(302,2,194,''),(303,2,199,''),(304,2,201,''),(305,2,203,''),(306,2,205,''),(307,2,207,''),(308,2,209,''),(309,2,211,''),(310,2,212,''),(311,2,213,''),(312,2,216,''),(313,2,217,''),(314,2,219,''),(315,2,221,''),(316,2,222,''),(317,2,223,''),(318,2,225,''),(319,2,226,''),(320,2,227,''),(321,2,229,''),(322,2,230,''),(323,2,231,''),(324,2,232,''),(325,2,233,''),(326,2,234,''),(327,2,236,''),(328,2,238,''),(329,2,239,''),(330,2,240,''),(331,2,241,''),(332,2,242,''),(333,2,243,''),(334,2,244,''),(335,2,245,''),(336,2,246,''),(337,2,247,''),(338,2,248,''),(339,2,250,''),(340,2,251,''),(341,2,252,''),(342,2,253,''),(343,2,254,''),(344,2,255,''),(345,2,256,''),(346,2,257,''),(347,2,258,''),(348,2,259,''),(349,2,260,''),(350,2,261,''),(351,2,262,''),(352,2,263,''),(353,2,264,''),(354,2,265,''),(355,2,266,''),(356,2,267,''),(357,2,268,''),(358,2,269,''),(359,2,270,''),(360,2,271,''),(361,2,272,''),(362,2,275,''),(363,2,277,''),(364,2,279,''),(365,2,281,''),(366,2,284,''),(367,2,286,''),(368,2,287,''),(369,2,288,''),(370,2,289,''),(371,2,290,''),(372,2,291,''),(373,2,292,''),(374,2,293,''),(375,2,294,''),(376,2,295,''),(377,2,296,''),(378,2,297,''),(379,2,298,''),(380,2,299,''),(381,2,300,''),(382,2,301,''),(383,2,302,''),(384,2,303,''),(385,2,304,''),(386,2,305,''),(387,2,306,''),(388,2,307,''),(389,2,308,''),(390,2,309,''),(391,2,310,'');
/*!40000 ALTER TABLE `respostas_abertas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `respostas_alternativa`
--

DROP TABLE IF EXISTS `respostas_alternativa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `respostas_alternativa` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_prontuario` int NOT NULL,
  `id_pergunta` int DEFAULT NULL,
  `id_alternativa` int DEFAULT NULL,
  `checked` tinyint DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1129 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `respostas_alternativa`
--

LOCK TABLES `respostas_alternativa` WRITE;
/*!40000 ALTER TABLE `respostas_alternativa` DISABLE KEYS */;
INSERT INTO `respostas_alternativa` VALUES (681,1,4,5,1),(682,1,4,4,0),(683,1,4,6,0),(684,1,8,8,0),(685,1,8,9,0),(686,1,8,10,0),(687,1,27,11,0),(688,1,27,12,0),(689,1,27,13,0),(690,1,26,14,0),(691,1,26,15,0),(692,1,26,16,0),(693,1,4,17,0),(694,1,4,18,0),(695,1,4,19,0),(696,1,5,20,0),(697,1,5,21,0),(698,1,5,22,0),(699,1,5,23,0),(700,1,6,24,0),(701,1,6,25,0),(702,1,6,26,0),(703,1,6,27,0),(704,1,6,28,0),(705,1,6,29,0),(706,1,6,30,0),(707,1,6,31,0),(708,1,6,32,0),(709,1,6,33,0),(710,1,6,34,0),(711,1,6,35,0),(712,1,15,36,0),(713,1,15,37,0),(714,1,15,38,0),(715,1,18,39,0),(716,1,18,40,0),(717,1,18,41,0),(718,1,19,42,0),(719,1,19,43,0),(720,1,19,44,0),(721,1,22,45,0),(722,1,22,46,0),(723,1,22,47,0),(724,1,23,48,0),(725,1,23,49,0),(726,1,23,50,0),(727,1,24,51,0),(728,1,24,52,0),(729,1,24,53,0),(730,1,29,54,0),(731,1,29,55,0),(732,1,29,56,0),(733,1,30,57,0),(734,1,30,58,0),(735,1,30,59,0),(736,1,33,60,1),(737,1,33,61,0),(738,1,33,62,0),(739,1,35,63,1),(740,1,35,64,0),(741,1,35,65,0),(742,1,35,66,0),(743,1,35,67,0),(744,1,35,68,0),(745,1,35,69,0),(746,1,37,70,0),(747,1,37,71,0),(748,1,37,72,0),(749,1,37,73,0),(750,1,37,74,0),(751,1,37,75,0),(752,1,38,76,0),(753,1,38,77,0),(754,1,38,78,0),(755,1,40,79,0),(756,1,40,80,0),(757,1,40,81,0),(758,1,43,82,0),(759,1,43,83,0),(760,1,43,84,0),(761,1,43,85,0),(762,1,43,86,0),(763,1,43,87,0),(764,1,45,88,0),(765,1,45,89,0),(766,1,45,90,0),(767,1,47,91,0),(768,1,47,92,0),(769,1,47,93,0),(770,1,48,94,0),(771,1,48,95,0),(772,1,48,96,0),(773,1,49,97,0),(774,1,49,98,0),(775,1,49,99,0),(776,1,50,100,0),(777,1,50,101,0),(778,1,50,102,0),(779,1,51,103,0),(780,1,51,104,0),(781,1,51,105,0),(782,1,52,106,0),(783,1,52,107,0),(784,1,52,108,0),(785,1,53,109,0),(786,1,53,110,0),(787,1,53,111,0),(788,1,54,112,0),(789,1,54,113,0),(790,1,54,114,0),(791,1,55,115,0),(792,1,55,116,0),(793,1,55,117,0),(794,1,56,118,0),(795,1,56,119,0),(796,1,56,120,0),(797,1,57,121,0),(798,1,57,122,0),(799,1,57,123,0),(800,1,58,124,0),(801,1,58,125,0),(802,1,58,126,0),(803,1,59,127,0),(804,1,59,128,0),(805,1,59,129,0),(806,1,60,130,0),(807,1,60,131,0),(808,1,60,132,0),(809,1,61,133,0),(810,1,61,134,0),(811,1,61,135,0),(812,1,62,136,0),(813,1,62,137,0),(814,1,62,138,0),(815,1,63,139,0),(816,1,63,140,0),(817,1,63,141,0),(818,1,64,142,0),(819,1,64,143,0),(820,1,64,144,0),(821,1,65,145,0),(822,1,65,146,0),(823,1,65,147,0),(824,1,66,148,0),(825,1,66,149,0),(826,1,66,150,0),(827,1,67,151,0),(828,1,67,152,0),(829,1,67,153,0),(830,1,68,154,0),(831,1,68,155,0),(832,1,68,156,0),(833,1,69,157,0),(834,1,69,158,0),(835,1,69,159,0),(836,1,186,167,0),(837,1,186,168,0),(838,1,188,169,0),(839,1,188,170,0),(840,1,189,171,0),(841,1,189,172,0),(842,1,189,173,0),(843,1,193,174,0),(844,1,193,175,0),(845,1,195,176,0),(846,1,195,177,0),(847,1,197,178,0),(848,1,197,179,0),(849,1,198,180,0),(850,1,198,181,0),(851,1,200,182,0),(852,1,200,183,0),(853,1,202,184,0),(854,1,202,185,0),(855,1,204,186,0),(856,1,204,187,0),(857,1,206,188,0),(858,1,208,189,0),(859,1,210,190,0),(860,1,210,191,0),(861,1,214,192,0),(862,1,214,193,0),(863,1,215,194,0),(864,1,215,195,0),(865,1,218,196,0),(866,1,218,197,0),(867,1,220,201,0),(868,1,220,202,0),(869,1,224,203,0),(870,1,224,204,0),(871,1,228,205,0),(872,1,228,206,0),(873,1,228,207,0),(874,1,228,208,0),(875,1,228,209,0),(876,1,228,210,0),(877,1,235,211,0),(878,1,235,212,0),(879,1,235,213,0),(880,1,235,214,0),(881,1,235,215,0),(882,1,235,216,0),(883,1,235,217,0),(884,1,235,218,0),(885,1,235,219,0),(886,1,237,220,0),(887,1,237,221,0),(888,1,237,222,0),(889,1,237,223,0),(890,1,237,224,0),(891,1,237,225,0),(892,1,237,226,0),(893,1,237,227,0),(894,1,249,228,0),(895,1,249,229,0),(896,1,249,230,0),(897,1,273,231,0),(898,1,274,232,0),(899,1,276,233,0),(900,1,278,234,0),(901,1,280,235,0),(902,1,282,236,0),(903,1,283,237,0),(904,1,285,238,0),(905,2,4,4,0),(906,2,4,5,0),(907,2,4,6,1),(908,2,8,8,0),(909,2,8,9,0),(910,2,8,10,0),(911,2,27,11,0),(912,2,27,12,1),(913,2,27,13,0),(914,2,26,14,1),(915,2,26,15,0),(916,2,26,16,0),(917,2,4,17,0),(918,2,4,18,0),(919,2,4,19,0),(920,2,5,20,0),(921,2,5,21,1),(922,2,5,22,0),(923,2,5,23,0),(924,2,6,24,1),(925,2,6,25,0),(926,2,6,26,0),(927,2,6,27,0),(928,2,6,28,0),(929,2,6,29,0),(930,2,6,30,0),(931,2,6,31,0),(932,2,6,32,0),(933,2,6,33,0),(934,2,6,34,0),(935,2,6,35,0),(936,2,15,36,0),(937,2,15,37,0),(938,2,15,38,0),(939,2,18,39,0),(940,2,18,40,0),(941,2,18,41,0),(942,2,19,42,0),(943,2,19,43,0),(944,2,19,44,0),(945,2,22,45,0),(946,2,22,46,0),(947,2,22,47,1),(948,2,23,48,1),(949,2,23,49,0),(950,2,23,50,0),(951,2,24,51,0),(952,2,24,52,0),(953,2,24,53,1),(954,2,29,54,0),(955,2,29,55,0),(956,2,29,56,1),(957,2,30,57,0),(958,2,30,58,0),(959,2,30,59,0),(960,2,33,60,1),(961,2,33,61,0),(962,2,33,62,0),(963,2,35,63,0),(964,2,35,64,0),(965,2,35,65,1),(966,2,35,66,0),(967,2,35,67,0),(968,2,35,68,0),(969,2,35,69,0),(970,2,37,70,0),(971,2,37,71,1),(972,2,37,72,0),(973,2,37,73,0),(974,2,37,74,0),(975,2,37,75,0),(976,2,38,76,0),(977,2,38,77,0),(978,2,38,78,0),(979,2,40,79,0),(980,2,40,80,0),(981,2,40,81,0),(982,2,43,82,0),(983,2,43,83,0),(984,2,43,84,0),(985,2,43,85,0),(986,2,43,86,0),(987,2,43,87,0),(988,2,45,88,0),(989,2,45,89,0),(990,2,45,90,0),(991,2,47,91,0),(992,2,47,92,0),(993,2,47,93,0),(994,2,48,94,0),(995,2,48,95,0),(996,2,48,96,0),(997,2,49,97,0),(998,2,49,98,0),(999,2,49,99,0),(1000,2,50,100,0),(1001,2,50,101,0),(1002,2,50,102,0),(1003,2,51,103,0),(1004,2,51,104,0),(1005,2,51,105,0),(1006,2,52,106,0),(1007,2,52,107,0),(1008,2,52,108,0),(1009,2,53,109,0),(1010,2,53,110,0),(1011,2,53,111,0),(1012,2,54,112,0),(1013,2,54,113,0),(1014,2,54,114,0),(1015,2,55,115,0),(1016,2,55,116,0),(1017,2,55,117,0),(1018,2,56,118,0),(1019,2,56,119,0),(1020,2,56,120,0),(1021,2,57,121,0),(1022,2,57,122,0),(1023,2,57,123,0),(1024,2,58,124,0),(1025,2,58,125,0),(1026,2,58,126,0),(1027,2,59,127,0),(1028,2,59,128,0),(1029,2,59,129,0),(1030,2,60,130,0),(1031,2,60,131,0),(1032,2,60,132,0),(1033,2,61,133,0),(1034,2,61,134,0),(1035,2,61,135,0),(1036,2,62,136,0),(1037,2,62,137,0),(1038,2,62,138,0),(1039,2,63,139,0),(1040,2,63,140,0),(1041,2,63,141,0),(1042,2,64,142,0),(1043,2,64,143,0),(1044,2,64,144,0),(1045,2,65,145,0),(1046,2,65,146,0),(1047,2,65,147,0),(1048,2,66,148,0),(1049,2,66,149,0),(1050,2,66,150,0),(1051,2,67,151,0),(1052,2,67,152,0),(1053,2,67,153,0),(1054,2,68,154,0),(1055,2,68,155,0),(1056,2,68,156,0),(1057,2,69,157,0),(1058,2,69,158,0),(1059,2,69,159,0),(1060,2,186,167,0),(1061,2,186,168,0),(1062,2,188,169,0),(1063,2,188,170,0),(1064,2,189,171,0),(1065,2,189,172,0),(1066,2,189,173,0),(1067,2,193,174,0),(1068,2,193,175,0),(1069,2,195,176,0),(1070,2,195,177,0),(1071,2,197,178,0),(1072,2,197,179,0),(1073,2,198,180,0),(1074,2,198,181,0),(1075,2,200,182,0),(1076,2,200,183,0),(1077,2,202,184,0),(1078,2,202,185,0),(1079,2,204,186,0),(1080,2,204,187,0),(1081,2,206,188,0),(1082,2,208,189,0),(1083,2,210,190,0),(1084,2,210,191,0),(1085,2,214,192,0),(1086,2,214,193,0),(1087,2,215,194,0),(1088,2,215,195,0),(1089,2,218,196,0),(1090,2,218,197,0),(1091,2,220,201,0),(1092,2,220,202,0),(1093,2,224,203,0),(1094,2,224,204,0),(1095,2,228,205,0),(1096,2,228,206,0),(1097,2,228,207,0),(1098,2,228,208,0),(1099,2,228,209,0),(1100,2,228,210,0),(1101,2,235,211,0),(1102,2,235,212,0),(1103,2,235,213,0),(1104,2,235,214,0),(1105,2,235,215,0),(1106,2,235,216,0),(1107,2,235,217,0),(1108,2,235,218,0),(1109,2,235,219,0),(1110,2,237,220,0),(1111,2,237,221,0),(1112,2,237,222,0),(1113,2,237,223,0),(1114,2,237,224,0),(1115,2,237,225,0),(1116,2,237,226,0),(1117,2,237,227,0),(1118,2,249,228,0),(1119,2,249,229,0),(1120,2,249,230,0),(1121,2,273,231,0),(1122,2,274,232,0),(1123,2,276,233,0),(1124,2,278,234,0),(1125,2,280,235,0),(1126,2,282,236,0),(1127,2,283,237,0),(1128,2,285,238,0);
/*!40000 ALTER TABLE `respostas_alternativa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `retorno`
--

DROP TABLE IF EXISTS `retorno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `retorno` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_endodontia` int DEFAULT NULL,
  `data_retorno` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `retorno`
--

LOCK TABLES `retorno` WRITE;
/*!40000 ALTER TABLE `retorno` DISABLE KEYS */;
INSERT INTO `retorno` VALUES (2,91,'2024-06-25'),(3,70,'2024-06-25'),(4,116,'2024-06-25'),(5,131,'2024-06-25'),(6,133,'2024-06-25'),(8,140,'2024-06-27'),(9,140,'2024-06-28'),(10,140,'2024-06-30'),(11,140,'2024-07-03');
/*!40000 ALTER TABLE `retorno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(245) DEFAULT NULL,
  `descricao` varchar(245) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (4,'cadastrar_prontuario','Cadastrar novos prontu√°rios'),(6,'cadastrar_paciente','Cadastrar pacientes'),(7,'cadastrar_triagem','Cadastrar Ficha de Triagem'),(9,'cadastrar_pronto_atendimento','Cadastrar prontu√°rio de pronto atendimento'),(10,'cadastrar_prontuario_menor','Cadastrar Prontuario para menor de idade');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles_modulo`
--

DROP TABLE IF EXISTS `roles_modulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles_modulo` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_role` int DEFAULT NULL,
  `modulo` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_idx` (`id_role`),
  CONSTRAINT `roles_ffk` FOREIGN KEY (`id_role`) REFERENCES `roles` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles_modulo`
--

LOCK TABLES `roles_modulo` WRITE;
/*!40000 ALTER TABLE `roles_modulo` DISABLE KEYS */;
/*!40000 ALTER TABLE `roles_modulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles_semestre`
--

DROP TABLE IF EXISTS `roles_semestre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles_semestre` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_role` int DEFAULT NULL,
  `periodo` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_idx` (`id_role`),
  CONSTRAINT `roles_fk` FOREIGN KEY (`id_role`) REFERENCES `roles` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles_semestre`
--

LOCK TABLES `roles_semestre` WRITE;
/*!40000 ALTER TABLE `roles_semestre` DISABLE KEYS */;
INSERT INTO `roles_semestre` VALUES (43,4,1),(44,6,1),(45,7,1),(46,9,1),(47,10,1);
/*!40000 ALTER TABLE `roles_semestre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_usuario`
--

DROP TABLE IF EXISTS `tipo_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_usuario` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descricao` enum('administrador','professor','estudante') DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_usuario`
--

LOCK TABLES `tipo_usuario` WRITE;
/*!40000 ALTER TABLE `tipo_usuario` DISABLE KEYS */;
INSERT INTO `tipo_usuario` VALUES (1,'administrador'),(2,'professor'),(3,'estudante');
/*!40000 ALTER TABLE `tipo_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `triagem`
--

DROP TABLE IF EXISTS `triagem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `triagem` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_professor_assinatura` int DEFAULT NULL,
  `id_estudante_assinatura` int DEFAULT NULL,
  `id_paciente` int NOT NULL,
  `encaminhar_periodo` enum('1','2','3','4','5','6','7','8') NOT NULL,
  `especializacao_cirurgia` tinyint NOT NULL,
  `especializacao_protese_implante` tinyint NOT NULL,
  `outras_especializacoes` varchar(400) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `status` enum('0','1','2') NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_paciente` (`id_paciente`),
  KEY `id_professor_vinculado` (`id_professor_assinatura`),
  KEY `estudante_FK_idx` (`id_estudante_assinatura`),
  CONSTRAINT `estudante_FK` FOREIGN KEY (`id_estudante_assinatura`) REFERENCES `estudante` (`id`),
  CONSTRAINT `triagem_ibfk_1` FOREIGN KEY (`id_paciente`) REFERENCES `paciente` (`id`),
  CONSTRAINT `triagem_ibfk_2` FOREIGN KEY (`id_professor_assinatura`) REFERENCES `professor` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `triagem`
--

LOCK TABLES `triagem` WRITE;
/*!40000 ALTER TABLE `triagem` DISABLE KEYS */;
INSERT INTO `triagem` VALUES (2,2,3,4,'1',1,0,'Ortodontia','2024-05-31 16:14:12','0'),(3,2,3,5,'1',1,0,'Ortodontia','2024-05-31 16:14:12','0'),(4,12,4,3,'6',0,1,'teste outros editando','2024-06-02 01:00:27','0'),(5,7,4,6,'4',1,1,'','2024-06-02 20:08:59','1'),(6,5,7,7,'4',1,1,'szrthrtgshdrtgh','2024-06-03 02:14:00','1'),(7,5,7,8,'5',1,1,'','2024-06-05 00:48:10','1'),(9,5,7,19,'4',1,0,'','2024-06-19 23:53:27','2'),(10,NULL,13,21,'3',0,0,'Limpeza Dent√°ria','2024-06-26 00:01:03','0');
/*!40000 ALTER TABLE `triagem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_tipo_usuario` int NOT NULL,
  `identificador_unifenas` varchar(245) NOT NULL,
  `email` varchar(150) NOT NULL,
  `blocked` tinyint DEFAULT '1',
  `login_failed` int DEFAULT '0',
  `password_hash` blob NOT NULL,
  `password_salt` blob NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_tipo_usuario` (`id_tipo_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (2,1,'207875221','joao.narciso@aluno.unifenas.com.br',0,0,_binary '¢Ç`ì~\”;û\ƒ\Ìwá ≠Ó∞üπæ\n\—\Ë5NùºÜX÷å\ÂL\ŒZ—ë\ÎOÿÑ±¸X\Ô|\n\\D\√MEdN\ÿ1\"kß',_binary 'Te\nï¥º\Ôú\ÈÅ˘k\‡ü'),(3,1,'7859474867','joao.fernandes@aluno.unifenas.com.br',0,0,_binary 'L»∞\€\ÔH[¨z\Î2ZÆ/\“HT\"\Ôï4£wQ!ﬁ≥¢%›á˚ﬂæ2WùO6Ú\»N2+:\‰Õù˛ù\'Ú\‹Œπ',_binary '\r6|gÛ\„S/è\œvüU•|'),(4,1,'1234098765T','felipe.araujo@aluno.unifenas.br',0,0,_binary 'ºù\rJ¥ƒÖ∆≠ßaáç\Õ\÷˚˜\≈3ø¢\›N\Ó)\ÁaVMô\Â˛\n\ÿI¶¢B∏:l\‡Ç7\Ó+l\»\€8LgÅLRÇ{',_binary '3ñ\–\Z\ﬂ%Œû[àµ\’:\Ì'),(5,1,'207875222','joao.narciso@aluno.unifenas.com.br.com',0,0,_binary 'Ñùja˛$U\»\ﬁo|BÖ\‰Âª®≤ø±î<¨\ÿ\ÎD\ƒ“âYÉ˚G\€tL\÷˜4\ﬂcx°.¥n\‹<szt¢åa\‹\’bLo\÷\Ó¯',_binary '\Ô[.ÿ∞Z∞Ä˚\≈*\ÓEß'),(6,1,'206491221','joao.pfernandes@aluno.unifenas.br',0,0,_binary ';Cã.nÚ—ñ\·c\‘p\ÿ+Ò9\≈\ﬂ(q*<]∞˙:©Ûü\nˇ∏´Wñw*\Í\ÊVÅjYÆ\›;\ﬂ‘∏B\œ0˚õ',_binary 'ú	£5p©t\–˛ö\ÕfJW'),(7,1,'209846046','joao@unifenas.br',0,0,_binary 'yññD ïf≥\rı_7g5î\Îb@¡˙|#:≤S$ß˘w\Îπ\–;\Á	kB§%z\ﬁ»óuQt≥¶Mø˝\Ër°∂',_binary 'πå@±-O\‚áf∞\Ó!õè\¬'),(8,1,'123123','joaojp@unifenas.br',0,0,_binary '¡\‹\‘ÕåÚ\÷).Loù\0\Àwú\Îåù¡o~\ﬂr\ﬁˇóÚ	\Î\⁄\’/=`åπ=.aos\"IøÕ∑qy\Î≤uv',_binary '\‡ëx\–˘\œ\–ˇW≥Ä·™úº'),(9,3,'821312312','felipe@unifenas.com',0,0,_binary 'C\Ë\¬Gü˝\‚	™]-âXR§{P\’\≈DG\√\ﬁˆO?5Ñó\Ìé;\…\–\Ë\“\‡\€\ÎZ£\Èô\Á®»°NYóã??~ÚÒ\€',_binary 'H\–≈ñ\‹,ä:k@lºóäÅç'),(10,3,'1231312312','joao@unifenas.com',1,0,_binary 'Ö6Sr(ÄO\√h\Ã˜¸x\Ìf»Ö—¢^\√`ç¥º»Ö£V_¢√¨\Î˚,îOº\œ\Õ˜Y\Ÿ%≠Y\Zz§ ì¥Fj\Ì',_binary '\“˝ã2\ŒÒîy˝DØ{låD'),(11,3,'111111111','joao.Ze123@unifenas.com',0,0,_binary 'J∏}\∆¶Ràñw\—^í\È TA\»˙¡\Ê+Aw	K+\Ìo≥Õ™∂\Ôè £9\ÿ\Z4´iÌúú\Ê\nK!ßj|∫Ω',_binary '}Xy7ìˇ√ãÉ\“ummê'),(12,3,'002920201','joaoZe111@unifenas.com',0,0,_binary '\‹.s\◊k∞¶ï<\œg\–Y\"o&\…\Zˆ [ïzˆc\ÂñTQc\–\Ì@}œóøö|°i\’*>49\È\—[äU@\ÈÒQ˙',_binary '\ f/\›\ÿZT√ªE\ÿ\…dç'),(13,3,'5555555','joaoZe555@unifenas.com',0,0,_binary 'ºdª\"$\’bRLOÄº0zu\÷†Ée—∫πZÚ{mŸøâπXB:Wú£∫∫ôø(zöΩÈ•Çãcu¢>NΩéf`†\Ëî',_binary '_õnøg™4c-ï˝éˆEg-'),(15,2,'33333','joaoZe222@unifenas.com',0,0,_binary '´BπÜ-Iã	;Ú`\‚Y\ﬁJY§ÛÙŒç\Ô\—œ©,öu35&\—\÷<§\ÿ\›\∆ ¨Q˝Y\Ï)V·ø∫ü^	<\„2¥%ö\∆',_binary '-\Í	\—1n\Ì\ŸOB|PÃ¢'),(16,3,'207875212','joao@aluno.unifenas.br',1,0,_binary 'ù,ˇ\‹Ú∫i,ALp.)µ£4\Z\Ó-qàÛO\‡õ@ø÷á¯	+\Ÿa\·\€\'$\◊\¬\“\\Äí˚π\‰ò¸\…Y\„q\"¯y',_binary 'u>Igj\„AXP—îí36'),(17,3,'666666','joaoZe999@unifenas.com',0,0,_binary '%zb+¶c\‹\'IΩ\Î\’\€˘∑\≈\œ\ÓâΩ\0+\ra\«\ﬁ\ÿ$nfJ\'\rp8ô%\‰˛Å\œà<≤\∆}\ﬂn\ZDã∑∑Vñ',_binary 'Æ†˜\Àa≈º\¬ZL\Ê—¥\’H'),(18,3,'6666s66','joaoZe909@unifenas.com',0,0,_binary '\‡5/p\Ìås˙É_\Á≤cZ\ÿe\ŒjSÜ2}cqt\Ôò\"]\Ô\'≥ˇ_(|\ÎôJ\·âS1\’\œÚ\√\Ã®≤t&nzº9ı',_binary '∫”ñ¡[¡6f\ÔC~\\\nó9i'),(19,3,'6666312366','joaoZe9009@unifenas.com',0,0,_binary 'k©4≤\Õ¸µ†%e†ä∫Ä\·ÆF@Ä\·§®uÉ\"˝I£Lh	\ÿ’àw[æo1\”rzz}˚q\‹¿{\—\‡\”_†r',_binary 'K +cp8Hnp\ «ç¿'),(20,3,'0000087','joaoZe209@unifenas.com',0,0,_binary '¨}\Ã\”@Q;äGg\’\’\‰f’Ü¡´\”fß;5±ã®yl5π•áñ®è˜µ<ô%ûÒ\ﬂMú°´yV$ÚIµfU\Ì\Î',_binary '\ËKstzè\È\Àrg ü–åå'),(21,3,'83838383832','joao000000@unifenas.com',0,0,_binary '\nëÄùX™Ωjmç\Ÿaò\”¸8í∫\“\ÈÙÒ† f~YΩ.R¨ê˝\€WkÑ˛æFπ[\€\‹Ú8hu4.EOSY6\Ê5Mz',_binary 'ø\ \…9ı+Ø˛ö\0qå\—'),(22,1,'23123141','joao.adm@unifenas.br',0,0,_binary 'P1\À&µÙˆî*Ω]_ \›\È\·{ˆÖZ\0Q°˙†l˛¨+\rmu/\Áu\·%©Ere\≈ˇ™z\‚öSS@Å˙\nÅA',_binary '˜9\–u •˙\ÔxáTö'),(23,3,'124345345','joao.aluno@unifenas.br',0,0,_binary ';U≥ôÇí\ÏÖxé¿lﬂ£iY˚IGë~\Â\ŸE?\Ì®ÆPM[√ª|Q\‹|\ )h<Aæ^\‰\€O\œ!z#kAõñØ',_binary '≥?\\O°y9˘qIcå^P\Ô'),(24,2,'53464563465','joao.professor@unifenas.br',0,0,_binary 'Ù4\∆I\Œz\¬\–ŒçØ(Ié{C≤\‹\Â:zg\ `•u⁄ûôÛˇ˘Ç•\‡B°k\‹\‰l™™\Â~9Ø¢≤ãk\'@8åΩ¥›µ\◊',_binary '\Êb¶t\Ÿ\ËåïHä˙5'),(25,2,'2078754221','joao@prof.unifenas.br',0,0,_binary '~/ˇÅ§òï\Èd\Z¡\·ÒqV\‹±\n¿¯\‰é*\÷E.<\À,-±\Õ[Và0–∑aSúl5[FP\ŸóHL\Ã*&uDuô',_binary 'ƒç£\"]π5N∞Ö◊¶!Øâ'),(26,2,'20787554221','joao@profe.unifenas.br',0,0,_binary '\Ì\ﬁR4pwâ>ˆ\ƒ\‰J7¿É7z9}ê•H≈ø\÷^>NÇ\Z€ºO\ﬂŒè˙˘m\Z9Ù\’\Œi \À0¢9aÅ\ZíO¢Ú',_binary '`cµmbPtnq6≠i'),(27,2,'2078754554221','joao@profes.unifenas.br',0,0,_binary '!¡i¨\“\«zs7DZ+\€+N•@\—c\›g≤ë%á•\Ë@èåE0[Yúj}\…A∫*ØÅ5\—´8\⁄ÒFCï≤Ü\À;´˜',_binary 'G?\œ\‰aáVî-D\‹\“6'),(28,3,'124718248124','teste@unifenas.br',0,0,_binary '6\Êº\‹\—W…≥\ÍH8Húg\\\Ïfb˘]\ﬁ-(\Ë[À∂˙J˝\÷\»˛ìª\–[Á•ømAw™\‰Øp$ôxôÆ5®Z\À',_binary 'ba¢\À7PI/k<Xê˘Òó'),(29,1,'205399221','livia.morais@aluno.unifenas.br',0,5,_binary '≠¯AV˜[>*0.rrqrºµ£1;É\0ã\÷¿zı\Ëâ\ÏΩ1$¿W\ÿ\Ê¢P2°ƒÉL§\Ô®\ËölVg\ \Î˙=gEpÑ˜',_binary 'ˆ∫ ¯¸#õ\ÿ\Œå¢Òı\‘1'),(30,1,'9982739472','celso.user@unifenas.br',0,0,_binary 'Ÿñ™tBˆcwˇª\√—™Ç\ÀÖH&@\ŸF\Óm5	∏ñ\Î[\—\ZØŸæ\’¯≥Õ≤πVºb\”và\'°LR\ƒ¯œ£È¥πF',_binary 'r\›:£7qÑ\ Õ©⁄Éﬁù\Ÿ'),(31,3,'5530318','mariaunifenas@gmail.com',0,0,_binary 'xΩT\Íé‹∏/—æ\ƒpdß◊¢›ã≠jKó.fâ\È_°\¬A$©∂Çˆ\ƒ\ÊQ\ËPãl∑~F%g™!ârÙXç∂¿\–C\Œs\Â',_binary 'ä≠Än\Õ\Ì8•π\Œ18º'),(32,1,'201571211','rafael.silveira@aluno.unifenas.br',0,0,_binary 'Øz\Ï\Ëi\ﬁ6\’jD≥t\◊	B\€\ \'jPw\◊-[&ßDXâHD\n¶Ç\∆Ùk˜\Ï°P≤o:\‡Jk˛\0\Ÿ\›tO}UM',_binary '\ﬁ\»\‰ÛDå?N\Á∏J~°êW'),(33,3,'123468597','j@unifenas.br',0,0,_binary '\‰=Cy\◊;\“\ÁH®_˙!V¡zQÚ\ﬂ>•o˙û\ D\‰Äo\Ë\„#\ÏsÚ\ÓÉt4ÛI\\≠HT\Î<\Ïí2ñ\Ë£±',_binary '†.íZí∂k¶âÄ\0Bï@\r'),(34,2,'324765','jp@unifenas.br',0,0,_binary '\‘2LúW/\Ÿ~B6\÷&Éä.\‹js.Nﬂ§™Ç{˘y;\0cF\Ô•)5^iÄôAΩXyg.\Ó-ïe÷≥¯\„',_binary 'gÉÑ\ÈÒ\ sπ?ú`-Æ'),(35,1,'123465241','joao@unifenas.com.br',0,0,_binary 'w\Á¥s±5qk∞ö\0\Ê˚\Ô	_∑àèªEcW7.¸YS\Õ™üÛf±3î9\ŸDK±\·`O\≈u\€˙s\÷Õ∫≤}.X∑',_binary '!±\ÿ\0¶}I\’=ÀÑÜB¡P'),(36,1,'1234652344','joao.narciso@aluno.unifenas.br',0,0,_binary '\‚†1XWŒ†NÃ∂FGÑ\·æw\∆Z]ˆî\…7î\‘1hl~ä≤\Œ8Fîá\ÓN>oè-Wù\›J~\Â\›˘ö|ÄΩ∞é',_binary 'L©h%\›\Ó)\Á\"w9π\¬:'),(37,3,'123897345','felipeiyuvas@unifenas.com',0,0,_binary 'ç\¬˚RΩ\’\"4ã˙âZÚ8ıCzT\”O\›\’©kÈºç£êıPPËïΩ\‹7iBu¿\ÏïÁ•ÇvMp\0Ò4',_binary 'ÕÇynº>)çàqSµÎ∫ô'),(38,2,'92834293742','jose.teste@unifenas.br',0,0,_binary 'g®\Á\ÃG¥vèÃú\" Ω¡K\Ÿn<lX{∏nSwfuXdÜ5è?F$tôØ\€Pex{÷Ä+D6£:yìû“òX',_binary '˛6_âùÒ†[\Ìß\Ô®\ÕV\Ì'),(39,2,'3232','flavia.santos@unifenas.br',0,1,_binary 'M\Ë_Pπe<\÷Ωó\√gM˙,∞\»ÙeP©i\Ó¿I§˘]z\"TΩˇz@\—eñ\‡y\«\Ë\Ê\ƒ=\r,\Zß:æ\Ã\≈#:',_binary '\√\Ôb5XÇH˘\√~(MA1'),(40,2,'702801','fabio.carvalho@unifenas.br',0,0,_binary 'ñ \ZÖ\À\≈\–\ÈÙ\‡Ñü\€~|\‰\ﬁ=π˚¸SRåÛÆ\Ì\”\ﬂ@1©+p∑\·ı	≈≥ü\‡ç’¨å\Ëc\ƒ¶ÖÇ\“§`L(',_binary 'ÑHL\Â\ÂÄ9?ˇQ^˚\ﬂNY'),(41,3,'123123123','ana.clara@aluno.unifenas.br',0,0,_binary 'd{~\n\”\—\‚eñ:ò\„\Œ\⁄\ƒ;F;GÜp\Èû\ÀKêú1É]!¿1˝\Ë+£\ZõÃãô´\rrèeIijæù,=\‡D*≤',_binary '?-ˇ\ÿ”ΩÛ9R4ãø\"|'),(42,3,'205526222','larissa.milani@aluno.unifenas.br',0,0,_binary '\Ÿ\“\Ï≈çt#\ƒføn;¶ëä˜kÙ\Îç\Ÿ˜≈Ø§/z94°˝\…\'üıöy\”;s˝ ¶ÛQsèµN\ƒ9¢”£„≠ìæ',_binary '*)6(¥hôÆP˛ë8lñ\⁄'),(43,3,'206002222','Roberto.barnabe@aluno.unifenas.br',0,0,_binary 'ˇ\Ëˆeyjé\‰fGí2Ù\0π{\n\Ïu≤\ﬁP©¨\ÔøN\»\ÍÅ3∂âu\Ëj∏\0\ƒVv\Âô<≤[ˇÛí)$\ÿP	+(',_binary 'ù*«ΩÙ\0º\Ÿ\⁄‚©≤ˆü'),(44,3,'201913201','debora.damasceno@aluno.unifenas.br',0,0,_binary 'i_7b?´5\Í}$o8<zZ/ß\‚\'9òñª\‡’äTaı\ÿ©\‹r≤Áï≤64=˙àd\"˙+ƒÇ\»\∆P\œA•è',_binary '3Sî∞8\Ã˙ÅWR∏'),(45,3,'206073222','clara.batista@aluno.unifenas.br',0,0,_binary 'Ãó∞\◊bJ(\∆@Ò+vª!|U%‹•$\Â5\–cá¿¯ﬂ†\Ô\¬\ÂÒö8\“\n	øÚ\‹d\√y[d§@™˝^\¬',_binary '\÷&ú9KÄ\≈yæ*T≠î\«\‹'),(46,2,'206491223','joao.pedro.fernandes@aluno.unifenas.br',0,0,_binary '∑5dß8”™g\Ô_e\»Q	@†ÑV∑¶Ö%ÑPë6qµëhôm1ÑGq˜Ah\Ê%p\÷\ÀWMå\Ïì 6∆≥Tb4®',_binary 'ÒÏååªU[\Ó•G~.æ'),(47,3,'917398273','zeze.capimba@aluno.unifenas.br',1,0,_binary ',\Ëõ\\\ÿ\€˜Pæ\›*\⁄{-ø2óø)\√ü¯/]¥\Í9\ÁVE?\¬&£˚\‘!ù˜})liˇÃ®˙my±\'bø\◊\“',_binary '@M\ÀJ2)E\ÊJ\Êå6 w≥\Í'),(48,3,'324353246525','joao.narciso@aluno.unifenas.br.cop.gin',1,0,_binary '{ä\ hB\Ô(ˇ\„ü◊´èŒäΩÑ\\á\ﬁw˙ï+ZàíZ¸THÙé?Oµ\Z™ı\ `ÅbM_†ÿøy#e\ﬂÒìÅØ\ÃU',_binary '\0\Ïhˆëd\À\Ó\’cY\√9e&)'),(49,3,'1258756453','zeze.caximba@aluno.unifenas.br',1,0,_binary '˘Ci\Âí\’\0\œE2¢\ƒ\◊\ i˝á5ø¥•Ëùè4eä…úóõ\'I\ \‚Àí\÷û<\'˝≠x5t\◊<&}E\‡\‡û}≥4PAjeå',_binary 'ÕÉuˇ\«_l\œ“π\€uW'),(50,1,'207207207','livia.aluna@aluno.unifenas.br',0,0,_binary ':9Eˇ4à˙]¥zlKÚí\€^ˆh\Ë±≈ûªó˜R{bp	Ag\‹vfáYïÄ\ÈdÅâ©®\·\‘fSôâ=Oè¢',_binary 'Wh©Z5X¥)üKfyw3'),(51,3,'434235','joao.narciso@aluno.unifenas.br.gro.drgh',1,0,_binary '$Öµè£Ñ\Ã*	cä\Ô\√oqÕíaì8ÄZ(M{a%BÀãèNÀ∂A:a\“\‡q\"\"õ’≤˙$è\Ë£˘\÷É∂§0Ãù¨',_binary '«æ;.6&b∂?qólo\ÈEˆ'),(52,1,'209890876','joao.pedro.fernandes.reis@aluno.unifenas.br',0,0,_binary 'U\◊(ﬂ∞\ﬂ\„\"\„&1>i|+%¿º7q≤f˘˛≥á\Ó\œ|û∆ÄL+_í3\ÿ˜\≈j%}ß °ú\‡Gá¥\∆\Ó—æ_',_binary 'çïdyÕª&G¡;®\Œπ'),(53,3,'1788553453','felipe.araujo1@aluno.unifenas.br',0,0,_binary '\‡fWW%∑`Ù<\œƒ•l\–ú[Le\œo\r§û∆ß6•éu˝\∆-@Ü\Ê∑uöäf©+15Ñ\‡º}õ\ÁP\Œb∫≤tVnW',_binary 'QG	¸∏≠)n\\û\›¸,\⁄'),(54,3,'123112112','aaaaa@aluno.unifenas.br',0,0,_binary '\—@d˚\—$\Ó≥\"ì¿ìeQˆn\«ƒ±ìh$$\Îøg˙X¿XmÒm~\Â\≈:yqè04Ù\Â¨√πà˝-˚õì\»\‹9˜',_binary '\‰\'Ñvö|öK\Õ¿Lπ¶):'),(55,3,'202010312','caio.junior@aluno.unifenas.br',0,0,_binary '\ﬁg\À\n ®˚˛ô∏¨Iêrû\Ÿh3nNh\\î|Ú}=\Ï\’X\‹Q∂x¨}\—Xùm√Ä\œ=Ijö0ò\∆	[MwOl2',_binary '\Óó\·\rk\…S!Kêz\„˜%');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-26 11:56:40
