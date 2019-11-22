using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace TrivialPursuit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        const int pointGagner = 3;
        Random r = new Random();
        int tourJoueur = 1;
        int catChoisi;
        int idQuestion;
        int idJoueur1;
        int idJoueur2;
        int idJoueurTour;

        private void btn_play_Click(object sender, EventArgs e)
        {
            btn_play.Visible = false;
            catChoisi = ChercherCategorie();
            idQuestion = ChercherQuestion(catChoisi);
            ChercherReponses(idQuestion);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Initialisations();
        }

        private void btn_sport_Click(object sender, EventArgs e)
        {
            catChoisi = 1;
            btn_sport.BackColor = Color.Orange;
            DisableButtonsCategorie();
            idQuestion = ChercherQuestion(catChoisi);
            ChercherReponses(idQuestion);
        }

        private void btn_anime_Click(object sender, EventArgs e)
        {
            catChoisi = 2;
            btn_anime.BackColor = Color.Yellow;
            DisableButtonsCategorie();
            idQuestion = ChercherQuestion(catChoisi);
            ChercherReponses(idQuestion);
        }

        private void btn_jeuxVideo_Click(object sender, EventArgs e)
        {
            catChoisi = 3;
            btn_jeuxVideo.BackColor = Color.Blue;
            DisableButtonsCategorie();
            idQuestion = ChercherQuestion(catChoisi);
            ChercherReponses(idQuestion);
        }

        private void btn_animaux_Click(object sender, EventArgs e)
        {
            catChoisi = 4;
            btn_animaux.BackColor = Color.Purple;
            DisableButtonsCategorie();
            idQuestion = ChercherQuestion(catChoisi);
            ChercherReponses(idQuestion);
        }

        private void btn_reponses(object sender, EventArgs e)
        {
            DisableButtonsCategorie();
            Button clicked = (Button)sender;
            string nomBoutton = clicked.Name;
            int reponse = RetourReponse(nomBoutton);
            UpdateScore(reponse);
            TourJoueur(reponse);

            if (reponse == 1)
                AjouterPoint();

            catChoisi = ChercherCategorie();
            idQuestion = ChercherQuestion(catChoisi);
            ChercherReponses(idQuestion);
            Gagner();
        }

        private void DisableButtonsCategorie()
        {
            btn_animaux.Enabled = false;
            btn_animaux.BackColor = Color.White;
            btn_anime.Enabled = false;
            btn_anime.BackColor = Color.White;
            btn_jeuxVideo.Enabled = false;
            btn_jeuxVideo.BackColor = Color.White;
            btn_sport.Enabled = false;
            btn_sport.BackColor = Color.White;
        }

        private void EnableButtonsCategorie()
        {
            btn_animaux.Enabled = true;
            btn_anime.Enabled = true;
            btn_jeuxVideo.Enabled = true;
            btn_sport.Enabled = true;
        }

        private void Initialisations()
        {
            lbl_joueur1.Text = Form1.Joueur1;
            lbl_Joueur2.Text = Form1.Joueur2;
            idJoueur1 = GetIdJoueur(Form1.Joueur1);
            idJoueur2 = GetIdJoueur(Form1.Joueur2);
            idJoueurTour = idJoueur1;
        }

        private int ChercherQuestion(int catChoisi)
        {
            int idQuestion = 0;
            SqlCommand chercherQuestion = new SqlCommand("chercherQuestion", Form1.conn);
            chercherQuestion.CommandText = "chercherQuestion";
            chercherQuestion.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@idCat", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = catChoisi;
            chercherQuestion.Parameters.Add(param);


            SqlDataReader reader = chercherQuestion.ExecuteReader();
            while (reader.Read())
            {
                lbl_question.Text = reader.GetString(1);
                idQuestion = reader.GetInt32(0);
            }

            reader.Close();

            return idQuestion;
        }

        private int ChercherCategorie()
        {
            int couleur = r.Next(1, 6);

            if (couleur == 1)
                btn_sport.BackColor = Color.Orange;
            else if (couleur == 2)
                btn_anime.BackColor = Color.Yellow;
            else if (couleur == 3)
                btn_jeuxVideo.BackColor = Color.Blue;
            else if (couleur == 4)
                btn_animaux.BackColor = Color.Purple;
            else
            {
                lbl_question.Text = "Vous Pouvez choisir votre catégorie en haut a gauche";
                btn_animaux.Enabled = true;
                btn_anime.Enabled = true;
                btn_jeuxVideo.Enabled = true;
                btn_sport.Enabled = true;
            }
            return couleur;
        }

        private void TourJoueur(int reponse)
        {
            if (reponse == 0 && tourJoueur == 1)
                tourJoueur = 2;
            else if (reponse == 0 && tourJoueur == 2)
                tourJoueur = 1;

            if (tourJoueur == 1)
            {
                lbl_tourJoueur.Text = "Tour de: " + Form1.Joueur1;
                idJoueurTour = idJoueur1;
            }
            else if (tourJoueur == 2)
            {
                lbl_tourJoueur.Text = "Tour de: " + Form1.Joueur2;
                idJoueurTour = idJoueur2;
            }
        }

        private void ChercherReponses(int idQuestion)
        {
            SqlCommand chercherReponse = new SqlCommand("chercherReponse", Form1.conn);
            chercherReponse.CommandText = "chercherReponse";
            chercherReponse.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@idQuestion", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = idQuestion;
            chercherReponse.Parameters.Add(param);


            SqlDataReader reader = chercherReponse.ExecuteReader();

            int i = 1;
            while (reader.Read())
            {
                if(i == 1)
                    btn_rep1.Text = reader.GetString(1);
                else if(i == 2)
                    btn_rep2.Text = reader.GetString(1);
                else if (i == 3)
                    btn_rep3.Text = reader.GetString(1);
                else
                    btn_rep4.Text = reader.GetString(1);
                i++;
            }
            reader.Close();
        }
               
        private int RetourReponse(string nomBoutton)
        {
            int reponseSelected = BouttonSelected(nomBoutton);
            string reponse = $"select dbo.validerReponse({reponseSelected});";
            int bonneReponse = 0;

            try
            {
                SqlCommand selectReponse = new SqlCommand(reponse, Form1.conn);
                selectReponse.CommandText = reponse;
                selectReponse.CommandType = CommandType.Text;

                SqlDataReader reader = selectReponse.ExecuteReader();
                reader.Read();
                bonneReponse = reader.GetInt32(0);
                reader.Close();
                return bonneReponse;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private int BouttonSelected(string nomBoutton)
        {
            int bouttonSelected = 0;

            if (nomBoutton == btn_rep1.Name)
                bouttonSelected = idQuestion * 4 - 3;
            else if (nomBoutton == btn_rep2.Name)
                bouttonSelected = idQuestion * 4 - 2;
            else if (nomBoutton == btn_rep3.Name)
                bouttonSelected = idQuestion * 4 - 1;
            else
                bouttonSelected = idQuestion * 4;
            return bouttonSelected;
        }

        private void UpdateScore(int reponse)
        {
            SqlCommand updateScore = new SqlCommand("mettreAJourScore", Form1.conn);
            updateScore.CommandText = "mettreAJourScore";
            updateScore.CommandType = CommandType.StoredProcedure;

            SqlParameter paramReponse = new SqlParameter("@reponse", SqlDbType.Int);
            paramReponse.Direction = ParameterDirection.Input;
            SqlParameter paramJoueur = new SqlParameter("@idJoueur", SqlDbType.Int);
            paramJoueur.Direction = ParameterDirection.Input;
            SqlParameter paramCategorie = new SqlParameter("@idCategorie", SqlDbType.Int);
            paramCategorie.Direction = ParameterDirection.Input;


            paramReponse.Value = reponse;
            paramJoueur.Value = idJoueurTour;
            paramCategorie.Value = catChoisi;

            updateScore.Parameters.Add(paramReponse);
            updateScore.Parameters.Add(paramJoueur);
            updateScore.Parameters.Add(paramCategorie);
            updateScore.ExecuteNonQuery();
        }

        private int GetIdJoueur(string alias)
        {
            string reponse = $"select dbo.getIdJoueur('{alias}');";
            int idJoueur = 0;
            try
            {
                SqlCommand selectId = new SqlCommand(reponse, Form1.conn);
                selectId.CommandText = reponse;
                selectId.CommandType = CommandType.Text;

                SqlDataReader reader = selectId.ExecuteReader();
                reader.Read();
                idJoueur = reader.GetInt32(0);
                reader.Close();
                return idJoueur;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void AjouterPoint()
        {
            int point;
            if (catChoisi == 1 && idJoueur1 == idJoueurTour)
            {
                point = int.Parse(btn_o1.Text);
                point++;
                btn_o1.Text = point.ToString();
            }
            else if (catChoisi == 2 && idJoueur1 == idJoueurTour)
            {
                point = int.Parse(btn_j1.Text);
                point++;
                btn_j1.Text = point.ToString();
            }
            else if (catChoisi == 3 && idJoueur1 == idJoueurTour)
            {
                point = int.Parse(btn_b1.Text);
                point++;
                btn_b1.Text = point.ToString();
            }
            else if (catChoisi == 4 && idJoueur1 == idJoueurTour)
            {
                point = int.Parse(btn_m1.Text);
                point++;
                btn_m1.Text = point.ToString();
            }
            else if (catChoisi == 1 && idJoueur2 == idJoueurTour)
            {
                point = int.Parse(btn_o2.Text);
                point++;
                btn_o2.Text = point.ToString();
            }
            else if (catChoisi == 2 && idJoueur2 == idJoueurTour)
            {
                point = int.Parse(btn_j2.Text);
                point++;
                btn_j2.Text = point.ToString();
            }
            else if (catChoisi == 3 && idJoueur2 == idJoueurTour)
            {
                point = int.Parse(btn_b2.Text);
                point++;
                btn_b2.Text = point.ToString();
            }
            else if (catChoisi == 4 && idJoueur2 == idJoueurTour)
            {
                point = int.Parse(btn_m2.Text);
                point++;
                btn_m2.Text = point.ToString();
            }
        }

        private void Gagner()
        {
            int pOrange1 = int.Parse(btn_o1.Text);
            int pJaune1 = int.Parse(btn_j1.Text);
            int pBleu1 = int.Parse(btn_b1.Text);
            int pMauve1 = int.Parse(btn_m1.Text);

            int pOrange2 = int.Parse(btn_o2.Text);
            int pJaune2 = int.Parse(btn_j2.Text);
            int pBleu2 = int.Parse(btn_b2.Text);
            int pMauve2 = int.Parse(btn_m2.Text);

            if (pOrange1 >= pointGagner && pJaune1 >= pointGagner && 
                pBleu1 >= pointGagner && pMauve1 >= pointGagner)
            {
                lbl_winner.Text += Form1.Joueur1;
                lbl_winner.Show();
                DisableReponses();
            }
            else if (pOrange2 >= pointGagner && pJaune2 >= pointGagner &&
                     pBleu2 >= pointGagner && pMauve2 >= pointGagner)
            {
                lbl_winner.Text += Form1.Joueur2;
                lbl_winner.Show();
                DisableReponses();
            }
        }

        private void DisableReponses()
        {
            btn_rep1.Enabled = false;
            btn_rep2.Enabled = false;
            btn_rep3.Enabled = false;
            btn_rep4.Enabled = false;
        }

    }
}
