using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Lacaze_Pintault_.Models
{
    public class EntreeSortie
    {

        private bool _emprunter;

        public Livre Livre { get; set; }
        public Auteur Auteur { get; set; }
        public Abonne Abonne { get; set; }

        public bool Emprunter
        {
            get { return _emprunter; }
            set { _emprunter = value; }
        }

        public virtual string Affiche()
        {
            return string.Format("{0}", Emprunter);
        }

        protected EntreeSortie(string nomLivre, string nomAuteur, string prenomAuteur, string nomAbonne, string prenomAbonne, bool emprunter)
            : base()
        {
            Livre = new Livre(nomLivre, nomAuteur, prenomAuteur);
            Auteur = (Auteur)new PersonneBase(nomAuteur, prenomAuteur);
            Abonne = (Abonne)new PersonneBase(nomAbonne, prenomAbonne);
            _emprunter = emprunter;
            
        }
    }
}