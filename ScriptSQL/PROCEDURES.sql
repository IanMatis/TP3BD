use TrivialPursuitBD;

drop procedure if exists insertJoueur;

go

--Cree le joueur et son tableau de score en meme temps
create procedure insertJoueur(@alias varchar(60),@nom varchar(60),@prenom varchar(60))
as 
begin
	insert into Joueurs(Alias,nom,prenom) values(@alias,@nom,@prenom);

	declare @nbCategories int,@idJ int,@cnt int = 1;
	select @nbCategories = count(idCategorie) from Categories;
	select @idJ = idJoueur from Joueurs where Alias = @alias;

	while @cnt <= @nbCategories
	begin
		insert into Score(idCategorie,idJoueur) values(@cnt,@idJ);
		Set @cnt = @cnt + 1;
	end
end;

go;

--Select all
select * from Joueurs;
select * from Categories;
select * from Score;
select * from Questions;
select * from Reponses;

execute insertJoueur
@alias = 'vex0272',
@nom = 'M2',
@prenom = 'F2';
