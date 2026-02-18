using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercice_15.Interface;

namespace exercice_15.Class
{
    internal class GuerrierMage : Personnage, IAttaqueSpeciale, IMagie

    {
        public GuerrierMage(string nom, int pv, int dammage, Arme Arme) : base(nom, pv, dammage, Arme)
        {
        }
        public override void Attaquer(Personnage cible)
        {
            cible.PV -= 5;
        }

        public void Attaquespecial(Personnage cible)
        {
            cible.PV -= 20;
            Arme.Utiliser();

        }

        public void LancerSort(Personnage cible)
        {
            cible.PV -=Dammage + Arme.DegatSupplementaire;
            Arme.Utiliser();
        }
    }
}
