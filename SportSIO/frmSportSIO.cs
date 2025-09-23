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
            lstvResultat.Columns.Clear(); // Clear previously added columns
            lstvResultat.Items.Clear(); // Clear previously populated items
            lstvResultat.View = View.Details; // Set View property
            MySqlDataReader rd = Sportif.GetSportif(txtRecherche.Text, cbxCritere.SelectedIndex);

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
            //cnx.Close();
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
