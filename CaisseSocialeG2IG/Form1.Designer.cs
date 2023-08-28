namespace CaisseSocialeG2IG
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAffichage = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnCompleterFiche = new System.Windows.Forms.Button();
            this.btnMembres = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 95);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(116, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caisse Sociale G2 INFORMATIQUE DE GESTION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.btnImprimer);
            this.panel2.Controls.Add(this.btnCompleterFiche);
            this.panel2.Controls.Add(this.btnMembres);
            this.panel2.Controls.Add(this.btnAccueil);
            this.panel2.Location = new System.Drawing.Point(89, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 52);
            this.panel2.TabIndex = 1;
            // 
            // pnlAffichage
            // 
            this.pnlAffichage.BackColor = System.Drawing.Color.White;
            this.pnlAffichage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAffichage.Location = new System.Drawing.Point(0, 95);
            this.pnlAffichage.Name = "pnlAffichage";
            this.pnlAffichage.Size = new System.Drawing.Size(711, 371);
            this.pnlAffichage.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::CaisseSocialeG2IG.Properties.Resources.icons8_minimize_window_30px;
            this.btnMinimize.Location = new System.Drawing.Point(646, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 23);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::CaisseSocialeG2IG.Properties.Resources.icons8_close_window_30px;
            this.btnClose.Location = new System.Drawing.Point(679, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.FlatAppearance.BorderSize = 0;
            this.btnImprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnImprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(81)))), ((int)(((byte)(219)))));
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimer.Image = global::CaisseSocialeG2IG.Properties.Resources.icons8_view_50px_1;
            this.btnImprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimer.Location = new System.Drawing.Point(474, 1);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(146, 49);
            this.btnImprimer.TabIndex = 0;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnCompleterFiche
            // 
            this.btnCompleterFiche.FlatAppearance.BorderSize = 0;
            this.btnCompleterFiche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnCompleterFiche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(81)))), ((int)(((byte)(219)))));
            this.btnCompleterFiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleterFiche.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleterFiche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompleterFiche.Image = global::CaisseSocialeG2IG.Properties.Resources.icons8_send_hot_list_50px;
            this.btnCompleterFiche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompleterFiche.Location = new System.Drawing.Point(264, 1);
            this.btnCompleterFiche.Name = "btnCompleterFiche";
            this.btnCompleterFiche.Size = new System.Drawing.Size(194, 49);
            this.btnCompleterFiche.TabIndex = 0;
            this.btnCompleterFiche.Text = "Completer Fiche";
            this.btnCompleterFiche.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCompleterFiche.UseVisualStyleBackColor = true;
            this.btnCompleterFiche.Click += new System.EventHandler(this.btnCompleterFiche_Click);
            // 
            // btnMembres
            // 
            this.btnMembres.FlatAppearance.BorderSize = 0;
            this.btnMembres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnMembres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(81)))), ((int)(((byte)(219)))));
            this.btnMembres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembres.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMembres.Image = global::CaisseSocialeG2IG.Properties.Resources.icons8_leader_1_64px;
            this.btnMembres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembres.Location = new System.Drawing.Point(120, 0);
            this.btnMembres.Name = "btnMembres";
            this.btnMembres.Size = new System.Drawing.Size(147, 49);
            this.btnMembres.TabIndex = 0;
            this.btnMembres.Text = "Membres";
            this.btnMembres.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMembres.UseVisualStyleBackColor = true;
            this.btnMembres.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAccueil
            // 
            this.btnAccueil.FlatAppearance.BorderSize = 0;
            this.btnAccueil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnAccueil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(81)))), ((int)(((byte)(219)))));
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueil.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccueil.Image = global::CaisseSocialeG2IG.Properties.Resources.icons8_home_page_50px;
            this.btnAccueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccueil.Location = new System.Drawing.Point(4, 1);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(117, 49);
            this.btnAccueil.TabIndex = 0;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaisseSocialeG2IG.Properties.Resources.FB_IMG_16138042002872975;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 466);
            this.Controls.Add(this.pnlAffichage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Panel pnlAffichage;
        private System.Windows.Forms.Button btnMembres;
        private System.Windows.Forms.Button btnCompleterFiche;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}

