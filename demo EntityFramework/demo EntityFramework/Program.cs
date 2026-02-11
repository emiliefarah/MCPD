
using demo_EntityFramework.DbManager;
using demo_EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("===Demo Entity FrameWork===");

//Nous devons instancier une AppDbContext pour ouvrir la connexion avec la BDD
using AppDbContext db = new AppDbContext();

//La méthode Migrate permet de synchroniser nos tables avec notre BDD 
db.Database.Migrate();
//CREATE
db.Personne.Add(new Personne("toto", "Tata", 30, "0123456789", "test@tes.com"));
db.SaveChanges();

//READ ALL
List<Personne>allPersonnes = db.Personne.ToList();
foreach (Personne p in allPersonnes)
    Console.WriteLine(p);

//FIND BY ID 
Personne p1 = db.Personne.First();
Console.WriteLine(p1);

//UPDATE
p1.Email = " unAutreTest@test.com";
p1.Age = 20;
db.Personne.Update(p1);
db.SaveChanges();

//DELETE PERSONNE 
//db.Personne.Remove(p1);
//db.SaveChanges


//TODO vider Table 
//db.Personne;
/*
 * 
 * READ (avec des filtres )
*/

//Filtre WHERE + trie avec ORDER By

List<Personne> adulTrie =db.Personne
    .Where (p=>p.Age >=18)
    .OrderBy(p=> p.LastName)
    .ToList();

//Pagination
 