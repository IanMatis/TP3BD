using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrivialPursuit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        string _nomOrdi;
        public SqlConnection conn = new SqlConnection();


        private void btn_start_Click(object sender, EventArgs e)
        {
            ConnectionBD();
            ChangeForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _nomOrdi = Environment.MachineName;
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

        private void ChangeForm()
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
