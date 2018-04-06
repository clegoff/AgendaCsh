using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    [Serializable()]
    public class Compte
    {
        private int idCompte;
        public int IdCompte { get => idCompte; set => idCompte = value; }

        private String nom;
        public String Nom { get => nom; set => nom = value; }

        private String prenom;
        public String Prenom { get => prenom; set => prenom = value; }

        private String tel;
        public String Tel { get => tel; set => tel = value; }

        private String tel_pro;
        public String Tel_pro { get => tel_pro; set => tel_pro = value; }

        private String email;
        public string Email { get => email; set => email = value; }

        private String service;
        public string Service { get => service; set => service = value; }

        private String mdp;

        private Calendrier leCalendrier;
        public Calendrier LeCalendrier { get => leCalendrier; set => leCalendrier = value; }

        private List<Compte> lesContacts;
        public List<Compte> LesContacts { get => lesContacts; set => lesContacts = value; }

        public Compte(int id, String n, String p, String t, String tp, String e, String s, String m, Calendrier c, List<Compte> ct)
        {
            idCompte = id;
            nom = n;
            prenom = p;
            tel = t;
            tel_pro = tp;
            email = e;
            service = s;
            mdp = m;
            leCalendrier = c;
            lesContacts = ct;
        }

        public Compte()
        {
        }
    }
}
