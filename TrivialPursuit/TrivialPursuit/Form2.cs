using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrivialPursuit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 form1 = new Form1();
        Random r = new Random();
        int tourJoueur = 1;

        

        private void TourJoueur()
        {
            if (tourJoueur == 1)
            {
                lbl_tourJoueur.Text = "Tour du joueur 1" ;
                tourJoueur = 2;
            }
            else if (tourJoueur == 2)
            {
                lbl_tourJoueur.Text = "Tour du joueur 2";
                tourJoueur = 1;
            }
            SqlConnection conn = form1.conn;
        }

        private void CategorieChoisi()
        {
            int couleur = r.Next(1, 5);

            if (couleur == 1)
            {
                //btn_play.BackColor
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            TourJoueur();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
