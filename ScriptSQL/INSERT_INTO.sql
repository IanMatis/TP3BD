use TrivialPursuitBD;
-----------------------------------------------------------------------------------------------------------------------
--insert into...
--insert into Joueurs 
insert into Joueurs(Alias,nom,prenom) values('vex027','M','F');
insert into Joueurs(Alias,nom,prenom) values('Bigbinotte','I','L');

--insert into Categories									
insert into Categories(nomCategorie,Couleur) values('Sport','O');--Orange
insert into Categories(nomCategorie,Couleur) values('Anime','J');--Jaune
insert into Categories(nomCategorie,Couleur) values('Jeu Video','B');--Bleu
insert into Categories(nomCategorie,Couleur) values('Animaux','V');--Violet

--insert into Score
--cree un trigger sur Joueur quand un est insert cree un Score pour ce Joueur
--Score pour le joueur 1
--insert into Score(idCategorie,idJoueur) values(1,1);
--insert into Score(idCategorie,idJoueur) values(2,1);
--insert into Score(idCategorie,idJoueur) values(3,1);
--insert into Score(idCategorie,idJoueur) values(4,1);
--
--Score pour le joueur 2
--insert into Score(idCategorie,idJoueur) values(1,2);
--insert into Score(idCategorie,idJoueur) values(2,2);
--insert into Score(idCategorie,idJoueur) values(3,2);
--insert into Score(idCategorie,idJoueur) values(4,2);

--insert into Questions
--Question de Sport Orange
insert into Questions(enonceQuestion,idCategorie) values('Que lance-t-on avec une raquette de badminton ?',1);
insert into Questions(enonceQuestion,idCategorie) values('Où les boxeurs ne peuvent ils pas frapper ?',1);
insert into Questions(enonceQuestion,idCategorie) values('Le biathlon se compose de 2 disciplines :',1);
insert into Questions(enonceQuestion,idCategorie) values('Quel sport ne fait pas partie du triathlon ?',1);
insert into Questions(enonceQuestion,idCategorie) values('Un boxeur est déclaré K.O. après :',1);
insert into Questions(enonceQuestion,idCategorie) values('Combien de quilles y a-t-il sur la piste de bowling ? ',1);
insert into Questions(enonceQuestion,idCategorie) values('Quelle couleur a la ceinture d’un débutant au judo ?',1);
insert into Questions(enonceQuestion,idCategorie) values('De quelle couleur est la carte qu’un arbitre montre lorsqu’il veut faire sortir un joueur du terrain ?',1);
insert into Questions(enonceQuestion,idCategorie) values('En tennis de table, le gagnant est celui qui atteint en premier le score de :',1);
insert into Questions(enonceQuestion,idCategorie) values('Combien de joueur y a t-il sur un terrain de Voleyball en jeu?',1);

--Question de Anime Jaune
insert into Questions(enonceQuestion,idCategorie) values('Quel est le Titre du Troisieme Opening de Bakemonogatari ?',2);
insert into Questions(enonceQuestion,idCategorie) values('Quel est le nom du personnage masculin principal dans la Bakemonogatari series ?',2);
insert into Questions(enonceQuestion,idCategorie) values('Dans quel anime le personnage principal est un super heros chauve qui tue ses enemies avec un seul coup de poing ?',2);
insert into Questions(enonceQuestion,idCategorie) values('Comment s apelle le personnage feminin principal dans l anime Darling in the Franxx',2);
insert into Questions(enonceQuestion,idCategorie) values('Comment s apelle les deux protagonistes dans fullmetal alchemist ?',2);
insert into Questions(enonceQuestion,idCategorie) values('Lequel de ces personnages n est pas dans Hunter X Hunter :',2);
insert into Questions(enonceQuestion,idCategorie) values('Dans l anime Konosuba quel personnage feminin est une déesse inutile ?',2);
insert into Questions(enonceQuestion,idCategorie) values('Quel est le nom du personnage principale dans l anime Demon Slayer ?',2);
insert into Questions(enonceQuestion,idCategorie) values('Quel est le nom de la soeur(démon) du personnage principal dans l anime Demon Slayer ?',2);
insert into Questions(enonceQuestion,idCategorie) values('En automne 2019 quel saison de l anime My Hero Academia est difusé :',2);

--Question de Jeu Video Bleu
insert into Questions(enonceQuestion,idCategorie) values('Comment s apelle l inteligence artificiel qui aide Master Chief dans le jeu Halo ?',3);
insert into Questions(enonceQuestion,idCategorie) values('Quel personnage n existe pas dans League of Legends :',3);
insert into Questions(enonceQuestion,idCategorie) values('Quel personnage dans League of Legends a comme arme : un lance rocket et un minigun ?',3);
insert into Questions(enonceQuestion,idCategorie) values('Dans quel Gears of war le personnage Dominique Santiago meurt-il ?',3);
insert into Questions(enonceQuestion,idCategorie) values('Quel compagnie a fait le jeu : The Elder Scrolls | Skyrim ?',3);
insert into Questions(enonceQuestion,idCategorie) values('Quel compagnie a fait le jeu : Fallout 3 ?',3);
insert into Questions(enonceQuestion,idCategorie) values('Quel compagnie a fait le jeu : Red Dead Redemption 2 ?',3);
insert into Questions(enonceQuestion,idCategorie) values('Quel compagnie a fait le jeu : Far Cry 3 ?',3);
insert into Questions(enonceQuestion,idCategorie) values('En quelle année la premiere édition de RuneScape a publié ?',3);
insert into Questions(enonceQuestion,idCategorie) values('En quelle année le jeu League of Legends a officiellement publié ?',3);

--Question de Animaux Violet
insert into Questions(enonceQuestion,idCategorie) values('Quel oiseau est un symbole international de paix ?',4);
insert into Questions(enonceQuestion,idCategorie) values('Quelle espèce de rhinocéros n’existe pas ?',4);
insert into Questions(enonceQuestion,idCategorie) values('La libellule est un insecte que l’on rencontre surtout :',4);
insert into Questions(enonceQuestion,idCategorie) values('Combien de yeux une araignee possede t-elle ?',4);
insert into Questions(enonceQuestion,idCategorie) values('A quelle vitesse peut courir une autruche ?',4);
insert into Questions(enonceQuestion,idCategorie) values('La vipère est un serpent venimeux mais elle a elle-même des ennemis. Son plus grand ennemi est :',4);
insert into Questions(enonceQuestion,idCategorie) values('Le cou de la girafe est très long. Combien de vertèbres cervicales comporte-t-il ? ',4);
insert into Questions(enonceQuestion,idCategorie) values('Quel animal nous donne le jambon ?',4);
insert into Questions(enonceQuestion,idCategorie) values('Certains oiseaux, comme le colibri, peuvent :',4);
insert into Questions(enonceQuestion,idCategorie) values('Où se trouve l’aiguillon du scorpion qui sécrète le venin ?',4);

--insert into Reponses

--Reponse Sport
--Q1
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Un volant',1,1);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Une balle',0,1);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Une fléchette',0,1);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Une puck',0,1);

--Q2
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Sous la ceinture',1,2);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Sur le visage',0,2);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Sur le thorax',0,2);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Sur les seins',0,2);
--Q3
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Trampoline et tir à la carabine',0,3);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Ski de fond et trampoline',0,3);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Ski de fond et tir à la carabine',1,3);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Boxe et lutte',0,3);
--Q4
insert into Reponses(enonceReponse,estBonne,idQuestion) values('La natation',0,4);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Le cyclisme',0,4);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('La lutte',1,4);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('La course',0,4);
--Q5
insert into Reponses(enonceReponse,estBonne,idQuestion) values('5 secondes',0,5);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('10 secondes',1,5);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('15 secondes',0,5);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('27 secondes',0,5);
--Q6
insert into Reponses(enonceReponse,estBonne,idQuestion) values('10',1,6);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('9',0,6);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('11',0,6);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('12',0,6);
--Q7
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Blanc',1,7);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Jaune',0,7);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Noire',0,7);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Bleu',0,7);
--Q8
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Vert',0,8);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Jaune',0,8);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Rouge',1,8);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Noir',0,8);
--Q9
insert into Reponses(enonceReponse,estBonne,idQuestion) values('21',1,9);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('40',0,9);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('45',0,9);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('12',0,9);
--Q10
insert into Reponses(enonceReponse,estBonne,idQuestion) values('7',0,10);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('6',1,10);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('4',0,10);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('12',0,10);

--Reponse Anime
--Q11
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Renai Circulation',1,11);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Platinum Disco',0,11);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Kanashii Ureshii',0,11);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Unravel',0,11);
--Q12
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Koyomi Araragi',1,12);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Koyomi Aragi',0,12);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Koyomi Arararararagi',0,12);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Gino Chouinard',0,12);
--Q13
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Evangelion',0,13);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Psycho-Pass',0,13);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('One punch man',1,13);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('K-ON',0,13);
--Q14
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Ichigo',0,14);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Zero two',1,14);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Kiss-Shot',0,14);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Asuna',0,14);
--Q15
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Edward et Alphonse',1,15);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Edward et Roy',0,15);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Kirito et Gon',0,15);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Bill et bob',0,15);
--Q16
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Hisoka',0,16);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Kurapika',0,16);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Naruto',1,16);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Gon',0,16);
--Q17
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Aqua',1,17);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Megumin',0,17);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Lalatina',0,17);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Chris',0,17);
--Q18
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Tanjiro',1,18);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Inosuke',0,18);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Muzan',0,18);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Zenitsu',0,18);
--Q19
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Muzan',0,19);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Sakura',0,19);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Nezuko',1,19);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Tami',0,19);
--Q20
insert into Reponses(enonceReponse,estBonne,idQuestion) values('1',0,20);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('4',1,20);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('5',0,20);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('12',0,20);

--Reponse Jeu Video
--Q21
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Siri',0,21);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Cortana',1,21);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Sonia',0,21);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Yan',0,21);
--Q22
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Artemis',1,22);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Ziggs',0,22);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Aurelion sol',0,22);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Zed',0,22);
--Q23
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Zed',0,23);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Katarina',0,23);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Jinx',1,23);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Caitlyn',0,23);
--Q24
insert into Reponses(enonceReponse,estBonne,idQuestion) values('1',0,24);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('2',0,24);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('3',1,24);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('12',0,24);
--Q25
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Ubisoft',0,25);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Bethesda',1,25);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Rockstar',0,25);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Activision',0,25);
--Q26
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Ubisoft',0,26);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Bethesda',1,26);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Rockstar',0,26);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Activision',0,26);
--Q27
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Ubisoft',0,27);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Bethesda',0,27);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Rockstar',1,27);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Activision',0,27);
--Q28
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Ubisoft',1,28);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Bethesda',0,28);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Rockstar',0,28);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Activision',0,28);
--Q29
insert into Reponses(enonceReponse,estBonne,idQuestion) values('1998',0,29);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('2001',1,29);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('2004',0,29);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('2012',0,29);
--Q30
insert into Reponses(enonceReponse,estBonne,idQuestion) values('2009',1,30);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('2006',0,30);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('2012',0,30);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('1212',0,30);

--Reponse Animaux
--Q31
insert into Reponses(enonceReponse,estBonne,idQuestion) values('La colombe',1,31);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('L hirondelle',0,31);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('La cigogne',0,31);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Le pan',0,31);
--Q32
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Le rhinocéros blanc',0,32);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Le rhinocéros noir',0,32);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Le rhinocéros brun',1,32);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Aucun',0,32);
--Q33
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Au bord de l’eau',1,33);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Dans la forêt',0,33);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Dans la montagne',0,33);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Dans un bar',0,33);
--Q34
insert into Reponses(enonceReponse,estBonne,idQuestion) values('2',0,34);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('4',0,34);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('8',1,34);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('12',0,34);
--Q35
insert into Reponses(enonceReponse,estBonne,idQuestion) values('70 km/h',1,35);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('15 km/h',0,35);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('95 km/h',0,35);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('12 km/h',0,35);
--Q36
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Le renard',0,36);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Le blaireau',0,36);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('L homme',1,36);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('La licorne',0,36);
--Q37
insert into Reponses(enonceReponse,estBonne,idQuestion) values('2',0,37);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('7',1,37);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('25',0,37);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('12',0,37);
--Q38
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Le porc',1,38);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('La vache',0,38);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Le cheval',0,38);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Le renard',0,38);
--Q39
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Voler sur place',1,39);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Flotter',0,39);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Surnager',0,39);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Plonger',0,39);
--Q40
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Au bout de sa langue',0,40);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Sur sa tete',0,40);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Au bout de sa queue',1,40);
insert into Reponses(enonceReponse,estBonne,idQuestion) values('Sur ses pattes',0,40);


--Select all
select * from Joueurs;
select * from Categories;
select * from Score;
select * from Questions;
select * from Reponses;