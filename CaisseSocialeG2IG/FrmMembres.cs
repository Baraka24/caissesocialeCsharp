using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CaisseSocialeG2IG
{
    public partial class FrmMembres : Form
    {
        public FrmMembres()
        {
            InitializeComponent();
        }

        private void btnDeconnection_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.ShowDialog();
        }

        private void FrmMembres_Load(object sender, EventArgs e)
        {
            AfficherMembreConnecter(false);
        }
        private void AfficherMembreConnecter(bool search)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=caisse_sociale;uid=root;pwd=";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            if (search == false)
            {
                cmd.CommandText = "select contribution1.mois,contribution1.semaine,contribution1.montant FROM contribution1 join contributeur on contribution1.matricule= contributeur.matricule where motDePasse=''";
            }
            else
            {
                cmd.CommandText = "SELECT contribution1.mois,contribution1.semaine,contribution1.montant FROM contributeur join contribution1 on contribution1.matricule= contributeur.matricule WHERE motDepasse=@pwd";
                cmd.Parameters.Add("pwd", MySqlDbType.VarChar).Value = txtPwd.Text;
            }

            cmd.Connection = conn;
            conn.Open();
            MySqlDataAdapter tuyau = new MySqlDataAdapter();
            DataTable table = new DataTable();
            tuyau.SelectCommand = cmd;
            tuyau.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void RemplirCbxNomsMembre()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=caisse_sociale;uid=root;pwd=";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT concat(contributeur.nom,' ',contributeur.postnom) as Noms from contributeur join contribution1 on contribution1.matricule=contributeur.matricule WHERE motDepasse=@pwd";
            cmd.Parameters.Add("pwd", MySqlDbType.VarChar).Value = txtPwd.Text;
            cmd.Connection = conn;
            conn.Open();
            MySqlDataAdapter tuyau = new MySqlDataAdapter();
            DataTable table = new DataTable();
            tuyau.SelectCommand = cmd;
            tuyau.Fill(table);
            //parcourir les données se trouvant dans table
            foreach (DataRow item in table.Rows)
            {
                cbxNomsMembre.Items.Add(item[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfficherMembreConnecter(true);
            
            RemplirCbxNomsMembre();
            cbxNomsMembre.SelectedIndex = 0;
            cbxNomsMembre.Visible = true;
        }
    }
}
