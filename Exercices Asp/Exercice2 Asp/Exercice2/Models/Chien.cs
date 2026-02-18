using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2.Models
{
    public class Chien
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }

        public Chien() { }
        public Chien(int id,string nom, int age, string race)
        {
            Id = id;
            Nom = nom;
            Age = age;
            Race = race;
        }
        public override string ToString()
        {
            return $"{Id}{Nom} {Age} {Race}";
        }
    }
}
