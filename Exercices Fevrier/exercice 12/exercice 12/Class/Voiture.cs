using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercice_12.Interface;

namespace exercice_12.Class
{
    internal class Voiture :Vehicule, IMotorise
    {
        public Voiture(string nom,string marque):base (nom,marque) { }

        public void Demarrer()
        {
            Console.WriteLine("La voiture Démarre");
        }
    }
}
