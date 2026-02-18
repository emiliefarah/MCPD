using Exercice_14.Class;

User us1 = new User("Dupont", "Vanessa",new Adresse(100," rue de Marquillies", "59000 ","Lille") );

User us2 = new User("grominet", "titi", new Adresse(22, "rue des glycines"," 59000"," Lille"));

Lettre l1 = new Lettre(us1, us2, "carte postale");
Lettre l2 = new Lettre (us2,us1,"carte d'anniversaire");

Console.WriteLine(l1);
Console.WriteLine(l2);
Console.WriteLine(us1);
Console.WriteLine(us2);
l1.Lire();
l2.Envoyer();
Console.WriteLine(l1);
Console.WriteLine(l2);
