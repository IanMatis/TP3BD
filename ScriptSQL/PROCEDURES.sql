use TrivialPursuitBD;

drop procedure if exists insertJoueur;

go

create procedure insertJoueur(@alias varchar(30),@nom varchar(30),@prenom int)
as 
begin
	insert into Joueurs(Alias,nom,prenom) values(@alias,@nom,@prenom);
end;

go;

--Select all
select * from Joueurs;
select * from Categories;
select * from Score;
select * from Questions;
select * from Reponses;