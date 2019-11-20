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
        public frm_delete()
        {
            InitializeComponent();
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

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void frm_delete_Load(object sender, EventArgs e)
        {
            ShowAlias();
        }
    }


}
