using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrivialPursuit
{
    public partial class frm_delete : Form
    {
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cmb_alias.Text != "")
            {
                DeleteJoueur();
                this.Hide();
                ReloadForm();
            }
            else
            {
                lbl_erreur.Show();
            }

        }

        private void frm_delete_Load(object sender, EventArgs e)
        {
            ShowAlias();
        }

        private void frm_delete_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadForm();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReloadForm();
        }

        public frm_delete()
        {
            InitializeComponent();
        }

        private void ReloadForm()
        {
            Form1.conn.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        public void ShowAlias()
        {
            string getJoueurs = $"select Alias from Joueurs;";

            try
            {
                SqlCommand joueurs = new SqlCommand(getJoueurs, Form1.conn);

                SqlDataReader reader = joueurs.ExecuteReader();

                while (reader.Read())
                {
                    cmb_alias.Items.Add(reader[0]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteJoueur()
        {
            string alias = cmb_alias.Text;

            SqlCommand deleteJoueur = new SqlCommand("deleteJoueur", Form1.conn);
            deleteJoueur.CommandText = "deleteJoueur";
            deleteJoueur.CommandType = CommandType.StoredProcedure;

            SqlParameter paramAlias = new SqlParameter("@alias", SqlDbType.VarChar, 60);
            paramAlias.Direction = ParameterDirection.Input;


            paramAlias.Value = alias;

            deleteJoueur.Parameters.Add(paramAlias);
            deleteJoueur.ExecuteNonQuery();
        }

    }


}
