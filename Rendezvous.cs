using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    [Serializable()]
    public class Rendezvous
    {
        private String intitule;
        public string Intitule { get => intitule; set => intitule = value; }

        private DateTime dateDebut;
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }

        private DateTime dateFin;
        public DateTime DateFin { get => dateFin; set => dateFin = value; }

        public Rendezvous(String i, DateTime dd, DateTime df)
        {
            intitule = i;
            DateDebut = dd;
            DateFin = df;
        }

        public Rendezvous()
        {

        }
    }
}
