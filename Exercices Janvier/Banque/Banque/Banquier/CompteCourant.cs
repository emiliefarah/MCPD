using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Banquier
{
    internal class CompteCourant : CompteBancaire
    {
        private float _decouvertautorise;


        public float Decouvertautorise { get => _decouvertautorise; set => _decouvertautorise = value; }

        public CompteCourant(string titulaire, float solde, string devise, float decouvertautorise) : base(titulaire, solde, devise)
        {
            _decouvertautorise = decouvertautorise;
        }
    
    public void RetirerDecouvertautorise(float montant)
        {
            if (Solde - montant <= -Decouvertautorise)
            {
                Console.WriteLine($" decouvert non autorisé");

            }
            else
            {
                Console.WriteLine("Decouvert autorisé");
                Solde = Solde - montant;
            }
        }

    }
}