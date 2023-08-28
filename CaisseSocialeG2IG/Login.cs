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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void rdbtnMembre_CheckedChanged(object sender, EventArgs e)
        {
            gpAuthentification.Text = "Membre";
        }

        private void rdbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            gpAuthentification.Text = "Administrateur";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=caisse_sociale;uid=root;pwd=";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            if (gpAuthentification.Text == "Administrateur")
            {
                cmd.CommandText = "select * from Admin where username=@username and pwd=@pwd";
                cmd.Parameters.Add("username", MySqlDbType.VarChar).Value = txtUserName.Text;
                cmd.Parameters.Add("pwd", MySqlDbType.VarChar).Value = txtPwd.Text;
                cmd.Connection = conn;
                DataTable dt = new DataTable();
                MySqlDataAdapter tuyau = new MySqlDataAdapter();
                tuyau.SelectCommand = cmd;
                tuyau.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Form1 frm = new Form1();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    //MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrect!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    lblErreur.Text = "Nom d'utilisateur ou Mot de passe incorrect!";
                }
            }
            else
            {
                cmd.CommandText = "select * from contributeur where matricule=@matricule and motDePasse=@pwd";
                cmd.Parameters.Add("matricule", MySqlDbType.VarChar).Value = txtUserName.Text;
                cmd.Parameters.Add("pwd", MySqlDbType.VarChar).Value = txtPwd.Text;
                cmd.Connection = conn;
                DataTable dt = new DataTable();
                MySqlDataAdapter tuyau = new MySqlDataAdapter();
                tuyau.SelectCommand = cmd;
                tuyau.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    FrmMembres frm = new FrmMembres();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    //MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrect!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    lblErreur.Text = "Nom d'utilisateur ou Mot de passe incorrect!";
                }
            }
        }
    }
}
