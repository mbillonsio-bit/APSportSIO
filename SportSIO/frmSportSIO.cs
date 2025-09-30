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
        }
        public void StartListView(System.Windows.Forms.ListView lstv)
        {
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString); 
            cnx.Open();
            string Search = "SELECT * FROM Sportif";
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
            frmModifs modif = new frmModifs();
            modif.Show();
        }
    }
}
