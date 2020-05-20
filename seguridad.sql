-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-05-2020 a las 02:24:28
-- Versión del servidor: 10.1.26-MariaDB
-- Versión de PHP: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `seguridad`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `procedimientoLogin` (IN `usuario` VARCHAR(25), IN `clave` VARCHAR(25))  NO SQL
Select tbl_usuario.PK_id_Usuario FROM tbl_usuario where tbl_usuario.PK_id_Usuario = usuario and tbl_usuario.password_usuario = MD5(clave) AND tbl_usuario.estado_usuario=1$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ayuda`
--

CREATE TABLE `ayuda` (
  `Id_ayuda` int(11) NOT NULL,
  `Ruta` text COLLATE utf8_unicode_ci NOT NULL,
  `indice` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `ayuda`
--

INSERT INTO `ayuda` (`Id_ayuda`, `Ruta`, `indice`) VALUES
(1, 'Página web ayuda/ayuda.chm', 'menu.html'),
(2, 'Página web ayuda/ayuda.chm', 'Menúboletos.html');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_aplicacion`
--

CREATE TABLE `tbl_aplicacion` (
  `PK_id_aplicacion` int(11) NOT NULL,
  `PK_id_modulo` int(11) NOT NULL,
  `nombre_aplicacion` varchar(45) DEFAULT NULL,
  `descripcion_aplicacion` varchar(200) DEFAULT NULL,
  `estado_aplicacion` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_aplicacion`
--

INSERT INTO `tbl_aplicacion` (`PK_id_aplicacion`, `PK_id_modulo`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1, 1, 'Contabilidad', 'Gestión Contable ', 1),
(2, 1, 'Bancos', 'Gestión Bancaria', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bitacora`
--

CREATE TABLE `tbl_bitacora` (
  `PK_id_bitacora` int(11) NOT NULL,
  `PK_id_usuario` varchar(25) NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `host` varchar(45) DEFAULT NULL,
  `ip` varchar(25) DEFAULT NULL,
  `accion` varchar(50) DEFAULT NULL,
  `tabla` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_bitacora`
--

INSERT INTO `tbl_bitacora` (`PK_id_bitacora`, `PK_id_usuario`, `fecha`, `hora`, `host`, `ip`, `accion`, `tabla`) VALUES
(1, 'rchocm', '2020-04-05', '12:13:58', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(2, 'rchocm', '2020-04-05', '12:14:26', 'AMAZING', '192.168.1.17', 'Realizo una consulta a modulos', 'tbl_modulos'),
(3, 'rchocm', '2020-04-05', '12:14:31', 'AMAZING', '192.168.1.17', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(4, 'rchocm', '2020-04-05', '12:14:31', 'AMAZING', '192.168.1.17', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(5, 'rchocm', '2020-04-05', '12:15:13', 'AMAZING', '192.168.1.17', 'Inserto un nuevo perfil: 1 - admin', 'tbl_perfil'),
(6, 'rchocm', '2020-04-05', '12:15:31', 'AMAZING', '192.168.1.17', 'Inserto un nuevo perfil: 2 - operador', 'tbl_perfil'),
(7, 'rchocm', '2020-04-05', '12:15:38', 'AMAZING', '192.168.1.17', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(8, 'rchocm', '2020-04-05', '12:15:38', 'AMAZING', '192.168.1.17', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(9, 'rchocm', '2020-04-05', '12:15:43', 'AMAZING', '192.168.1.17', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(10, 'rchocm', '2020-04-05', '12:15:55', 'AMAZING', '192.168.1.17', 'Asigno perfil: admin a usuario: rchocm', 'tbl_usuario_perfil'),
(11, 'rchocm', '2020-04-05', '12:16:01', 'AMAZING', '192.168.1.17', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(12, 'rchocm', '2020-04-05', '12:16:02', 'AMAZING', '192.168.1.17', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(13, 'rchocm', '2020-04-05', '12:16:08', 'AMAZING', '192.168.1.17', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(14, 'rchocm', '2020-04-05', '12:16:08', 'AMAZING', '192.168.1.17', 'Realizo una consulta a modulos', 'tbl_modulos'),
(15, 'rchocm', '2020-04-05', '12:16:45', 'AMAZING', '192.168.1.17', 'Inserto un nuevo modulo: 1 - FRM', 'tbl_modulo'),
(16, 'rchocm', '2020-04-05', '12:17:03', 'AMAZING', '192.168.1.17', 'Inserto un nuevo modulo: 2 - SCM', 'tbl_modulo'),
(17, 'rchocm', '2020-04-05', '12:17:18', 'AMAZING', '192.168.1.17', 'Inserto un nuevo modulo: 3 - MRP', 'tbl_modulo'),
(18, 'rchocm', '2020-04-05', '12:17:30', 'AMAZING', '192.168.1.17', 'Inserto un nuevo modulo: 4 - CRM', 'tbl_modulo'),
(19, 'rchocm', '2020-04-05', '12:17:46', 'AMAZING', '192.168.1.17', 'Inserto un nuevo modulo: 5 - HRM', 'tbl_modulo'),
(20, 'rchocm', '2020-04-05', '12:17:52', 'AMAZING', '192.168.1.17', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(21, 'rchocm', '2020-04-05', '12:17:52', 'AMAZING', '192.168.1.17', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(22, 'rchocm', '2020-04-05', '12:17:54', 'AMAZING', '192.168.1.17', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(23, 'rchocm', '2020-04-05', '12:17:54', 'AMAZING', '192.168.1.17', 'Realizo una consulta a modulos', 'tbl_modulos'),
(24, 'rchocm', '2020-04-05', '12:18:01', 'AMAZING', '192.168.1.17', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(25, 'rchocm', '2020-04-05', '12:18:07', 'AMAZING', '192.168.1.17', 'Realizo una consulta a modulos', 'tbl_modulos'),
(26, 'rchocm', '2020-04-05', '12:20:41', 'AMAZING', '192.168.1.17', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(27, 'rchocm', '2020-04-05', '12:20:42', 'AMAZING', '192.168.1.17', 'Realizo una consulta a modulos', 'tbl_modulos'),
(28, 'rchocm', '2020-04-05', '12:20:47', 'AMAZING', '192.168.1.17', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(29, 'rchocm', '2020-04-05', '12:20:55', 'AMAZING', '192.168.1.17', 'Asigno aplicacion: Contabilidad a usuario: rchocm', 'tbl_usuario_aplicacion'),
(30, 'rchocm', '2020-04-05', '12:21:03', 'AMAZING', '192.168.1.17', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(31, 'rchocm', '2020-04-05', '12:21:12', 'AMAZING', '192.168.1.17', 'Asigno aplicacion: Bancos a usuario: rchocm', 'tbl_usuario_aplicacion'),
(32, 'rchocm', '2020-04-05', '12:21:18', 'AMAZING', '192.168.1.17', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(33, 'rchocm', '2020-04-05', '12:21:18', 'AMAZING', '192.168.1.17', 'Realizo una consulta a modulos', 'tbl_modulos'),
(34, 'rchocm', '2020-04-05', '12:21:22', 'AMAZING', '192.168.1.17', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(35, 'rchocm', '2020-04-05', '12:21:30', 'AMAZING', '192.168.1.17', 'Asigno permiso: Contabilidad a perfil: admin', 'tbl_usuario_aplicacion'),
(36, 'rchocm', '2020-04-05', '12:21:34', 'AMAZING', '192.168.1.17', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(37, 'rchocm', '2020-04-05', '12:21:42', 'AMAZING', '192.168.1.17', 'Asigno permiso: Bancos a perfil: admin', 'tbl_usuario_aplicacion'),
(38, 'rchocm', '2020-04-05', '12:21:53', 'AMAZING', '192.168.1.17', 'Consulto bitacora', 'tbl_bitacora'),
(39, 'rchocm', '2020-04-05', '12:31:02', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(40, 'rchocm', '2020-04-05', '12:31:03', 'AMAZING', '192.168.1.17', 'Probó la Bitacora', 'General'),
(41, 'rchocm', '2020-04-05', '12:31:05', 'AMAZING', '192.168.1.17', 'Probó la Bitacora', 'General'),
(42, 'rchocm', '2020-04-05', '12:31:05', 'AMAZING', '192.168.1.17', 'Probó la Bitacora', 'General'),
(43, 'rchocm', '2020-04-05', '12:31:06', 'AMAZING', '192.168.1.17', 'Probó la Bitacora', 'General'),
(44, 'rchocm', '2020-04-05', '12:31:06', 'AMAZING', '192.168.1.17', 'Probó la Bitacora', 'General'),
(45, 'rchocm', '2020-04-05', '12:31:20', 'AMAZING', '192.168.1.17', 'Consulto bitacora', 'tbl_bitacora'),
(46, 'rchocm', '2020-04-05', '12:31:40', 'AMAZING', '192.168.1.17', 'Cerro sesion en el sistema', 'Login'),
(47, 'rchocm', '2020-04-05', '01:10:57', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(48, 'rchocm', '2020-04-05', '01:27:12', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(49, 'rchocm', '2020-04-05', '01:29:26', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(50, 'rchocm', '2020-04-05', '01:32:43', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(51, 'rchocm', '2020-04-05', '01:34:00', 'AMAZING', '192.168.1.17', 'Probó la Bitacora', 'General'),
(52, 'rchocm', '2020-04-05', '01:40:19', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(53, 'rchocm', '2020-04-05', '01:44:05', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(54, 'rchocm', '2020-04-05', '01:47:00', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(55, 'rchocm', '2020-04-05', '05:48:52', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(56, 'rchocm', '2020-04-05', '05:49:42', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(57, 'rchocm', '2020-04-05', '05:50:45', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(58, 'rchocm', '2020-04-05', '05:53:08', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(59, 'rchocm', '2020-04-05', '05:54:58', 'AMAZING', '192.168.1.17', 'Realizo una consulta a modulos', 'tbl_modulos'),
(60, 'rchocm', '2020-04-05', '05:55:15', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(61, 'rchocm', '2020-04-05', '05:55:28', 'AMAZING', '192.168.1.17', 'Consulto bitacora', 'tbl_bitacora'),
(62, 'rchocm', '2020-04-05', '05:55:55', 'AMAZING', '192.168.1.17', 'Realizo una consulta a modulos', 'tbl_modulos'),
(63, 'rchocm', '2020-04-05', '05:56:06', 'AMAZING', '192.168.1.17', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(64, 'rchocm', '2020-04-05', '05:56:06', 'AMAZING', '192.168.1.17', 'Realizo una consulta a modulos', 'tbl_modulos'),
(65, 'rchocm', '2020-04-05', '05:56:13', 'AMAZING', '192.168.1.17', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(66, 'rchocm', '2020-04-05', '05:56:13', 'AMAZING', '192.168.1.17', 'Realizo una consulta a modulos', 'tbl_modulos'),
(67, 'rchocm', '2020-04-05', '05:56:32', 'AMAZING', '192.168.1.17', 'Se logeo al sistema', 'Login'),
(68, 'rchocm', '2020-04-05', '05:56:57', 'AMAZING', '192.168.1.17', 'Consulto bitacora', 'tbl_bitacora'),
(69, 'rchocm', '2020-04-05', '05:57:14', 'AMAZING', '192.168.1.17', 'Cerro sesion en el sistema', 'Login'),
(70, 'rchocm', '2020-04-11', '04:53:30', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(71, 'rchocm', '2020-04-11', '04:58:54', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(72, 'rchocm', '2020-04-11', '04:59:15', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'tbl_modulo'),
(73, 'rchocm', '2020-04-11', '05:05:08', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(74, 'rchocm', '2020-04-11', '05:05:29', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(75, 'rchocm', '2020-04-11', '05:07:13', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(76, 'rchocm', '2020-04-11', '05:12:13', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(77, 'rchocm', '2020-04-11', '05:12:34', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'bancos'),
(78, 'rchocm', '2020-04-11', '05:13:05', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'bancos'),
(79, 'rchocm', '2020-04-11', '05:19:39', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(80, 'rchocm', '2020-04-11', '06:22:26', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'clasificador_de_movimientos'),
(81, 'rchocm', '2020-04-11', '06:39:33', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'monedas'),
(82, 'rchocm', '2020-04-11', '06:41:18', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'cuentas_bancarias'),
(83, 'rchocm', '2020-04-11', '07:07:52', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'modulos'),
(84, 'rchocm', '2020-04-11', '07:08:05', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'modulos'),
(85, 'rchocm', '2020-04-11', '07:08:20', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'modulos'),
(86, 'rchocm', '2020-04-11', '07:08:35', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'modulos'),
(87, 'rchocm', '2020-04-11', '07:14:40', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'cuentas_bancarias'),
(88, 'rchocm', '2020-04-11', '07:14:48', 'AMAZING', '192.168.1.11', 'Se actualizó un registro', 'cuentas_bancarias'),
(89, 'rchocm', '2020-04-11', '07:14:55', 'AMAZING', '192.168.1.11', 'Se actualizó un registro', 'cuentas_bancarias'),
(90, 'rchocm', '2020-04-11', '07:19:56', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'cuentas_bancarias'),
(91, 'rchocm', '2020-04-11', '07:20:12', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'chequeras'),
(92, 'rchocm', '2020-04-12', '03:59:18', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(93, 'rchocm', '2020-04-12', '03:59:26', 'AMAZING', '192.168.1.11', 'Vio las partidas', 'Libro Diario'),
(94, 'rchocm', '2020-04-12', '04:00:28', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'modulos'),
(95, 'rchocm', '2020-04-12', '04:00:43', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'modulos'),
(96, 'rchocm', '2020-04-12', '04:00:53', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'modulos'),
(97, 'rchocm', '2020-04-12', '04:01:02', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'modulos'),
(98, 'rchocm', '2020-04-12', '04:01:24', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'monedas'),
(99, 'rchocm', '2020-04-12', '04:02:03', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'bancos'),
(100, 'rchocm', '2020-04-12', '04:02:17', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'bancos'),
(101, 'rchocm', '2020-04-12', '04:02:30', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'bancos'),
(102, 'rchocm', '2020-04-12', '04:03:16', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'cuentas_bancarias'),
(103, 'rchocm', '2020-04-12', '04:03:30', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'chequeras'),
(104, 'rchocm', '2020-04-14', '10:45:00', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(105, 'rchocm', '2020-04-14', '10:46:47', 'AMAZING', '192.168.1.11', 'Cerro sesion en el sistema', 'Login'),
(106, 'rchocm', '2020-04-15', '08:44:48', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(107, 'rchocm', '2020-04-15', '09:53:03', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(108, 'rchocm', '2020-04-15', '09:53:51', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(109, 'rchocm', '2020-04-15', '09:54:50', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(110, 'rchocm', '2020-04-15', '09:55:05', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(111, 'rchocm', '2020-04-15', '09:55:18', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(112, 'rchocm', '2020-04-15', '09:55:26', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(113, 'rchocm', '2020-04-15', '09:57:15', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(114, 'rchocm', '2020-04-16', '08:49:18', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(115, 'rchocm', '2020-04-17', '02:55:04', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'EMPLEADO'),
(116, 'rchocm', '2020-04-17', '02:56:57', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'CLIENTE'),
(117, 'rchocm', '2020-04-17', '02:57:40', 'AMAZING', '192.168.1.11', 'Se actualizó un registro', 'CLIENTE'),
(118, 'rchocm', '2020-04-17', '02:58:44', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'CLIENTE'),
(119, 'rchocm', '2020-04-17', '03:05:14', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'CATEGORIA'),
(120, 'rchocm', '2020-04-17', '03:05:20', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'CATEGORIA'),
(122, 'rchocm', '2020-04-17', '03:13:47', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'MORA'),
(123, 'rchocm', '2020-04-17', '03:13:56', 'AMAZING', '192.168.1.11', 'Se actualizó un registro', 'MORA'),
(124, 'rchocm', '2020-04-17', '03:23:32', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'MATERIAL'),
(125, 'rchocm', '2020-04-17', '03:25:14', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'MATERIAL'),
(126, 'rchocm', '2020-04-17', '03:25:44', 'AMAZING', '192.168.1.11', 'Se actualizó un registro', 'MATERIAL'),
(127, 'rchocm', '2020-04-17', '03:33:11', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'BONO'),
(128, 'rchocm', '2020-04-17', '04:16:03', 'AMAZING', '192.168.1.11', 'Se actualizó un registro', 'MATERIAL'),
(129, 'rchocm', '2020-04-17', '04:16:10', 'AMAZING', '192.168.1.11', 'Se actualizó un registro', 'MATERIAL'),
(130, 'rchocm', '2020-04-17', '04:18:23', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(131, 'rchocm', '2020-04-17', '08:01:39', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'MATERIAL'),
(132, 'rchocm', '2020-04-17', '08:03:50', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'EMPLEADO'),
(133, 'rchocm', '2020-04-17', '08:04:39', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'CLIENTE'),
(134, 'rchocm', '2020-04-17', '09:17:26', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'CLIENTE'),
(135, 'rchocm', '2020-04-17', '09:32:29', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(136, 'rchocm', '2020-04-17', '09:34:33', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(137, 'rchocm', '2020-04-17', '09:38:29', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(138, 'rchocm', '2020-04-17', '09:39:48', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'CLIENTE'),
(139, 'rchocm', '2020-04-17', '09:40:06', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'EMPLEADO'),
(140, 'rchocm', '2020-04-17', '09:41:05', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'MATERIAL'),
(141, 'rchocm', '2020-04-17', '09:43:26', 'AMAZING', '192.168.1.11', 'Consulto bitacora', 'tbl_bitacora'),
(142, 'rchocm', '2020-04-17', '09:43:46', 'AMAZING', '192.168.1.11', 'Cerro sesion en el sistema', 'Login'),
(143, 'rchocm', '2020-04-18', '07:32:29', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(144, 'rchocm', '2020-04-18', '07:33:03', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(145, 'rchocm', '2020-04-18', '07:33:35', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(146, 'rchocm', '2020-04-19', '11:31:59', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'modulos'),
(147, 'rchocm', '2020-04-20', '01:36:30', 'AMAZING', '192.168.1.11', 'Se actualizó un registro', 'modulos'),
(148, 'rchocm', '2020-04-20', '01:37:02', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'cuentas_bancarias'),
(149, 'rchocm', '2020-04-20', '10:11:03', 'AMAZING', '192.168.1.2', 'Se creó un nuevo registro', 'bancos'),
(150, 'rchocm', '2020-04-20', '10:12:42', 'AMAZING', '192.168.1.2', 'Se creó un nuevo registro', 'cuentas_bancarias'),
(151, 'rchocm', '2020-04-20', '11:15:24', 'AMAZING', '192.168.1.2', 'Se creó un nuevo registro', 'cuentas_bancarias'),
(152, 'rchocm', '2020-04-20', '11:25:06', 'AMAZING', '192.168.1.2', 'Se creó un nuevo registro', 'cuentas_bancarias'),
(153, 'rchocm', '2020-04-22', '09:54:51', 'AMAZING', '192.168.1.2', 'Se creó un nuevo registro', 'concepto'),
(154, 'rchocm', '2020-04-22', '09:55:00', 'AMAZING', '192.168.1.2', 'Se actualizó un registro', 'concepto'),
(155, 'rchocm', '2020-04-22', '10:04:39', 'AMAZING', '192.168.1.2', 'Se creó un nuevo registro', 'departamento'),
(156, 'rchocm', '2020-04-22', '10:17:00', 'AMAZING', '192.168.1.2', 'Se creó un nuevo registro', 'empleado'),
(157, 'rchocm', '2020-04-22', '10:24:56', 'AMAZING', '192.168.1.2', 'Se creó un nuevo registro', 'puesto'),
(158, 'rchocm', '2020-04-22', '10:25:38', 'AMAZING', '192.168.1.2', 'Se creó un nuevo registro', 'empleado'),
(159, 'rchocm', '2020-04-22', '12:55:35', 'AMAZING', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(160, 'rchocm', '2020-04-22', '01:00:19', 'AMAZING', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(161, 'rchocm', '2020-04-22', '01:03:09', 'AMAZING', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(162, 'rchocm', '2020-04-22', '01:03:48', 'AMAZING', '192.168.1.2', 'Se creó un nuevo registro', 'departamento'),
(163, 'rchocm', '2020-04-22', '01:04:33', 'AMAZING', '192.168.1.2', 'Se creó un nuevo registro', 'empleado'),
(164, 'rchocm', '2020-04-22', '01:07:59', 'AMAZING', '192.168.1.2', 'Consulto bitacora', 'tbl_bitacora'),
(165, 'rchocm', '2020-04-23', '12:39:19', 'AMAZING', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(166, 'rchocm', '2020-04-23', '12:39:55', 'AMAZING', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(167, 'rchocm', '2020-04-23', '12:50:38', 'AMAZING', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(168, 'rchocm', '2020-04-24', '01:33:58', 'AMAZING', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(169, 'rchocm', '2020-04-24', '01:39:46', 'AMAZING', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(170, 'rchocm', '2020-04-24', '11:08:49', 'AMAZING', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(171, 'rchocm', '2020-04-28', '06:41:00', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(172, 'rchocm', '2020-04-28', '06:42:11', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(173, 'rchocm', '2020-04-28', '06:42:40', 'AMAZING', '192.168.1.14', 'Consulto bitacora', 'tbl_bitacora'),
(174, 'rchocm', '2020-04-28', '06:44:03', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(175, 'rchocm', '2020-04-28', '06:50:29', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(176, 'rchocm', '2020-04-28', '06:55:00', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(177, 'rchocm', '2020-04-28', '07:02:59', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(178, 'rchocm', '2020-04-28', '07:03:30', 'AMAZING', '192.168.1.14', 'Consulto bitacora', 'tbl_bitacora'),
(179, 'rchocm', '2020-04-28', '07:54:15', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(180, 'rchocm', '2020-04-28', '08:06:03', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(181, 'rchocm', '2020-04-28', '08:06:31', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'puesto'),
(182, 'rchocm', '2020-04-28', '08:13:22', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(183, 'rchocm', '2020-04-28', '08:18:15', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(184, 'rchocm', '2020-04-28', '08:19:10', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(185, 'rchocm', '2020-04-28', '11:47:25', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(186, 'rchocm', '2020-04-29', '11:53:50', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(187, 'rchocm', '2020-04-29', '11:54:28', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'concepto'),
(188, 'rchocm', '2020-04-29', '11:54:56', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'departamento'),
(189, 'rchocm', '2020-04-29', '11:55:33', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'puesto'),
(190, 'rchocm', '2020-04-29', '11:55:50', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'puesto'),
(191, 'rchocm', '2020-04-29', '11:56:14', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'empleado'),
(192, 'rchocm', '2020-04-29', '11:56:36', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'empleado'),
(193, 'rchocm', '2020-04-29', '11:56:59', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'empleado'),
(194, 'RCHOCM', '2020-04-29', '12:00:43', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(195, 'RCHOCM', '2020-04-29', '12:01:30', 'AMAZING', '192.168.1.14', 'Consulto bitacora', 'tbl_bitacora'),
(196, 'rchocm', '2020-05-02', '07:51:07', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'cuentas_bancarias'),
(197, 'rchocm', '2020-05-02', '08:53:49', 'AMAZING', '192.168.1.14', 'Se eliminó un registro', 'cuentas_bancarias'),
(198, 'rchocm', '2020-05-02', '09:20:18', 'AMAZING', '192.168.1.14', 'Se eliminó un registro', 'cuentas_bancarias'),
(199, 'rchocm', '2020-05-08', '08:25:49', 'AMAZING', '192.168.1.8', 'Se creó un nuevo registro', 'monedas'),
(200, 'rchocm', '2020-05-08', '08:51:03', 'AMAZING', '192.168.1.8', 'Se actualizó un registro', 'cuentas_bancarias'),
(201, 'rchocm', '2020-05-11', '09:28:41', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(202, 'rchocm', '2020-05-11', '09:31:32', 'AMAZING', '192.168.1.14', 'Realizo una consulta a modulos', 'tbl_modulos'),
(203, 'ligia', '2020-05-11', '09:32:01', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(204, 'ligia', '2020-05-11', '09:47:22', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(205, 'ligia', '2020-05-11', '10:03:32', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(206, 'rchocm', '2020-05-11', '10:07:12', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(207, 'rchocm', '2020-05-18', '08:48:43', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(208, 'rchocm', '2020-05-18', '08:54:29', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(209, 'rchocm', '2020-05-18', '08:57:17', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(210, 'rchocm', '2020-05-18', '09:10:33', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(211, 'rchocm', '2020-05-18', '09:16:26', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(212, 'rchocm', '2020-05-18', '09:16:37', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(213, 'rchocm', '2020-05-18', '09:22:50', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(214, 'rchocm', '2020-05-18', '09:39:28', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(215, 'rchocm', '2020-05-18', '09:42:12', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'monedas'),
(216, 'rchocm', '2020-05-18', '09:42:54', 'AMAZING', '192.168.1.11', 'Se eliminó un registro', 'monedas'),
(217, 'rchocm', '2020-05-18', '11:45:22', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(218, 'rchocm', '2020-05-18', '11:50:07', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(219, 'rchocm', '2020-05-18', '11:50:39', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(220, 'rchocm', '2020-05-18', '11:55:51', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(221, 'rchocm', '2020-05-18', '11:56:45', 'AMAZING', '192.168.1.10', 'Se logeo al sistema', 'Login'),
(222, 'rchocm', '2020-05-18', '11:59:26', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(223, 'rchocm', '2020-05-18', '12:10:08', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(224, 'rchocm', '2020-05-18', '12:12:48', 'AMAZING', '192.168.1.16', 'Se actualizó un registro', 'monedas'),
(225, 'rchocm', '2020-05-18', '12:13:18', 'AMAZING', '192.168.1.11', 'Se creó un nuevo registro', 'monedas'),
(226, 'rchocm', '2020-05-19', '12:22:22', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(227, 'rchocm', '2020-05-19', '05:30:16', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(228, 'rchocm', '2020-05-19', '06:16:47', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login'),
(229, 'rchocm', '2020-05-19', '06:19:42', 'AMAZING', '192.168.1.11', 'Se logeo al sistema', 'Login');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_modulo`
--

CREATE TABLE `tbl_modulo` (
  `PK_id_Modulo` int(11) NOT NULL,
  `nombre_modulo` varchar(45) DEFAULT NULL,
  `descripcion_modulo` varchar(200) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_modulo`
--

INSERT INTO `tbl_modulo` (`PK_id_Modulo`, `nombre_modulo`, `descripcion_modulo`, `estado`) VALUES
(1, 'FRM', 'FRM - Gustavo - Randy', 1),
(2, 'SCM', 'SCM - Ligia', 1),
(3, 'MRP', 'MRP - Edgar', 1),
(4, 'CRM', 'CRM - Victor', 1),
(5, 'HRM', 'HRM - Juan', 1),
(6, 'prueba', 'solo para comparar', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfil_detalle`
--

CREATE TABLE `tbl_perfil_detalle` (
  `PK_id_perfil` int(11) NOT NULL,
  `PK_id_aplicacion` int(11) NOT NULL,
  `ingresar` tinyint(4) DEFAULT NULL,
  `consultar` tinyint(4) DEFAULT NULL,
  `modificar` tinyint(4) DEFAULT NULL,
  `eliminar` tinyint(4) DEFAULT NULL,
  `imprimir` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_perfil_detalle`
--

INSERT INTO `tbl_perfil_detalle` (`PK_id_perfil`, `PK_id_aplicacion`, `ingresar`, `consultar`, `modificar`, `eliminar`, `imprimir`) VALUES
(1, 1, 1, 1, 1, 1, 1),
(1, 2, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfil_encabezado`
--

CREATE TABLE `tbl_perfil_encabezado` (
  `PK_id_perfil` int(11) NOT NULL,
  `nombre_perfil` varchar(45) DEFAULT NULL,
  `descripcion_perfil` varchar(200) DEFAULT NULL,
  `estado_perfil` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_perfil_encabezado`
--

INSERT INTO `tbl_perfil_encabezado` (`PK_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'admin', 'administrador', 1),
(2, 'operador', 'Operador', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario`
--

CREATE TABLE `tbl_usuario` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `nombre_usuario` varchar(45) DEFAULT NULL,
  `apellido_usuarios` varchar(45) DEFAULT NULL,
  `password_usuario` varchar(45) DEFAULT NULL,
  `cambio_contrasena` tinyint(4) DEFAULT NULL,
  `estado_usuario` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_usuario`
--

INSERT INTO `tbl_usuario` (`PK_id_usuario`, `nombre_usuario`, `apellido_usuarios`, `password_usuario`, `cambio_contrasena`, `estado_usuario`) VALUES
('ligia', 'Ligia', 'Abril', 'f1c1592588411002af340cbaedd6fc33', 0, 1),
('MiUsuario', 'Usuario', 'Prueba', 'e19d5cd5af0378da05f63f891c7467af', 0, 1),
('rchocm', 'Randy', 'Choc', 'f1c1592588411002af340cbaedd6fc33', 0, 1);

--
-- Disparadores `tbl_usuario`
--
DELIMITER $$
CREATE TRIGGER `actualizarClave` BEFORE UPDATE ON `tbl_usuario` FOR EACH ROW IF NEW.password_usuario <> OLD.password_usuario THEN
SET NEW.password_usuario = MD5(NEW.password_usuario);
END IF
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `encriptarClave` BEFORE INSERT ON `tbl_usuario` FOR EACH ROW BEGIN
SET NEW.password_usuario = MD5(NEW.password_usuario);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario_aplicacion`
--

CREATE TABLE `tbl_usuario_aplicacion` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_aplicacion` int(11) NOT NULL,
  `ingresar` tinyint(4) DEFAULT NULL,
  `consultar` tinyint(4) DEFAULT NULL,
  `modificar` tinyint(4) DEFAULT NULL,
  `eliminar` tinyint(4) DEFAULT NULL,
  `imprimir` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario_perfil`
--

CREATE TABLE `tbl_usuario_perfil` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_usuario_perfil`
--

INSERT INTO `tbl_usuario_perfil` (`PK_id_usuario`, `PK_id_perfil`) VALUES
('rchocm', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbl_aplicacion`
--
ALTER TABLE `tbl_aplicacion`
  ADD PRIMARY KEY (`PK_id_aplicacion`,`PK_id_modulo`),
  ADD KEY `fk_Aplicacion_Modulo` (`PK_id_modulo`);

--
-- Indices de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD PRIMARY KEY (`PK_id_bitacora`,`PK_id_usuario`),
  ADD KEY `fk_Bitacora_Usuario1` (`PK_id_usuario`);

--
-- Indices de la tabla `tbl_modulo`
--
ALTER TABLE `tbl_modulo`
  ADD PRIMARY KEY (`PK_id_Modulo`);

--
-- Indices de la tabla `tbl_perfil_detalle`
--
ALTER TABLE `tbl_perfil_detalle`
  ADD PRIMARY KEY (`PK_id_perfil`,`PK_id_aplicacion`),
  ADD KEY `fk_Perfil_detalle_Aplicacion1` (`PK_id_aplicacion`);

--
-- Indices de la tabla `tbl_perfil_encabezado`
--
ALTER TABLE `tbl_perfil_encabezado`
  ADD PRIMARY KEY (`PK_id_perfil`);

--
-- Indices de la tabla `tbl_usuario`
--
ALTER TABLE `tbl_usuario`
  ADD PRIMARY KEY (`PK_id_usuario`);

--
-- Indices de la tabla `tbl_usuario_aplicacion`
--
ALTER TABLE `tbl_usuario_aplicacion`
  ADD PRIMARY KEY (`PK_id_usuario`,`PK_id_aplicacion`),
  ADD KEY `fk_tbl_usuario_aplicacion_tbl_aplicacion1` (`PK_id_aplicacion`);

--
-- Indices de la tabla `tbl_usuario_perfil`
--
ALTER TABLE `tbl_usuario_perfil`
  ADD PRIMARY KEY (`PK_id_usuario`,`PK_id_perfil`),
  ADD KEY `fk_Usuario_perfil_Perfil1` (`PK_id_perfil`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  MODIFY `PK_id_bitacora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=230;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_aplicacion`
--
ALTER TABLE `tbl_aplicacion`
  ADD CONSTRAINT `fk_Aplicacion_Modulo` FOREIGN KEY (`PK_id_modulo`) REFERENCES `tbl_modulo` (`PK_id_Modulo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD CONSTRAINT `fk_Bitacora_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_perfil_detalle`
--
ALTER TABLE `tbl_perfil_detalle`
  ADD CONSTRAINT `fk_Perfil_detalle_Aplicacion1` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Perfil_detalle_Perfil1` FOREIGN KEY (`PK_id_perfil`) REFERENCES `tbl_perfil_encabezado` (`PK_id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_usuario_aplicacion`
--
ALTER TABLE `tbl_usuario_aplicacion`
  ADD CONSTRAINT `fk_Usuario_aplicacion_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tbl_usuario_aplicacion_tbl_aplicacion1` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_usuario_perfil`
--
ALTER TABLE `tbl_usuario_perfil`
  ADD CONSTRAINT `fk_Usuario_perfil_Perfil1` FOREIGN KEY (`PK_id_perfil`) REFERENCES `tbl_perfil_encabezado` (`PK_id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Usuario_perfil_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
