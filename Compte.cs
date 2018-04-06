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

        private String mdp;

        public Compte(int id, int n, int p, String t, String tp, String m)
        {
            idCompte = id;
            nom = n;
            prenom = p;
            tel = t;
            tel_pro = tp;
            mdp = m;
        }
    }
}
