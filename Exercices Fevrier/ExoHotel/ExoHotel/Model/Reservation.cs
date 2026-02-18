using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Model
{
    internal class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Statut { get; set; }
        public int ChambreId { get; set; }

        public Chambre? Chambre { get; set; }
        public int ClientId { get; set; }
        public Client? Client { get; set; }




        public Reservation() { }
        public Reservation (string statut, int Chambre, int Client)
        {
           
            Statut = statut;
            ChambreId = Chambre;
            ClientId = Client;
        }

        public override string ToString()
        {
            return $"Id {Id},Statut {Statut},Chambre {Chambre},Client {Client}.";
        }
    }
}
