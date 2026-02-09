using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_ado_1.Classes.Model
{
    internal class Etudiant
    {
        public int? Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Datedenaissance { get; set; }
        public string Email { get; set; }

        public Etudiant(int? id, string nom, string prenom, DateTime datedenaissance, string email)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
           Datedenaissance = datedenaissance;
            Email = email;
        }
        public override string ToString()
        {
            return $"ID : {Id}, Nom: {Nom} {Prenom}, Date de naissance : {Datedenaissance}, Email :{Email}.";
        }




    }
}
