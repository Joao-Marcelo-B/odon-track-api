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
) ENGINE=InnoDB AUTO_INCREMENT=239 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-09 12:57:55
