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
        public void StartListView(System.Windows.Forms.ListView lstv)
        {
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString); 
            lstv.Columns.Clear(); // Clear previously added columns
            lstv.Items.Clear(); // Clear previously populated items
            lstv.View = View.Details; // Set View property
            cnx.Open();
            string Search = "SELECT * FROM Sportif";
            MySqlCommand cmd = new MySqlCommand(Search, cnx);
            MySqlDataReader rd = cmd.ExecuteReader();

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
            lstv.AutoResizeColumn(8, ColumnHeaderAutoResizeStyle.HeaderSize);
            lstv.Columns[4].Width = 200;
            lstv.Columns[2].Width = 100;
            lstv.Columns[6].Width = 150;
            lstv.Columns[1].Width = 100;


            while (rd.Read())
            {
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
            cnx.Close();
        }
        public void SearchListView()
        {    
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
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
            cnx.Close();
        }
        public frmSportSIO()
        {

            InitializeComponent();
            StartListView(lstvResultat);
            StartListView(lstvModifs);
        }
        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            List<Sportif> Sportifs = new List<Sportif>();
            try
            {
                if (txtRecherche.Text != "")
                {
                    SearchListView();
                    return;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                StartListView(lstvResultat);
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxCritere_TextChanged(object sender, EventArgs e)
        {
            txtRecherche.Clear();
            StartListView(lstvResultat);
        }

        private void cbxModifs_TextChanged(object sender, EventArgs e)
        {
            txtRecherche.Clear();
            StartListView(lstvModifs);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Sportif> Sportifs = new List<Sportif>();
            try
            {
                if (txtRecherche.Text != "")
                {
                    SearchListView();
                    return;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                StartListView(lstvResultat);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
