using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_14.Class
{
    internal class Adresse
    {
        private int _numeroRue;
        private string _nomRue;
        private string _ville;
        private string _codePostal;

        public int NumeroRue { get => _numeroRue; set => _numeroRue=value;}
        public string NomRue { get => _nomRue; set => _nomRue=value;}
        public string Ville { get => _ville; set => _ville=value;}
        public string CodePostal { get => _codePostal; set => _codePostal=value;}

     public Adresse(int numeroRue, string nomRue, string ville, string codePostal)
        {

            NumeroRue = numeroRue;
            NomRue = nomRue;
            Ville = ville;
            CodePostal = codePostal;
        }


        public override string ToString()
        {
            return $"L'adresse est {NumeroRue}, {NomRue}, {Ville}, {CodePostal}";
        }
    }
    



}


