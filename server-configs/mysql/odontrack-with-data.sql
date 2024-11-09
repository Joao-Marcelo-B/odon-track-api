CREATE DATABASE  IF NOT EXISTS `odon_track` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `odon_track`;
-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: odon_track
-- ------------------------------------------------------
-- Server version	8.0.36

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alternativas`
--

LOCK TABLES `alternativas` WRITE;
/*!40000 ALTER TABLE `alternativas` DISABLE KEYS */;
INSERT INTO `alternativas` VALUES (1,3,'Tranquilo'),(2,3,'Agitado'),(3,3,'Dorme Muito'),(4,4,'Sim'),(5,4,'Nega'),(6,4,'Não sei');
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
INSERT INTO `codigo_seguranca` VALUES (1,'joao.pfernandes@aluno.unifenas.br',918574,'2024-05-31 21:02:54',0),(2,'joao.pfernandes@aluno.unifenas.br',138334,'2024-05-31 21:03:25',0),(3,'felipe.araujo@aluno.unifenas.br',536525,'2024-05-31 21:04:01',0),(4,'joao.pfernandes@aluno.unifenas.br',389953,'2024-05-31 21:12:15',0),(5,'joao.pfernandes@aluno.unifenas.br',340920,'2024-05-31 21:13:53',0),(6,'joao.pfernandes@aluno.unifenas.br',990368,'2024-05-31 21:17:34',0),(7,'joao.pfernandes@aluno.unifenas.br',601649,'2024-05-31 21:18:05',0),(8,'joao.pfernandes@aluno.unifenas.br',853040,'2024-05-31 21:19:44',0),(9,'joao.pfernandes@aluno.unifenas.br',648896,'2024-05-31 21:20:20',0),(10,'joao.pfernandes@aluno.unifenas.br',265379,'2024-05-31 21:25:16',0),(11,'joao.pfernandes@aluno.unifenas.br',232496,'2024-05-31 21:25:58',0),(12,'joao.pfernandes@aluno.unifenas.br',916766,'2024-05-31 21:49:48',0),(13,'joao.pfernandes@aluno.unifenas.br',772967,'2024-05-31 21:50:26',0),(14,'joao.pfernandes@aluno.unifenas.br',858764,'2024-05-31 21:53:30',0),(15,'joao.pfernandes@aluno.unifenas.br',541353,'2024-05-31 21:56:22',0),(16,'joao.pfernandes@aluno.unifenas.br',435841,'2024-05-31 21:57:11',0),(17,'joao.pfernandes@aluno.unifenas.br',932444,'2024-05-31 22:09:54',0),(18,'joao.pfernandes@aluno.unifenas.br',993817,'2024-05-31 22:38:39',0),(19,'joao.pfernandes@aluno.unifenas.br',547632,'2024-05-31 22:42:10',0),(20,'joao.pfernandes@aluno.unifenas.br',849727,'2024-05-31 22:44:35',0),(21,'joao.pfernandes@aluno.unifenas.br',315496,'2024-05-31 22:50:02',0),(22,'joao.pfernandes@aluno.unifenas.br',654358,'2024-06-01 00:01:24',0),(23,'joao.pfernandes@aluno.unifenas.br',922363,'2024-06-01 14:52:29',0),(24,'joao.pfernandes@aluno.unifenas.br',151153,'2024-06-01 15:14:47',0),(25,'joao.pfernandes@aluno.unifenas.br',281116,'2024-06-01 15:18:51',0),(26,'joao.pfernandes@aluno.unifenas.br',675712,'2024-06-01 15:20:29',0),(27,'joao.pfernandes@aluno.unifenas.br',798327,'2024-06-01 15:29:11',0),(28,'joao.narciso@aluno.unifenas.br',894729,'2024-06-01 16:01:40',0),(29,'joao.narciso@aluno.unifenas.br',403219,'2024-06-02 02:04:04',0),(30,'felipe.araujo@aluno.unifenas.br',408023,'2024-06-02 02:07:50',0),(31,'joao.narciso@aluno.unifenas.br',399908,'2024-06-02 02:08:01',0),(32,'joao.narciso@aluno.unifenas.br',612147,'2024-06-02 02:09:08',0),(33,'joao.narciso@aluno.unifenas.br',733593,'2024-06-02 02:10:27',0),(34,'joao.pfernandes@aluno.unifenas.br',262152,'2024-06-02 13:28:05',0),(35,'joao.pfernandes@aluno.unifenas.br',466036,'2024-06-02 20:02:58',0),(36,'joao.pfernandes@aluno.unifenas.br',793045,'2024-06-02 20:17:29',0),(37,'joao.pfernandes@aluno.unifenas.br',555346,'2024-06-02 20:20:00',0),(38,'joao.pfernandes@aluno.unifenas.br',872387,'2024-06-02 20:22:02',0),(39,'joao.pfernandes@aluno.unifenas.br',821097,'2024-06-02 20:28:45',0),(40,'joao.pfernandes@aluno.unifenas.br',547003,'2024-06-02 20:30:37',0),(41,'joao.pfernandes@aluno.unifenas.br',621549,'2024-06-02 23:35:03',0),(42,'joao.pfernandes@aluno.unifenas.br',170732,'2024-06-02 20:35:48',0),(43,'joao.pfernandes@aluno.unifenas.br',630700,'2024-06-02 20:37:51',0),(44,'joao.pfernandes@aluno.unifenas.br',770819,'2024-06-02 20:45:53',0),(45,'joao.pfernandes@aluno.unifenas.br',736135,'2024-06-02 20:51:02',0),(46,'joao.pfernandes@aluno.unifenas.br',923621,'2024-06-02 20:53:25',0),(47,'joao.pfernandes@aluno.unifenas.br',233948,'2024-06-02 20:57:13',0),(48,'joao.pfernandes@aluno.unifenas.br',289341,'2024-06-02 21:14:07',0),(49,'joao.pfernandes@aluno.unifenas.br',556751,'2024-06-02 21:15:13',0),(50,'joao.pfernandes@aluno.unifenas.br',796661,'2024-06-02 21:23:28',1),(51,'joao.pfernandes@aluno.unifenas.br',708832,'2024-06-03 01:00:41',1),(52,'joao.narciso@aluno.unifenas.br',291608,'2024-06-03 01:02:30',1),(53,'joao.pfernandes@aluno.unifenas.br',746406,'2024-06-03 11:31:27',1),(54,'joao.pfernandes@aluno.unifenas.br',756081,'2024-06-03 12:48:02',0),(55,'felipe.araujo@aluno.unifenas.br',471580,'2024-06-03 22:46:33',1),(56,'joao.pfernandes@aluno.unifenas.br',923728,'2024-06-04 23:43:42',1),(57,'joao.pfernandes@aluno.unifenas.br',312635,'2024-06-06 15:06:35',1),(58,'joao.narciso@aluno.unifenas.br',664318,'2024-06-08 17:29:42',1),(59,'joao.narciso@aluno.unifenas.br',261445,'2024-06-10 20:14:24',1),(60,'joao.pfernandes@aluno.unifenas.br',622075,'2024-06-14 23:07:08',1),(61,'joao.pfernandes@aluno.unifenas.br',845195,'2024-06-20 19:10:31',1),(62,'joao.pfernandes@aluno.unifenas.br',249720,'2024-06-24 02:11:02',0),(63,'joao.pfernandes@aluno.unifenas.br',348682,'2024-06-24 02:15:36',0);
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
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conduta_pronto_atendimento`
--

LOCK TABLES `conduta_pronto_atendimento` WRITE;
/*!40000 ALTER TABLE `conduta_pronto_atendimento` DISABLE KEYS */;
INSERT INTO `conduta_pronto_atendimento` VALUES (1,8,'123123','teste'),(2,8,'123','teste'),(3,9,'123123','teste'),(4,9,'123','teste'),(5,10,'123123','teste'),(6,10,'123','teste'),(7,11,'123123','teste'),(8,11,'123','teste'),(9,12,'123123','teste'),(10,12,'123','teste'),(11,13,'123123','teste'),(12,13,'123','teste'),(13,14,'123123','teste'),(14,14,'123','teste'),(15,15,'123123','teste'),(16,15,'123','teste'),(17,16,'123123','teste'),(18,16,'123','teste'),(19,17,'123123','teste'),(20,17,'123','teste'),(21,18,'123123','teste'),(22,18,'123','teste'),(23,19,'123123','teste'),(24,19,'123','teste'),(25,20,'123123','teste'),(26,20,'123','teste'),(27,21,'123123','teste'),(28,21,'123','teste'),(29,22,'123123','teste'),(30,22,'123','teste'),(31,23,'123123','teste'),(32,23,'123','teste'),(33,24,'123123','teste'),(34,24,'123','teste'),(35,25,'123123','teste'),(36,25,'123','teste'),(37,26,'123123','teste'),(38,26,'123','teste'),(39,27,'123123','teste'),(40,27,'123','teste'),(41,28,'123123','teste'),(42,28,'123','teste'),(43,29,'123123','teste'),(44,29,'123','teste');
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
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consulta`
--

LOCK TABLES `consulta` WRITE;
/*!40000 ALTER TABLE `consulta` DISABLE KEYS */;
INSERT INTO `consulta` VALUES (1,18,'2024-06-17 09:30:00','Teste 1','2024-06-16 17:35:53','NADA CONSTA',1),(2,16,'2024-06-27 07:00:00','teste asda','2024-06-16 22:46:52','NADA CONSTA',0),(3,17,'2024-06-27 10:30:00','tasvxiaosc','2024-06-17 01:57:50','NADA CONSTA',0),(4,19,'2024-06-28 15:45:00','Carie','2024-06-17 02:11:28','NADA CONSTA',0),(5,18,'2024-07-31 17:10:00','retorno para limpeza','2024-06-17 02:18:12','REALIZADA',1),(6,19,'2024-07-30 10:20:00','Retorno 12','2024-06-17 02:31:56','REMARCADA',1),(7,19,'2024-06-18 19:44:00','Retorno','2024-06-17 22:44:25','REALIZADA',1),(8,19,'2024-06-24 15:30:00','Carie asdasdASd','2024-06-22 15:36:57','NADA CONSTA',1),(9,19,'2024-06-22 16:00:00','ASDASDA','2024-06-22 15:43:21','REMARCADA',1),(10,17,'2024-06-22 17:50:00','Motivo 2','2024-06-22 15:50:08','REALIZADA',1),(11,19,'2024-06-22 15:52:00','Consulta Normal','2024-06-22 15:50:51','PACIENTE FALTOU',1),(12,19,'2024-06-23 15:53:00','dfgafgdfgsdf','2024-06-22 15:52:20','REALIZADA',1),(13,19,'2024-06-22 20:06:00','qweqwe','2024-06-22 16:02:16','REALIZADA',1),(14,19,'2024-06-24 22:58:00','123123','2024-06-23 22:57:50','REALIZADA',1),(15,20,'2024-06-27 21:41:00','dor no dente','2024-06-25 21:38:27','REMARCADA',1);
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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endereco`
--

LOCK TABLES `endereco` WRITE;
/*!40000 ALTER TABLE `endereco` DISABLE KEYS */;
INSERT INTO `endereco` VALUES (1,4,'123','Rua das Flores','Jardim das Rosas','São Paulo','SP','01234-567'),(2,5,'123','Rua das Flores','Jardim das Rosas','São Paulo','SP','01234-567'),(3,3,'123','Rua das Flores','Jardim das Rosas','São Paulo','SP','01234-567'),(5,6,'123','Rua das Flores','Jardim das Rosas','São Paulo','SP','01234-567'),(6,7,'GWER','EARGW','AWEF','WARGET','MG','ARGE'),(7,8,'116','Rua João Machado Rocha','Santa Luíza','Campo do Meio','MG','37165000'),(9,16,'305A','São Benedito','centro','Campos gerais','MG','37160000'),(10,18,'1372','Casa','São Benedito','Campos Gerais','MG','37160000'),(11,19,'1234','teste','teste','Areado','MG','37160000');
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endereco_responsavel`
--

LOCK TABLES `endereco_responsavel` WRITE;
/*!40000 ALTER TABLE `endereco_responsavel` DISABLE KEYS */;
INSERT INTO `endereco_responsavel` VALUES (7,19,'123123','3123','123','MG','13212-31','123',19);
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
) ENGINE=InnoDB AUTO_INCREMENT=141 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endodontia`
--

LOCK TABLES `endodontia` WRITE;
/*!40000 ALTER TABLE `endodontia` DISABLE KEYS */;
INSERT INTO `endodontia` VALUES (112,9,'teste 38',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(113,9,'teste 2',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2024-06-24',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(114,9,'teste 3',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2024-06-24',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(115,9,'teste 45',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2024-06-24',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(140,12,'fef',12,0,1,0,0,0,1,0,0,1,0,1,0,0,1,0,NULL,NULL,0,0,1,0,1,0,'1','1',1,NULL,'1',NULL,'2024-06-27',NULL,'1','1','1','1','1','1','1','1','1');
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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estudante`
--

LOCK TABLES `estudante` WRITE;
/*!40000 ALTER TABLE `estudante` DISABLE KEYS */;
INSERT INTO `estudante` VALUES (1,16,'João Marcelo Batista Narciso',2,NULL,1),(2,23,'Joao Aluno',3,NULL,0),(3,28,'Teste Aprimorado',7,NULL,0),(4,31,'Kariny ',6,NULL,1),(5,33,'juaijgrke',1,NULL,1),(6,37,'felipe estudante',0,NULL,1),(7,41,'Ana Clara',1,NULL,1),(8,42,'Larissa Milani Mezavila',0,NULL,1),(9,43,'Roberto augusto',0,NULL,1),(10,44,'Débora Eliza Braga Damasceno ',0,NULL,1),(11,45,'Clara Gabriella Batista',0,NULL,1),(12,53,'zezz',1,NULL,1),(13,54,'Rafael estudante',1,NULL,1);
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupo`
--

LOCK TABLES `grupo` WRITE;
/*!40000 ALTER TABLE `grupo` DISABLE KEYS */;
INSERT INTO `grupo` VALUES (1,'geral'),(2,'perfil_psicologico');
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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horario_disponivel_atendimento`
--

LOCK TABLES `horario_disponivel_atendimento` WRITE;
/*!40000 ALTER TABLE `horario_disponivel_atendimento` DISABLE KEYS */;
INSERT INTO `horario_disponivel_atendimento` VALUES (1,3,1,1,1,0),(2,4,0,1,1,1),(3,5,1,0,1,1),(4,6,1,1,1,1),(5,2,1,1,1,1),(6,7,1,1,1,1),(7,9,0,0,1,0);
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
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `imagens_prontuario`
--

LOCK TABLES `imagens_prontuario` WRITE;
/*!40000 ALTER TABLE `imagens_prontuario` DISABLE KEYS */;
INSERT INTO `imagens_prontuario` VALUES (8,8,'outros','/app/imagens-prontuario/8_outros_2024-06-24-05-34-28.jpeg','image/jpeg','8_outros_2024-06-24-05-34-28.jpeg'),(9,9,'mapa_periodontal','/app/imagens-prontuario/9_mapa_periodontal_2024-06-24-20-39-12.png','image/png','9_mapa_periodontal_2024-06-24-20-39-12.png'),(10,9,'mapa_periodontal','/app/imagens-prontuario/9_mapa_periodontal_2024-06-24-20-41-52.jpeg','image/jpeg','9_mapa_periodontal_2024-06-24-20-41-52.jpeg'),(11,8,'outros','/app/imagens-prontuario/8_outros_2024-06-24-22-07-45.jpeg','image/jpeg','8_outros_2024-06-24-22-07-45.jpeg'),(14,9,'outros','/app/imagens-prontuario/9_outros_2024-06-24-22-35-31.jpeg','image/jpeg','9_outros_2024-06-24-22-35-31.jpeg'),(15,9,'outros','/app/imagens-prontuario/9_outros_2024-06-24-22-37-35.jpeg','image/jpeg','9_outros_2024-06-24-22-37-35.jpeg'),(18,9,'mapa_periodontal','/app/imagens-prontuario/9_mapa_periodontal_2024-06-24-22-45-46.png','image/png','9_mapa_periodontal_2024-06-24-22-45-46.png'),(19,9,'mapa_periodontal','/app/imagens-prontuario/9_mapa_periodontal_2024-06-24-22-45-52.jpeg','image/jpeg','9_mapa_periodontal_2024-06-24-22-45-52.jpeg'),(22,9,'controle_placa_bacteriana','/app/imagens-prontuario/9_controle_placa_bacteriana_2024-06-25-00-59-42.jpeg','image/jpeg','9_controle_placa_bacteriana_2024-06-25-00-59-42.jpeg'),(23,8,'mapa_periodontal','/app/imagens-prontuario/8_mapa_periodontal_2024-06-25-04-03-45.jpeg','image/jpeg','8_mapa_periodontal_2024-06-25-04-03-45.jpeg'),(24,12,'mapa_periodontal','/app/imagens-prontuario/12_mapa_periodontal_2024-06-25-14-50-06.jpeg','image/jpeg','12_mapa_periodontal_2024-06-25-14-50-06.jpeg'),(25,12,'outros','/app/imagens-prontuario/12_outros_2024-06-25-14-49-56.jpeg','image/jpeg','12_outros_2024-06-25-14-49-56.jpeg'),(26,12,'controle_placa_bacteriana','/app/imagens-prontuario/12_controle_placa_bacteriana_2024-06-25-14-50-06.jpeg','image/jpeg','12_controle_placa_bacteriana_2024-06-25-14-50-06.jpeg'),(27,12,'mapa_periodontal','/app/imagens-prontuario/12_mapa_periodontal_2024-06-25-19-52-33.jpeg','image/jpeg','12_mapa_periodontal_2024-06-25-19-52-33.jpeg'),(28,12,'controle_placa_bacteriana','/app/imagens-prontuario/12_controle_placa_bacteriana_2024-06-25-19-54-00.jpeg','image/jpeg','12_controle_placa_bacteriana_2024-06-25-19-54-00.jpeg'),(29,12,'outros','/app/imagens-prontuario/12_outros_2024-06-25-19-54-06.jpeg','image/jpeg','12_outros_2024-06-25-19-54-06.jpeg');
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
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `necessidade_tratamento`
--

LOCK TABLES `necessidade_tratamento` WRITE;
/*!40000 ALTER TABLE `necessidade_tratamento` DISABLE KEYS */;
INSERT INTO `necessidade_tratamento` VALUES (2,3,'periodontia','Tratamento de gengivite'),(3,3,'cirurgia','Extração de dente'),(12,4,'cirurgia','teste tes'),(13,4,'endodontia','teste edição '),(14,4,'protese','teste edição '),(15,4,'periodontia','teste edição'),(17,5,'cirurgia','remoção do dente siso '),(18,5,'protese','protese dente canino'),(24,2,'periodontia','teste'),(30,9,'periodontia','teste'),(33,7,'cirurgia','Cirurgia de Próstata'),(39,6,'periodontia','gyhrsertgergs'),(40,6,'cirurgia','sertrthessrth');
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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES (3,3000,27,'Felipe','2024-05-31 16:14:12','São Paulo','SP','Engenheiro','12345678900','123456789','José da Silva','Maria da Silva','(11) 98765-4321','132','12','1980-05-15',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(4,2000,27,'Renato','2024-05-31 16:15:06','São Paulo','SP','Engenheiro','13543533245','123456789','José da Silva','Maria da Silva','1198765-4321','12','123','1980-05-15',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(5,3000,27,'João Marcelo','2024-05-31 16:15:51','São Paulo','SP','Engenheiro','12312342341','123456789','José da Silva','Maria da Silva','1198765-4321','1234567890','0987654321','1980-05-15',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(6,3000,27,'João Pedro','2024-05-31 16:16:45','São Paulo','SP','Engenheiro','12432242341','123456789','José da Silva','Maria da Silva','1198765-4321','1234567890','0987654321','1980-05-15',1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(7,3000,36,'sdfhg','2024-06-03 02:05:19','efarsgth','MG','awfergs','12345678910','eafwrgs','ewafrg','QWEDF','RGSEDT','AREGTR','AWEGR','2003-05-07',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(8,3000,6,'João Pedro Fernandes Reis','2024-06-05 00:44:26','Alfenas','MG','Cientista da Computação','16750213685','MG11123123','Eduardo Megda Reis','Camila Aparecida Fernandes Reis','35984164532','123098345','423094842','2002-07-28',0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(9,1000,4,'Renato Araujo','2024-06-15 00:58:16','Nepomuceno','mg','Estudante','92812912911','192556421','Ricardo Marciano Araujo','Eliane Raquel de C. Araujo','35920005547','123456787652222','123456787652222','2007-10-24',1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(10,1000,4,'FELIPE C ARAUJO','2024-06-15 02:34:35','Nepomuceno','MG','','91231321232','123456782','FELIPE C ARAUJO','FELIPE C ARAUJO','35920005547','098721839012312','098721839012312','2004-05-07',1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(11,1000,4,'FELIPE C ARAUJO','2024-06-15 02:34:35','sdfgbvcs','AS','','12345665643','123456784','asddfghnn','ascvdgf','35920005547','123456786543212','123456786543212','2004-05-07',0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(12,1000,4,'FELIPE C ARAUJO','2024-06-15 02:36:33','wasfdgh','AS','','12345654321','213456543','wfsdbg','asfdfbg','35920005547','123456765432123','123456765432123','2024-06-15',0,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(13,1000,4,'sdfgbn','2024-06-15 02:39:59','dsfgsf','RE','','12345643423','123456753','dsfghg','sdfgds','35920005547','1234567','123456','2004-05-07',0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(14,1000,4,'wefghfds','2024-06-15 02:45:17','dwef','VD','','67876576454','132457343','fgedf','sdgs','35920005547','1234656786','1324576342','2012-12-12',1,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(15,1000,4,'wqertyuthgfdq','2024-06-15 02:47:36','12345y6','AS','','54621345642','312456785','dasfdghg','awesfrgthy','12324564344','1234656845432','32456853215','2024-06-10',1,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(16,1000,4,'Kaju Araujo Correa','2024-06-15 20:37:10','brasileiro','MG','Apoio Emocional ','15887770655','675544543','Felipe Araujo','Kariny Maria','35920024811','6766664355436','564453342557','2024-03-24',1,1,'MASCULINO','','Laranja','2024-06-07',NULL,'SOLTEIRO','OUTROS','Coronel jJoaquim Ribeiro','7° ano','MANHÃ','teste outros'),(17,1000,4,'Jaguatirica','2024-06-16 11:15:02','Brasileiro','MG','','25670709990','22540555','Felipe de Carvalho Araujo','Kariny Maria Correa','35998275936','999999999999999','999999999999999','2021-02-26',1,1,'MASCULINO','','Laranja','2021-05-10',NULL,'SOLTEIRO','MÃE','','','',''),(18,1000,4,'Linda Maria de Araujo','2024-06-16 12:20:04','Brasileiro','MG','Apoio emotivo ','37160561111','665342137','Kariny Maria','FELIPE C ARAUJO','359200023333','MG','55564432334567','2003-12-02',1,0,'FEMININO','','Escaminha','2005-12-10',NULL,'DIVORCIADO','','','','',''),(19,3000,32,'Rafael Fernandes','2024-06-16 18:18:52','Minas Gerais','MG','Estudante','22222222222','222222222','teste 1','teste 1','33333333333','343242424132421','45435546546','2003-02-14',1,0,'','','','2024-06-29',NULL,'','','','','',''),(20,1000,54,'Rafael','2024-06-25 21:29:22','Minas Gerais','MG','Estudante','11111111111','222222222','aaaaaaa','bbbbbb','35998438463','2432431234134','12341241234234','2003-02-14',1,0,'MASCULINO','','aeeeaeaf','2011-11-10','professor','VIÚVO','','','','','');
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perguntas`
--

LOCK TABLES `perguntas` WRITE;
/*!40000 ALTER TABLE `perguntas` DISABLE KEYS */;
INSERT INTO `perguntas` VALUES (1,1,'aberta','Queixa principal'),(2,1,'aberta','História da doença atual'),(3,2,'alternativa','Sono'),(4,2,'alternativa','Já foi ao dentista?');
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
INSERT INTO `professor` VALUES (1,2,'João Marcelo Batista Narciso',1),(2,3,'João Pedro Fernandes',1),(5,4,'Felipe Araújo ',1),(6,5,'João Marcelo Batista Narciso',1),(7,6,'João Pedro Fernandes',1),(8,7,'João Marcelo Batista',0),(9,8,'João ',0),(10,15,'JoaoNinguem',0),(11,22,'Joao Adm',0),(12,24,'joao Professor',0),(13,27,'João Marcelo Batista Narciso',0),(14,29,'livia',0),(15,30,'Celso ',1),(16,32,'Rafael',0),(17,34,'13427658',0),(18,35,'Joao Marcelo',0),(19,36,'Joao Marcelo',0),(20,38,'Jose ',0),(21,39,'Flávia Santos ',1),(22,40,'Fábio',0),(23,46,'João Pedro',0),(24,50,'Lívia Morais',0),(25,52,'joao pedro',0);
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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario`
--

LOCK TABLES `prontuario` WRITE;
/*!40000 ALTER TABLE `prontuario` DISABLE KEYS */;
INSERT INTO `prontuario` VALUES (8,19,5,7,1000,'2024-06-24 04:28:38','dor','',1,NULL,NULL,1,'ASDA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(9,18,5,7,2000,'2024-06-24 19:56:26','teste dor','',1,1,0,NULL,'verifica',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'asd','asd','asd','asd',NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(10,16,5,NULL,1000,'2024-06-24 23:39:01','','',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(11,17,NULL,2,1000,'2024-06-25 01:02:23',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(12,6,19,7,2000,'2024-06-25 04:12:47','dor teste solidão','teste',1,1,1,1,'todas',1,1,1,1,1,1,1,1,1,1,1,'todas',1,1,1,1,'todas',1,1,1,1,1,1,'todas',1,1,1,1,1,'todas',1,1,1,1,'todas',1,'2024-06-25',1,1,1,'teste',1,1,1,1,'todas',1,1,1,1,1,'todas',1,1,1,1,1,'todas','todas',1,1,1,1,'todas',1,'todos','todos',1,NULL,NULL,NULL,'todos','todos','todo','toda','todos',1,1,1,1,1,1,1,1,1,'tudo','todas',1,'sempre',1,'sempre','todos','sempre','sempre','sempres','t','teste','teste',NULL,NULL,NULL,1,1,1,'todas',1,1,1,1,'teste','todas',1,'teste','testet','teste','teste','teste','tetse','teste',1,'teste','2024-06-29 03:00:00','teste','teste','teste','teste',NULL),(13,9,7,NULL,2000,'2024-06-25 21:34:20','Queixada','doença bem ruim',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(14,20,NULL,13,1000,'2024-06-25 21:37:27','dor no dente','nenhuma',0,0,0,0,NULL,0,0,0,0,0,0,0,0,0,0,0,NULL,0,0,0,0,NULL,0,0,NULL,NULL,NULL,NULL,NULL,0,0,0,0,0,NULL,0,0,0,0,NULL,0,NULL,0,0,0,NULL,0,0,0,0,NULL,0,0,0,0,0,NULL,NULL,NULL,NULL,NULL,0,NULL,NULL,0,0,0,0,NULL,NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,0,0,0,0,0,0,0,0,NULL,NULL,0,NULL,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',NULL,NULL,NULL,0,0,0,NULL,0,0,0,0,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
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
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario_assinatura_usuario`
--

LOCK TABLES `prontuario_assinatura_usuario` WRITE;
/*!40000 ALTER TABLE `prontuario_assinatura_usuario` DISABLE KEYS */;
INSERT INTO `prontuario_assinatura_usuario` VALUES (1,4,9),(2,4,9),(3,41,9),(4,23,0),(5,23,11),(6,41,8),(7,41,0),(8,41,12),(9,41,12),(10,41,12),(11,41,12),(12,41,12),(13,41,12),(14,41,12),(15,41,12),(16,41,12),(17,41,12),(18,41,12),(19,41,12),(20,41,12),(21,41,12),(22,41,12),(23,41,12),(24,41,12),(25,41,12),(26,41,12),(27,41,12),(28,41,12),(29,36,12),(30,36,12),(31,36,12),(32,36,12),(33,36,12),(34,36,12),(35,36,12),(36,36,12),(37,36,12),(38,36,12),(39,36,12),(40,36,12),(41,6,13),(42,54,0),(43,54,14);
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
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario_diagnostico_dentes`
--

LOCK TABLES `prontuario_diagnostico_dentes` WRITE;
/*!40000 ALTER TABLE `prontuario_diagnostico_dentes` DISABLE KEYS */;
INSERT INTO `prontuario_diagnostico_dentes` VALUES (1,1,'Gengivite','_18'),(2,1,'PeriodontiteLeve','_17,_11'),(3,1,'PeriodontiteGrave',''),(4,1,'EComplicada',''),(21,8,'Gengivite',''),(22,8,'PeriodontiteLeve',''),(23,8,'PeriodontiteGrave',''),(24,8,'EComplicada',''),(25,9,'Gengivite','_12,_11,_42,_41'),(26,9,'PeriodontiteLeve','_13,_12,_43,_42'),(27,9,'PeriodontiteGrave','_15'),(28,9,'EComplicada',''),(29,10,'Gengivite',''),(30,10,'PeriodontiteLeve',''),(31,10,'PeriodontiteGrave',''),(32,10,'EComplicada',''),(33,11,'Gengivite',''),(34,11,'PeriodontiteLeve',''),(35,11,'PeriodontiteGrave',''),(36,11,'EComplicada',''),(37,12,'Gengivite','_16,_15,_46,_45'),(38,12,'PeriodontiteLeve','_16,_15,_46,_45'),(39,12,'PeriodontiteGrave','_16,_15,_46,_45'),(40,12,'EComplicada','_16,_15,_46'),(41,13,'Gengivite',''),(42,13,'PeriodontiteLeve',''),(43,13,'PeriodontiteGrave',''),(44,13,'EComplicada',''),(45,14,'Gengivite',''),(46,14,'PeriodontiteLeve',''),(47,14,'PeriodontiteGrave',''),(48,14,'EComplicada','');
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
  PRIMARY KEY (`id`),
  KEY `id_paciente` (`id_paciente`),
  KEY `id_professor_vinculado` (`id_professor_vinculado`),
  KEY `prontuario_pronto_atendimento_estudante_idx` (`id_estudante`),
  CONSTRAINT `prontuario_pronto_atendimento_ibfk_1` FOREIGN KEY (`id_paciente`) REFERENCES `paciente` (`id`),
  CONSTRAINT `prontuario_pronto_atendimento_ibfk_2` FOREIGN KEY (`id_professor_vinculado`) REFERENCES `professor` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario_pronto_atendimento`
--

LOCK TABLES `prontuario_pronto_atendimento` WRITE;
/*!40000 ALTER TABLE `prontuario_pronto_atendimento` DISABLE KEYS */;
INSERT INTO `prontuario_pronto_atendimento` VALUES (1,4,1,'dor','sei la',1,1,1,'dor',1,'pacetamol',1,'sei la',1,1,1,'sei la',1,1,'outros',1,1,1,1,'sim',1,1,1,1,1,1,'sei la',1,'sei la','nenhum','nenhuma','12','morrendo',1,'Alfenas','2024-06-02 00:00:00',1,1,0),(2,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 00:43:45',NULL,NULL,NULL),(3,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 00:46:46',NULL,NULL,NULL),(4,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 00:47:44',NULL,NULL,NULL),(5,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 00:49:08',NULL,NULL,NULL),(6,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 00:53:37',NULL,NULL,NULL),(7,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 00:59:12',NULL,NULL,NULL),(8,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 01:04:31',NULL,NULL,NULL),(9,19,6,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 01:39:18',1,NULL,NULL),(10,19,6,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 01:57:21',1,NULL,NULL),(11,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 01:58:51',NULL,NULL,NULL),(12,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 01:59:02',NULL,NULL,NULL),(13,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:00:59',NULL,NULL,NULL),(14,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:03:23',NULL,NULL,NULL),(15,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:04:14',NULL,NULL,NULL),(16,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:05:46',NULL,NULL,NULL),(17,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:06:30',NULL,NULL,NULL),(18,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:07:05',NULL,NULL,NULL),(19,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:09:20',NULL,NULL,NULL),(20,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:11:25',NULL,NULL,NULL),(21,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:12:51',NULL,NULL,NULL),(22,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:17:26',NULL,NULL,NULL),(23,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:18:14',NULL,NULL,NULL),(24,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:19:47',NULL,NULL,NULL),(25,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:22:14',NULL,NULL,NULL),(26,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:24:19',NULL,NULL,NULL),(27,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:26:36',NULL,NULL,NULL),(28,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',NULL,NULL,'2024-06-25 02:28:49',NULL,NULL,NULL),(29,19,NULL,'teste','teste',1,1,1,'teste',0,NULL,1,'teste',1,1,0,'teste',0,0,'teste',0,1,0,0,'teste',0,0,0,0,0,0,'teste',0,'teste','teste','teste','teste','teste',1,NULL,'2024-06-25 02:30:46',NULL,NULL,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `responsavel`
--

LOCK TABLES `responsavel` WRITE;
/*!40000 ALTER TABLE `responsavel` DISABLE KEYS */;
INSERT INTO `responsavel` VALUES (1,3,'Ana da Silva','(11) 91234-5678','ana.silva@example.com','987.654.321-00',NULL),(2,3,'Carlos de Souza','(11) 93456-7890','carlos.souza@example.com','456.123.789-00',NULL),(3,4,'Ana da Silva','(11) 91234-5678','ana.silva@example.com','987.654.321-00',NULL),(4,4,'Carlos de Souza','(11) 93456-7890','carlos.souza@example.com','456.123.789-00',NULL),(5,5,'Ana da Silva','(11) 91234-5678','ana.silva@example.com','987.654.321-00',NULL),(6,5,'Carlos de Souza','(11) 93456-7890','carlos.souza@example.com','456.123.789-00',NULL),(7,6,'Ana da Silva','(11) 91234-5678','ana.silva@example.com','987.654.321-00',NULL),(8,6,'Carlos de Souza','(11) 93456-7890','carlos.souza@example.com','456.123.789-00',NULL),(13,16,'Kariny Maria','(35) 9999-29201','kariny@gmail.com','098.765.456-70',NULL),(18,17,'JOAO PEDRO FERNANDES REIS','(12) 3123-1233','joaofernandesreis32@gmail.com','123.123.123-12',NULL),(19,19,'JOAO PEDRO FERNANDES REIS','(12) 3123-1232','joaofernandesreis32@gmail.com','123.123.123-12',NULL);
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
  `anotacao` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `respostas_abertas`
--

LOCK TABLES `respostas_abertas` WRITE;
/*!40000 ALTER TABLE `respostas_abertas` DISABLE KEYS */;
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
  `anotacao` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `respostas_alternativa`
--

LOCK TABLES `respostas_alternativa` WRITE;
/*!40000 ALTER TABLE `respostas_alternativa` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'buscar_prontuario','Acessar as informações do prontuario'),(2,'editar_prontuario','Editar informações do prontuário'),(3,'deletar_prontuario','Deletar prontuários'),(4,'cadastrar_prontuario','Cadastrar novos prontuários'),(5,'editar_triagem','Editar Triagem'),(6,'cadastrar_paciente','Cadastrar pacientes'),(7,'cadastrar_triagem','Cadastrar Ficha de Triagem');
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
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles_modulo`
--

LOCK TABLES `roles_modulo` WRITE;
/*!40000 ALTER TABLE `roles_modulo` DISABLE KEYS */;
INSERT INTO `roles_modulo` VALUES (36,1,1),(37,7,18),(38,3,6),(39,6,8);
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
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles_semestre`
--

LOCK TABLES `roles_semestre` WRITE;
/*!40000 ALTER TABLE `roles_semestre` DISABLE KEYS */;
INSERT INTO `roles_semestre` VALUES (32,1,1),(36,2,1),(37,5,1),(38,3,1),(40,4,1),(41,6,1),(42,7,1);
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `triagem`
--

LOCK TABLES `triagem` WRITE;
/*!40000 ALTER TABLE `triagem` DISABLE KEYS */;
INSERT INTO `triagem` VALUES (2,2,3,4,'1',1,0,'Ortodontia','2024-05-31 16:14:12','0'),(3,2,3,5,'1',1,0,'Ortodontia','2024-05-31 16:14:12','0'),(4,12,4,3,'6',0,1,'teste outros editando','2024-06-02 01:00:27','0'),(5,18,4,6,'4',1,0,'','2024-06-02 20:08:59','0'),(6,5,7,7,'4',1,1,'szrthrtgshdrtgh','2024-06-03 02:14:00','1'),(7,5,7,8,'5',1,1,'','2024-06-05 00:48:10','1'),(9,5,7,19,'4',1,0,'','2024-06-19 23:53:27','2');
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
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (2,1,'5656566','joao.narciso@aluno.unifenas.br565',0,0,_binary '��`�~�;���w� ���\n��5N���X֌�L�Zё�O؄��X�|\n\\D�MEdN�1\"k�',_binary 'Te\n�������k��'),(3,1,'7859474867','joao.fernandes@aluno.unifenas.com.br',0,0,_binary 'LȰ��H[�z�2Z�/�HT\"�4�wQ!޳�%݇�߾2W�O6��N2+:�͝��\'��ι',_binary '\r6|g��S/��v�U�|'),(4,1,'1234098765T','felipe.araujo@aluno.unifenas.br',0,0,_binary '��\rJ�ąƭ�a�������3���N�)�aVM���\n�I��B�:l��7�+l��8Lg�LR�{',_binary '3��\Z�%Ξ[���:�'),(5,1,'207875222','joao.narciso@aluno.unifenas.com.br.com',0,0,_binary '��ja�$U��o|�B��廨����<���D�҉Y��G�tL��4�cx�.�n�<szt��a��bLo���',_binary '�[.ذZ����*�E�'),(6,1,'206491221','joao.pfernandes@aluno.unifenas.br',0,0,_binary 'L*�����S�M��i�M��f�{�|\0�_Uz�{X���Nx)H�aŵ�\'R�o�5�r�Wq�$��.raZ',_binary '��1�bVnΔ��z�'),(7,1,'209846046','joao@unifenas.br',0,0,_binary 'y��Dʕf�\r�_7g5��b@��|#:�S$��w���;�	kB�%z�ȗuQt��M���r��',_binary '��@�-O�f��!���'),(8,1,'123123','joaojp@unifenas.br',0,0,_binary '���͌��).Lo�\0�w�����o~�r����	���/=`��=.aos\"I�ͷqy�uv',_binary '��x�����W��᪜�'),(9,3,'821312312','felipe@unifenas.com',0,0,_binary 'C��G���	�]-�XR�{P��DG���O?5���;�������Z���ȡN�Y��??~���',_binary 'H�Ŗ�,�:k@l�����'),(10,3,'1231312312','joao@unifenas.com',1,0,_binary '�6Sr(�O�h���x�fȅѢ^�`���ȅ�V_�ì��,�O����Y�%�Y\Zz� ��Fj�',_binary '���2��y�D�{l�D'),(11,3,'111111111','joao.Ze123@unifenas.com',0,0,_binary 'J�}��R��w�^�� TA����+Aw	K+�o�ͪ�� �9�\Z4�i휜�\nK!�j|��',_binary '}Xy7��Ë��umm�'),(12,3,'002920201','joaoZe111@unifenas.com',0,0,_binary '�.s�k���<�g�Y\"o&�\Z� [�z�c�TQc��@}ϗ��|�i�*>49��[�U@��Q�',_binary '�f/��ZTûE��d�'),(13,3,'5555555','joaoZe555@unifenas.com',0,0,_binary '�d�\"$�bRLO��0zu���eѺ�Z�{mٿ��XB:W������(z��饂�cu�>N��f`��',_binary '_�n�g�4c-����Eg-'),(15,2,'33333','joaoZe222@unifenas.com',0,0,_binary '�B��-I�	;�`�Y�JY���΍��ϩ,�u35&��<����ʬQ�Y�)VῺ�^	<�2�%��',_binary '-�	�1n��OB|P̢'),(16,3,'207875212','joao@aluno.unifenas.br',0,0,_binary '�,����i,ALp.)��4\Z�-q��O��@�և�	+�a��\'$���\\�������Y�q\"�y',_binary 'u>Igj�AXPє�36'),(17,3,'666666','joaoZe999@unifenas.com',0,0,_binary '%zb+�c�\'I����������\0+\ra���$nfJ\'\rp8�%�����<��}�n\ZD���V�',_binary '����aż�ZL�Ѵ�H'),(18,3,'6666s66','joaoZe909@unifenas.com',0,0,_binary '�5/p�s��_�cZ�e�jS�2}cqt�\"]�\'��_(|�J�S1�������t&nz�9�',_binary '�Ӗ�[�6f�C~\\\n�9i'),(19,3,'6666312366','joaoZe9009@unifenas.com',0,0,_binary 'k�4�����%e�����F@���u�\"�I�Lh	�Ոw[�o1�rzz}�q��{���_�r',_binary 'K +cp8Hnp�Ǎ�'),(20,3,'0000087','joaoZe209@unifenas.com',0,0,_binary '�}��@Q;�Gg���fՆ���f�;5���yl5��������<�%���M���yV$�I�fU��',_binary '�Kstz���rgʟЌ�'),(21,3,'83838383832','joao000000@unifenas.com',0,0,_binary '\n���X��jm��a���8������ f~Y�.R����Wk���F�[���8hu4.EOSY6�5Mz',_binary '���9�+���\0q��'),(22,1,'23123141','joao.adm@unifenas.br',0,0,_binary 'P1�&����*�]_ ���{��Z\0Q���l��+\rm�u/�u�%�Ere���z�SS@��\n�A',_binary '�9�u ���x�T�'),(23,3,'124345345','joao.aluno@unifenas.br',0,0,_binary ';U�����x��lߣiY�IG�~��E?���PM[û|Q�|�)h<A�^��O�!z#kA���',_binary '�?\\O�y9�qIc�^P�'),(24,2,'53464563465','joao.professor@unifenas.br',0,0,_binary '�4�I�z��΍�(I�{C���:zg�`�uڞ�������B�k��l���~9����k\'@8���ݵ�',_binary '�b�t���H��5'),(25,2,'2078754221','joao@prof.unifenas.br',0,0,_binary '~/������d\Z���qV��\n���*�E.<�,-��[V�0зaS�l5[FP��HL�*&uDu�',_binary 'č�\"]�5N��צ!��'),(26,2,'20787554221','joao@profe.unifenas.br',0,0,_binary '��R4pw�>���J7��7z9}��Hſ�^>N�\ZۼO�Ώ��m\Z9���i �0�9a�\Z�O��',_binary '`c�mbPtnq6�i'),(27,2,'2078754554221','joao@profes.unifenas.br',0,0,_binary '!�i���zs7DZ+�+N�@�c�g��%���@��E0[Y�j}�A�*��5��8��FC����;��',_binary 'G?��a�V�-D��6'),(28,3,'124718248124','teste@unifenas.br',0,0,_binary '6���Wɳ�H8H�g\\�fb�]�-(�[˶�J�������[祿mAw��p$�x��5�Z�',_binary 'ba��7PI/k<X���'),(29,1,'205399221','livia.morais@aluno.unifenas.br',0,3,_binary '��AV�[>*0.rrqr���1;�\0���z���1$�W��P2�ăL����lVg���=gEp��',_binary '�� ��#��������1'),(30,1,'9982739472','celso.user@unifenas.br',0,0,_binary 'ٖ�tB�cw���Ѫ���H&@�F�m5	���[�\Z�پ���Ͳ�V�b�v�\'�LR��ϣ鴹F',_binary 'r�:�7q��ͩڃޝ�'),(31,3,'5530318','mariaunifenas@gmail.com',0,0,_binary 'x�T�ܸ/Ѿ�pd�ע݋�jK�.f��_��A$������Q�P�l�~F%g�!�r�X����C�s�',_binary '���n��8���18�'),(32,1,'201571211','rafael.silveira@aluno.unifenas.br',0,0,_binary '�z��i�6�jD�t�	B��\'jPw�-[&�DX�HD\n����k��P�o:�Jk�\0��tO}UM',_binary '����D�?N�J~��W'),(33,3,'123468597','j@unifenas.br',0,0,_binary '�=Cy�;��H�_�!V�zQ��>�o���D�o��#�s��t4�I\\�HT�<�2���',_binary '�.�Z��k���\0B�@\r'),(34,2,'324765','jp@unifenas.br',0,0,_binary '�2L�W/�~B6�&��.�js.Nߤ��{�y;\0cF�)5^i��A�Xyg.�-�eֳ��',_binary 'g�����s�?�`-�'),(35,1,'123465241','joao@unifenas.com.br',0,0,_binary 'w�s�5qk��\0���	_����EcW7.�YS����f�3�9�DK��`O�u��s�ͺ�}.X�',_binary '!��\0�}I�=˄�B�P'),(36,1,'12346523445665','joao.narciso@aluno.unifenas.br656',0,0,_binary '�1XWΠN̶FG��w�Z]���7��1hl~���8F���N>o�-W��J~����|����',_binary 'L�h%��)�\"w9��:'),(37,3,'123897345','felipeiyuvas@unifenas.com',0,0,_binary '���R��\"4���Z�8�CzT�O���k鼍���PP蕽�7iBu��祂vMp\0�4',_binary '͂yn�>)��qS�뺙'),(38,2,'92834293742','jose.teste@unifenas.br',0,0,_binary 'g���G�v�̜\" ��K�n<lX{�nSwfuXd�5�?F$t���Pex{ր+D6�:y��ҘX',_binary '�6_���[����V�'),(39,2,'3232','flavia.santos@unifenas.br',0,1,_binary '�M�_P�e<����gM�,���eP�i��I��]z\"T��z@�e��y����=\r,\Z�:���#:',_binary '��b5X�H��~(MA1'),(40,2,'702801','fabio.carvalho@unifenas.br',0,0,_binary '� \Z����������~|��=���SR�����@1�+p���	ų���լ��c������`L(',_binary '�HL��9?�Q^��NY'),(41,3,'123123123','ana.clara@aluno.unifenas.br',0,0,_binary 'd{~\n���e�:�����;F;G�p��K��1�]!�1��+�\Z�̋��\rr�eIij��,=�D*�',_binary '?-��ӽ�9R4��\"|'),(42,3,'205526222','larissa.milani@aluno.unifenas.br',0,0,_binary '���ōt#�f�n;����k����ů�/z94���\'���y�;s�ʦ�Qs��N�9��ӣ㭓�',_binary '*)6(�h��P��8l��'),(43,3,'206002222','Roberto.barnabe@aluno.unifenas.br',0,0,_binary '���eyj��fG�2�\0�{\n�u��P���N��3��u�j�\0�Vv�<�[��)$�P	+(',_binary '�*ǽ�\0���⩲��'),(44,3,'201913201','debora.damasceno@aluno.unifenas.br',0,0,_binary 'i_7b?�5�}$o8<zZ/��\'9����ՊTa����r�畲64=��d\"�+Ă��P�A��',_binary '3S��8���WR�'),(45,3,'206073222','clara.batista@aluno.unifenas.br',0,0,_binary '̗��bJ(�@�+v�!|U%ܥ$�5�c���ߠ����8�\n	���d�y[d�@��^�',_binary '�&�9K��y�*T����'),(46,2,'206491223','joao.pedro.fernandes@aluno.unifenas.br',0,0,_binary '�5d�8Ӫg�_e�Q	@��V���%�P�6q��h�m1�Gq�Ah��%p��WM�� 6ƳTb4�',_binary '�쌌�U[�G~.�'),(47,3,'917398273','zeze.capimba@aluno.unifenas.br',1,0,_binary ',�\\���P��*�{-�2��)���/]��9�VE?�&���!��})li�̨�my�\'b���',_binary '@M�J2)E�J�6 w��'),(48,3,'324353246525','joao.narciso@aluno.unifenas.br.cop.gin',1,0,_binary '{��hB�(��׫�Ί��\\��w��+Z��Z�TH�?O�\Z���`�bM_�ؿy#e�񓁯�U',_binary '\0�h��d���cY�9e&)'),(49,3,'1258756453','zeze.caximba@aluno.unifenas.br',1,0,_binary '�Ci��\0�E2����i��5���蝏4e�ɜ��\'I��˒��<\'��x5t�<&}E���}�4PAje�',_binary '̓u��_l�ҹ�uW'),(50,1,'207207207','livia.aluna@aluno.unifenas.br',0,0,_binary ':9E�4��]�zlK��^�h�Ş���R{bp	Ag�vf�Y���d������fS��=O��',_binary 'Wh�Z5X�)�Kfyw3'),(51,3,'434235','joao.narciso@aluno.unifenas.br.gro.drgh',1,0,_binary '$������*	c���oq͒a�8�Z(M{a%Bˋ�N˶A:a��q\"\"�ղ�$�������0̝�',_binary 'Ǿ;.6&b�?q�lo�E�'),(52,1,'209890876','joao.pedro.fernandes.reis@aluno.unifenas.br',0,0,_binary 'U��(߰��\"�&1>i|+%��7q�f������|�ƀL+_�3���j%}� ���G����Ѿ_',_binary '��dyͻ&G�;���'),(53,3,'1788553453','felipe.araujo1@aluno.unifenas.br',0,0,_binary '�fWW%�`�<�ĥl��[Le�o\r��Ƨ6��u��-@��u��f�+15��}��P�b��tVnW',_binary 'QG	���)n\\���,�'),(54,3,'123112112','aaaaa@aluno.unifenas.br',0,0,_binary '�@d��$�\"���eQ�n�ı�h$$�g��X�Xm�m~��:yq�04��ù��-�����9�',_binary '�\'�v�|�K��L��):');
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

-- Dump completed on 2024-11-08 23:21:42
