using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSportif
{
    public class Sport
    {
        int id;
        string nomSport;

        public Sport(int id, string nomSport)
        {
            this.id = id;
            this.nomSport = nomSport;
        }

        public int Id { get => id; set => id = value; }
        public string NomSport { get => nomSport; set => nomSport = value; }
    }
}
