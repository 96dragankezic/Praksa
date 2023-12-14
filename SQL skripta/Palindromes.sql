CREATE DATABASE Palindromes;

USE Palindromes;

CREATE TABLE Candidates(
	Text varchar(400) NOT NULL
);

CREATE TABLE Palindromes(
	Text varchar(400) NOT NULL
);

SELECT * FROM Candidates;

SELECT * FROM Palindromes;



INSERT INTO Candidates VALUES ('Ana voli milovana.');
INSERT INTO Candidates VALUES ('Zovi autobus u subotu, a i voz!');
INSERT INTO Candidates VALUES ('Ona ima pregled kod lekara.');
INSERT INTO Candidates VALUES ('Na sebe je besan.');
INSERT INTO Candidates VALUES ('Ovo je muka, kume Jovo!');
INSERT INTO Candidates VALUES ('Sir ima miris.');
INSERT INTO Candidates VALUES ('Oni vole belo vino.');
INSERT INTO Candidates VALUES ('Udovica baci vodu.');
INSERT INTO Candidates VALUES ('Ona je igrala fudbal!');
INSERT INTO Candidates VALUES ('Velja je najbolji ucenik u skoli.');

ALTER TABLE Palindromes DROP COLUMN Text;