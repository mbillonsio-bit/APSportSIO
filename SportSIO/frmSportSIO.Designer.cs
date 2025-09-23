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
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSportifs = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabSportifs.SuspendLayout();
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
            this.cbxCritere.Location = new System.Drawing.Point(7, 60);
            this.cbxCritere.Name = "cbxCritere";
            this.cbxCritere.Size = new System.Drawing.Size(178, 31);
            this.cbxCritere.TabIndex = 0;
            this.cbxCritere.Text = "Identifiant";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(191, 62);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(768, 29);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecherche_KeyPress);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(965, 6);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(180, 140);
            this.btnRecherche.TabIndex = 2;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // lstvResultat
            // 
            this.lstvResultat.HideSelection = false;
            this.lstvResultat.Location = new System.Drawing.Point(7, 152);
            this.lstvResultat.Name = "lstvResultat";
            this.lstvResultat.Size = new System.Drawing.Size(1140, 522);
            this.lstvResultat.TabIndex = 3;
            this.lstvResultat.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSportifs);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1161, 706);
            this.tabControl1.TabIndex = 6;
            // 
            // tabSportifs
            // 
            this.tabSportifs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabSportifs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabSportifs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSportifs.Controls.Add(this.lstvResultat);
            this.tabSportifs.Controls.Add(this.cbxCritere);
            this.tabSportifs.Controls.Add(this.btnRecherche);
            this.tabSportifs.Controls.Add(this.txtRecherche);
            this.tabSportifs.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabSportifs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSportifs.Location = new System.Drawing.Point(4, 22);
            this.tabSportifs.Name = "tabSportifs";
            this.tabSportifs.Padding = new System.Windows.Forms.Padding(3);
            this.tabSportifs.Size = new System.Drawing.Size(1153, 680);
            this.tabSportifs.TabIndex = 0;
            this.tabSportifs.Text = "Affichages des sportifs";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1153, 680);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmSportSIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 711);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Name = "frmSportSIO";
            this.Text = "Sport Sio";
            this.tabControl1.ResumeLayout(false);
            this.tabSportifs.ResumeLayout(false);
            this.tabSportifs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCritere;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.ListView lstvResultat;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSportifs;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

