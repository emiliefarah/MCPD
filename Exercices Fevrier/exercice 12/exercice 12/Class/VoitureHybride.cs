using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercice_12.Interface;

namespace exercice_12.Class
{
    internal class VoitureHybride : Vehicule, IMotorise, IElectrique
    {
        public VoitureHybride(string nom, string marque) : base(nom, marque) { }
        public void Demarrer()
        {
            Console.WriteLine(" La Voiture Hybride Démarre");
        }

        public void Recharger()
        {
            Console.WriteLine("La Voiture Hybride Recharge "); 
        }
    }
}
