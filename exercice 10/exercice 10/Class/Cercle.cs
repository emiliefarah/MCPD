using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_10.Class
{
    internal class Cercle:Forme 
    {
        private double _rayon;

        public double Rayon { get => _rayon; set => _rayon = value; }
    

    public Cercle(string name, double rayon) : base(name)
        {
            Rayon = rayon;
        }

        public override double CalculerAire()
        {
            return Math.PI * Math.Pow(Rayon, 2);
        }

        public override double CalculerPerimetre()
        {
            return 2 * Math.PI * Rayon;
        }
    }
}
