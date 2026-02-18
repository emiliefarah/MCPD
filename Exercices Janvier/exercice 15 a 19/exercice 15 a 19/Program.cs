int[] t = { 1, -5, 4, -7, 12, 4 , 5 , 2};

int compteur = 0;
int somme = 0;


foreach (int i in t) 
{
    if (i >= 0) 
    {
        compteur++;
        somme = somme + i;
    }

}

Console.WriteLine("la somme des valeurs est :" + somme);
Console.WriteLine("le nombre des valeurs est :" + compteur);
if (compteur != 0)
    Console.WriteLine("la moyenne des valeurs est : " + ((float)somme / compteur));