using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrivialPursuit
{
    public partial class Form1 : Form
    {
        public static string Joueur1;
        public static string Joueur2;
        string _nomOrdi;
        public static SqlConnection conn = new SqlConnection();


        public Form1()
        {
            InitializeComponent();
        }   

        private void btn_start_Click(object sender, EventArgs e)
        {
            Joueur1 = cmb_joueur1.Text;
            Joueur2 = cmb_joueur2.Text;
            if (Joueur1 != "" && Joueur2 != "" || cmb_joueur1.Text == cmb_joueur2.Text)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
                lbl_erreur.Hide();
            }
            else
            {
                lbl_erreur.Show();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _nomOrdi = Environment.MachineName;
            ConnectionBD();
            ShowJoueurs();
            RestartGame();
        }

        private void btn_addJoueur_Click(object sender, EventArgs e)
        {
            frm_ajouter ajouterJoueur = new frm_ajouter();
            this.Hide();
            ajouterJoueur.ShowDialog();
        }

        private void btn_deleteJoueur_Click(object sender, EventArgs e)
        {
            frm_delete deleteJoueur = new frm_delete();
            this.Hide();
            deleteJoueur.ShowDialog();
        }
        public void ShowJoueurs()
        {
            string getJoueurs = $"select Alias from Joueurs;";

            try
            {
                SqlCommand joueurs = new SqlCommand(getJoueurs, conn);

                SqlDataReader reader = joueurs.ExecuteReader();

                while (reader.Read())
                {
                    cmb_joueur1.Items.Add(reader[0]);
                    cmb_joueur2.Items.Add(reader[0]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConnectionBD()
        {
            string source = $"{_nomOrdi}\\SQLEXPRESS";
            string bd = "TrivialPursuitBD";
            string user = txt_compte.Text;
            string pw = txt_motDePasse.Text;
            string dSource = $"Data Source={source};Initial Catalog={bd};User ID={user};Password={pw}";

            conn.ConnectionString = dSource;
            conn.Open();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RestartGame()
        {
            SqlCommand restartGame = new SqlCommand("restartGame", Form1.conn);
            restartGame.CommandText = "restartGame";
            restartGame.CommandType = CommandType.StoredProcedure;

            restartGame.ExecuteNonQuery();
        }

    }
}
