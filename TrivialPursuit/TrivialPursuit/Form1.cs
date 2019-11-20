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
            Joueur2 = cmb_joueur1.Text;

            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _nomOrdi = Environment.MachineName;
            ConnectionBD();
            ShowProgrammes();
        }

        private void btn_addJoueur_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
        private void ShowProgrammes()
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
            string source = $"{_nomOrdi}\\SQLEXPRESS2017";
            string bd = "TrivialPursuitBD";
            string user = txt_compte.Text;
            string pw = txt_motDePasse.Text;
            string dSource = $"Data Source={source};Initial Catalog={bd};User ID={user};Password={pw}";

            conn.ConnectionString = dSource;
            conn.Open();
        }

    }
}
