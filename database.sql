-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.6.13 - MySQL Community Server (GPL)
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.3.0.5004
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura do banco de dados para cabeleireiro
CREATE DATABASE IF NOT EXISTS `cabeleireiro` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `cabeleireiro`;


-- Copiando estrutura para tabela cabeleireiro.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `ID_Cliente` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) DEFAULT NULL,
  `Apelido` varchar(50) DEFAULT NULL,
  `Endereco` varchar(50) DEFAULT NULL,
  `Tel_Fixo` varchar(50) DEFAULT NULL,
  `Tel_Cel` varchar(50) DEFAULT NULL,
  `Operadora` char(50) DEFAULT NULL,
  `Whatsapp` varchar(50) DEFAULT NULL,
  `Sexo` varchar(50) DEFAULT NULL,
  `Infantil` varchar(50) DEFAULT NULL,
  `Mensalista` char(50) DEFAULT NULL,
  `ValorPago` float DEFAULT NULL,
  `ValoraPagar` float DEFAULT NULL,
  `Obs` varchar(250) DEFAULT NULL,
  `UltimaConsulta` date DEFAULT NULL,
  `ProxConsulta` date DEFAULT NULL,
  `Frequencia` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.


-- Copiando estrutura para tabela cabeleireiro.historico
CREATE TABLE IF NOT EXISTS `historico` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Cliente` int(11) DEFAULT NULL,
  `DataC` datetime DEFAULT NULL,
  `DataP` datetime DEFAULT NULL,
  `Corte` varchar(3) DEFAULT NULL,
  `Barba` varchar(3) DEFAULT NULL,
  `Pezinho` varchar(3) DEFAULT NULL,
  `Sombrancelha` varchar(3) DEFAULT NULL,
  `SombrancelhaHenna` varchar(3) DEFAULT NULL,
  `Relaxamento` varchar(3) DEFAULT NULL,
  `Progressiva` varchar(50) DEFAULT NULL,
  `PigmentacaoCorte` varchar(3) DEFAULT NULL,
  `PigmentacaoBarba` varchar(3) DEFAULT NULL,
  `Luzes` varchar(3) DEFAULT NULL,
  `Gel` varchar(3) DEFAULT NULL,
  `Lapis` varchar(3) DEFAULT NULL,
  `Valor` float NOT NULL DEFAULT '0',
  `ValorPago` float DEFAULT NULL,
  `ValorEmAberto` float DEFAULT NULL,
  `Status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID_Cliente` (`ID_Cliente`),
  CONSTRAINT `ID_Cliente` FOREIGN KEY (`ID_Cliente`) REFERENCES `clientes` (`ID_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
