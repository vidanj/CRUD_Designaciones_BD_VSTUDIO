-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         8.3.0 - MySQL Community Server - GPL
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.0.0.6468
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para designaciones
CREATE DATABASE IF NOT EXISTS `designaciones` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `designaciones`;

-- Volcando estructura para tabla designaciones.artefactos
CREATE TABLE IF NOT EXISTS `artefactos` (
  `id_artefacto` bigint NOT NULL AUTO_INCREMENT,
  `artefacto` varchar(40) DEFAULT NULL,
  `parte` varchar(1) DEFAULT NULL,
  `atributoMain` varchar(20) DEFAULT NULL,
  `atributo1` varchar(20) DEFAULT NULL,
  `valor1` decimal(4,2) DEFAULT NULL,
  `atributo2` varchar(20) DEFAULT NULL,
  `valor2` decimal(4,2) DEFAULT NULL,
  `atributo3` varchar(20) DEFAULT NULL,
  `valor3` decimal(4,2) DEFAULT NULL,
  `atributo4` varchar(20) DEFAULT NULL,
  `valor4` decimal(4,2) DEFAULT NULL,
  PRIMARY KEY (`id_artefacto`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla designaciones.artefactos: 6 rows
DELETE FROM `artefactos`;
/*!40000 ALTER TABLE `artefactos` DISABLE KEYS */;
INSERT INTO `artefactos` (`id_artefacto`, `artefacto`, `parte`, `atributoMain`, `atributo1`, `valor1`, `atributo2`, `valor2`, `atributo3`, `valor3`, `atributo4`, `valor4`) VALUES
	(1, 'Furia del Trueno', '1', 'HP', 'ATK', 27.00, 'CRIT_RATE', 3.10, 'EM', 65.00, 'CRIT_DAMAGE', 13.20),
	(2, 'Final del Gladiador', '4', 'ELEMENTAL_DMG', 'ATK%', 4.10, 'ENERGY_RECHARGE', 12.30, 'CRIT_RATE', 12.80, 'ATK', 18.00),
	(3, 'Cazador Fantasmal', '3', 'HP%', 'ATK%', 4.10, 'ENERGY_RECHARGE', 12.30, 'CRIT_RATE', 12.80, 'ATK', 18.00),
	(4, 'Final del Gladiador', '5', 'CRIT_RATE', 'ATK%', 14.00, 'DEF%', 5.10, 'CRIT_DAMAGE', 29.80, 'ENERGY_RECHARGE', 5.20),
	(5, 'Cazador Fantasmal', '2', 'ATK', 'ATK%', 4.10, 'ENERGY_RECHARGE', 12.30, 'CRIT_RATE', 12.80, 'DEF', 18.00),
	(6, 'Furia del Trueno', '5', 'CRIT_DAMAGE', 'ATK', 27.00, 'HP%', 3.10, 'EM', 65.00, 'CRIT_RATE', 13.20);
/*!40000 ALTER TABLE `artefactos` ENABLE KEYS */;

-- Volcando estructura para tabla designaciones.asignaciones
CREATE TABLE IF NOT EXISTS `asignaciones` (
  `id_asignacion` bigint NOT NULL AUTO_INCREMENT,
  `id_cliente` bigint DEFAULT NULL,
  `id_artefacto` bigint DEFAULT NULL,
  `id_usuario` bigint DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`id_asignacion`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla designaciones.asignaciones: 7 rows
DELETE FROM `asignaciones`;
/*!40000 ALTER TABLE `asignaciones` DISABLE KEYS */;
INSERT INTO `asignaciones` (`id_asignacion`, `id_cliente`, `id_artefacto`, `id_usuario`, `fecha`) VALUES
	(1, 2, 1, 1, '2023-02-07'),
	(2, 1, 2, 1, '2024-06-17'),
	(3, 3, 3, 1, '2022-06-07'),
	(4, 2, 4, 5, '2022-03-08'),
	(5, 5, 5, 3, '2024-05-27'),
	(8, 2, 6, 5, '2021-06-07'),
	(9, 1, 3, 3, '2004-02-07');
/*!40000 ALTER TABLE `asignaciones` ENABLE KEYS */;

-- Volcando estructura para tabla designaciones.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `id_cliente` bigint NOT NULL AUTO_INCREMENT,
  `cliente` varchar(40) DEFAULT NULL,
  `ASCENCION` varchar(3) DEFAULT NULL,
  `LVL` bigint DEFAULT NULL,
  `HP` bigint DEFAULT NULL,
  `ATK` bigint DEFAULT NULL,
  `DEF` bigint DEFAULT NULL,
  `EM` bigint DEFAULT NULL,
  `ENERGY_RECHARGE` decimal(5,2) DEFAULT NULL,
  `CRIT_RATE` decimal(5,2) DEFAULT NULL,
  `CRIT_DAMAGE` decimal(5,2) DEFAULT NULL,
  `ELEMENTAL_DMG` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla designaciones.clientes: 5 rows
DELETE FROM `clientes`;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`id_cliente`, `cliente`, `ASCENCION`, `LVL`, `HP`, `ATK`, `DEF`, `EM`, `ENERGY_RECHARGE`, `CRIT_RATE`, `CRIT_DAMAGE`, `ELEMENTAL_DMG`) VALUES
	(1, 'Alhacén', 'A6', 80, 12410, 291, 727, 0, 100.00, 5.00, 50.00, 28.80),
	(2, 'Cyno', 'A6', 80, 11020, 281, 758, 0, 100.00, 5.00, 78.80, 0.00),
	(3, 'Neuvillette', 'A6', 80, 13662, 194, 536, 0, 100.00, 5.00, 88.40, 0.00),
	(5, 'Candace', 'A7', 80, 13662, 194, 5365, 0, 100.00, 5.00, 88.40, 0.00),
	(8, 'Neuvillette', 'A3', 1, 13662, 194, 536, 0, 100.00, 5.00, 88.40, 0.00);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Volcando estructura para tabla designaciones.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `id_usuario` bigint NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `cuenta` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `clave` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `nivel` varchar(2) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `idioma` varchar(2) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`id_usuario`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla designaciones.usuarios: 4 rows
DELETE FROM `usuarios`;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`id_usuario`, `usuario`, `cuenta`, `clave`, `nivel`, `idioma`) VALUES
	(1, 'Efren Campuzano', 'admin', '202cb962ac59075b964b07152d234b70', '0', '1'),
	(3, 'Joven Gringo', 'gringo', 'caf1a3dfb505ffed0d024130f58c5cfa', '1', '2'),
	(5, 'Joven Gringo2', 'gringo2', '6e65871be49417d2e6c1de83a7e0f875', '1', '2'),
	(7, 'Joven No gringo', 'admin2', 'c84258e9c39059a89ab77d846ddab909', '0', '1');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
