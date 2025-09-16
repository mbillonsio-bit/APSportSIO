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
            this.cbxCritere = new System.Windows.Forms.ComboBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.lstvResultat = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxCritere
            // 
            this.cbxCritere.AutoCompleteCustomSource.AddRange(new string[] {
            "Ville,",
            "Niveau d\'expérience,",
            "Nom du sport"});
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
            this.cbxCritere.Location = new System.Drawing.Point(119, 59);
            this.cbxCritere.Name = "cbxCritere";
            this.cbxCritere.Size = new System.Drawing.Size(180, 21);
            this.cbxCritere.TabIndex = 0;
            this.cbxCritere.Text = "Identifiant";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(305, 59);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(469, 20);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecherche_KeyPress);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(780, 41);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(180, 55);
            this.btnRecherche.TabIndex = 2;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // lstvResultat
            // 
            this.lstvResultat.HideSelection = false;
            this.lstvResultat.Location = new System.Drawing.Point(12, 128);
            this.lstvResultat.Name = "lstvResultat";
            this.lstvResultat.Size = new System.Drawing.Size(1036, 423);
            this.lstvResultat.TabIndex = 3;
            this.lstvResultat.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ville";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // frmSportSIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstvResultat);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.cbxCritere);
            this.Name = "frmSportSIO";
            this.Text = "Sport Sio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCritere;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.ListView lstvResultat;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

