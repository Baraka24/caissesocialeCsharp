namespace CaisseSocialeG2IG
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpAuthentification = new System.Windows.Forms.GroupBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rdbtnMembre = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErreur = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gpAuthentification.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblErreur);
            this.groupBox1.Controls.Add(this.gpAuthentification);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentification";
            // 
            // gpAuthentification
            // 
            this.gpAuthentification.BackColor = System.Drawing.Color.DodgerBlue;
            this.gpAuthentification.Controls.Add(this.txtPwd);
            this.gpAuthentification.Controls.Add(this.txtUserName);
            this.gpAuthentification.Controls.Add(this.label4);
            this.gpAuthentification.Controls.Add(this.label3);
            this.gpAuthentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpAuthentification.ForeColor = System.Drawing.Color.White;
            this.gpAuthentification.Location = new System.Drawing.Point(438, 44);
            this.gpAuthentification.Name = "gpAuthentification";
            this.gpAuthentification.Size = new System.Drawing.Size(227, 121);
            this.gpAuthentification.TabIndex = 5;
            this.gpAuthentification.TabStop = false;
            this.gpAuthentification.Text = "Authentification";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(9, 83);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(193, 22);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(9, 39);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(193, 22);
            this.txtUserName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mot de passe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.btnConnection);
            this.panel3.Controls.Add(this.btnQuit);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(391, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 102);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnConnection
            // 
            this.btnConnection.BackColor = System.Drawing.Color.White;
            this.btnConnection.Image = global::CaisseSocialeG2IG.Properties.Resources.icons8_key_30px;
            this.btnConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnection.Location = new System.Drawing.Point(15, 37);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(116, 45);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Valider";
            this.btnConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.White;
            this.btnQuit.Image = global::CaisseSocialeG2IG.Properties.Resources.icons8_shutdown_30px;
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuit.Location = new System.Drawing.Point(146, 40);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(103, 42);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(142, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Qui êtes-vous?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.rdbtnAdmin);
            this.panel2.Controls.Add(this.rdbtnMembre);
            this.panel2.Location = new System.Drawing.Point(6, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 84);
            this.panel2.TabIndex = 0;
            // 
            // rdbtnAdmin
            // 
            this.rdbtnAdmin.AutoSize = true;
            this.rdbtnAdmin.ForeColor = System.Drawing.Color.White;
            this.rdbtnAdmin.Location = new System.Drawing.Point(140, 29);
            this.rdbtnAdmin.Name = "rdbtnAdmin";
            this.rdbtnAdmin.Size = new System.Drawing.Size(125, 20);
            this.rdbtnAdmin.TabIndex = 0;
            this.rdbtnAdmin.TabStop = true;
            this.rdbtnAdmin.Text = "Administrateur";
            this.rdbtnAdmin.UseVisualStyleBackColor = true;
            this.rdbtnAdmin.CheckedChanged += new System.EventHandler(this.rdbtnAdmin_CheckedChanged);
            // 
            // rdbtnMembre
            // 
            this.rdbtnMembre.AutoSize = true;
            this.rdbtnMembre.ForeColor = System.Drawing.Color.White;
            this.rdbtnMembre.Location = new System.Drawing.Point(12, 29);
            this.rdbtnMembre.Name = "rdbtnMembre";
            this.rdbtnMembre.Size = new System.Drawing.Size(82, 20);
            this.rdbtnMembre.TabIndex = 1;
            this.rdbtnMembre.TabStop = true;
            this.rdbtnMembre.Text = "Membre";
            this.rdbtnMembre.UseVisualStyleBackColor = true;
            this.rdbtnMembre.CheckedChanged += new System.EventHandler(this.rdbtnMembre_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaisseSocialeG2IG.Properties.Resources.FB_IMG_16138042002872975;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(97, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caisse Sociale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = " G2 INFORMATIQUE DE GESTION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 107);
            this.panel1.TabIndex = 4;
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(148, 280);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 21);
            this.lblErreur.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(695, 332);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpAuthentification.ResumeLayout(false);
            this.gpAuthentification.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpAuthentification;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbtnAdmin;
        private System.Windows.Forms.RadioButton rdbtnMembre;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErreur;
    }
}