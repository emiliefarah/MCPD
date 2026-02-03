using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_18_bibliotheque.Classe
{
    internal class Bibliotheque
    {
       private List<Livre> toutLesLivres = new List<Livre>();

        public List<Livre> Toutleslivres { get => toutLesLivres; set => toutLesLivres = value; }




    }
}
