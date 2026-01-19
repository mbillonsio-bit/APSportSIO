using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSportif
{
    public class Participe
    {
        private int idSportif;
        private int idSport;
        public Participe(int idSportif, int idSport)
        {
            this.idSportif = idSportif;
            this.idSport = idSport;
        }
        public int IdSportif { get => idSportif; set => idSportif = value; }
        public int IdSport { get => idSport; set => idSport = value; }
    }
}
