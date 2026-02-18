using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exo_salarie.Salaire
{
    internal class Salarie
    {
        private string _nom;
        private string _service;
        private double _salaire;
        private static int _nombretotalemployes;
        private static double _salairetotal;

        public string Nom { get => _nom; set => _nom = value; }
        public string Service { get => _service; set => _service = value; }
        public double Salaire { get => _salaire; set => _salaire = value; }
        public static int Nombretotalemployes { get => _nombretotalemployes; set => _nombretotalemployes = value; }
        public static double Salairetotal { get => _salairetotal; set => _salairetotal = value; }
        public Salarie(string nom, string service, double salaire)
        {
            Nom = nom;
            Service = service;
            Salaire = salaire;
            Salairetotal += salaire;
            Nombretotalemployes ++;
        }

        public void AfficherSalaire()
        {
            return $"le salarié s'appelle {Nom} il est du service {Service}, il gagne {Salaire}";
        }

     



    }



}
