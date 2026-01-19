namespace SportSIO
{
    partial class frmAjoutSport
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
            this.lblNomSport = new System.Windows.Forms.Label();
            this.btnAjouterSport = new System.Windows.Forms.Button();
            this.txtNomSport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomSport
            // 
            this.lblNomSport.AutoSize = true;
            this.lblNomSport.Location = new System.Drawing.Point(25, 29);
            this.lblNomSport.Name = "lblNomSport";
            this.lblNomSport.Size = new System.Drawing.Size(63, 13);
            this.lblNomSport.TabIndex = 0;
            this.lblNomSport.Text = "Nom Sport :";
            // 
            // btnAjouterSport
            // 
            this.btnAjouterSport.Location = new System.Drawing.Point(78, 70);
            this.btnAjouterSport.Name = "btnAjouterSport";
            this.btnAjouterSport.Size = new System.Drawing.Size(105, 41);
            this.btnAjouterSport.TabIndex = 1;
            this.btnAjouterSport.Text = "Ajouter";
            this.btnAjouterSport.UseVisualStyleBackColor = true;
            this.btnAjouterSport.Click += new System.EventHandler(this.btnAjouterSport_Click);
            // 
            // txtNomSport
            // 
            this.txtNomSport.Location = new System.Drawing.Point(94, 26);
            this.txtNomSport.Name = "txtNomSport";
            this.txtNomSport.Size = new System.Drawing.Size(160, 20);
            this.txtNomSport.TabIndex = 2;
            // 
            // frmAjoutSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 135);
            this.Controls.Add(this.txtNomSport);
            this.Controls.Add(this.btnAjouterSport);
            this.Controls.Add(this.lblNomSport);
            this.Name = "frmAjoutSport";
            this.Text = "Ajouter Sport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomSport;
        private System.Windows.Forms.Button btnAjouterSport;
        private System.Windows.Forms.TextBox txtNomSport;
    }
}