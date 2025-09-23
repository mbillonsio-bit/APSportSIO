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
            this.lstvResultat = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSport = new System.Windows.Forms.TabControl();
            this.tabSportifs = new System.Windows.Forms.TabPage();
            this.tabModifs = new System.Windows.Forms.TabPage();
            this.lstvModifs = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxModifs = new System.Windows.Forms.ComboBox();
            this.tabSport.SuspendLayout();
            this.tabSportifs.SuspendLayout();
            this.tabModifs.SuspendLayout();
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
            this.cbxCritere.Location = new System.Drawing.Point(5, 72);
            this.cbxCritere.Name = "cbxCritere";
            this.cbxCritere.Size = new System.Drawing.Size(178, 31);
            this.cbxCritere.TabIndex = 0;
            this.cbxCritere.Text = "Identifiant";
            this.cbxCritere.TextChanged += new System.EventHandler(this.cbxCritere_TextChanged);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(189, 74);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(954, 29);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // lstvResultat
            // 
            this.lstvResultat.HideSelection = false;
            this.lstvResultat.Location = new System.Drawing.Point(5, 151);
            this.lstvResultat.Name = "lstvResultat";
            this.lstvResultat.Size = new System.Drawing.Size(1138, 524);
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
            // tabSport
            // 
            this.tabSport.Controls.Add(this.tabSportifs);
            this.tabSport.Controls.Add(this.tabModifs);
            this.tabSport.Location = new System.Drawing.Point(1, 1);
            this.tabSport.Name = "tabSport";
            this.tabSport.SelectedIndex = 0;
            this.tabSport.Size = new System.Drawing.Size(1164, 709);
            this.tabSport.TabIndex = 6;
            // 
            // tabSportifs
            // 
            this.tabSportifs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabSportifs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabSportifs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSportifs.Controls.Add(this.lstvResultat);
            this.tabSportifs.Controls.Add(this.cbxCritere);
            this.tabSportifs.Controls.Add(this.txtRecherche);
            this.tabSportifs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabSportifs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSportifs.Location = new System.Drawing.Point(4, 22);
            this.tabSportifs.Name = "tabSportifs";
            this.tabSportifs.Padding = new System.Windows.Forms.Padding(3);
            this.tabSportifs.Size = new System.Drawing.Size(1156, 683);
            this.tabSportifs.TabIndex = 0;
            this.tabSportifs.Text = "Affichages des sportifs";
            // 
            // tabModifs
            // 
            this.tabModifs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabModifs.Controls.Add(this.lstvModifs);
            this.tabModifs.Controls.Add(this.textBox1);
            this.tabModifs.Controls.Add(this.cbxModifs);
            this.tabModifs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabModifs.Location = new System.Drawing.Point(4, 22);
            this.tabModifs.Name = "tabModifs";
            this.tabModifs.Padding = new System.Windows.Forms.Padding(3);
            this.tabModifs.Size = new System.Drawing.Size(1156, 683);
            this.tabModifs.TabIndex = 1;
            this.tabModifs.Text = "Modifications";
            // 
            // lstvModifs
            // 
            this.lstvModifs.HideSelection = false;
            this.lstvModifs.Location = new System.Drawing.Point(6, 152);
            this.lstvModifs.Name = "lstvModifs";
            this.lstvModifs.Size = new System.Drawing.Size(1138, 524);
            this.lstvModifs.TabIndex = 4;
            this.lstvModifs.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(954, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbxModifs
            // 
            this.cbxModifs.AutoCompleteCustomSource.AddRange(new string[] {
            "Ville,",
            "Niveau d\'expérience,",
            "Nom du sport"});
            this.cbxModifs.FormattingEnabled = true;
            this.cbxModifs.Items.AddRange(new object[] {
            "Identifiant",
            "Nom",
            "Prenom",
            "Date de naissance",
            "Rue",
            "Code postal",
            "Ville",
            "Niveau d\'expérience",
            "Nom du sport"});
            this.cbxModifs.Location = new System.Drawing.Point(6, 73);
            this.cbxModifs.Name = "cbxModifs";
            this.cbxModifs.Size = new System.Drawing.Size(178, 31);
            this.cbxModifs.TabIndex = 1;
            this.cbxModifs.Text = "Identifiant";
            this.cbxModifs.TextChanged += new System.EventHandler(this.cbxModifs_TextChanged);
            // 
            // frmSportSIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 711);
            this.Controls.Add(this.tabSport);
            this.Controls.Add(this.label2);
            this.Name = "frmSportSIO";
            this.Text = "Sport Sio";
            this.tabSport.ResumeLayout(false);
            this.tabSportifs.ResumeLayout(false);
            this.tabSportifs.PerformLayout();
            this.tabModifs.ResumeLayout(false);
            this.tabModifs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCritere;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.ListView lstvResultat;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabSport;
        private System.Windows.Forms.TabPage tabSportifs;
        private System.Windows.Forms.TabPage tabModifs;
        private System.Windows.Forms.ListView lstvModifs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxModifs;
    }
}

