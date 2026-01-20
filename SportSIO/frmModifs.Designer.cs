namespace SportSIO
{
    partial class frmModifs
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
            this.gbxModif = new System.Windows.Forms.GroupBox();
            this.cbxSport3 = new System.Windows.Forms.ComboBox();
            this.cbxSport2 = new System.Windows.Forms.ComboBox();
            this.cbxSport = new System.Windows.Forms.ComboBox();
            this.dtpDateNais = new System.Windows.Forms.DateTimePicker();
            this.lblNomSport = new System.Windows.Forms.Label();
            this.lblNivExp = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePost = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblDateNais = new System.Windows.Forms.Label();
            this.lblPren = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtPren = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cbxNivExp = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxModif.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxModif
            // 
            this.gbxModif.Controls.Add(this.cbxSport3);
            this.gbxModif.Controls.Add(this.cbxSport2);
            this.gbxModif.Controls.Add(this.cbxSport);
            this.gbxModif.Controls.Add(this.dtpDateNais);
            this.gbxModif.Controls.Add(this.lblNomSport);
            this.gbxModif.Controls.Add(this.lblNivExp);
            this.gbxModif.Controls.Add(this.lblVille);
            this.gbxModif.Controls.Add(this.lblCodePost);
            this.gbxModif.Controls.Add(this.lblRue);
            this.gbxModif.Controls.Add(this.lblDateNais);
            this.gbxModif.Controls.Add(this.lblPren);
            this.gbxModif.Controls.Add(this.lblNom);
            this.gbxModif.Controls.Add(this.txtVille);
            this.gbxModif.Controls.Add(this.txtCP);
            this.gbxModif.Controls.Add(this.txtRue);
            this.gbxModif.Controls.Add(this.txtPren);
            this.gbxModif.Controls.Add(this.txtNom);
            this.gbxModif.Controls.Add(this.cbxNivExp);
            this.gbxModif.Location = new System.Drawing.Point(1, -13);
            this.gbxModif.Name = "gbxModif";
            this.gbxModif.Size = new System.Drawing.Size(487, 426);
            this.gbxModif.TabIndex = 1;
            this.gbxModif.TabStop = false;
            this.gbxModif.Text = "Modifier";
            // 
            // cbxSport3
            // 
            this.cbxSport3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSport3.FormattingEnabled = true;
            this.cbxSport3.Location = new System.Drawing.Point(86, 396);
            this.cbxSport3.Name = "cbxSport3";
            this.cbxSport3.Size = new System.Drawing.Size(391, 21);
            this.cbxSport3.TabIndex = 33;
            // 
            // cbxSport2
            // 
            this.cbxSport2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSport2.FormattingEnabled = true;
            this.cbxSport2.Location = new System.Drawing.Point(86, 369);
            this.cbxSport2.Name = "cbxSport2";
            this.cbxSport2.Size = new System.Drawing.Size(391, 21);
            this.cbxSport2.TabIndex = 32;
            // 
            // cbxSport
            // 
            this.cbxSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSport.FormattingEnabled = true;
            this.cbxSport.Location = new System.Drawing.Point(86, 342);
            this.cbxSport.Name = "cbxSport";
            this.cbxSport.Size = new System.Drawing.Size(391, 21);
            this.cbxSport.TabIndex = 31;
            // 
            // dtpDateNais
            // 
            this.dtpDateNais.Location = new System.Drawing.Point(127, 112);
            this.dtpDateNais.Name = "dtpDateNais";
            this.dtpDateNais.Size = new System.Drawing.Size(350, 20);
            this.dtpDateNais.TabIndex = 30;
            // 
            // lblNomSport
            // 
            this.lblNomSport.AutoSize = true;
            this.lblNomSport.Location = new System.Drawing.Point(11, 345);
            this.lblNomSport.Name = "lblNomSport";
            this.lblNomSport.Size = new System.Drawing.Size(61, 13);
            this.lblNomSport.TabIndex = 29;
            this.lblNomSport.Text = "Nom sport :";
            // 
            // lblNivExp
            // 
            this.lblNivExp.AutoSize = true;
            this.lblNivExp.Location = new System.Drawing.Point(11, 301);
            this.lblNivExp.Name = "lblNivExp";
            this.lblNivExp.Size = new System.Drawing.Size(113, 13);
            this.lblNivExp.TabIndex = 28;
            this.lblNivExp.Text = "Niveau d\'experience : ";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(11, 256);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(35, 13);
            this.lblVille.TabIndex = 27;
            this.lblVille.Text = " Ville :";
            // 
            // lblCodePost
            // 
            this.lblCodePost.AutoSize = true;
            this.lblCodePost.Location = new System.Drawing.Point(11, 210);
            this.lblCodePost.Name = "lblCodePost";
            this.lblCodePost.Size = new System.Drawing.Size(69, 13);
            this.lblCodePost.TabIndex = 26;
            this.lblCodePost.Text = "Code postal :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(11, 163);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(33, 13);
            this.lblRue.TabIndex = 25;
            this.lblRue.Text = "Rue :";
            // 
            // lblDateNais
            // 
            this.lblDateNais.AutoSize = true;
            this.lblDateNais.Location = new System.Drawing.Point(11, 118);
            this.lblDateNais.Name = "lblDateNais";
            this.lblDateNais.Size = new System.Drawing.Size(102, 13);
            this.lblDateNais.TabIndex = 24;
            this.lblDateNais.Text = "Date de naissance :";
            // 
            // lblPren
            // 
            this.lblPren.AutoSize = true;
            this.lblPren.Location = new System.Drawing.Point(11, 73);
            this.lblPren.Name = "lblPren";
            this.lblPren.Size = new System.Drawing.Size(49, 13);
            this.lblPren.TabIndex = 23;
            this.lblPren.Text = "Prenom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(11, 30);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 22;
            this.lblNom.Text = "Nom :";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(86, 253);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(391, 20);
            this.txtVille.TabIndex = 19;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(86, 207);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(391, 20);
            this.txtCP.TabIndex = 18;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(86, 160);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(391, 20);
            this.txtRue.TabIndex = 17;
            // 
            // txtPren
            // 
            this.txtPren.Location = new System.Drawing.Point(86, 70);
            this.txtPren.Name = "txtPren";
            this.txtPren.Size = new System.Drawing.Size(391, 20);
            this.txtPren.TabIndex = 15;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(86, 23);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(391, 20);
            this.txtNom.TabIndex = 14;
            // 
            // cbxNivExp
            // 
            this.cbxNivExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNivExp.FormattingEnabled = true;
            this.cbxNivExp.Items.AddRange(new object[] {
            "Débutant",
            "Confirmé",
            "Avancé",
            "Professionnel"});
            this.cbxNivExp.Location = new System.Drawing.Point(130, 298);
            this.cbxNivExp.Name = "cbxNivExp";
            this.cbxNivExp.Size = new System.Drawing.Size(347, 21);
            this.cbxNivExp.TabIndex = 4;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(1, 419);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(237, 50);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Modifier";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(252, 419);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(236, 50);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1, 419);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(237, 50);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insérer";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // frmModifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(490, 481);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.gbxModif);
            this.Name = "frmModifs";
            this.Text = "Modifier";
            this.gbxModif.ResumeLayout(false);
            this.gbxModif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxModif;
        private System.Windows.Forms.ComboBox cbxNivExp;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtPren;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DateTimePicker dtpDateNais;
        private System.Windows.Forms.Label lblNomSport;
        private System.Windows.Forms.Label lblNivExp;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCodePost;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblDateNais;
        private System.Windows.Forms.Label lblPren;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cbxSport;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbxSport3;
        private System.Windows.Forms.ComboBox cbxSport2;
    }
}