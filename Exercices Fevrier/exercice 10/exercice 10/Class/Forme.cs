using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_10.Class
{
    internal abstract class Forme
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }
        public Forme(string name)
        {

            Name = name;

        }

        public abstract double CalculerAire();
        public abstract double CalculerPerimetre();


    }
}
