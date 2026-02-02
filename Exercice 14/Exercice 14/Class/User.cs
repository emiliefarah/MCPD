using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_14.Class
{
    internal class User
    {
        private string _nom;
        private string _prenom;
        private Adresse _adresse;


        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public Adresse Adresse { get => _adresse; set => _adresse = value; }

      
    
    public User(string nom, string prenom, Adresse adresse)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
        }
        public override string ToString()
        {
            return $"l'utilisateur: {Nom},{Prenom} et habite à l'adresse suivante {Adresse}"; 
        }
    
    
    }


}
