using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    [Serializable()]
    public class Calendrier
    {
        private Compte leCompte;
        public Compte LeCompte { get => leCompte; set => leCompte = value; }

        private List<Rendezvous> listeRendezVous;
        public List<Rendezvous> ListeRendezVous { get => listeRendezVous; set => listeRendezVous = value; }


    }
}
