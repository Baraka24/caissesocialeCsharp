-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 18 Novembre 2021 à 10:00
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `caisse_sociale`
--

-- --------------------------------------------------------

--
-- Structure de la table `admin`
--

CREATE TABLE IF NOT EXISTS `admin` (
  `username` varchar(15) NOT NULL,
  `pwd` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `admin`
--

INSERT INTO `admin` (`username`, `pwd`) VALUES
('Baraka', 'baraka*#kin'),
('kl', '0000');

-- --------------------------------------------------------

--
-- Structure de la table `contributeur`
--

CREATE TABLE IF NOT EXISTS `contributeur` (
  `matricule` varchar(15) NOT NULL,
  `nom` varchar(25) NOT NULL,
  `postnom` varchar(25) NOT NULL,
  `prenom` varchar(25) NOT NULL,
  `genre` char(1) NOT NULL,
  `dateInscription` datetime NOT NULL,
  `motDePasse` varchar(8) NOT NULL,
  PRIMARY KEY (`matricule`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `contributeur`
--

INSERT INTO `contributeur` (`matricule`, `nom`, `postnom`, `prenom`, `genre`, `dateInscription`, `motDePasse`) VALUES
('IG001/2021', 'Kambale ', 'Kitegha', 'Jackson', 'M', '2021-09-15 09:16:20', '5555'),
('IG002/2021', 'Kambale', 'Musavuli', 'JeanBaptiste', 'M', '2021-09-15 10:04:02', '8852'),
('IG003/2021', 'Kathungu', 'Mathina', 'Neema', 'F', '2021-09-15 10:14:56', '125'),
('IG004/2021', 'Baraka', 'Mayele', 'Bene', 'F', '2021-09-15 10:22:21', '3666'),
('IG005/2021', 'Baraka', 'Kinywa', 'Mbale', 'M', '2021-09-15 10:30:56', '2580'),
('IG006/2021', 'Kahambu', 'Matina', 'Suzanne', 'F', '2021-09-15 10:34:28', '9955'),
('IG007/2021', 'Kavira', 'Vinywasiki', 'Sarah', 'F', '2021-09-15 10:36:43', 'kelper'),
('IG008/2021', 'ddwfs', 'dsfrf', 'ez', 'M', '2021-09-15 10:39:06', 'fdf'),
('IG009/2021', 'Dieumerci', 'Bwira', 'A', 'M', '2021-09-20 18:57:42', '1964'),
('IG010/2021', 'CUIDOI', 'OPOO', 'KL', 'M', '2021-09-20 19:39:48', '2222'),
('IG011/2021', 'Aristote', 'Kirongo', 'mumbere', 'M', '2021-09-28 18:25:25', '2007'),
('IG012/2021', 'Kavira ', 'Kiviti', 'Imma', 'F', '2021-10-16 12:50:28', 'imma');

-- --------------------------------------------------------

--
-- Structure de la table `contribution1`
--

CREATE TABLE IF NOT EXISTS `contribution1` (
  `numero` int(11) NOT NULL AUTO_INCREMENT,
  `mois` varchar(20) NOT NULL,
  `matricule` varchar(15) DEFAULT NULL,
  `montant` decimal(10,0) DEFAULT NULL,
  `semaine` varchar(9) DEFAULT NULL,
  PRIMARY KEY (`numero`),
  KEY `matricule` (`matricule`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Contenu de la table `contribution1`
--

INSERT INTO `contribution1` (`numero`, `mois`, `matricule`, `montant`, `semaine`) VALUES
(1, 'Janvier', 'IG009/2021', '5100', 'Semaine1'),
(2, 'Janvier', 'IG001/2021', '2000', 'Semaine1'),
(3, 'Janvier', 'IG010/2021', '5000', 'Semaine1'),
(4, 'Fevrier', 'IG001/2021', '100', 'semaine1'),
(5, 'Fevrier', 'IG010/2021', '250', 'semaine1'),
(6, 'Janvier', 'IG011/2021', '500', 'Semaine1'),
(7, 'Janvier', 'IG012/2021', '5000', 'Semaine1'),
(8, 'Février', 'IG002/2021', '200', 'Semaine4');

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `ficheavectotal`
--
CREATE TABLE IF NOT EXISTS `ficheavectotal` (
`matricule` varchar(15)
,`nom` varchar(25)
,`postnom` varchar(25)
,`prenom` varchar(25)
,`semaine` varchar(9)
,`mois` varchar(20)
,`montant` decimal(10,0)
,`Total` decimal(32,0)
);
-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `v_fiches`
--
CREATE TABLE IF NOT EXISTS `v_fiches` (
`matricule` varchar(15)
,`mois` varchar(20)
,`montant` decimal(10,0)
,`semaine` varchar(9)
,`nom` varchar(25)
,`postnom` varchar(25)
,`prenom` varchar(25)
,`genre` char(1)
);
-- --------------------------------------------------------

--
-- Structure de la vue `ficheavectotal`
--
DROP TABLE IF EXISTS `ficheavectotal`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `ficheavectotal` AS select `contribution1`.`matricule` AS `matricule`,`contributeur`.`nom` AS `nom`,`contributeur`.`postnom` AS `postnom`,`contributeur`.`prenom` AS `prenom`,`contribution1`.`semaine` AS `semaine`,`contribution1`.`mois` AS `mois`,`contribution1`.`montant` AS `montant`,sum(`contribution1`.`montant`) AS `Total` from (`contributeur` join `contribution1`) where (`contribution1`.`matricule` = `contributeur`.`matricule`) group by `contributeur`.`matricule`;

-- --------------------------------------------------------

--
-- Structure de la vue `v_fiches`
--
DROP TABLE IF EXISTS `v_fiches`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_fiches` AS select `contribution1`.`matricule` AS `matricule`,`contribution1`.`mois` AS `mois`,`contribution1`.`montant` AS `montant`,`contribution1`.`semaine` AS `semaine`,`contributeur`.`nom` AS `nom`,`contributeur`.`postnom` AS `postnom`,`contributeur`.`prenom` AS `prenom`,`contributeur`.`genre` AS `genre` from (`contribution1` join `contributeur` on((`contribution1`.`matricule` = `contributeur`.`matricule`)));

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `contribution1`
--
ALTER TABLE `contribution1`
  ADD CONSTRAINT `contribution1_ibfk_1` FOREIGN KEY (`matricule`) REFERENCES `contributeur` (`matricule`) ON DELETE NO ACTION ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
