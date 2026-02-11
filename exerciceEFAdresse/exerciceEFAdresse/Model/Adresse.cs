using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceEFAdresse.Model
{
    internal class Adresse
    {
        [Key]
        public int Id { get; set; }
        public int NumeroDeVoie {  get; set; }
        public string ComplementDeVoie { get; set; }
        public string IntituleDeLaVoie { get; set; }
        public string Commune {  get; set; }
        public string CodePostal { get; set; }

        public Adresse() { }



        public Adresse( int numeroDeVoie, string complementDeVoie, string intituleDeLaVoie, string commune, string codePostal)
        {
            
            NumeroDeVoie = numeroDeVoie;
            ComplementDeVoie = complementDeVoie;
            IntituleDeLaVoie = intituleDeLaVoie;
            Commune = commune;
            CodePostal = codePostal;
        }
        public override string ToString()
        {
            return $"Id : {Id} Numero de voie :{NumeroDeVoie},Complement de voie  {ComplementDeVoie},L'intitulé de la voie {IntituleDeLaVoie},La commune {Commune},Le code postal {CodePostal} ";
        }
    
    }
    


}
