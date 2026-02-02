using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exercice_15.Class
{
    internal abstract class Personnage
    {
        private string _nom;
        private string _prenom;
        private int _pv;
        private int _dammage;
        private Arme _arme;

        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public int PV { get => _pv; set => _pv = value; }
        public int Dammage { get => _dammage; set => _dammage = value; }
        public Arme Arme { get => _arme; set => _arme = value; }


        public Personnage(string nom, int pv, int dammage,Arme Arme)
        {
            Nom = nom;
            Prenom = nom;
            PV = pv;
            Dammage = dammage;
            this.Arme = Arme;
        }

        public abstract void Attaquer(Personnage cible);

        public override string ToString()
        {
            return $"Le personnage s'appel {Nom},{Prenom} ses PV sont de {PV} et les dammages quil afflige sont de {Dammage}";
        }









    }
    

}


        
        

        


   

