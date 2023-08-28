using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaisseSocialeG2IG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//reduire la forme
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ///this.Close();//fermer ceci
            Login frm = new Login();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            UCAccueil uc = new UCAccueil();
            pnlAffichage.Controls.Clear();
            pnlAffichage.Controls.Add(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UCAccueil uc = new UCAccueil();//Appel à UCAccueil pendant le démarrage de l'app cad dans Load event
            pnlAffichage.Controls.Add(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCMembres uc = new UCMembres();//création de l'objet UC en utilisant le controle d'utilisateur 
            pnlAffichage.Controls.Clear();//pnAffichage efface ton contenu
            pnlAffichage.Controls.Add(uc);//pnAffichage considère uc après déclenchement de l'event
        }

        private void btnCompleterFiche_Click(object sender, EventArgs e)
        {
            UCFiches uc = new UCFiches();
            pnlAffichage.Controls.Clear();
            pnlAffichage.Controls.Add(uc);
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            //FrmImprimerFiches frm = new FrmImprimerFiches();
            //frm.ShowDialog();
        }
    }
}
