using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3.classe
{
    internal class Personnage
    {
        private string _name;
        private int _health;
        private int _damage;
        private bool _isAlive;

        public string Name { get => _name; set => _name = value; }
        public int Health { get => _health; set => _health = value; }
        public int Damage { get => _damage; set => _damage = value; }
        public bool IsAlive { get => _isAlive; set => _isAlive = value; }

        public Personnage(string name, int health, int damage)
        {
            Name=name;
            Health=health;
            Damage=damage;
            IsAlive = true;
        }
      
        public void Attack(Personnage ennemy)
        {
            ennemy.Health = ennemy.Health - Damage;

            if (ennemy.Health <= 0)
            {
                ennemy.IsAlive = false;
            }

            Console.WriteLine(Name +" "+ "a attaqué " + ennemy.Name);
            Console.WriteLine("il reste " + ennemy.Health + "pv");
        }


    }
}
