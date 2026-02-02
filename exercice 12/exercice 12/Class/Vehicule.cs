using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exercice_12.Class
{
    internal abstract class Vehicule
    {
        private string _nom;
        public string Nom { get => _nom; set => _nom = value; }

        private string _marque;
        public string Marque { get => _marque; set => _marque = value; }

        public Vehicule(string nom, string marque)
        {
            Nom = nom;
            Marque = marque;
        }


        public override string ToString()
        {
            return $"Le vehicule est un {Nom} il est de marque {Marque}";
        }



    }
}



