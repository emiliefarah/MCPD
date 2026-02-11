using System;
using exerciceEFAdresse.DbManager;
using exerciceEFAdresse.Model;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


void AfficherMenu()
{
    Console.WriteLine("""


        ===MENU PRINCIPAL===


        1.Voir les adresses
        2.Ajouter une adresse 
        3.Editer une adresse 
        4.Supprimer une adresse
        0.Quitter le programme 
        
        """);
}
void AfficherTouteLesAdresses(AppDbContext db)
{
    List<Adresse> alladresses = db.Adresse.ToList();

    foreach (Adresse a in alladresses)
    {
        Console.WriteLine(a);
    }
}


void AjouterUneAdresse(AppDbContext db)
{
    Console.WriteLine("Ajouter un numero de rue");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine("Ajouter un complement de rue");
    string comp = Console.ReadLine();

    Console.WriteLine("Ajouter un intitulé de voie");
    string intitule = Console.ReadLine();

    Console.WriteLine("Ajouter une commune");
    string commune = Console.ReadLine();

    Console.WriteLine("Ajouter un code postal");
    string codepostal = Console.ReadLine();


    db.Adresse.Add(new Adresse(num, comp, intitule, commune, codepostal));
    db.SaveChanges();
}
void ModifierAdresse(AppDbContext db)
{
    Console.WriteLine("Veuillez entrer l'Id de  l'adresse a changer ");
    int Id = int.Parse(Console.ReadLine());
    Adresse adresse = db.Adresse.Find(Id);

    Console.WriteLine("Ajouter un numero de rue");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine("Ajouter un complement de rue");
    string comp = Console.ReadLine();

    Console.WriteLine("Ajouter un intitulé de voie");
    string intitule = Console.ReadLine();

    Console.WriteLine("Ajouter une commune");
    string commune = Console.ReadLine();

    Console.WriteLine("Ajouter un code postal");
    string codepostal = Console.ReadLine();

    adresse.NumeroDeVoie = num;
    adresse.ComplementDeVoie = comp;
    adresse.IntituleDeLaVoie = intitule;
    adresse.Commune = commune;
    adresse.CodePostal = codepostal;


    db.Adresse.Update(adresse);
    db.SaveChanges();

}

void SupprimerUneAdresse(AppDbContext db)
{
    Console.WriteLine("veuillez entrer l'ID DE l'adresse à supprimer ");
    int Id = int.Parse(Console.ReadLine());
    Adresse a = db.Adresse.Find(Id);

    if (a == null)
    {
        Console.WriteLine("Id introuvable");
        return;
    }
    db.Adresse.Remove(a);
    db.SaveChanges();
}

using AppDbContext db = new AppDbContext();

db.Database.Migrate();


db.Adresse.Add(new Adresse(20, "", "rue des glycines", "lille", "59000"));
db.Adresse.Add(new Adresse(21, "", "avenue de la République", "Lille", "59000"));
db.Adresse.Add(new Adresse(22, "", "rue Nationale", "Lille", "59800"));
db.Adresse.Add(new Adresse(23, "", "boulevard Victor Hugo", "Roubaix", "59100"));
db.Adresse.Add(new Adresse(24, "", "rue Jean Jaurès", "Tourcoing", "59200"));
db.Adresse.Add(new Adresse(25, "", "rue Faidherbe", "Arras", "62000"));
db.Adresse.Add(new Adresse(26, "", "place du Général de Gaulle", "Lille", "59800"));
db.Adresse.Add(new Adresse(27, "", "rue de Paris", "Valenciennes", "59300"));
db.Adresse.Add(new Adresse(28, "", "avenue des Nations Unies", "Dunkerque", "59140"));

db.SaveChanges();

string choix = "";
do
{
    AfficherMenu();
    Console.WriteLine("votre choix :");

    choix = Console.ReadLine();

    switch (choix)
    {
        case "1":
            AfficherTouteLesAdresses(db);

            break;

        case "2":
            AjouterUneAdresse(db);

            break;

        case "3":
            ModifierAdresse(db);

            break;

        case "4":
            SupprimerUneAdresse(db);

            break;

    }

} while (choix != "0");