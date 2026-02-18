using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_18_bibliotheque.Classe
{
    internal class Livre 
    {
        private int _numero;
        private string _titre;
        private string _auteur;
        private int _nbexemplaires;

        public int Numero {get => _numero;set=>_numero = value; }
        public string Titre { get => _titre;set => _titre = value; }
        public string Auteur { get => _auteur; set => _auteur = value; }
        public int Nbexemplaires { get => _nbexemplaires; set => _nbexemplaires = value; }

        public Livre(int numero, string titre, string auteur, int nbexemplaires)
        {
            Numero = numero;
            Titre = titre;
            Auteur = auteur;
            Nbexemplaires=nbexemplaires;
        }





    }
}
