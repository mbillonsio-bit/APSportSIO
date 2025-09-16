using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
