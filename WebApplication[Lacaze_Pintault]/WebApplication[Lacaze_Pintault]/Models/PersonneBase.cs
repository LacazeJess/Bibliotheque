using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Lacaze_Pintault_.Models
{
    public class PersonneBase : IPersonnes
    {
        private string _nom;
        private string _prenom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value.ToUpper();}
        }

        public string Prenom
        {
            get { return _nom; }
            set { _nom = value.ToUpper(); }
        }

        public PersonneBase(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public string Affiche()
        {
            return System.String.Format("{0},{1}", Nom, Prenom);
        }
    }
}