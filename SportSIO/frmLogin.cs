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
    public partial class frmLogin: Form
    {
        public static Compte cpte;

        public List<Compte> findAccounts()
        {
            List<Compte> lesComptes = new List<Compte>();
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            cnx.Open();
            string Search = "SELECT * FROM Utilisateur";
            MySqlCommand cmd = new MySqlCommand(Search, cnx);
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Compte compte = new Compte(rd[0].ToString(), rd[1].ToString());
                lesComptes.Add(compte);
            }
            cnx.Close();
            return lesComptes;
        }

        public frmLogin()
        {
            InitializeComponent(); 
            btnSave.Hide();
            btnSignUp.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Compte> lesComptes = findAccounts();
            int cpt = 0;
            foreach (Compte compte in lesComptes)
            {
                if (compte.Username == txtUser.Text && compte.Password == txtPass.Text)
                {
                    cpte = compte;
                    this.Hide();
                    frmSportSIO frmSportSIO = new frmSportSIO();
                    frmSportSIO.Closed += (s, args) => this.Close();
                    frmSportSIO.Show();
                    cpt++;
                }
            }
            if (cpt == 0)
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect");
            }

        }

        public void lblForgot_Click(object sender, EventArgs e)
        {
            btnLogin.Hide();
            btnSave.Show();
            lblForgot.Hide();
            lblSignUp.Hide();
        }

        private void lblForgot_MouseHover(object sender, EventArgs e)
        {
            lblForgot.Cursor = Cursors.Hand;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            btnLogin.Hide();
            btnSignUp.Show();
            lblForgot.Hide();
            lblSignUp.Hide();
        }

        private void lblSignUp_MouseHover(object sender, EventArgs e)
        {
            lblSignUp.Cursor = Cursors.Hand;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Compte> lesComptes = findAccounts();
            int cpt = 0;
            foreach (Compte compte in lesComptes)
            {
                if (compte.Username == txtUser.Text)
                {
                    MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
                    cnx.Open();
                    string Search = $"UPDATE Utilisateur SET password='{txtPass.Text}' WHERE username='{txtUser.Text}'";
                    MySqlCommand cmd = new MySqlCommand(Search, cnx);
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    cpt++;
                }
            }
            if (cpt == 0)
            {
                MessageBox.Show("Identifiant incorrect");
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Veuillez entrer un mot de passe");
                cpt--;
            }
            else
            {
                btnLogin.Show();
                btnSave.Hide();
                lblForgot.Show();
                lblSignUp.Show();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            List<Compte> lesComptes = findAccounts();
            int cpt = 0;
            int cptCheck = 0;
            string rep = "";
            foreach (Compte compte in lesComptes)
            {
                if (compte.Username == txtUser.Text)
                {
                    MessageBox.Show("Identifiant deja utiliser");
                    cptCheck++;
                }
            }
            foreach (Compte compte in lesComptes)
            {
                if (txtUser.Text != "" && txtPass.Text != "") 
                {
                    if (compte.Username != txtUser.Text && cpt == 0 && cptCheck == 0)
                    {
                        MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
                        cnx.Open();
                        string Search = $"INSERT INTO Utilisateur VALUES ('{txtUser.Text}','{txtPass.Text}')";
                        MySqlCommand cmd = new MySqlCommand(Search, cnx);
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                        cpt++;
                    }
                }
            }
            if (txtPass.Text == "")
            {
                rep = "Veuillez entrer un mot de passe. ";
            }
            if (txtUser.Text == "")
            {
                rep += "Veuillez entrer un nom d'utilisateur";
            }
            if (rep != "")
            {
                MessageBox.Show(rep);
                cpt--;
            }
            if (cpt == 1)
            {
                btnLogin.Show();
                btnSignUp.Hide();
                lblForgot.Show();
                lblSignUp.Show();
            }
            cpt = 0;
        }
    }
}
