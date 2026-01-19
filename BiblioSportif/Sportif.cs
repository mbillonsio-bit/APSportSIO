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
        private DateTime dateNais;
        private int id;
        private int niveauExperience;
        private string nom;
        private List<Sport> lesSport;
        private string prenom;
        private string rue;
        private string ville;
        public Sportif(int id, string nom, string prenom, DateTime dateNais, string rue, string codePostal, string ville, int niveauExperience)
        {
            this.codePostal = codePostal;
            this.dateNais = dateNais;
            this.id = id;
            this.niveauExperience = niveauExperience;
            this.nom = nom;
            this.prenom = prenom;
            this.rue = rue;
            this.ville = ville;
            List<Sport> sports = new List<Sport>();
      
        }

        public string CodePostal { get => codePostal; set => codePostal = value; }
        public DateTime DateNais { get => dateNais; set => dateNais = value; }
        public int Id { get => id; set => id = value; }
        public int NiveauExperience { get => niveauExperience; set => niveauExperience = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Ville { get => ville; set => ville = value; }
        public List<Sport> LesSport { get => lesSport; set => lesSport = value; }

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
                    searchCriteria = "S.id";
                    break;
                case 1:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "S.nom";
                    break;
                case 2:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "S.prenom";
                    break;
                case 3:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "S.dateNais";
                    break;
                case 4:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "S.rue";
                    break;
                case 5:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "S.codePostal";
                    break;
                case 6:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "S.ville";
                    break;
                case 7:
                    searchValue = $"{valeur}";
                    searchCriteria = "S.niveauExperience";
                    break;
                case 8:
                    searchValue = $"'%{valeur}%'";
                    searchCriteria = "Sp.nomSport";
                    break;
                default:
                    searchValue = $"{valeur}";
                    searchCriteria = "S.id";
                    break;
            }
            MySqlConnection cnx = new MySqlConnection(ConfigurationManager.ConnectionStrings["cnxbdSport"].ConnectionString);
            cnx.Open();

            string Search = $"SELECT S.id,S.nom,S.prenom,S.dateNais,S.rue,S.codePostal,S.ville,S.niveauExperience,Sp.nomSport FROM Sportif S INNER JOIN Participe P ON S.id = P.idSportif INNER JOIN Sport Sp ON P.idSport = Sp.id WHERE {searchCriteria} LIKE {searchValue} GROUP BY P.idSportif";
            MySqlCommand cmd = new MySqlCommand(Search, cnx);
            return cmd.ExecuteReader();
        }

    }
}
