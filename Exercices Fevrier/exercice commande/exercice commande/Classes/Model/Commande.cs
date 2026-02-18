using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_commande.Classes.Model
{
    internal class Commande
    {
        public int ? Id { get; set; }
        public int ClientId { get; set; }
         public DateTime DateCommande { get; set; }
        public decimal Total {  get; set; }

        public Commande(int? id, int clientId, DateTime dateCommande, decimal total)
        {
            Id = id;
            ClientId = clientId;
            DateCommande = dateCommande;
            Total = total;
        }

        public override string ToString()
        {
            return $"Id {Id}, Client Id {ClientId},DateCommande {DateCommande},Total {Total}.";
        }
    }
}
