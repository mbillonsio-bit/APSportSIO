namespace SportSIO
{
    partial class frmSportSIO
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
            this.label2 = new System.Windows.Forms.Label();
            this.lstvResultat = new System.Windows.Forms.ListView();
            this.cbxCritere = new System.Windows.Forms.ComboBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblModifPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // lstvResultat
            // 
            this.lstvResultat.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvResultat.HideSelection = false;
            this.lstvResultat.Location = new System.Drawing.Point(11, 133);
            this.lstvResultat.Name = "lstvResultat";
            this.lstvResultat.Size = new System.Drawing.Size(1144, 566);
            this.lstvResultat.TabIndex = 8;
            this.lstvResultat.UseCompatibleStateImageBehavior = false;
            this.lstvResultat.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstvResultat_ColumnClick);
            // 
            // cbxCritere
            // 
            this.cbxCritere.AutoCompleteCustomSource.AddRange(new string[] {
            "Ville,",
            "Niveau d\'expérience,",
            "Nom du sport"});
            this.cbxCritere.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCritere.FormattingEnabled = true;
            this.cbxCritere.Items.AddRange(new object[] {
            "Identifiant",
            "Nom",
            "Prenom",
            "Date de naissance",
            "Rue",
            "Code postal",
            "Ville",
            "Niveau d\'expérience",
            "Nom du sport"});
            this.cbxCritere.Location = new System.Drawing.Point(11, 54);
            this.cbxCritere.Name = "cbxCritere";
            this.cbxCritere.Size = new System.Drawing.Size(178, 31);
            this.cbxCritere.TabIndex = 6;
            this.cbxCritere.Text = "Identifiant";
            this.cbxCritere.TextChanged += new System.EventHandler(this.cbxCritere_TextChanged);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(195, 56);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(960, 29);
            this.txtRecherche.TabIndex = 7;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // btnModif
            // 
            this.btnModif.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.Location = new System.Drawing.Point(11, 91);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(381, 39);
            this.btnModif.TabIndex = 9;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(392, 91);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(381, 39);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(774, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(381, 39);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 23);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "label1";
            // 
            // lblModifPass
            // 
            this.lblModifPass.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifPass.Location = new System.Drawing.Point(978, 12);
            this.lblModifPass.Name = "lblModifPass";
            this.lblModifPass.Size = new System.Drawing.Size(175, 30);
            this.lblModifPass.TabIndex = 13;
            this.lblModifPass.Text = "Modifier mot de passe";
            this.lblModifPass.UseVisualStyleBackColor = true;
            this.lblModifPass.Click += new System.EventHandler(this.lblModifPass_Click);
            // 
            // frmSportSIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1165, 711);
            this.Controls.Add(this.lblModifPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.lstvResultat);
            this.Controls.Add(this.cbxCritere);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.label2);
            this.Name = "frmSportSIO";
            this.Text = "Sport Sio";
            this.VisibleChanged += new System.EventHandler(this.frmSportSIO_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCritere;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.ListView lstvResultat;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button lblModifPass;
    }
}

