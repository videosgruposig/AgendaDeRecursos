-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.6.27-log


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema educacion
--

CREATE DATABASE IF NOT EXISTS educacion;
USE educacion;

--
-- Definition of table `agenda`
--

DROP TABLE IF EXISTS `agenda`;
CREATE TABLE `agenda` (
  `idAgenda` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`idAgenda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `agenda`
--

/*!40000 ALTER TABLE `agenda` DISABLE KEYS */;
/*!40000 ALTER TABLE `agenda` ENABLE KEYS */;


--
-- Definition of table `agendaambiente`
--

DROP TABLE IF EXISTS `agendaambiente`;
CREATE TABLE `agendaambiente` (
  `idAgendaAmbiente` int(11) NOT NULL AUTO_INCREMENT,
  `FechaDesde` datetime DEFAULT NULL,
  `FechaHasta` datetime DEFAULT NULL,
  `Observaciones` varchar(45) DEFAULT NULL,
  `DistribucionPorCargo_idDistribucionPorCargo` int(11) NOT NULL,
  `Ambiente_idAmbiente` int(11) NOT NULL,
  PRIMARY KEY (`idAgendaAmbiente`,`DistribucionPorCargo_idDistribucionPorCargo`,`Ambiente_idAmbiente`),
  KEY `fk_AgendaAmbiente_DistribucionPorCargo1_idx` (`DistribucionPorCargo_idDistribucionPorCargo`),
  KEY `fk_AgendaAmbiente_Ambiente1_idx` (`Ambiente_idAmbiente`),
  CONSTRAINT `fk_AgendaAmbiente_Ambiente1` FOREIGN KEY (`Ambiente_idAmbiente`) REFERENCES `ambiente` (`idAmbiente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_AgendaAmbiente_DistribucionPorCargo1` FOREIGN KEY (`DistribucionPorCargo_idDistribucionPorCargo`) REFERENCES `distribucionporcargo` (`idDistribucionPorCargo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `agendaambiente`
--

/*!40000 ALTER TABLE `agendaambiente` DISABLE KEYS */;
/*!40000 ALTER TABLE `agendaambiente` ENABLE KEYS */;


--
-- Definition of table `agrupaciones`
--

DROP TABLE IF EXISTS `agrupaciones`;
CREATE TABLE `agrupaciones` (
  `idAgrupaciones` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Las Agrupaciones son por ejemplo "Primer A??o", "Segundo A??o", etc.',
  `Nombre` varchar(45) DEFAULT NULL,
  `EstructuraCurricular_idEstructuraCurricular` int(11) NOT NULL,
  PRIMARY KEY (`idAgrupaciones`,`EstructuraCurricular_idEstructuraCurricular`),
  KEY `fk_Agrupaciones_EstructuraCurricular1_idx` (`EstructuraCurricular_idEstructuraCurricular`),
  CONSTRAINT `fk_Agrupaciones_EstructuraCurricular1` FOREIGN KEY (`EstructuraCurricular_idEstructuraCurricular`) REFERENCES `estructuracurricular` (`idEstructuraCurricular`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `agrupaciones`
--

/*!40000 ALTER TABLE `agrupaciones` DISABLE KEYS */;
INSERT INTO `agrupaciones` (`idAgrupaciones`,`Nombre`,`EstructuraCurricular_idEstructuraCurricular`) VALUES 
 (1,'Primer A??o',1),
 (2,'Segundo A??o',2),
 (3,'Tercero',1),
 (4,'Primer A??o',2),
 (5,'Segundo',2);
/*!40000 ALTER TABLE `agrupaciones` ENABLE KEYS */;


--
-- Definition of table `ambiente`
--

DROP TABLE IF EXISTS `ambiente`;
CREATE TABLE `ambiente` (
  `idAmbiente` int(11) NOT NULL AUTO_INCREMENT,
  `EstadoConservacion` varchar(45) DEFAULT NULL,
  `Observaciones` varchar(45) DEFAULT NULL,
  `Superficiemt2` int(11) DEFAULT NULL,
  `TipoCubierta` varchar(45) DEFAULT NULL,
  `Nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`idAmbiente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `ambiente`
--

/*!40000 ALTER TABLE `ambiente` DISABLE KEYS */;
/*!40000 ALTER TABLE `ambiente` ENABLE KEYS */;


--
-- Definition of table `cargoporestablecimiento`
--

DROP TABLE IF EXISTS `cargoporestablecimiento`;
CREATE TABLE `cargoporestablecimiento` (
  `idCargoPorEstablecimiento` int(11) NOT NULL AUTO_INCREMENT,
  `NomencladorCargosPOF_idNomencladorCargosPOF` int(11) NOT NULL,
  `UnidadEducativa_idUnidadEducativa` int(11) NOT NULL,
  `DistribucionPorCargo_idDistribucionPorCargo` int(11) NOT NULL,
  PRIMARY KEY (`idCargoPorEstablecimiento`,`NomencladorCargosPOF_idNomencladorCargosPOF`,`UnidadEducativa_idUnidadEducativa`,`DistribucionPorCargo_idDistribucionPorCargo`),
  KEY `fk_CargoPorEstablecimiento_NomencladorCargosPOF1_idx` (`NomencladorCargosPOF_idNomencladorCargosPOF`),
  KEY `fk_CargoPorEstablecimiento_UnidadEducativa1_idx` (`UnidadEducativa_idUnidadEducativa`),
  KEY `fk_CargoPorEstablecimiento_DistribucionPorCargo1_idx` (`DistribucionPorCargo_idDistribucionPorCargo`),
  CONSTRAINT `fk_CargoPorEstablecimiento_DistribucionPorCargo1` FOREIGN KEY (`DistribucionPorCargo_idDistribucionPorCargo`) REFERENCES `distribucionporcargo` (`idDistribucionPorCargo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CargoPorEstablecimiento_NomencladorCargosPOF1` FOREIGN KEY (`NomencladorCargosPOF_idNomencladorCargosPOF`) REFERENCES `nomencladorcargospof` (`idNomencladorCargosPOF`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CargoPorEstablecimiento_UnidadEducativa1` FOREIGN KEY (`UnidadEducativa_idUnidadEducativa`) REFERENCES `unidadeducativa` (`idUnidadEducativa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cargoporestablecimiento`
--

/*!40000 ALTER TABLE `cargoporestablecimiento` DISABLE KEYS */;
/*!40000 ALTER TABLE `cargoporestablecimiento` ENABLE KEYS */;


--
-- Definition of table `cursoseccion`
--

DROP TABLE IF EXISTS `cursoseccion`;
CREATE TABLE `cursoseccion` (
  `idCursoSeccion` int(11) NOT NULL AUTO_INCREMENT,
  `AliasCurso` varchar(45) DEFAULT NULL,
  `AliasDivision` varchar(45) DEFAULT NULL,
  `Curso` varchar(45) NOT NULL,
  `Division` varchar(45) NOT NULL,
  `FechaCreacion` datetime DEFAULT NULL,
  `InstrumentoLegal` varchar(45) DEFAULT NULL,
  `Matricula` varchar(45) DEFAULT NULL,
  `MotivoCreacion` varchar(45) DEFAULT NULL,
  `Observaciones` varchar(45) DEFAULT NULL,
  `TipoInstrumentoLegal` varchar(45) DEFAULT NULL,
  `Turno` varchar(45) DEFAULT NULL,
  `Agrupaciones_idAgrupaciones` int(11) NOT NULL,
  PRIMARY KEY (`idCursoSeccion`,`Agrupaciones_idAgrupaciones`),
  KEY `fk_CursoSeccion_Agrupaciones1_idx` (`Agrupaciones_idAgrupaciones`),
  CONSTRAINT `fk_CursoSeccion_Agrupaciones1` FOREIGN KEY (`Agrupaciones_idAgrupaciones`) REFERENCES `agrupaciones` (`idAgrupaciones`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cursoseccion`
--

/*!40000 ALTER TABLE `cursoseccion` DISABLE KEYS */;
INSERT INTO `cursoseccion` (`idCursoSeccion`,`AliasCurso`,`AliasDivision`,`Curso`,`Division`,`FechaCreacion`,`InstrumentoLegal`,`Matricula`,`MotivoCreacion`,`Observaciones`,`TipoInstrumentoLegal`,`Turno`,`Agrupaciones_idAgrupaciones`) VALUES 
 (2,'','','1','A','2015-11-12 00:00:00','1829/8','25','Motivo','Obs.','Resolucion','Ma??ana',1),
 (3,NULL,NULL,'1','B','2015-11-12 00:00:00','1298/9','22','Motivo','Obs.','Decreto','Ma??ana',1),
 (11,'','','1','C','2015-11-17 10:00:24','','','','','','Ma??ana',1),
 (16,'','','1','A','2015-11-17 12:06:49','','','','','','Noche',4),
 (17,'','','1','B','2015-11-17 12:07:09','','','','','','Ma??ana',4),
 (18,'','','2','17vo','2015-11-17 21:22:03','','','','','','Noche',5),
 (20,'SegundoPeritoMercantil','Aula Azul','2','B','2015-11-19 14:10:18','343','1234','N/A','afdasdf','Ley','Ma??ana',2),
 (21,'Segundo','Sala Gris','2','4ta','2015-10-27 20:51:54','324','1324','N/A','Observaciones','Resoluci??n','Noche',2),
 (22,'Primero','El ??ltimo','1','Y','2015-11-19 20:30:48','234','21','N/A','df','Resoluci??n','Vespertino',4),
 (26,'','','3','B','2015-11-20 14:00:27','','','','','','Ma??ana',3);
/*!40000 ALTER TABLE `cursoseccion` ENABLE KEYS */;


--
-- Definition of table `dia`
--

DROP TABLE IF EXISTS `dia`;
CREATE TABLE `dia` (
  `idDia` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`idDia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `dia`
--

/*!40000 ALTER TABLE `dia` DISABLE KEYS */;
/*!40000 ALTER TABLE `dia` ENABLE KEYS */;


--
-- Definition of table `distribucionporcargo`
--

DROP TABLE IF EXISTS `distribucionporcargo`;
CREATE TABLE `distribucionporcargo` (
  `idDistribucionPorCargo` int(11) NOT NULL AUTO_INCREMENT,
  `FechaVinculo` datetime DEFAULT NULL,
  `FechaDesvinculo` datetime DEFAULT NULL,
  `CursoSeccion_idCursoSeccion` int(11) NOT NULL,
  `CursoSeccion_Agrupaciones_idAgrupaciones` int(11) NOT NULL,
  PRIMARY KEY (`idDistribucionPorCargo`,`CursoSeccion_idCursoSeccion`,`CursoSeccion_Agrupaciones_idAgrupaciones`),
  KEY `fk_DistribucionPorCargo_CursoSeccion1_idx` (`CursoSeccion_idCursoSeccion`,`CursoSeccion_Agrupaciones_idAgrupaciones`),
  CONSTRAINT `fk_DistribucionPorCargo_CursoSeccion1` FOREIGN KEY (`CursoSeccion_idCursoSeccion`, `CursoSeccion_Agrupaciones_idAgrupaciones`) REFERENCES `cursoseccion` (`idCursoSeccion`, `Agrupaciones_idAgrupaciones`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `distribucionporcargo`
--

/*!40000 ALTER TABLE `distribucionporcargo` DISABLE KEYS */;
/*!40000 ALTER TABLE `distribucionporcargo` ENABLE KEYS */;


--
-- Definition of table `estructuracurricular`
--

DROP TABLE IF EXISTS `estructuracurricular`;
CREATE TABLE `estructuracurricular` (
  `idEstructuraCurricular` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) DEFAULT NULL,
  `PlanDeEstudio_idPlanDeEstudio` int(11) NOT NULL,
  PRIMARY KEY (`idEstructuraCurricular`,`PlanDeEstudio_idPlanDeEstudio`),
  KEY `fk_EstructuraCurricular_PlanDeEstudio1_idx` (`PlanDeEstudio_idPlanDeEstudio`),
  CONSTRAINT `fk_EstructuraCurricular_PlanDeEstudio1` FOREIGN KEY (`PlanDeEstudio_idPlanDeEstudio`) REFERENCES `plandeestudio` (`idPlanDeEstudio`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `estructuracurricular`
--

/*!40000 ALTER TABLE `estructuracurricular` DISABLE KEYS */;
INSERT INTO `estructuracurricular` (`idEstructuraCurricular`,`Nombre`,`PlanDeEstudio_idPlanDeEstudio`) VALUES 
 (1,'??nica',1),
 (2,'??nica',2);
/*!40000 ALTER TABLE `estructuracurricular` ENABLE KEYS */;


--
-- Definition of table `horarios`
--

DROP TABLE IF EXISTS `horarios`;
CREATE TABLE `horarios` (
  `idHorarios` int(11) NOT NULL AUTO_INCREMENT,
  `HoraDesde` datetime DEFAULT NULL,
  `HoraHasta` datetime DEFAULT NULL,
  `Dia_idDia` int(11) NOT NULL,
  `AgendaAmbiente_idAgendaAmbiente` int(11) NOT NULL,
  PRIMARY KEY (`idHorarios`,`Dia_idDia`,`AgendaAmbiente_idAgendaAmbiente`),
  KEY `fk_Horarios_Dia_idx` (`Dia_idDia`),
  KEY `fk_Horarios_AgendaAmbiente1_idx` (`AgendaAmbiente_idAgendaAmbiente`),
  CONSTRAINT `fk_Horarios_AgendaAmbiente1` FOREIGN KEY (`AgendaAmbiente_idAgendaAmbiente`) REFERENCES `agendaambiente` (`idAgendaAmbiente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Horarios_Dia` FOREIGN KEY (`Dia_idDia`) REFERENCES `dia` (`idDia`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `horarios`
--

/*!40000 ALTER TABLE `horarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `horarios` ENABLE KEYS */;


--
-- Definition of table `instanciadecurso`
--

DROP TABLE IF EXISTS `instanciadecurso`;
CREATE TABLE `instanciadecurso` (
  `idInstanciaDeCurso` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) NOT NULL COMMENT 'Ejemplo "Ciclo Lectivo 2013"',
  `Fecha` datetime NOT NULL,
  `CursoSeccion_idCursoSeccion` int(11) NOT NULL,
  PRIMARY KEY (`idInstanciaDeCurso`,`CursoSeccion_idCursoSeccion`),
  KEY `fk_InstanciaDeCurso_CursoSeccion1_idx` (`CursoSeccion_idCursoSeccion`),
  CONSTRAINT `fk_InstanciaDeCurso_CursoSeccion1` FOREIGN KEY (`CursoSeccion_idCursoSeccion`) REFERENCES `cursoseccion` (`idCursoSeccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `instanciadecurso`
--

/*!40000 ALTER TABLE `instanciadecurso` DISABLE KEYS */;
/*!40000 ALTER TABLE `instanciadecurso` ENABLE KEYS */;


--
-- Definition of table `materiaasociada`
--

DROP TABLE IF EXISTS `materiaasociada`;
CREATE TABLE `materiaasociada` (
  `idMateriaAsociada` int(11) NOT NULL AUTO_INCREMENT,
  `HoraRelojReal` int(11) NOT NULL,
  `TiempoDeCursada` varchar(45) NOT NULL COMMENT '"Anual, Cuatrimestral, Trimestral"',
  `Agrupaciones_idAgrupaciones` int(11) NOT NULL,
  `Materias_idMaterias` int(11) NOT NULL,
  PRIMARY KEY (`idMateriaAsociada`,`Agrupaciones_idAgrupaciones`,`Materias_idMaterias`),
  KEY `fk_MateriaAsociada_Agrupaciones1_idx` (`Agrupaciones_idAgrupaciones`),
  KEY `fk_MateriaAsociada_Materias1_idx` (`Materias_idMaterias`),
  CONSTRAINT `fk_MateriaAsociada_Agrupaciones1` FOREIGN KEY (`Agrupaciones_idAgrupaciones`) REFERENCES `agrupaciones` (`idAgrupaciones`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_MateriaAsociada_Materias1` FOREIGN KEY (`Materias_idMaterias`) REFERENCES `materias` (`idMaterias`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `materiaasociada`
--

/*!40000 ALTER TABLE `materiaasociada` DISABLE KEYS */;
INSERT INTO `materiaasociada` (`idMateriaAsociada`,`HoraRelojReal`,`TiempoDeCursada`,`Agrupaciones_idAgrupaciones`,`Materias_idMaterias`) VALUES 
 (1,120,'Trimestral',1,5),
 (5,234,'Cuatrimestral',1,8);
/*!40000 ALTER TABLE `materiaasociada` ENABLE KEYS */;


--
-- Definition of table `materias`
--

DROP TABLE IF EXISTS `materias`;
CREATE TABLE `materias` (
  `idMaterias` int(11) NOT NULL AUTO_INCREMENT,
  `Alias` varchar(45) DEFAULT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Ciclo` varchar(45) DEFAULT NULL COMMENT 'Por ejemplo "Tercer Ciclo"... a efectos practicos sera "Unico"',
  `Contenido` varchar(45) DEFAULT NULL,
  `InstrumentoLegal` varchar(45) DEFAULT NULL,
  `Nivel` varchar(45) DEFAULT NULL COMMENT 'Por Ejemplo EGB (Para propositos practicos en una primera instancia sera "Unico")',
  `NucleoDisciplinaAfin` varchar(45) DEFAULT NULL COMMENT 'Por ejemplo para "Matem??ticas I" puede ser "Matem??ticas y Tenolog??a"',
  `TipoInstrumentoLegal` varchar(45) DEFAULT NULL,
  `CargaHorariaSugeridaHsReloj` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idMaterias`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `materias`
--

/*!40000 ALTER TABLE `materias` DISABLE KEYS */;
INSERT INTO `materias` (`idMaterias`,`Alias`,`Nombre`,`Ciclo`,`Contenido`,`InstrumentoLegal`,`Nivel`,`NucleoDisciplinaAfin`,`TipoInstrumentoLegal`,`CargaHorariaSugeridaHsReloj`) VALUES 
 (5,'Matem??ticas I','Matem??ticas I','??nico',NULL,'1234/1','??nico','Matem??tica y tecnolog??a','Ley','160'),
 (6,'Matem??tica II','Matem??tica II','??nico',NULL,'123/2','??nico','Matem??tica y tecnolog??a','Ley','160'),
 (7,'Matem??tica III','Matem??tica III','??nico',NULL,'323/2','??nico','Matem??tica y tecnolog??a','Ley','160'),
 (8,'Lengua I','Lengua I ','??nico',NULL,'234/2','??nico','Ciencias B??sicas','Ley','210'),
 (9,'Lengua II','Lengua II','??nico',NULL,'234/2','??nico','Ciencias B??sicas','Ley','210'),
 (10,'Lengua III','Lengua III','??nico',NULL,'134/2','??nico','Ciencias B??sicas','Ley','210');
/*!40000 ALTER TABLE `materias` ENABLE KEYS */;


--
-- Definition of table `nomencladorcargospof`
--

DROP TABLE IF EXISTS `nomencladorcargospof`;
CREATE TABLE `nomencladorcargospof` (
  `idNomencladorCargosPOF` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idNomencladorCargosPOF`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `nomencladorcargospof`
--

/*!40000 ALTER TABLE `nomencladorcargospof` DISABLE KEYS */;
INSERT INTO `nomencladorcargospof` (`idNomencladorCargosPOF`,`Descripcion`) VALUES 
 (1,'Profesor Hora Catedra'),
 (2,'Maestra de Grado');
/*!40000 ALTER TABLE `nomencladorcargospof` ENABLE KEYS */;


--
-- Definition of table `plandeestudio`
--

DROP TABLE IF EXISTS `plandeestudio`;
CREATE TABLE `plandeestudio` (
  `idPlanDeEstudio` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) DEFAULT NULL,
  `UnidadEducativa_idUnidadEducativa` int(11) NOT NULL,
  PRIMARY KEY (`idPlanDeEstudio`,`UnidadEducativa_idUnidadEducativa`),
  KEY `fk_PlanDeEstudio_UnidadEducativa1_idx` (`UnidadEducativa_idUnidadEducativa`),
  CONSTRAINT `fk_PlanDeEstudio_UnidadEducativa1` FOREIGN KEY (`UnidadEducativa_idUnidadEducativa`) REFERENCES `unidadeducativa` (`idUnidadEducativa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `plandeestudio`
--

/*!40000 ALTER TABLE `plandeestudio` DISABLE KEYS */;
INSERT INTO `plandeestudio` (`idPlanDeEstudio`,`Descripcion`,`UnidadEducativa_idUnidadEducativa`) VALUES 
 (1,'Plan de Estudio Perito Mercantil',1),
 (2,'T??cnico en Computaci??n',2);
/*!40000 ALTER TABLE `plandeestudio` ENABLE KEYS */;


--
-- Definition of table `recurso`
--

DROP TABLE IF EXISTS `recurso`;
CREATE TABLE `recurso` (
  `idRecurso` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idRecurso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `recurso`
--

/*!40000 ALTER TABLE `recurso` DISABLE KEYS */;
/*!40000 ALTER TABLE `recurso` ENABLE KEYS */;


--
-- Definition of table `recursosxagenda`
--

DROP TABLE IF EXISTS `recursosxagenda`;
CREATE TABLE `recursosxagenda` (
  `idRecursosXAgenda` int(11) NOT NULL AUTO_INCREMENT,
  `FechaInicio` datetime DEFAULT NULL,
  `FechaFin` datetime DEFAULT NULL,
  `Agenda_idAgenda` int(11) NOT NULL,
  `Recurso_idRecurso` int(11) NOT NULL,
  PRIMARY KEY (`idRecursosXAgenda`,`Agenda_idAgenda`,`Recurso_idRecurso`),
  KEY `fk_RecursosXAgenda_Agenda1_idx` (`Agenda_idAgenda`),
  KEY `fk_RecursosXAgenda_Recurso1_idx` (`Recurso_idRecurso`),
  CONSTRAINT `fk_RecursosXAgenda_Agenda1` FOREIGN KEY (`Agenda_idAgenda`) REFERENCES `agenda` (`idAgenda`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_RecursosXAgenda_Recurso1` FOREIGN KEY (`Recurso_idRecurso`) REFERENCES `recurso` (`idRecurso`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `recursosxagenda`
--

/*!40000 ALTER TABLE `recursosxagenda` DISABLE KEYS */;
/*!40000 ALTER TABLE `recursosxagenda` ENABLE KEYS */;


--
-- Definition of table `unidadeducativa`
--

DROP TABLE IF EXISTS `unidadeducativa`;
CREATE TABLE `unidadeducativa` (
  `idUnidadEducativa` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) NOT NULL,
  PRIMARY KEY (`idUnidadEducativa`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `unidadeducativa`
--

/*!40000 ALTER TABLE `unidadeducativa` DISABLE KEYS */;
INSERT INTO `unidadeducativa` (`idUnidadEducativa`,`Descripcion`) VALUES 
 (1,'Polimodal Colegio'),
 (2,'Colegio T??cnico');
/*!40000 ALTER TABLE `unidadeducativa` ENABLE KEYS */;


--
-- Definition of procedure `ActualizarInstancia`
--

DROP PROCEDURE IF EXISTS `ActualizarInstancia`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarInstancia`(
ridCursoSeccion 				INT,
rAliasCurso  					VARCHAR(45),
rAliasDivision  				VARCHAR(45),
rCurso   						VARCHAR(45),
rDivision  						VARCHAR(45),
rFechaCreacion 					DATETIME,
rInstrumentoLegal 				VARCHAR(45),
rMatricula  					VARCHAR(45),
rMotivoCreacion 				VARCHAR(45),
rObservaciones 					VARCHAR(45),
rTipoInstrumentoLegal  			VARCHAR(45),
rTurno   						VARCHAR(45),
rAgrupaciones_idAgrupaciones 	INT  
)
BEGIN

UPDATE cursoseccion 
SET
idCursoSeccion = ridCursoSeccion,
AliasCurso = rAliasCurso, 
AliasDivision 	= rAliasDivision,
Curso 	= rCurso,   
Division = rDivision,
FechaCreacion 	= rFechaCreacion,
InstrumentoLegal = rInstrumentoLegal,
Matricula = rMatricula,   
MotivoCreacion 	= rMotivoCreacion,
Observaciones 	= rObservaciones,
TipoInstrumentoLegal = rTipoInstrumentoLegal,
Turno = rTurno, 
Agrupaciones_idAgrupaciones = rAgrupaciones_idAgrupaciones
 
WHERE 

IdCursoSeccion = rIdCursoSeccion;


END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `ActualizarMateriaPorPlanes`
--

DROP PROCEDURE IF EXISTS `ActualizarMateriaPorPlanes`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarMateriaPorPlanes`(

ridMateriaAsociada 				INT,
rHoraRelojReal 					INT,
rTiempoDeCursada  				VARCHAR(45), 
rAgrupaciones_idAgrupaciones 	INT,
rMaterias_idMaterias 			INT

)
BEGIN

UPDATE materiaasociada 
SET

idMateriaAsociada = ridMateriaAsociada, 
HoraRelojReal = rHoraRelojReal, 
TiempoDeCursada = rTiempoDeCursada, 
Agrupaciones_idAgrupaciones = rAgrupaciones_idAgrupaciones, 
Materias_idMaterias = rMaterias_idMaterias
 
WHERE 

idMateriaAsociada = ridMateriaAsociada;


END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `ConsultaAgrupacion`
--

DROP PROCEDURE IF EXISTS `ConsultaAgrupacion`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ConsultaAgrupacion`()
BEGIN

select

		agr.IdAgrupaciones as Id,
        agr.Nombre as Nombre,
        est.Nombre as EstructuraCurricular,
        pla.Descripcion as PlanDeEsturdio,
        uni.Descripcion as UnidadEducativa
	from 
		agrupaciones as agr,
        EstructuraCurricular as est,
		PlanDeEstudio as pla,
		UnidadEducativa as uni
	where
		agr.EstructuraCurricular_idEstructuraCurricular = est.idEstructuraCurricular and
        est.PlanDeEstudio_idPlanDeEstudio = pla.idPlanDeEstudio and
        pla.UnidadEducativa_idUnidadEducativa = uni.idUnidadEducativa;

END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `ConsultaDeInstancias`
--

DROP PROCEDURE IF EXISTS `ConsultaDeInstancias`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ConsultaDeInstancias`(IN UnidadEducativa VARCHAR(45))
BEGIN
select 
		cur.IdCursoSeccion as Id,
        uni.Descripcion as UnidadEducativa,
        pla.Descripcion as PlanDeEstudio, 
        est.Nombre as EstructuraCurricular,
        agr.Nombre as Agrupacion,
        cur.Curso as Curso,
        cur.Division as Division,
        cur.Turno as Turno
	from 
		cursoseccion as cur, 
		agrupaciones as agr, 
		EstructuraCurricular as est, 
        PlanDeEstudio as pla,
        unidadeducativa as uni
	where 
		cur.Agrupaciones_idAgrupaciones = agr.idAgrupaciones and
		agr.EstructuraCurricular_idEstructuraCurricular = est.idEstructuraCurricular and
        est.PlanDeEstudio_idPlanDeEstudio = pla.idPlanDeEstudio and
        pla.UnidadEducativa_idUnidadEducativa =  uni.idUnidadEducativa and
		uni.Descripcion like UnidadEducativa;
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `ConsultaDeMateria`
--

DROP PROCEDURE IF EXISTS `ConsultaDeMateria`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ConsultaDeMateria`(IN ridMaterias INT, rnombre VARCHAR(45))
BEGIN
select
		*
from
		materias
where 
		Nombre like rnombre or
        idMaterias = ridMaterias;
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `ConsultaEstructuraCurricular`
--

DROP PROCEDURE IF EXISTS `ConsultaEstructuraCurricular`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ConsultaEstructuraCurricular`()
BEGIN
select
		est.idEstructuraCurricular as Id,
        est.Nombre as EstructuraCurricular,
        pla.Descripcion as PlanDeEsturdio,
        uni.Descripcion as UnidadEducativa
	from 
		EstructuraCurricular as est,
		PlanDeEstudio as pla,
		UnidadEducativa as uni
	where
		est.PlanDeEstudio_idPlanDeEstudio = pla.idPlanDeEstudio and
        pla.UnidadEducativa_idUnidadEducativa = uni.idUnidadEducativa; 
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `ConsultaMateriaPorPlanes`
--

DROP PROCEDURE IF EXISTS `ConsultaMateriaPorPlanes`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ConsultaMateriaPorPlanes`(IN Agrup INT)
BEGIN
SELECT 
matas.idMateriaAsociada as Id, 
mat.Nombre as Materia, 
matas.HoraRelojReal as HsRelojReal, 
matas.TiempoDeCursada as TiempoCursada, 
mat.NucleoDisciplinaAfin as DisciplinaAfin
FROM 
materiaasociada as matas,
materias as mat
where 
matas.Materias_idMaterias=idMaterias and
matas.Agrupaciones_idAgrupaciones = Agrup;
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `EliminarInstancia`
--

DROP PROCEDURE IF EXISTS `EliminarInstancia`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarInstancia`(IN ID INT)
BEGIN
DELETE FROM cursoseccion
WHERE idCursoSeccion = ID;
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `EliminarMateriaPorPlanes`
--

DROP PROCEDURE IF EXISTS `EliminarMateriaPorPlanes`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarMateriaPorPlanes`(IN ID INT)
BEGIN
DELETE FROM materiaasociada
WHERE idMateriaAsociada = ID;
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `InsertarAgrupaciones`
--

DROP PROCEDURE IF EXISTS `InsertarAgrupaciones`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarAgrupaciones`(Nombre1 VARCHAR(45), Id_EstructuraCurricular1 INT)
BEGIN


INSERT INTO agrupaciones (Nombre,EstructuraCurricular_idEstructuraCurricular) VALUES(Nombre1, Id_EstructuraCurricular1);

END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `InsertarInstancia`
--

DROP PROCEDURE IF EXISTS `InsertarInstancia`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarInstancia`(
rAliasCurso  VARCHAR(45),   
rAliasDivision  VARCHAR(45),   
rCurso   VARCHAR(45), 
rDivision  VARCHAR(45),
rFechaCreacion DATETIME,  
rInstrumentoLegal VARCHAR(45),  
rMatricula  VARCHAR(45),  
rMotivoCreacion VARCHAR(45),  
rObservaciones VARCHAR(45),
rTipoInstrumentoLegal  VARCHAR(45), 
rTurno   VARCHAR(45),
rAgrupaciones_idAgrupaciones INT  
)
BEGIN
INSERT INTO cursoseccion 
(
AliasCurso,   
AliasDivision,    
Curso,   
Division, 
FechaCreacion, 
InstrumentoLegal, 
Matricula,    
MotivoCreacion,  
Observaciones, 
TipoInstrumentoLegal,  
Turno,   
Agrupaciones_idAgrupaciones 
) 
VALUES
(
rAliasCurso,  
rAliasDivision, 
rCurso,   
rDivision, 
rFechaCreacion, 
rInstrumentoLegal, 
rMatricula,  
rMotivoCreacion, 
rObservaciones, 
rTipoInstrumentoLegal,  
rTurno,   
rAgrupaciones_idAgrupaciones 
);
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `InsertarMateriaPorPlanes`
--

DROP PROCEDURE IF EXISTS `InsertarMateriaPorPlanes`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarMateriaPorPlanes`(
rHoraRelojReal INT, 
rTiempoDeCursada VARCHAR(45),
rAgrupaciones_idAgrupaciones INT, 
rMaterias_idMaterias INT
)
BEGIN
INSERT INTO materiaasociada 
(
HoraRelojReal, 
TiempoDeCursada, 
Agrupaciones_idAgrupaciones, 
Materias_idMaterias
) 
VALUES
(
rHoraRelojReal, 
rTiempoDeCursada,
rAgrupaciones_idAgrupaciones, 
rMaterias_idMaterias
);
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `ObtenerAgrupacionId`
--

DROP PROCEDURE IF EXISTS `ObtenerAgrupacionId`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerAgrupacionId`(IN id INT)
BEGIN


SELECT cur.Agrupaciones_idAgrupaciones FROM cursoseccion as cur
where cur.idCursoSeccion = Id;


END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `ObtenerInstancia`
--

DROP PROCEDURE IF EXISTS `ObtenerInstancia`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerInstancia`(IN Id INT)
BEGIN

SELECT * FROM educacion.cursoseccion
where idCursoSeccion = Id;

END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `ObtenerMateriaPorPlanes`
--

DROP PROCEDURE IF EXISTS `ObtenerMateriaPorPlanes`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerMateriaPorPlanes`(IN Agrup INT)
BEGIN
SELECT 
*
FROM 
materiaasociada as matas
where 
matas.idMateriaAsociada = Agrup;
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
