use TrivialPursuitBD;

drop procedure if exists insertJoueur;
drop procedure if exists chercherQuestion;
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

go

--Remet a zero tout ce qui est utile dans la partie
create procedure chercherQuestion(@idCat int)
as 
begin
	declare @idQues int,@rand int = rand(10-1)+1;

	select @idQues = idQuestion from Questions where idCategorie = @idCat  and flag = 0;
	

	select TOP 1 idQuestion,enonceQuestion, flag, idCategorie from Questions 
						where idQuestion = @idQues;

	update Questions set flag = 1 where idQuestion = @idQues;
end;

go

create procedure chercherReponse(@idQuestion int)
as 
begin
	select  idReponse,enonceReponse, estBonne, idQuestion from Reponses 
						where idQuestion = @idQuestion;
end;

go

create function validerReponse(@idReponse int) returns int
as 
begin
	declare @flag int = 0;
	select @flag = estBonne from Reponses where idReponse = @idReponse;
	return @flag;
end;


--Select all
select * from Joueurs;
select * from Categories;
select * from Score;
select * from Questions;
select * from Reponses;

--TEST
execute insertJoueur
@alias = 'vex0272',
@nom = 'M2',
@prenom = 'F2';
--
execute chercherQuestion
@idCat = 1;

execute chercherReponse
@idQuestion = 8;

--30   0
--31   1
select dbo.validerReponse(31) as Etat;