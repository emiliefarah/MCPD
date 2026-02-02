Console.WriteLine("Saisir un nombre ");
//int nbpos = int.Parse(Console.ReadLine()); // "4" Ok, "toto" Ko => crash

bool test = int.TryParse(Console.ReadLine(), out int nbpos); // "4" => test = TRUE et a = 4 / "toto" => test = FALSE et a = 0

while (nbpos < 0 || !test)
{
    Console.WriteLine("vous devez entrer un nombre positif");
    test = int.TryParse(Console.ReadLine(), out nbpos);
}
Console.WriteLine("ok nombre accepté");
Console.WriteLine();