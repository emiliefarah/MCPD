using exercice_10.Class;

//Forme forme = new Forme("geometrique");
//Console.WriteLine(forme.Nom);
//forme.calculeraire();
//forme.calculerperimetre();

Rectangle rectangle = new Rectangle("Rectangle",5, 3);

Cercle cercle = new Cercle("Cercle",6);

Forme[] lesFormes = { rectangle, cercle };

foreach (Forme forme in lesFormes)
{
    Console.WriteLine($"{forme.Name} a un petimetre de {forme.CalculerPerimetre()} et a une aire de {forme.CalculerAire()}");
}