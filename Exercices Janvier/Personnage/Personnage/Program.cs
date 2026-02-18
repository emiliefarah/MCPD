
using System.ComponentModel.Design;
using Exercice3.classe;

Personnage p1 = new Personnage ("gimli",20,5);
Personnage p2 = new Personnage("legolas", 20, 3);

while (p1.IsAlive && p2.IsAlive){
    p1.Attack(p2);

    if (!p2.IsAlive)
    {
        break;
    }

    p2.Attack(p1);
}

if (p1.IsAlive)
{
    Console.WriteLine(p1.Name +" " + "est le vainqueur!! ");
    
}
else
{
    Console.WriteLine(p2.Name +" "+ "est le vainqueur!! ");
}