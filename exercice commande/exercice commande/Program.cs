using exercice_commande.Classes.CommandeRepository;
using exercice_commande.Classes.Model;


ClientRepository.CreateTableClient();
CommandeRepository.CreateCommandeClient();

ClientRepository.AjouterUnClient(new Client(null, "linch", "joey", "10 rue des lauriers", "72000", "ambletteuse", "06-10-90-12-30"));
ClientRepository.AjouterUnClient(new Client(null, "dupont", "marie", "5 avenue de la gare", "75010", "paris", "06-45-78-12-90"));
ClientRepository.AjouterUnClient(new Client(null, "martin", "lucas", "18 rue victor hugo", "33000", "bordeaux", "07-22-14-98-56"));
ClientRepository.AjouterUnClient(new Client(null, "bernard", "sophie", "42 boulevard voltaire", "69003", "lyon", "06-88-30-45-21"));
ClientRepository.AjouterUnClient(new Client(null, "moreau", "thomas", "9 impasse des lilas", "59000", "lille", "07-61-04-77-33"));
ClientRepository.AjouterUnClient(new Client(null, "lefevre", "camille", "27 chemin du moulin", "44000", "nantes", "06-19-56-82-14"));



List<Client> toutlesclients = ClientRepository.AfficherToutLesClients();
CommandeRepository.AjouterUneCommande(new Commande(null, toutlesclients.First().Id ?? 1, new DateTime(2024, 02, 02), 10000));
CommandeRepository.AjouterUneCommande(new Commande(null, toutlesclients.First().Id ?? 1, new DateTime(2024, 03, 02), 1000));
CommandeRepository.AjouterUneCommande(new Commande(null, toutlesclients.First().Id ?? 1, new DateTime(2024, 02, 12), 10200));


Client c = ClientRepository.RecupererUnClient(toutlesclients.First().Id ?? 1);
List<Commande> commande = CommandeRepository.AfficherTouteLesCommandesAvecClientId(toutlesclients.First().Id ?? 1);

Console.WriteLine(c);
foreach (Commande commande1 in commande)
{
    Console.WriteLine(commande1);
}
void Supprimer()
{
    Console.WriteLine("Veuillez entrer le client a supprimer");
    int Id = int.Parse(Console.ReadLine());

    ClientRepository.SupprimerUnClient(Id);

}
void Afficher ()
{
    Console.WriteLine("Voici tout les clients :");
    List<Client> clients = new List<Client>();
    List<Client> clients1 = ClientRepository.AfficherToutLesClients();
    foreach(Client c in clients1)
    {
        Console.WriteLine(c);
    }
}

string choix = "";

do
{
    Console.WriteLine("""


   ____                                          _           
  / ___|___  _ __ ___  _ __ ___   __ _ _ __   __| | ___  ___ 
 | |   / _ \| '_ ` _ \| '_ ` _ \ / _` | '_ \ / _` |/ _ \/ __|
 | |__| (_) | | | | | | | | | | | (_| | | | | (_| |  __/\__ \
  \____\___/|_| |_| |_|_| |_| |_|\__,_|_| |_|\__,_|\___||___/

1. Afficher les clients
2. Créer un client
3. Modifier un client
4. Supprimer un client
5. Afficher les détails d'un client
6. Ajouter une commande
7. Modifier une commande
8. Supprimer une commande
0. Quitter
``````
 """);

    choix = Console.ReadLine();

    switch (choix)
    {
        case "1":
            Afficher();
            break;

            case "2":

            case "3":


            case "4":
            Supprimer();
            break;





    }

    while (choix != 0) ;






}
