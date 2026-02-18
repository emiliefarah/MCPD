// Cas 1 Inscriptions à une competition de jeux vidéos 


SortedSet<string> joueursparticipants = new SortedSet<string>();

joueursparticipants.Add("lola59");
joueursparticipants.Add("emilie");
joueursparticipants.Add("marc");
joueursparticipants.Add("lola59");
joueursparticipants.Add("ambre");
joueursparticipants.Add("marco");


Console.WriteLine("les joueurs inscrits sont ");
foreach (string joueur in joueursparticipants)
{
    Console.WriteLine(joueur);
}

if(joueursparticipants.Contains("lola59"))
    Console.WriteLine("le joueur lola 59 est bien inscrite");



//Cas 2 file d'attente dans un service client 


Queue<string> file = new Queue<string>();
file.Enqueue("emilie");
file.Enqueue("kaï");
file.Enqueue("elias");
file.Enqueue("nikita");
file.Enqueue("kuro");

while (file.Count > 0)
{

    Console.WriteLine("le client en cours de traitement est " + file.Dequeue());
    Console.ReadLine();

    Console.WriteLine("il reste " + file.Count + " clients");
    
}

Console.WriteLine("c'est l'heure de la pause" + file.Count);



// Cas 3 Gestion des notes d'élèves

Dictionary<string,int> noteseleves = new Dictionary<string,int>();

noteseleves["kuro"] = 12 ;
noteseleves["kaï"] = 15 ;
noteseleves["elias"] = 13;
noteseleves["nikita"] = 17;
noteseleves["elvira"] = 18;

noteseleves["elias"] = 15;

Console.WriteLine($"note du 3eme eleve " + noteseleves["elias"]);
Console.WriteLine("note du dernier eleve entré" + noteseleves.Last().Value);

foreach(var paire in noteseleves)
{
    Console.WriteLine($"{paire.Key} =>{paire.Value}");
}





