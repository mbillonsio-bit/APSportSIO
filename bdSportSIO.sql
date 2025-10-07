DROP DATABASE IF EXISTS bdSport;
CREATE DATABASE IF NOT EXISTS bdSport;
USE bdSport;
CREATE TABLE IF NOT EXISTS Sportif (
	id int auto_increment,
    nom varchar(30),
    prenom varchar(30),
    dateNais DATE,
    rue varchar(30),
    codePostal varchar(5),
    ville varchar(50),
    niveauExperience int,
    nomSport varchar(30),
    Primary key (id)
    ) Engine = InnoDB;
    
CREATE TABLE IF NOT EXISTS Utilisateur (
    username varchar(32),
    password varchar(32),
    Primary key (username)
    ) Engine = InnoDB;
    
INSERT INTO Sportif (nom,prenom,dateNais,rue,codePostal,ville,niveauExperience,nomSport) VALUES
('Davolio', 'Jeanne', '2003-06-15', '5 rue de la poste', '63000','Clermont-Ferrand', 3, 'Tennis'),
('Dupont', 'Emma', '2006-11-22', '32 place de l''Hôtel de Ville', '63200','Riom', 3, 'Natation'),
('Martin', 'Julien', '2002-03-09', '254 avenue Berthelot','63500','Issoire', 2, 'FootBall'),
('Durand', 'Alice', '2004-07-18','1 place de Jaude', '63000','Clermont-Ferrand', 1, 'Tennis'),
('Bernard', 'Maxime', '2005-01-30', '15 rue des pinsons', '63200', 'Riom', 1, 'Judo'),
('Dupuy', 'Laura', '2003-09-05', '23 boulevard Central', '63500', 'Issoire', 3, 'FootBall'),
('Peacock', 'Pierre','2007-10-01','23 Impasse des Fleurs', '63000', 'Clermont-Ferrand',1, 'FootBall'),
('Buchanan', 'Alban','2007-05-12', '3 rue des tilleuls', '63200', 'Riom',1, 'FootBall'),
('Petit', 'Antoine', '2005-02-12', '7 rue de la paix', '63000', 'Clermont-Ferrand', 4, 'Tennis'),
('Merle', 'Louis','2004-01-30','3 avenue de la république', '63000', 'Clermont-Ferrand',3, 'Judo'),
('Arquizan', 'Lucie', '2005-02-15','3 boulevard Berthelot', '63000', 'Clermont-Ferrand',1, 'Natation');

INSERT INTO Utilisateur VALUES ('Maxev3','123');
SELECT * FROM Sportif 