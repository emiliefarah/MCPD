//tableau d'entier avec des valeurs deja donees 

int[] t = { 1, 2, 2, 8, 9, 9 };


// si (if?) deux valeurs sont identiques mettre un message 

bool identique = false; 
for (int i=0; i<t.Length-1; i++)
{
    if (t[i] == t[i + 1])
    {
        Console.WriteLine("vous avez des valeurs identiques");
        identique = true;
        break;
    }

}

if (!identique)
{
    Console.WriteLine("vous n'avez pas de valeurs identiques");

}
