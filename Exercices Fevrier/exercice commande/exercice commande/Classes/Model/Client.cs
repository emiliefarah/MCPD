using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_commande.Classes.Model
{
    internal class Client
    {
        public int?  Id { get; set; }
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string NumeroDeTelephone { get; set; }


        public Client(int? id, string nom, string prenom, string adresse, string codepostal, string ville, string numerodetelephone)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal=codepostal;
            Ville = ville;
            NumeroDeTelephone = numerodetelephone;
        }
        public override string ToString()
        {
            return $"Id : {Id}, Nom {Nom} , Prenom {Prenom},Adresse {Adresse},CodePostal {CodePostal},Ville {Ville},NumeroDeTelephone{NumeroDeTelephone}";
        }









    }
}
