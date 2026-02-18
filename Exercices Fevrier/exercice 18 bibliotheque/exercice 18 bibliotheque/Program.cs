using exercice_18_bibliotheque.Classe;

Bibliotheque biblio = new Bibliotheque();
biblio.AjouterunLivre(1,"Strong 1","Eva Sorn",70);
biblio.AjouterunLivre(2, "L'imperatrice", "Aya Estrela", 100);
biblio.AjouterunLivre(3, "Lakestone", "Sarah Rivens", 170);
biblio.AjouterunLivre(4, "Tout le bleu du ciel", "Melissa Dacosta", 50);
biblio.AjouterunLivre(5, "The south Girl 1 ", "Aya Estrela", 90);
biblio.AjouterunLivre(6, "Hope is blue ", "Aya Estrela ", 150);
biblio.AjouterunLivre(7, "Strong 2", "Eva Sorn", 90);


biblio.AfficherToutLesLivres();
biblio.RechercherUnLivre("Strong 1");

biblio.RechercherUnLivreauteur("Aya Estrela");

Console.WriteLine("Veuillez entrer un nouvau livre");
biblio =tryparse( Console.ReadLine());