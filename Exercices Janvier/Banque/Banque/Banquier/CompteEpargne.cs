using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Banquier
{
    internal class CompteEpargne : CompteBancaire
    {
        private float _tauxinteret;

        public float Tauxinteret { get => _tauxinteret;set => _tauxinteret = value; }


        public CompteEpargne(string titulaire, float solde, string devise , float tauxinteret): base(titulaire, solde, devise)
        {
          _tauxinteret=tauxinteret;
        }

        
    }
}
