using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_14.Class
{
    internal class Lettre
    {
        private User _expediteur;
        private User _destinataire;
        private string _contenu;
        private string _statut;

        public User Expediteur { get => _expediteur; set => _expediteur = value; }
        public User Destinataire { get => _destinataire;set => _destinataire = value; }
        public  string Contenu {get => _contenu;set => _contenu = value; }
        public string Statut { get => _statut;set => _statut = value; }

        public Lettre (User expediteur, User destinataire, string contenu)
        {
           Expediteur = expediteur;
            Destinataire = destinataire;
            Contenu = contenu;
            Statut = "en attente";
        }

        public void Envoyer()
        {
            Statut = "envoyé";
        }
        public void Lire()
        {
            Statut = "lu";
        }

        public override string ToString()
        {
            return $"La lettre est adressé à {Expediteur} le destinataire est  {Destinataire} elle contient {Contenu} et son statut est {Statut}";
        }



    }

}
