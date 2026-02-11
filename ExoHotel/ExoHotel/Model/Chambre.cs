using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Model
{
    internal class Chambre
    {
        [Key]
        public int Numero {  get; set; }
        public string Statut { get; set; }
        public int NombresDeLits { get; set; }
        public int Tarif {  get; set; }

        public Chambre() { }

        public Chambre ( string statut, int nombresDeLits, int tarif)
        {
            
            Statut = statut;
            NombresDeLits = nombresDeLits;
            Tarif = tarif;
        }

        public override string ToString()
        {
            return $" Numero {Numero}, Statut {Statut},NombreDeLits{NombresDeLits};Tarif{Tarif}.";
        }
    
    }

}
