using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrivialPursuit
{
    public partial class frm_ajouter : Form
    {

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            string alias = txt_alias.Text;
            string nom = txt_prenom.Text;
            string prenom = txt_nom.Text;

            if (alias != "" && nom != "" && prenom != "")
            {
                AjouterJoueur(alias, nom, prenom);
                this.Hide();
                ReloadForm();
            }
            else
            {
                lbl_erreur.Show();
            }
        }

        private void frm_ajouter_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadForm();
        }

        public frm_ajouter()
        {
            InitializeComponent();
        }

        private void AjouterJoueur(string alias, string nom, string prenom)
        {

            SqlCommand ajouterJoueur = new SqlCommand("insertJoueur", Form1.conn);
            ajouterJoueur.CommandText = "insertJoueur";
            ajouterJoueur.CommandType = CommandType.StoredProcedure;

            SqlParameter paramAlias = new SqlParameter("@alias", SqlDbType.VarChar, 60);
            paramAlias.Direction = ParameterDirection.Input;
            SqlParameter paramNom = new SqlParameter("@nom", SqlDbType.VarChar, 60);
            paramNom.Direction = ParameterDirection.Input;
            SqlParameter paramPrn = new SqlParameter("@prenom", SqlDbType.VarChar, 60);
            paramPrn.Direction = ParameterDirection.Input;


            paramAlias.Value = alias;
            paramNom.Value = nom;
            paramPrn.Value = prenom;

            ajouterJoueur.Parameters.Add(paramAlias);
            ajouterJoueur.Parameters.Add(paramNom);
            ajouterJoueur.Parameters.Add(paramPrn);
            ajouterJoueur.ExecuteNonQuery();


            //totalEtudiants();//refresh le total d'etudiants apres un ajout
        }

        private void ReloadForm()
        {
            Form1.conn.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
