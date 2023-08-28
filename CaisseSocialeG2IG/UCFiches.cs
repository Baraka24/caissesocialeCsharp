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
    public partial class UCFiches : UserControl
    {
        public UCFiches()
        {
            InitializeComponent();
        }

        private void UCFiches_Load(object sender, EventArgs e)
        {
            AfficherPaiements(false);
            RemplirCbxMatricule();
        }
        //fonction qui vide les champs
        private void ViderChamps()
        {
            cbxSemaine.SelectedIndex = -1;
            cbxMois.SelectedIndex = -1;
            cbxMatricule.SelectedIndex = -1;
            txtMontant.Text = "";
        }
        //création de la méthode AfficherPaiements qui permettra de chaque fois afficher le contenu de la table contribution
        private void AfficherPaiements(bool search)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=caisse_sociale;uid=root;pwd=";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            if (search == false)
            {
                cmd.CommandText = "select * from contribution1";
            }
            else
            {
                cmd.CommandText = "SELECT *FROM contribution1 WHERE matricule LIKE @matricule";
                cmd.Parameters.Add("matricule", MySqlDbType.VarChar).Value = txtSearch.Text + "%";
            }

            cmd.Connection = conn;
            conn.Open();
            MySqlDataAdapter tuyau = new MySqlDataAdapter();
            DataTable table = new DataTable();
            tuyau.SelectCommand = cmd;
            tuyau.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void RemplirCbxMatricule()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;database=caisse_sociale;uid=root;pwd=";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select matricule from contributeur";
            cmd.Connection = conn;
            conn.Open();
            MySqlDataAdapter tuyau = new MySqlDataAdapter();
            DataTable table = new DataTable();
            tuyau.SelectCommand = cmd;
            tuyau.Fill(table);
            //parcourir les données se trouvant dans table
            foreach (DataRow item in table.Rows)
            {
                cbxMatricule.Items.Add(item[0]);
            }
        }
        //fonction pour vérifier si le mois,la semaine et le matricule existe pour un enregistrement donné
        private bool VerifierMatriculeMoisSemaineExiste()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (cbxMatricule.SelectedItem.ToString() == dataGridView1.Rows[i].Cells["matricule"].Value.ToString() && cbxMois.SelectedItem.ToString() == dataGridView1.Rows[i].Cells["mois"].Value.ToString() && cbxSemaine.SelectedItem.ToString() == dataGridView1.Rows[i].Cells["semaine"].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        int numero = 0;
        //fonction permettant d' éditer le numéro(ex. datagridview vide)
        private int GetNumeroToEdit()
        {
            int num = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (cbxMatricule.SelectedItem.ToString() == dataGridView1.Rows[i].Cells["matricule"].Value.ToString() && cbxMois.SelectedItem.ToString() == dataGridView1.Rows[i].Cells["mois"].Value.ToString()&&cbxSemaine.SelectedItem.ToString() == dataGridView1.Rows[i].Cells["semaine"].Value.ToString())
                {
                    num = int.Parse(dataGridView1.Rows[i].Cells["numero"].Value.ToString());
                }
            }
            return num;
        }
        //Decimal montantAjouter = -1;
        decimal mt;
        //création de la fonction qui voit si les champs sont corrects 
        private bool ChampsOK()
        {
            
            if (cbxMatricule.SelectedIndex!=-1 && cbxMois.SelectedIndex!=-1 && cbxSemaine.SelectedIndex!=-1 && decimal.TryParse(txtMontant.Text, out mt))
            {
                return true;
            }
            return false;
        }
        //fonction qui notifie lorsqu'il y a erreur
        private void NotifierErreur()
        {
            if (cbxMatricule.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbxMatricule, "Veuillez selectionner le matricule!");
            }
            else
            {
                errorProvider1.SetError(cbxMatricule, "");
            }
            if (cbxMois.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbxMois, "Veuillez selectionner le mois!");
            }
            else
            {
                errorProvider1.SetError(cbxMois, "");
            }
            if (cbxSemaine.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbxSemaine, "Veuillez selectionner la semaine!");
            }
            else
            {
                errorProvider1.SetError(cbxSemaine, "");
            }
            if (txtMontant.Text!=decimal.TryParse(txtMontant.Text, out mt).ToString())
            {
                errorProvider1.SetError(txtMontant, "Veuillez entrer un montant correct svp!");
            }
            else
            {
                errorProvider1.SetError(txtMontant, "");
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Verifier s'il n'y a pas d'erreurs dans les champs
            if (!ChampsOK())
            {
                NotifierErreur();
                return;
            }

            //Insertion des données dans la table Contribution
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            conn.ConnectionString = "server=localhost;database=caisse_sociale;uid=root;pwd=";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            if (upDatePaiements == true )
            {
                cmd.CommandText = "update contribution1 set mois=@mois,montant=@montant,semaine=@semaine where numero=@numero";
                cmd.Parameters.Add("numero", MySqlDbType.Int32).Value = dataGridView1.CurrentRow.Cells["numero"].Value.ToString();
                cmd.Parameters.Add("montant", MySqlDbType.Decimal).Value = txtMontant.Text;
                cmd.Parameters.Add("mois", MySqlDbType.VarChar).Value = cbxMois.Text;
                cmd.Parameters.Add("semaine", MySqlDbType.VarChar).Value = cbxSemaine.Text;
            }
            else
            {
                if ( VerifierMatriculeMoisSemaineExiste())
                {
                    cmd.CommandText = "update contribution1 set montant=@montant where matricule=@matricule and mois=@mois and semaine=@semaine";
                    cmd.Parameters.Add("montant", MySqlDbType.Decimal).Value = decimal.Parse(dataGridView1.CurrentRow.Cells["montant"].Value.ToString()) + decimal.Parse(txtMontant.Text);
                    cmd.Parameters.Add("matricule", MySqlDbType.VarChar).Value = cbxMatricule.Text;
                    cmd.Parameters.Add("mois", MySqlDbType.VarChar).Value = cbxMois.Text;
                    cmd.Parameters.Add("semaine", MySqlDbType.VarChar).Value = cbxSemaine.Text;

                }
                else
                {
                    cmd.CommandText = "insert into contribution1(matricule,mois,montant,semaine) values(@matricule,@mois,@montant,@semaine)";
                    cmd.Parameters.Add("montant", MySqlDbType.Decimal).Value = txtMontant.Text;
                    cmd.Parameters.Add("matricule", MySqlDbType.VarChar).Value = cbxMatricule.Text;
                    cmd.Parameters.Add("mois", MySqlDbType.VarChar).Value = cbxMois.Text;
                    cmd.Parameters.Add("semaine", MySqlDbType.VarChar).Value = cbxSemaine.Text;
                    cmd.Parameters.Add("numero", MySqlDbType.Int32).Value = GetNumeroToEdit();
                }
            }
            
           
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Enregistré avec succès!", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AfficherPaiements(false);
                ViderChamps();
                RemplirCbxMatricule();
                upDatePaiements = false;
            }
            else 
            {
                MessageBox.Show("Echec lors de l'enregistrement", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        
            
        }
        //modifier
        bool upDatePaiements;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            numero = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cbxMatricule.Text = dataGridView1.CurrentRow.Cells["matricule"].Value.ToString();
            cbxMois.Text = dataGridView1.CurrentRow.Cells["mois"].Value.ToString();
            cbxSemaine.Text = dataGridView1.CurrentRow.Cells["semaine"].Value.ToString();
            txtMontant.Text = dataGridView1.CurrentRow.Cells["montant"].Value.ToString();
            //montantAjouter = decimal.Parse(dataGridView1.CurrentRow.Cells["montant"].Value.ToString());
            upDatePaiements = true;
            //MySqlConnection conn = new MySqlConnection();
            //conn.ConnectionString = "server=localhost;database=caisse_sociale;uid=root;pwd=";
            //MySqlCommand cmd = new MySqlCommand();
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
            cmd.CommandText = "delete from contribution1 where numero=@numero";
            cmd.Parameters.Add("numero", MySqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Suppression effectuée avec succès!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AfficherPaiements(false);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AfficherPaiements(true);
        }

        private void cbxMatricule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMatricule.SelectedIndex!=-1)
            {
                errorProvider1.SetError(cbxMatricule, "");
            }
        }
    }
}
