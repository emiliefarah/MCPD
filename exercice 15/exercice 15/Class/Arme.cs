using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_15.Class
{
    internal class Arme
    {
        private string _nomArme;
        private int _degatSupplementaire;
        private int _durabilite;

        public string NomArme { get => _nomArme; set => _nomArme = value; }
        public int DegatSupplementaire { get => _degatSupplementaire; set => _degatSupplementaire = value; }
        public int Durabilite { get => _durabilite; set => _durabilite = value; }

        public Arme(string nomArme, int degatSupplementaire, int durabilite)
        {
            NomArme = nomArme;
            DegatSupplementaire=degatSupplementaire;
            Durabilite = durabilite;
        }
         public void Utiliser()
        {
            Durabilite--;
        }

    }
}
