using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CaisseSocialeG2IG
{
    public partial class UCMembres : UserControl
    {
        public UCMembres()
        {
            InitializeComponent();
        }
        private void RemplirTxtMatricule()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=caisse_sociale;uid=root;pwd=";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select matricule from contributeur ORDER BY dateinscription DESC";
            cmd.Connection = conn;
            conn.Open();
            string matricule = "";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                matricule = reader["matricule"].ToString();
            }
            else
            {
                txtMatricule.Text = "IG001/" + DateTime.Now.Year;
                return;
            }
            //recupérer une chaîne de caractères avec substring fonction qui prend l'index et la longueur de la chaîne des caractères
            string numpart = matricule.Substring(2, 3);
            int NewNum = int.Parse(numpart)+1;
            string nextMat = matricule.Replace(numpart, string.Format("{0:D3}", NewNum));
            txtMatricule.Text = nextMat;

        }
        private void UCMembres_Load(object sender, EventArgs e)
        {
            AfficherMembres();
           RemplirTxtMatricule();
        }
        private void AfficherMembres()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=caisse_sociale;uid=root;pwd=";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from contributeur";
            cmd.Connection = conn;
            conn.Open();
            MySqlDataAdapter tuyau = new MySqlDataAdapter();
            DataTable table = new DataTable();
            tuyau.SelectCommand = cmd;
            tuyau.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void ViderChamps()
        {
            txtMatricule.Text = "";
            txtNom.Text = "";
            txtPostnom.Text = "";
            txtPrenom.Text = "";
            //cbxSexe.Text = "";
            cbxSexe.SelectedIndex = -1;
            txtpwd.Text = "";
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            //Verifier s'il n'y a pas d'erreurs dans les champs
            if (!ChampsOK())
            {
                NotifierErreur();
                return;
            }
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            conn.ConnectionString = "server=localhost;database=caisse_sociale;uid=root;pwd=";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            if (upDateMembres == true)
            {
                txtMatricule.ReadOnly = true;
                cmd.CommandText = "update contributeur set nom=@nom,postnom=@postnom,prenom=@prenom,motdepasse=@pwd,genre=@sexe,dateInscription=@dateInscription where matricule=@matricule";
            }
            
            else if( upDateMembres == false)
            { 
                cmd.CommandText = "insert into contributeur(matricule,nom,postnom,prenom,genre,motdepasse,dateInscription) values(@matricule,@nom,@postnom,@prenom,@sexe,@pwd,@dateInscription)";  
            }
            //string s1 = "IG";
            //string s2 = "/2019";
            //string mat;
            //for (int i = 0; ; i++)
            //{
            //    mat = s1 + i + s2;
            //}
            cmd.Parameters.Add("matricule", MySqlDbType.VarChar).Value = txtMatricule.Text;
            cmd.Parameters.Add("nom", MySqlDbType.VarChar).Value = txtNom.Text;
            cmd.Parameters.Add("postnom", MySqlDbType.VarChar).Value = txtPostnom.Text;
            cmd.Parameters.Add("prenom", MySqlDbType.VarChar).Value = txtPrenom.Text;
            cmd.Parameters.Add("sexe", MySqlDbType.VarChar).Value = cbxSexe.Text;
            cmd.Parameters.Add("pwd", MySqlDbType.VarChar).Value = txtpwd.Text;
            cmd.Parameters.Add("dateInscription", MySqlDbType.DateTime).Value = dateTimePicker1.Value;
                
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                RemplirTxtMatricule();
                MessageBox.Show("Enregistré avec succès!", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AfficherMembres();
                ViderChamps();
                upDateMembres = false;
                
            }
            else
            {
                MessageBox.Show("Echec lors de l'enregistrement", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool upDateMembres;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtMatricule.Text = dataGridView1.CurrentRow.Cells["matricule"].Value.ToString();
            txtNom.Text = dataGridView1.CurrentRow.Cells["nom"].Value.ToString();
            txtPostnom.Text = dataGridView1.CurrentRow.Cells["postnom"].Value.ToString();
            txtPrenom.Text = dataGridView1.CurrentRow.Cells["prenom"].Value.ToString();
            cbxSexe.Text = dataGridView1.CurrentRow.Cells["genre"].Value.ToString();
            txtpwd.Text = dataGridView1.CurrentRow.Cells["motDePasse"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["dateInscription"].Value.ToString();
            upDateMembres = true;
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=caisse_sociale;uid=root;pwd=";
            MySqlCommand cmd = new MySqlCommand();
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous vraiment supprimer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.No)
            {
                return;
            }
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=caisse_sociale;uid=root;pwd=";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from contributeur where matricule=@matricule";
            cmd.Parameters.Add("matricule", MySqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Suppression effectuée avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AfficherMembres();
                    RemplirTxtMatricule();
                }
                else
                {
                    MessageBox.Show("Echec de suppression!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //FrmListe_Membres frm = new FrmListe_Membres();
            //frm.ShowDialog();
        }
        //création de la fonction qui voit si les champs sont corrects 
        private bool ChampsOK()
        {

            if (txtMatricule.Text != "" && txtNom.Text != "" && txtPostnom.Text != "" && txtPrenom.Text != "" && txtpwd.Text != "" && cbxSexe.SelectedIndex != -1 && txtpwd.Text != "")
            {
                return true;
            }
            return false;
        }
        //fonction qui notifie lorsqu'il y a erreur
        private void NotifierErreur()
        {
            if (txtMatricule.Text == "")
            {
                errorProvider1.SetError(txtMatricule, "Entrer le matricule!");
            }
            else
            {
                errorProvider1.SetError(txtMatricule, "");
            }
            if (cbxSexe.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbxSexe, "Veuillez selectionner le sexe!");
            }
            else
            {
                errorProvider1.SetError(cbxSexe, "");
            }
            if (txtNom.Text=="")
            {
                errorProvider1.SetError(txtNom, "Veuillez entrer le nom!");
            }
            else
            {
                errorProvider1.SetError(txtNom, "");
            }
            if (txtPrenom.Text=="")
            {
                errorProvider1.SetError(txtPrenom, "Veuillez entrer le prenom!");
            }
            else
            {
                errorProvider1.SetError(txtPrenom, "");
            }
            if (txtPostnom.Text == "")
            {
                errorProvider1.SetError(txtPostnom, "Veuillez entrer le postnom!");
            }
            else
            {
                errorProvider1.SetError(txtPostnom, "");
            }
            if (txtpwd.Text == "")
            {
                errorProvider1.SetError(txtpwd, "Veuillez entrer le mot de passe!");
            }
            else
            {
                errorProvider1.SetError(txtpwd, "");
            }

        }
    }
}
