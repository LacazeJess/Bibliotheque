using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Lacaze_Pintault_.Models
{
    public class Livre
    {
        private static int _idMax;
        private int _quantite;
        private string nomLivre;
        private string nomAuteur;
        private string prenomAuteur;

        public int Id { get; private set; }
        public string Designation { get; set; }

        public Auteur Auteur { get; set; }

        public int Quantite
        {
            get { return _quantite; }
            set { _quantite = Math.Max(0,value); }
        }

        public virtual string Affiche()
        {
            return string.Format("{0}\t\t{1}\t{2}", Designation, Auteur, Quantite);
        }

        protected Livre(string nomLivre, string nomAuteur, string prenomAuteur) : base()
        {
            Id = _idMax;
            _idMax++;

            Designation = nomLivre;
            Auteur = (Auteur)new PersonneBase(nomAuteur, prenomAuteur);
            Quantite = 0;
        }

        public Livre(string nomLivre, string nomAuteur, string prenomAuteur)
        {
            // TODO: Complete member initialization
            this.nomLivre = nomLivre;
            this.nomAuteur = nomAuteur;
            this.prenomAuteur = prenomAuteur;
        }        
    }
}