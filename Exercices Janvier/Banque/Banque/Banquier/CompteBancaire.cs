using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Banquier
{
    internal class CompteBancaire
    {
        private string _titulaire;
        private float _solde;
        private string _devise;



        public string Titulaire { get => _titulaire; set => _titulaire = value; }
        public float Solde { get => _solde; set => _solde = value; }
        public string Devise { get => _devise; set => _devise = value; }




        public CompteBancaire(string titualaire, float solde, string devise)
        {
            Titulaire = titualaire;
            Solde = solde;
            Devise = devise;
        }
        public void Retirer(float montant)
        {
            if (Solde - montant <= 0)
            {
                Console.WriteLine($"Votre solde est insuffisant");

            }
            else
            {
                Console.WriteLine("Vous avez retirer de l'argent de votre compte ");
                Solde = Solde - montant;
            }


        }

        public void Deposer(float montant)
        {
            Solde = Solde + montant;
        }

        public void Affichersolde()
        {
            Console.WriteLine($"Votre solde est de {Solde}");
        }
    }
}











