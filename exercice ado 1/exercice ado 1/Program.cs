
using exercice_ado_1.Classes.Repository;
using exercice_ado_1.Classes.Model;
using System.Collections.Immutable;
using System.Globalization;
//MenuPrincipal();
EtudiantRepository.CreateTableEtudiant();
// Ajouter un étudiant
EtudiantRepository.AjouterUnEtudiant(new Etudiant(null, "Volkov", "Nikita", new DateTime(2003, 02, 02), "Volkov@gmail.com"));
EtudiantRepository.AjouterUnEtudiant(new Etudiant(null, "Hitake", "Kuro", new DateTime(2002, 10, 22), "Hitake@gmail.com"));
EtudiantRepository.AjouterUnEtudiant(new Etudiant(null, "Lakestone", "Kaï", new DateTime(2003, 02, 06), "Lakestone@gmail.com"));
EtudiantRepository.AjouterUnEtudiant(new Etudiant(null, "Croft", "Elvira", new DateTime(2004, 12, 02), "Croft@gmail.com"));
EtudiantRepository.AjouterUnEtudiant(new Etudiant(null, "Estrela", "Aya", new DateTime(2003, 06, 22), "Estrela@gmail.com"));
EtudiantRepository.AjouterUnEtudiant(new Etudiant(null, "Knight", "Ace", new DateTime(2003, 10, 02), "AceKnight@gmail.com"));
EtudiantRepository.AjouterUnEtudiant(new Etudiant(null, "laloute", "lorian", new DateTime(1998, 02, 12), "laloute@lol.com"));

// Modifier un étudiant
EtudiantRepository.ModifierUnEtudiant(new Etudiant(7, "ramsay", "lorian", new DateTime(1998, 02, 12), "ramsay@lolcom"));

// Recuperer un etudiant par son nom ,prenom
Etudiant Recuperer()
{
    string saisie =Console.ReadLine();

    List<Etudiant> etudiant = EtudiantRepository.AfficherUnEtudiantParSonNomPrenom(saisie);

    return etudiant.First();
}
void Modifier()
{
    string saisie =Console.ReadLine();
    Etudiant e = Recuperer();

    Etudiant eSaisie = SaisieUtilisateur();

    eSaisie.Id = e.Id;

    EtudiantRepository.ModifierUnEtudiant(eSaisie);
}

// Supprimer un étudiant
//EtudiantRepository.SupprimerUnEtudiant(etudiant.First().Id ?? 0);

// Quitter
//Voir tous les étudiants
Etudiant SaisieUtilisateur()
{
    Console.WriteLine("Veuillez saisir le nom");
    string nom=Console.ReadLine();

    Console.WriteLine("Veuillez saisir le prénom");
    string prenom = Console.ReadLine();

    Console.WriteLine("Veuillez saisir la date de naissance(annee-mois-jour)");
    DateTime datedenaissance =DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Veuillez saisir l'email");
    string mail = Console.ReadLine();


    return new Etudiant(null, nom, prenom,datedenaissance,mail );

}
void Supprimer()
{
    Console.WriteLine("veuillez entrer l'etudiant à supprimer");
    int Id = int.Parse(Console.ReadLine());

    EtudiantRepository.SupprimerUnEtudiant((int)(Id));
}

void afficher()
{
    Console.WriteLine("Voici tout les etudiants inscrit cette année ");

    List<Etudiant> etudiants = EtudiantRepository.AfficherToutLesEtudiants();
    foreach (Etudiant e in etudiants)
    {
        Console.WriteLine(e);
    }
}

//static void MenuPrincipal()
//    Console.WriteLine("veuillez entrer votre nom,prenom,date de naissance et email");
//   string? AjouterUnEtudiant = Console.ReadLine();

//}
string choix = "";
do
{
    Console.WriteLine("""
               _             _ _             _       
           ___| |_ _   _  __| (_) __ _ _ __ | |_ ___ 
          / _ \ __| | | |/ _` | |/ _` | '_ \| __/ __|
         |  __/ |_| |_| | (_| | | (_| | | | | |_\__ \
          \___|\__|\__,_|\__,_|_|\__,_|_| |_|\__|___/

        1. Voir tous les étudiants
        2. Ajouter un étudiant
        3. Modifier un étudiant
        4. Supprimer un étudiant
        0. Quitter
        """);

    choix = Console.ReadLine();

    switch (choix)
    {
        case "1":
            afficher();
        
            break;
        case "2":
            SaisieUtilisateur();
            break;

        case "3":
            Console.WriteLine(Recuperer());
            break;
        case "4":
            Supprimer();
            break;
        case "0":
            Console.WriteLine("vous avez quitté le menu");
            break;
    }

} while (choix != "0");
