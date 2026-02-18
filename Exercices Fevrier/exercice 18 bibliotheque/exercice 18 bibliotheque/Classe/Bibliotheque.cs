using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercice_18_bibliotheque.Classe;

namespace exercice_18_bibliotheque.Classe
{
    internal class Bibliotheque
    {
        private List<Livre> toutLesLivres = new List<Livre>();

        public List<Livre> Toutleslivres { get => toutLesLivres; set => toutLesLivres = value; }
        public void AjouterunLivre(int numero, string titre, string auteur, int nbexemplaires)

        {
            toutLesLivres.Add(new Livre(numero, titre, auteur, nbexemplaires));
        }

        public void Supprimerunlivre(int numero)
        {
            int id = -1;

            for (int i = 0; i < toutLesLivres.Count; i++)
            {
                if (toutLesLivres[i].Numero == numero)
                    id = i;

            }

            if (id == -1)
                return;

            toutLesLivres.RemoveAt(id);
        }

        public void RechercherUnLivre(string titre)
        {
            int id = -1;

            for (int i = 0; i < toutLesLivres.Count; i++)
            {
                if (toutLesLivres[i].Titre == titre)
                    id = i;

            }

            if (id == -1)
                return;

            Console.WriteLine($"Le titre du Livre est ,{toutLesLivres[id].Titre}");


        }
        public void AfficherToutLesLivres()
        {
            foreach (Livre str in toutLesLivres)
            {
                Console.WriteLine("tout les livres de ma bibliotheques sont" +str.Titre);
            }
        }
        public void RechercherUnLivreauteur(string auteur)
        {
            int id = -1;

            for (int i = 0; i < toutLesLivres.Count; i++)
            {
                if (toutLesLivres[i].Auteur == auteur)
                    id = i;

            }

            if (id == -1)
                return;

            Console.WriteLine($"L'auteur du Livre est ,{toutLesLivres[id].Auteur}");


        


        }








    }
}
