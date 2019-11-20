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

        private void CategorieChoisi()
        {
            int couleur = r.Next(1, 5);

            if (couleur == 1)
            {
                btn_play.BackColor = Color.Red;
            }
            else if (couleur == 2)
            {
                btn_play.BackColor = Color.Blue;
            }
            else if (couleur == 3)
            {
                btn_play.BackColor = Color.Green;
            }
            else
            {
                btn_play.BackColor = Color.Yellow;
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            TourJoueur();
            CategorieChoisi();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
