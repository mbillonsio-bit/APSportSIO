using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSportif
{
    public class Sportif
    {
        private string codePostal;
        private string dateNais;
        private int id;
        private int niveauExperience;
        private string nom;
        private string nomSport;
        private string prenom;
        private string rue;
        private string ville;
        public Sportif(string codePostal, string dateNais, int id, int niveauExperience, string nom, string nomSport, string prenom, string rue, string ville)
        {
            this.codePostal = codePostal;
            this.dateNais = dateNais;
            this.id = id;
            this.niveauExperience = niveauExperience;
            this.nom = nom;
            this.nomSport = nomSport;
            this.prenom = prenom;
            this.rue = rue;
            this.ville = ville;
        }

        public string CodePostal { get => codePostal; set => codePostal = value; }
        public string DateNais { get => dateNais; set => dateNais = value; }
        public int Id { get => id; set => id = value; }
        public int NiveauExperience { get => niveauExperience; set => niveauExperience = value; }
        public string Nom { get => nom; set => nom = value; }
        public string NomSport { get => nomSport; set => nomSport = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Ville { get => ville; set => ville = value; }

        public string GetLibelleNiveau()
        {
            switch (niveauExperience)
            {
                case 1:
                    return "Débutant";
                case 2:
                    return "Confirmé";
                case 3:
                    return "Avancé";
                case 4:
                    return "Professionel";
                default:
                    return "";
            }
        }

        public static MySqlDataReader GetSportif(string valeur, int critere)
        {
            string searchCriteria;
            string searchValue;
            switch (critere)
            {
                case 0:
                    searchValue = $"{valeur}";
                    searchCriteria = "id";
                    break;
                case 1:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "nom";
                    break;
                case 2:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "prenom";
                    break;
                case 3:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "dateNais";
                    break;
                case 4:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "rue";
                    break;
                case 5:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "codePostal";
                    break;
                case 6:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "ville";
                    break;
                case 7:
                    searchValue = $"{valeur}";
                    searchCriteria = "niveauExperience";
                    break;
                case 8:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "nomSport";
                    break;
                default:
                    searchValue = $"{valeur}";
                    searchCriteria = "id";
                    break;
            }
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            cnx.Open();

            string Search = $"SELECT * FROM Sportif WHERE {searchCriteria} LIKE {searchValue}";
            MySqlCommand cmd = new MySqlCommand(Search, cnx);
            return cmd.ExecuteReader();
        }

    }
}
