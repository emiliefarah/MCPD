using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercice_12.Interface;

namespace exercice_12.Class
{
    internal class Hydravion : Vehicule, IMotorise, IVolant,IFlottant
    {
        public Hydravion(string nom, string marque) : base(nom, marque) { }
        public void Atterir()
        {
            Console.WriteLine("l'hydravion atterit!"); 
        }

        public void Decoller()
        {
            Console.WriteLine("l'hydravion Décolle !");
        }

        public void Demarrer()
        {
            Console.WriteLine("l'hydravion Démarre");
        }

        public void Naviguer()
        {
            Console.WriteLine(" l'hydravion Navigue");
        }
    }
}
