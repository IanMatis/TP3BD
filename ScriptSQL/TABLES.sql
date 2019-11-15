create database TrivialPursuitBD;
use TrivialPursuitBD;

--Drop tables
drop table if exists Reponses;
drop table if exists Questions;
drop table if exists Score;
drop table if exists Categories;
drop table if exists Joueurs;


--Create tables
create table Joueurs
(
idJoueur int,
Aliasse VARCHAR(20),
nom VARCHAR(30),
prenom VARCHAR(30)
constraint pk_idJoueur primary key(idJoueur),
);

create table Categories
(
idCategorie int,
nomCategorie VARCHAR(30),
Colueur CHAR(1)
constraint pk_idCategorie primary key(idCategorie),
);

create table Score
(
idCategorie int,
idJoueurs int,constraint fk_Score_categories foreign key(idCategorie) references Categories(idCategorie),
constraint fk_Score_joueurs foreign key(idJoueurs) references Joueurs(idJoueur),
constraint pk_score primary key(idCategorie,idJoueurs)
);

create table Questions
(
idQuestion int,
enonceQuestion VARCHAR(60),
flag int,
idCategorie int
constraint pk_questions primary key(idQuestion),
constraint fk_Question_categories foreign key(idCategorie) references Categories(idCategorie)
);

create table Reponses
(
idReponse int,
enonceReponse VARCHAR(60),
estBonne int,
idQuestion int
constraint pk_reponses primary key(idReponse),
constraint fk_Reponses_questions foreign key(idQuestion) references Questions(idQuestion)
);