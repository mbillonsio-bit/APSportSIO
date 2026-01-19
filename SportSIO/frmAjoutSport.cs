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

namespace SportSIO
{
    public partial class frmAjoutSport : Form
    {
        public frmAjoutSport()
        {
            InitializeComponent();
        }

        private void btnAjouterSport_Click(object sender, EventArgs e)
        {
            List<Sport> lesSports = frmSportSIO.findSports();
            int id = lesSports.Count + 1;
            string nomSport = txtNomSport.Text;
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            cnx.Open();
            string InsertSportif = $"INSERT INTO Sport VALUES ({id},'{nomSport}')";
            MySqlCommand cmd = new MySqlCommand(InsertSportif, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            this.Close();
        }
    }
}
