using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace exo1_chiens.chenil
{
    internal class Chiens
    {
        private string _name;
        private string _race;
        private int _age;
        private static string _nomDuChenil;
        private static int _nbChiens;

        public string Name { get => _name; set => _name = value; }
        public string Race { get => _race; set => _race = value; }
        public int Age { get => _age; set => _age = value; }
        public static string NomDuChenil { get => _nomDuChenil; set => _nomDuChenil = value; }
        public static int NbChiens { get => _nbChiens; set => _nbChiens = value; }


        public Chiens()
        {
            NbChiens++;

        }

        public Chiens(string name, string race, int age) : this() 
        {
            Name = name;
            Race = race;
            Age = age;
        }
        public static void AfficherNbChiens()
        {
            Console.WriteLine("Vous avez " + NbChiens+" "+ "chiens");
        }
        public override string ToString()
        {
            return $"Le chien s'appel {Name} il est de race {Race}, il a {Age} ans et il est au chenil{NomDuChenil}";
        }






    }
}
