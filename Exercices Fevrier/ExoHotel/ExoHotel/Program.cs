using System.Globalization;
using ExoHotel.DbManager;
using ExoHotel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;

AppDbContext db = new AppDbContext();
db.Database.Migrate();

db.Client.Add(new Client("Lynch", "joey", "06-16-14-78-95"));
db.Client.Add(new Client("Dubois", "Emma", "07-82-14-56-93"));
db.Client.Add(new Client("Martin", "Lucas", "06-45-77-21-88"));
db.Client.Add(new Client("Bernard", "Chloé", "07-19-63-84-52"));
db.Client.Add(new Client("Robert", "Nathan", "06-73-25-90-14"));
db.Client.Add(new Client("Petit", "Inès", "07-58-41-76-39"));
db.Client.Add(new Client("Richard", "Hugo", "06-22-68-11-47"));
db.Client.Add(new Client("Durand", "Léa", "07-91-34-55-62"));
db.Client.Add(new Client("Moreau", "Tom", "06-84-29-73-10"));
db.Client.Add(new Client("Simon", "Sarah", "07-36-92-48-15"));
db.Client.Add(new Client("Laurent", "Adam", "06-59-87-20-64"));

db.Client.ExecuteDelete();

db.Chambre.Add(new Chambre("Libre", 2, 150));
db.Chambre.Add(new Chambre("Libre", 1, 140));
db.Chambre.Add(new Chambre("Libre", 1, 145));
db.Chambre.Add(new Chambre("Occupe", 2, 150));
db.Chambre.Add(new Chambre("Occupe", 3, 180));
db.Chambre.Add(new Chambre( "Occupe", 2, 160));
db.Chambre.Add(new Chambre( "Occupe", 2, 130));

db.Chambre.ExecuteDelete();

db.SaveChanges();


void AfficherLaListeDesClients(AppDbContext db)
{
    List<Client> toutlesclients = db.Client.OrderBy(c=>c.Nom).ToList();
   
    foreach (Client c in toutlesclients)
    {
        Console.WriteLine(toutlesclients);
    }

}
void AfficherLesChambresLibre(AppDbContext db)
{
    List<Chambre> chambrelibre = db.Chambre.ToList();
    foreach (Chambre ch in chambrelibre)
        if (ch.Statut == "Libre")
            Console.WriteLine(chambrelibre);

}
void AjouterUnClient(AppDbContext db)
{
    Console.WriteLine("Quel est le nom du client?");
    string nom = Console.ReadLine();

    Console.WriteLine("Quel est le prénom du client?");
    string prenom = Console.ReadLine();

    Console.WriteLine("Quel est le numéro de téléphone du client?");
    string telephone = Console.ReadLine();


    db.Client.Add(new(nom, prenom, telephone));
    db.SaveChanges();
}

void AfficherReservationClient(AppDbContext db)
{
    int id = 0;
    db.Reservation.Where(r => r.ClientId == id)
        .Include(r => r.ClientId)
        .Include(r => r.ChambreId)
        .ToList();


}

    //void AjouterUneReservation(AppDbContext db)// pour ajouter une reservation il nous faut le numero de chambre ,recuperer le client,et son statut?


    //Console.WriteLine("Veuillez entrer le numero de chambre ");
    // int numerodechambre = int.Parse(Console.ReadLine());

    //AQfficher les clients
    // Id du client

    // Ajouter reservation avec status en_cour 
    // xhanger statu chambe en occupé 


void Statutdelachambre(AppDbContext db)
{

    int statut = int.Parse(Console.ReadLine());

    if (statut == 1)
    {
        Console.WriteLine("La Chambre est libre!");
        return;
    }
    if (statut == 2)
    {
        Console.WriteLine("La chambre est occupée");
        return;
    }
    if (statut == 3)
    {
        Console.WriteLine("La chambre est en cours de nettoyage");
        return;
    }




}
void AfficherLaListeDesReservations(AppDbContext db)
{

    List<Reservation> allreservations = db.Reservation.ToList();
    foreach (Reservation r in allreservations)
        Console.WriteLine(r);
}