using BiblioSportif;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SportSIO
{    
    public partial class frmSportSIO : Form
    {
        public static int Modif;

        public void AddSportSportif(string idSportif)
        {
            lstSports.Items.Clear();
            string chConnexion = ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString;
            MySqlConnection cnx = new MySqlConnection(chConnexion);
            cnx.Open();
            string req = $"SELECT Sp.nomSport FROM Participe P INNER JOIN Sport Sp ON P.idSport = {idSportif};";
            MySqlCommand cmd = new MySqlCommand(req, cnx);
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lstSports.Items.Add(rd[0].ToString());
            }
        }
        public static List<Sportif> findSportifs()
        {
            List<Sportif> lesSportifs = new List<Sportif>();
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            cnx.Open();
            string Search = "SELECT * FROM Sportif";
            MySqlCommand cmd = new MySqlCommand(Search, cnx);
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Sportif sportif = new Sportif((int)rd[0], rd[1].ToString(), rd[2].ToString(), (DateTime)rd[3], rd[4].ToString(),
                    rd[5].ToString(), rd[6].ToString(), (int)rd[7]);
                lesSportifs.Add(sportif);
            }
            cnx.Close();
            return lesSportifs;
        }

        public static List<Participe> findParticipe()
        {
            List<Participe> lesParticipants = new List<Participe>();
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            cnx.Open();
            string Search = "SELECT * FROM Participe";
            MySqlCommand cmd = new MySqlCommand(Search, cnx);
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Participe participe = new Participe((int)rd[0], (int)rd[1]);
                lesParticipants.Add(participe);
            }
            cnx.Close();
            return lesParticipants;
        }



        public static List<Sport> findSports()
        {
            List<Sport> lesSports = new List<Sport>();
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            cnx.Open();
            string Search = "SELECT * FROM Sport";
            MySqlCommand cmd = new MySqlCommand(Search, cnx);
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Sport sport = new Sport((int)rd[0], rd[1].ToString());
                lesSports.Add(sport);
            }
            cnx.Close();
            return lesSports;
        }

        public void columnsRead(System.Windows.Forms.ListView lstv, MySqlDataReader rd)
        {
            lstv.Columns.Clear();
            lstv.Items.Clear(); 
            lstv.View = View.Details; 
            lstv.Columns.Add("Id");
            lstv.Columns.Add("Nom");
            lstv.Columns.Add("Prenom");
            lstv.Columns.Add("Date de naissance");
            lstv.Columns.Add("Rue");
            lstv.Columns.Add("Code postal");
            lstv.Columns.Add("Ville");
            lstv.Columns.Add("Niveau d'experience");
            lstv.Columns.Add("Nom du sport");
            lstv.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            lstv.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            lstv.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize);
            lstv.AutoResizeColumn(7, ColumnHeaderAutoResizeStyle.HeaderSize);
            lstv.Columns[8].Width = 138;
            lstv.Columns[4].Width = 200;
            lstv.Columns[2].Width = 100;
            lstv.Columns[6].Width = 150;
            lstv.Columns[1].Width = 100;
            List<Sportif> Sportifs = new List<Sportif>();
            List<Participe> lesParticipants = new List<Participe>();
            List<Sport> Sports = new List<Sport>();
            while (rd.Read())
            {
                Sportif unSportif = new Sportif((int)rd[0], rd[1].ToString(), rd[2].ToString(), (DateTime)rd[3], rd[4].ToString(),
                    rd[5].ToString(), rd[6].ToString(), (int)rd[7]);
                Participe unParticipe = new Participe((int)rd[10], (int)rd[9]);
                Sport unSport = new Sport((int)rd[9], rd[8].ToString());
                lesParticipants.Add(unParticipe);
                Sportifs.Add(unSportif);
                Sports.Add(unSport);

                ListViewItem lv = new ListViewItem(rd[0].ToString());
                lv.SubItems.Add(rd[1].ToString());
                lv.SubItems.Add(rd[2].ToString());
                lv.SubItems.Add(rd.GetDateTime(3).ToShortDateString());
                lv.SubItems.Add(rd[4].ToString());
                lv.SubItems.Add(rd[5].ToString());
                lv.SubItems.Add(rd[6].ToString());
                lv.SubItems.Add(rd[7].ToString());
                lv.SubItems.Add(rd[8].ToString());
                lstv.Items.Add(lv);
            }
            lstv.FullRowSelect = true;
        }
        public void StartListView(System.Windows.Forms.ListView lstv)
        {
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString); 
            cnx.Open();
            string Search = "SELECT S.id,S.nom,S.prenom,S.dateNais,S.rue,S.codePostal,S.ville,S.niveauExperience,Sp.nomSport,P.idSport,P.idSportif FROM Participe P INNER JOIN Sportif S ON S.id=P.idSportif INNER JOIN Sport Sp ON P.idSport = Sp.id;";
            MySqlCommand cmd = new MySqlCommand(Search, cnx);
            MySqlDataReader rd = cmd.ExecuteReader();
            columnsRead(lstv, rd);

            cnx.Close();
        }
        public void SearchListView(System.Windows.Forms.ListView lstv)
        {    
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            MySqlDataReader rd = Sportif.GetSportif(txtRecherche.Text, cbxCritere.SelectedIndex);
            columnsRead(lstv, rd);


            cnx.Close();
        }
        public frmSportSIO()
        {
            InitializeComponent();
            StartListView(lstvResultat);
            lblUser.Text = "Utilisateur : " + frmLogin.cpte.Username;
        }

        private void cbxCritere_TextChanged(object sender, EventArgs e)
        {
            txtRecherche.Clear();
            StartListView(lstvResultat);
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            List<Sportif> Sportifs = new List<Sportif>();
            try
            {
                if (txtRecherche.Text != "")
                {
                    SearchListView(lstvResultat);
                    return;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                StartListView(lstvResultat);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Modif = 0;
            if (lstvResultat.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un sportif à modifier");
                return;
            }
            else 
            {
                frmModifs modif = new frmModifs(lstvResultat);
                this.Hide();
                modif.ShowDialog();
                this.Show();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Modif = 1;
            frmModifs modif = new frmModifs();
            this.Hide();
            modif.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstvResultat.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un sportif à supprimer");
                return;
            }
            else
            {
                string id = lstvResultat.SelectedItems[0].SubItems[0].Text;
                MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
                cnx.Open();
                string Delete = $"CALL DeleteSportif({id})";
                MySqlCommand cmd = new MySqlCommand(Delete, cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
                StartListView(lstvResultat);
            }
        }

        private void lblModifPass_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            frmLogin.lblForgot_Click(sender, e);
            frmLogin.txtUser.Text = frmLogin.cpte.Username;
        }

        private void frmSportSIO_VisibleChanged(object sender, EventArgs e)
        {
            StartListView(lstvResultat);
        }

        private void lstvResultat_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            string order = "id";
            switch (lstvResultat.Columns[e.Column].Index)
            {
                case 0:
                    order = "id";
                    break;
                case 1:
                    order = "nom";
                    break;
                case 2:
                    order = "prenom";
                    break;
                case 3:
                    order = "dateNais";
                    break;
                case 4:
                    order = "rue";
                    break;
                case 5:
                    order = "codePostal";
                    break;
                case 6:
                    order = "ville";
                    break;
                case 7:
                    order = "niveauExperience";
                    break;
                case 8:
                    order = "idSport";
                    break;
            }
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            cnx.Open();
            string Delete = $"SELECT S.id,S.nom,S.prenom,S.dateNais,S.rue,S.codePostal,S.ville,S.niveauExperience,Sp.nomSport,P.idSport,P.idSportif FROM Participe P INNER JOIN Sportif S ON S.id=P.idSportif INNER JOIN Sport Sp ON P.idSport = Sp.id ORDER BY {order} asc";
            MySqlCommand cmd = new MySqlCommand(Delete, cnx);
            MySqlDataReader rd = cmd.ExecuteReader();
            columnsRead(lstvResultat, rd);
            cnx.Close();
        }

        private void lstvResultat_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddSportSportif(lstvResultat.SelectedItems[0].SubItems[0].Text);
        }
    }
}
