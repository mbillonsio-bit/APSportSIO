using BiblioSportif;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportSIO
{
    public partial class frmModifs : Form
    {
        public static string id;
        public frmModifs(System.Windows.Forms.ListView lstv)
        {
            InitializeComponent();
            id = lstv.SelectedItems[0].SubItems[0].Text;
            txtNom.Text = lstv.SelectedItems[0].SubItems[1].Text;
            txtPren.Text = lstv.SelectedItems[0].SubItems[2].Text;
            dtpDateNais.Value = Convert.ToDateTime(lstv.SelectedItems[0].SubItems[3].Text);
            txtRue.Text = lstv.SelectedItems[0].SubItems[4].Text;
            txtCP.Text = lstv.SelectedItems[0].SubItems[5].Text;
            txtVille.Text = lstv.SelectedItems[0].SubItems[6].Text;
            cbxSport.Text = lstv.SelectedItems[0].SubItems[8].Text;
            switch (lstv.SelectedItems[0].SubItems[7].Text)
            {
                case "1":
                    cbxNivExp.SelectedIndex = 0;
                    break;
                case "2":
                    cbxNivExp.SelectedIndex = 1;
                    break;
                case "3":
                    cbxNivExp.SelectedIndex = 2;
                    break;
                case "4":
                    cbxNivExp.SelectedIndex = 3;
                    break;
            }
            if(frmSportSIO.Modif == 0)
            {
                btnInsert.Hide();
            }
            else
            {
                btnValider.Hide();
            }
        }
        public frmModifs()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPren.Text;
            DateTime dateNais = dtpDateNais.Value;
            string dateNaisString = dateNais.ToString("yyyy-MM-dd");
            string rue = '"' + txtRue.Text + '"';
            string cp = txtCP.Text;
            string ville = txtVille.Text;
            int nivExp = cbxNivExp.SelectedIndex + 1;
            int idSport = cbxSport.SelectedIndex + 1;
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            cnx.Open();
            string Update = $"UPDATE Sportif SET nom='{nom}',prenom='{prenom}',dateNais='{dateNaisString}',rue={rue},codePostal='{cp}',ville='{ville}',niveauExperience={nivExp},idSport='{idSport}' " +
                $"WHERE id = {id}";
            MySqlCommand cmd = new MySqlCommand(Update, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            List<Sportif> lesSportif = frmSportSIO.findSportifs();
            int idInsert = lesSportif.Count + 1;
            string nom = txtNom.Text;
            string prenom = txtPren.Text;
            DateTime dateNais = dtpDateNais.Value;
            string dateNaisString = dateNais.ToString("yyyy-MM-dd");
            string rue = '"' + txtRue.Text + '"';
            string cp = txtCP.Text;
            string ville = txtVille.Text;
            int nivExp = cbxNivExp.SelectedIndex + 1;
            int idSport = cbxSport.SelectedIndex + 1;
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            cnx.Open();
            string Insert = $"INSERT INTO Sportif VALUES " +
                $"({idInsert},'{nom}','{prenom}','{dateNaisString}',{rue},'{cp}','{ville}',{nivExp},'{idSport}')";
            MySqlCommand cmd = new MySqlCommand(Insert, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            this.Close();
        }

    }
}
