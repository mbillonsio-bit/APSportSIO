using BiblioSportif;
using MySql.Data.MySqlClient;
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
        public void StartListView()
        {
            lstvResultat.Columns.Clear(); // Clear previously added columns
            lstvResultat.Items.Clear(); // Clear previously populated items
            lstvResultat.View = View.Details; // Set View property
            string chConnexion = ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString;
            MySqlConnection cnx = new MySqlConnection(chConnexion);
            cnx.Open();
            string Search = "SELECT * FROM Sportif";
            MySqlCommand cmd = new MySqlCommand(Search, cnx);
            MySqlDataReader rd = cmd.ExecuteReader();

            lstvResultat.Columns.Add("Id");
            lstvResultat.Columns.Add("Nom");
            lstvResultat.Columns.Add("Prenom");
            lstvResultat.Columns.Add("Date de naissance");
            lstvResultat.Columns.Add("Rue");
            lstvResultat.Columns.Add("Code postal");
            lstvResultat.Columns.Add("Ville");
            lstvResultat.Columns.Add("Niveau d'experience");
            lstvResultat.Columns.Add("Nom du sport");

            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd[0].ToString());
                lv.SubItems.Add(rd[1].ToString());
                lv.SubItems.Add(rd[2].ToString());
                lv.SubItems.Add(rd[3].ToString());
                lv.SubItems.Add(rd[4].ToString());
                lv.SubItems.Add(rd[5].ToString());
                lv.SubItems.Add(rd[6].ToString());
                lv.SubItems.Add(rd[7].ToString());
                lv.SubItems.Add(rd[8].ToString());
                lstvResultat.Items.Add(lv);
            }
            cnx.Close();
        }
        public void SearchListView()
        {
            string searchValue;
            string searchCriteria;
            
            lstvResultat.Columns.Clear(); // Clear previously added columns
            lstvResultat.Items.Clear(); // Clear previously populated items
            lstvResultat.View = View.Details; // Set View property
            string chConnexion = ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString;
            MySqlConnection cnx = new MySqlConnection(chConnexion);
            cnx.Open();
            switch (cbxCritere.SelectedIndex)
            {
                case 0:
                    searchValue = $"{txtRecherche.Text}";
                    searchCriteria = "id";
                    break;
                case 1:
                    searchValue = $"'%{txtRecherche.Text}%'";
                    searchCriteria = "nom";
                    break;
                case 2:
                    searchValue = $"'%{txtRecherche.Text}%'";
                    searchCriteria = "prenom";
                    break;
                case 3:
                    searchValue = $"'%{txtRecherche.Text}%'";
                    searchCriteria = "dateNais";
                    break;
                case 4:
                    searchValue = $"'%{txtRecherche.Text}%'";
                    searchCriteria = "rue";
                    break;
                case 5:
                    searchValue = $"'%{txtRecherche.Text}%'";
                    searchCriteria = "codePostal";
                    break;
                case 6:
                    searchValue = $"'%{txtRecherche.Text}%'";
                    searchCriteria = "ville";
                    break;
                case 7:
                    searchValue = $"{txtRecherche.Text}";
                    searchCriteria = "niveauExperience";
                    break;
                case 8:
                    searchValue = $"'%{txtRecherche.Text}%'";
                    searchCriteria = "nomSport";
                    break;
                default:
                    searchValue = $"{txtRecherche.Text}";
                    searchCriteria = "id";
                    break;
            }
            string Search = $"SELECT * FROM Sportif WHERE {searchCriteria} like {searchValue}";
            MySqlCommand cmd = new MySqlCommand(Search, cnx);
            cmd.Parameters.AddWithValue("@value", txtRecherche.Text);
            MySqlDataReader rd = cmd.ExecuteReader();

            lstvResultat.Columns.Add("Id");
            lstvResultat.Columns.Add("Nom");
            lstvResultat.Columns.Add("Prenom");
            lstvResultat.Columns.Add("Date de naissance");
            lstvResultat.Columns.Add("Rue");
            lstvResultat.Columns.Add("Code postal");
            lstvResultat.Columns.Add("Ville");
            lstvResultat.Columns.Add("Niveau d'experience");
            lstvResultat.Columns.Add("Nom du sport");

            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd[0].ToString());
                lv.SubItems.Add(rd[1].ToString());
                lv.SubItems.Add(rd[2].ToString());
                lv.SubItems.Add(rd[3].ToString());
                lv.SubItems.Add(rd[4].ToString());
                lv.SubItems.Add(rd[5].ToString());
                lv.SubItems.Add(rd[6].ToString());
                lv.SubItems.Add(rd[7].ToString());
                lv.SubItems.Add(rd[8].ToString());
                lstvResultat.Items.Add(lv);
            }
            cnx.Close();
        }
        public frmSportSIO()
        {

            InitializeComponent();
            StartListView();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {

            List<Sportif> Sportifs = new List<Sportif>();
            SearchListView();

        }

        private void txtRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
