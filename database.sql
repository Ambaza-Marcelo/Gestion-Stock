-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : lun. 22 nov. 2021 à 08:43
-- Version du serveur :  10.4.19-MariaDB
-- Version de PHP : 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bar`
--

-- --------------------------------------------------------

--
-- Structure de la table `clients`
--

CREATE TABLE `clients` (
  `idClient` int(11) NOT NULL,
  `nom` varchar(100) DEFAULT NULL,
  `prenom` varchar(100) DEFAULT NULL,
  `telephone` varchar(15) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `adresse` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `clients`
--

INSERT INTO `clients` (`idClient`, `nom`, `prenom`, `telephone`, `email`, `adresse`) VALUES
(1, 'iradukunda', 'Fleury', '+257657835', 'fleury@gmail.fr', 'carama'),
(2, 'Ndayishimiye', 'Samuel', '+2576354836', 'samuel@net.net', 'kamenge'),
(3, 'Niyonkuru', 'diomede', '+257835536', 'dio@gmail.fr', 'Ngagara');

-- --------------------------------------------------------

--
-- Structure de la table `depenses`
--

CREATE TABLE `depenses` (
  `idDepense` int(11) NOT NULL,
  `description` text DEFAULT NULL,
  `montant` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `depenses`
--

INSERT INTO `depenses` (`idDepense`, `description`, `montant`) VALUES
(1, 'deplacement Nadine', 5000),
(2, 'deux primus Bosco', 4000),
(3, 'frais scolaire Marcelo', 20000);

-- --------------------------------------------------------

--
-- Structure de la table `employees`
--

CREATE TABLE `employees` (
  `idEmployee` int(11) NOT NULL,
  `nom` varchar(100) DEFAULT NULL,
  `prenom` varchar(100) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `telephone` varchar(15) DEFAULT NULL,
  `adresse` varchar(100) DEFAULT NULL,
  `matricule` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `employees`
--

INSERT INTO `employees` (`idEmployee`, `nom`, `prenom`, `email`, `telephone`, `adresse`, `matricule`) VALUES
(1, 'ambaza', 'Marcellin', 'ambaza@gmail.com', '+25762765876', 'Rohero', '7669'),
(2, 'Irakoze', 'J.paul', 'irakoze@gmail.com', '+2578758363', 'Kanyosha', '5468'),
(3, 'Bazombanza', 'Nobel', 'nobel@gmail.com', '+25776534892', 'Nyabugete', 'AB78');

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

CREATE TABLE `produit` (
  `idProduit` int(11) NOT NULL,
  `nom` varchar(100) DEFAULT NULL,
  `prix_unitaire` int(11) DEFAULT NULL,
  `quantite` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`idProduit`, `nom`, `prix_unitaire`, `quantite`) VALUES
(1, 'souris', 15000, 20),
(2, 'Disque dur externe', 200000, 5),
(3, 'Laptop hp', 800000, 12);

-- --------------------------------------------------------

--
-- Structure de la table `ventes`
--

CREATE TABLE `ventes` (
  `idVente` int(11) NOT NULL,
  `produit_id` int(4) DEFAULT NULL,
  `client_id` int(4) DEFAULT NULL,
  `employee_id` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `ventes`
--

INSERT INTO `ventes` (`idVente`, `produit_id`, `client_id`, `employee_id`) VALUES
(1, 2, 1, 1),
(2, 1, 2, 3),
(3, 3, 3, 2);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`idClient`);

--
-- Index pour la table `depenses`
--
ALTER TABLE `depenses`
  ADD PRIMARY KEY (`idDepense`);

--
-- Index pour la table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`idEmployee`);

--
-- Index pour la table `produit`
--
ALTER TABLE `produit`
  ADD PRIMARY KEY (`idProduit`);

--
-- Index pour la table `ventes`
--
ALTER TABLE `ventes`
  ADD PRIMARY KEY (`idVente`),
  ADD KEY `produit_id` (`produit_id`),
  ADD KEY `client_id` (`client_id`),
  ADD KEY `employee_id` (`employee_id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `clients`
--
ALTER TABLE `clients`
  MODIFY `idClient` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `depenses`
--
ALTER TABLE `depenses`
  MODIFY `idDepense` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `employees`
--
ALTER TABLE `employees`
  MODIFY `idEmployee` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `produit`
--
ALTER TABLE `produit`
  MODIFY `idProduit` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `ventes`
--
ALTER TABLE `ventes`
  MODIFY `idVente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `ventes`
--
ALTER TABLE `ventes`
  ADD CONSTRAINT `ventes_ibfk_1` FOREIGN KEY (`produit_id`) REFERENCES `produit` (`idProduit`),
  ADD CONSTRAINT `ventes_ibfk_2` FOREIGN KEY (`client_id`) REFERENCES `clients` (`idClient`),
  ADD CONSTRAINT `ventes_ibfk_3` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`idEmployee`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
