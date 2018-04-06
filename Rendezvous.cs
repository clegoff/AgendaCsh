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
        private String intitulé;
        public string Intitulé { get => intitulé; set => intitulé = value; }

        private DateTime dateDebut;
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }

        private DateTime dateFin;
        public DateTime DateFin { get => dateFin; set => dateFin = value; }

        public Rendezvous(String i, DateTime dd, DateTime df)
        {
            intitulé = i;
            DateDebut = dd;
            DateFin = df;
        }
    }
}
