--create database TrivialPursuitBD;
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
idJoueur int identity(1,1),
Alias VARCHAR(20) not null,
nom VARCHAR(30) not null,
prenom VARCHAR(30) not null,
constraint pk_idJoueur primary key(idJoueur)
);

create table Categories
(
idCategorie int identity(1,1),
nomCategorie VARCHAR(30) not null,
Couleur CHAR(1),
constraint pk_idCategorie primary key(idCategorie)
);

create table Score
(
idCategorie int not null,
idJoueur int not null,nbBonneReponses int default 0,nbMauvaiseReponses int default 0,constraint fk_Score_categories foreign key(idCategorie) references Categories(idCategorie),
constraint fk_Score_joueurs foreign key(idJoueur) references Joueurs(idJoueur),
constraint pk_score primary key(idCategorie,idJoueur)
);

create table Questions
(
idQuestion int identity(1,1),
enonceQuestion VARCHAR(120),
flag int default 0,
idCategorie int not null,
constraint pk_questions primary key(idQuestion),
constraint fk_Question_categories foreign key(idCategorie) references Categories(idCategorie)
);

create table Reponses
(
idReponse int identity(1,1),
enonceReponse VARCHAR(60),
estBonne int default 0,
idQuestion int not null,
constraint pk_reponses primary key(idReponse),
constraint fk_Reponses_questions foreign key(idQuestion) references Questions(idQuestion)
);


--Select all
select * from Joueurs;
select * from Categories;
select * from Score;
select * from Questions;
select * from Reponses;


