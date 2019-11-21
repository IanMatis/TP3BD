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

        Random r = new Random();
        int tourJoueur = 1;
        int catChoisi;
        int idQuestion;

        private void btn_play_Click(object sender, EventArgs e)
        {
            btn_play.Visible = false;
            TourJoueur();
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
            ChercherQuestion(catChoisi);
            ChercherReponses(idQuestion);
        }

        private void btn_anime_Click(object sender, EventArgs e)
        {
            catChoisi = 2;
            btn_anime.BackColor = Color.Yellow;
            DisableButtonsCategorie();
            ChercherQuestion(catChoisi);
            ChercherReponses(idQuestion);
        }

        private void btn_jeuxVideo_Click(object sender, EventArgs e)
        {
            catChoisi = 3;
            btn_jeuxVideo.BackColor = Color.Blue;
            DisableButtonsCategorie();
            ChercherQuestion(catChoisi);
            ChercherReponses(idQuestion);
        }

        private void btn_animaux_Click(object sender, EventArgs e)
        {
            catChoisi = 4;
            btn_animaux.BackColor = Color.Purple;
            DisableButtonsCategorie();
            ChercherQuestion(catChoisi);
            ChercherReponses(idQuestion);
        }

        private void DisableButtonsCategorie()
        {
            btn_animaux.Enabled = false;
            btn_anime.Enabled = false;
            btn_jeuxVideo.Enabled = false;
            btn_sport.Enabled = false;
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

        private void TourJoueur()
        {
            if (tourJoueur == 1)
            {
                lbl_tourJoueur.Text = "Tour de: " + Form1.Joueur1;
                tourJoueur = 2;
            }
            else if (tourJoueur == 2)
            {
                lbl_tourJoueur.Text = "Tour de: " + Form1.Joueur2;
                tourJoueur = 1;
            }
            SqlConnection conn = Form1.conn;
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

        private void btn_reponses(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            string nomBoutton = clicked.Name;

        }
    }
}
