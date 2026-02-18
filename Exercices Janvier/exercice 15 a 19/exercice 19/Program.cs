

int[] suitenb = { 1, 2, 6, 2, 9, 22 };

bool decroissant = false;

for (int i = 0; i < suitenb.Length - 1; i++)
{
    if (suitenb[i] > suitenb[i + 1])
    {
        Console.WriteLine("la suite n'est pas croissante ");
        decroissant = true;
        break;
    }
}   

if (!decroissant)
{
    Console.WriteLine("la suite est croissante");
}