DROP DATABASE IF EXISTS bdSport;
CREATE DATABASE IF NOT EXISTS bdSport;
USE bdSport;

CREATE TABLE IF NOT EXISTS Sport (
	id int,
    nomSport varchar(30),
    Primary key (id)
	) Engine = InnoDB;
    
CREATE TABLE IF NOT EXISTS Sportif (
	id int auto_increment,
    nom varchar(30),
    prenom varchar(30),
    dateNais DATE,
    rue varchar(30),
    codePostal varchar(5),
    ville varchar(50),
    niveauExperience int,
    Primary key (id)
    ) Engine = InnoDB;

CREATE TABLE IF NOT EXISTS Participe (
	idSportif int,
    idSport int,
    Primary key (idSportif,idSport),
    foreign key (idSport) REFERENCES Sport(id),
    foreign key (idSportif) REFERENCES Sportif(id)
    ) Engine = InnoDB;
    
CREATE TABLE IF NOT EXISTS Utilisateur (
    username varchar(32),
    password varchar(32),
    Primary key (username)
    ) Engine = InnoDB;
    

 INSERT INTO Sport VALUES
(1,"Tennis"),
(2,"Natation"),
(3,"FootBall"),
(4,"Judo");
   
INSERT INTO Sportif (nom,prenom,dateNais,rue,codePostal,ville,niveauExperience) VALUES
('Davolio', 'Jeanne', '2003-06-15', '5 rue de la poste', '63000','Clermont-Ferrand', 3),
('Dupont', 'Emma', '2006-11-22', '32 place de l''Hôtel de Ville', '63200','Riom', 3),
('Martin', 'Julien', '2002-03-09', '254 avenue Berthelot','63500','Issoire', 2),
('Durand', 'Alice', '2004-07-18','1 place de Jaude', '63000','Clermont-Ferrand', 1),
('Bernard', 'Maxime', '2005-01-30', '15 rue des pinsons', '63200', 'Riom', 1),
('Dupuy', 'Laura', '2003-09-05', '23 boulevard Central', '63500', 'Issoire', 3),
('Peacock', 'Pierre','2007-10-01','23 Impasse des Fleurs', '63000', 'Clermont-Ferrand',1),
('Buchanan', 'Alban','2007-05-12', '3 rue des tilleuls', '63200', 'Riom',1),
('Petit', 'Antoine', '2005-02-12', '7 rue de la paix', '63000', 'Clermont-Ferrand', 4),
('Merle', 'Louis','2004-01-30','3 avenue de la république', '63000', 'Clermont-Ferrand',3),
('Arquizan', 'Lucie', '2005-02-15','3 boulevard Berthelot', '63000', 'Clermont-Ferrand',1);

 INSERT INTO Participe (idSportif,idSport) VALUES
 (1,1),
 (1,2),
 (2,2),
 (3,3),
 (4,1),
 (5,4),
 (6,3),
 (7,3),
 (8,3),
 (9,1),
 (10,4),
 (11,2);


INSERT INTO Utilisateur VALUES ('Maxev3','123');
SELECT S.id,S.nom,S.prenom,S.dateNais,S.rue,S.codePostal,S.ville,S.niveauExperience,Sp.nomSport FROM Participe P INNER JOIN Sportif S ON S.id=P.idSportif INNER JOIN Sport Sp ON P.idSport = Sp.id;
DELIMITER $
CREATE PROCEDURE DeleteSportif(IN idSportif2 int)
BEGIN
DELETE FROM Participe WHERE idSportif=idSportif2;
DELETE FROM Sportif WHERE id=idSportif2;
END$
DELIMITER ;