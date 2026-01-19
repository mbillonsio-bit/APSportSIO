using BiblioSportif;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
        public static int sport1;
        public static int sport2;
        public static int sport3;
        public frmModifs(System.Windows.Forms.ListView lstv, ListBox lst)
        {
            InitializeComponent();
            id = lstv.SelectedItems[0].SubItems[0].Text;
            txtNom.Text = lstv.SelectedItems[0].SubItems[1].Text;
            txtPren.Text = lstv.SelectedItems[0].SubItems[2].Text;
            dtpDateNais.Value = Convert.ToDateTime(lstv.SelectedItems[0].SubItems[3].Text);
            txtRue.Text = lstv.SelectedItems[0].SubItems[4].Text;
            txtCP.Text = lstv.SelectedItems[0].SubItems[5].Text;
            txtVille.Text = lstv.SelectedItems[0].SubItems[6].Text;
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
            List<Sport> lesSport = frmSportSIO.findSports();
            List<Sport> lesSport2 = frmSportSIO.findSports();
            List<Sport> lesSport3 = frmSportSIO.findSports();
            int i = 0;
            while (i < lst.Items.Count)
            {
                switch (i)
                {
                    case 0:
                        cbxSport.DataSource = lesSport;
                        cbxSport.DisplayMember = "nomSport";
                        cbxSport.Text = lst.Items[0].ToString();
                        break;
                    case 1:
                        cbxSport2.DataSource = lesSport2;
                        cbxSport2.DisplayMember = "nomSport";
                        cbxSport2.Text = lst.Items[1].ToString();
                        break;
                    case 2:
                        cbxSport3.DataSource = lesSport3;
                        cbxSport3.DisplayMember = "nomSport";
                        cbxSport3.Text = lst.Items[2].ToString();
                        break;
                }
                i++;
            }
            sport1 = cbxSport.SelectedIndex + 1;
            sport2 = cbxSport2.SelectedIndex + 1;
            sport3 = cbxSport3.SelectedIndex + 1;
        }
        public frmModifs()
        {
            InitializeComponent();
            List<Sport> lesSport = frmSportSIO.findSports();
            List<Sport> lesSport2 = frmSportSIO.findSports();
            List<Sport> lesSport3 = frmSportSIO.findSports();
            cbxSport.DataSource = lesSport;
            cbxSport.DisplayMember = "nomSport";
            cbxSport2.DataSource = lesSport2;
            cbxSport2.DisplayMember = "nomSport";
            cbxSport3.DataSource = lesSport3;
            cbxSport3.DisplayMember = "nomSport";
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
            int idSport2 = cbxSport2.SelectedIndex + 1;
            int idSport3 = cbxSport3.SelectedIndex + 1;
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            cnx.Open();
            string Update = $"UPDATE Sportif SET nom='{nom}',prenom='{prenom}',dateNais='{dateNaisString}',rue={rue},codePostal='{cp}',ville='{ville}',niveauExperience={nivExp} " +
                $"WHERE id = {id}";

            MySqlCommand cmd = new MySqlCommand(Update, cnx);
            cmd.ExecuteNonQuery();
            if (cbxSport.Text != "")
            {
                string UpdateParticipant = $"UPDATE Participe SET idSportif = {id}, idSport = {idSport} where idSportif = {id} AND idSport = {sport1}";
                MySqlCommand cmd2 = new MySqlCommand(UpdateParticipant, cnx);
                cmd2.ExecuteNonQuery();
            }
            if (cbxSport2.Text != "")
            {
                string UpdateParticipant2 = $"UPDATE Participe SET idSportif = {id}, idSport = {idSport2} where idSportif = {id} AND idSport = {sport2}";
                MySqlCommand cmd3 = new MySqlCommand(UpdateParticipant2, cnx);
                cmd3.ExecuteNonQuery();
            }
            if (cbxSport3.Text != "")
            {
                string UpdateParticipant3 = $"UPDATE Participe SET idSportif = {id}, idSport = {idSport3} where idSportif = {id} AND idSport = {sport3}";
                MySqlCommand cmd4 = new MySqlCommand(UpdateParticipant3, cnx);
                cmd4.ExecuteNonQuery();
            }
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
            int idSport2 = cbxSport2.SelectedIndex + 1;
            int idSport3 = cbxSport3.SelectedIndex + 1;

            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            cnx.Open();
            string InsertSportif = $"INSERT INTO Sportif VALUES " +
                $"({idInsert},'{nom}','{prenom}','{dateNaisString}',{rue},'{cp}','{ville}',{nivExp})";
            MySqlCommand cmd = new MySqlCommand(InsertSportif, cnx);
            cmd.ExecuteNonQuery();
            if (cbxSport.Text != "")
            {
                string InsertParticipant = $"INSERT INTO Participe VALUES ({idInsert},{idSport})";
                MySqlCommand cmd2 = new MySqlCommand(InsertParticipant, cnx);
                cmd2.ExecuteNonQuery();
            }
            if (cbxSport2.Text != "")
            {
                string InsertParticipant2 = $"INSERT INTO Participe VALUES ({idInsert},{idSport2})";
                MySqlCommand cmd3 = new MySqlCommand(InsertParticipant2, cnx);
                cmd3.ExecuteNonQuery();
            }
            if (cbxSport3.Text != "")
            {
                string InsertParticipant3 = $"INSERT INTO Participe VALUES ({idInsert},{idSport3})";
                MySqlCommand cmd4 = new MySqlCommand(InsertParticipant3, cnx);
                cmd4.ExecuteNonQuery();
            }
            cnx.Close();
            this.Close();
        }

    }
}
