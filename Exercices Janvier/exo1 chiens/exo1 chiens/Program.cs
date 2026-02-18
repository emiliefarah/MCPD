using exo1_chiens.chenil;

Chiens c1 = new Chiens("Naya","Berger Américain",4);
Chiens c2 = new Chiens("Ulysse","Bichon",10 );

Chiens.NomDuChenil = "Le Clos Fleuri";

Console.WriteLine(c1);
Console.WriteLine(c2);
Chiens.AfficherNbChiens();