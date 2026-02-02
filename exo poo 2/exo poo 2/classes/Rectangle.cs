using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_poo_2.classes
{
    internal class Rectangle
    {
        private int _largeur;
        private int _hauteur;


        public int Largeur { get => _largeur; set => _largeur = value; }
        public int Hauteur { get => _hauteur; set => _hauteur = value; }


        public Rectangle(int largeur, int hauteur)
        {

            Largeur = largeur;
            Hauteur = hauteur;
        }

        public int Perimetre()
        {
            return (Largeur + Hauteur) * 2;
        }


        public int Surface()
        {

            return Largeur * Hauteur;
        }


    }



}


