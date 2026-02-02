using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace exo_poo.classe
{
    internal class Chaise
    {
        private int _nbPieds;
        private string _materiaux;
        private string _couleurObjet;


        public int NbPied { get => _nbPieds; set => _nbPieds = value; }
        public string Materiaux { get => _materiaux; set => _materiaux = value; }
        public string Couleurobjet { get => _couleurObjet; set => _couleurObjet = value; }

        public Chaise (int nbpieds, string materiaux,string couleurObjet)
        {
            NbPied = nbpieds;
            Materiaux = materiaux;
            Couleurobjet= couleurObjet;
        }

        public override string ToString()
        {
            return $"Je suis une chaise {Couleurobjet},mon nombre de pieds est: {NbPied}. Je suis faite de :{Materiaux}.";
        }



    }
}