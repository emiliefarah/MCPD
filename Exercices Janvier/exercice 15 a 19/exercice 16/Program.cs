


    int[] t = new int[5];
Console.WriteLine("veuillez saisir 5 âges");
int entreeut;
int compteurvalide = 0;
int compteurinvalide = 0;

while (compteurvalide < 5)
{
    entreeut=int.Parse(Console.ReadLine());
    

    if (entreeut > 0 && entreeut < 120)
    {
        Console.WriteLine("valeur valide");
        t[compteurvalide]= entreeut;
        compteurvalide++;
        
    }
    else
    {
        Console.WriteLine("age invalide");
        compteurinvalide++;
    }
    
}

Console.WriteLine();

foreach (int i in t)
{
    Console.WriteLine(i);
}

Console.WriteLine("vous avez saisi des ages invalide:"+compteurinvalide);