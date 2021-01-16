-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  ven. 21 juin 2019 à 16:47
-- Version du serveur :  10.1.38-MariaDB
-- Version de PHP :  7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `perfectgest`
--

-- --------------------------------------------------------

--
-- Structure de la table `donation`
--

CREATE TABLE `donation` (
  `numDonation` int(11) NOT NULL,
  `nomDonateur` varchar(25) DEFAULT NULL,
  `prenomDonateur` varchar(35) DEFAULT NULL,
  `qtteDonation` int(11) DEFAULT NULL,
  `dateDonation` datetime DEFAULT NULL,
  `statutDonation` tinyint(1) DEFAULT '1',
  `numGerant` int(11) NOT NULL,
  `numTypeDon` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `gerant`
--

CREATE TABLE `gerant` (
  `numGerant` int(11) NOT NULL,
  `loginGerant` varchar(25) DEFAULT NULL,
  `mdpGerant` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `type_donation`
--

CREATE TABLE `type_donation` (
  `numTypeDonation` int(11) NOT NULL,
  `libTypeDonation` varchar(80) DEFAULT NULL,
  `numGerant` int(11) NOT NULL,
  `statutTypeDonation` tinyint(1) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `donation`
--
ALTER TABLE `donation`
  ADD PRIMARY KEY (`numDonation`),
  ADD KEY `fk_gerant_donation` (`numGerant`),
  ADD KEY `fk_typeDon_donation` (`numTypeDon`);

--
-- Index pour la table `gerant`
--
ALTER TABLE `gerant`
  ADD PRIMARY KEY (`numGerant`);

--
-- Index pour la table `type_donation`
--
ALTER TABLE `type_donation`
  ADD PRIMARY KEY (`numTypeDonation`),
  ADD KEY `fk_gerant_typeDon` (`numGerant`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `donation`
--
ALTER TABLE `donation`
  MODIFY `numDonation` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `gerant`
--
ALTER TABLE `gerant`
  MODIFY `numGerant` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `type_donation`
--
ALTER TABLE `type_donation`
  MODIFY `numTypeDonation` int(11) NOT NULL AUTO_INCREMENT;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `donation`
--
ALTER TABLE `donation`
  ADD CONSTRAINT `fk_gerant_donation` FOREIGN KEY (`numGerant`) REFERENCES `gerant` (`numGerant`),
  ADD CONSTRAINT `fk_typeDon_donation` FOREIGN KEY (`numTypeDon`) REFERENCES `type_donation` (`numTypeDonation`);

--
-- Contraintes pour la table `type_donation`
--
ALTER TABLE `type_donation`
  ADD CONSTRAINT `fk_gerant_typeDon` FOREIGN KEY (`numGerant`) REFERENCES `gerant` (`numGerant`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
