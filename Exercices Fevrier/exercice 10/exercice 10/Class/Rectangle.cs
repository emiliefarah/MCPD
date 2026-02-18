using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_10.Class
{
    internal class Rectangle : Forme
    {
        private double _longueur;
        private double _largeur;

        public double Longueur { get => _longueur; set => _longueur = value; }
        public double Largeur { get => _largeur; set => _largeur = value; }

        public Rectangle(string name, double longueur, double largeur):base(name)
        {
            Longueur=longueur;
            Largeur=largeur;
        }

        public override double CalculerAire()
        {
            return Longueur * Largeur;
        }

        public override double CalculerPerimetre()
        {
            return (Longueur + Largeur) * 2;
        }
    }
}
