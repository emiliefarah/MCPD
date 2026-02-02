//demander a l'utilisateur de rentrer un mot
Console.WriteLine("veuillez entrer un mot");
string mot =Console.ReadLine();

// if voyelles.contains(a)

int compteur = 0;
foreach (char lettre in mot)
{
    bool ok = "aeiouy".Contains(lettre);

    if (ok)
        compteur++;
}

Console.WriteLine("le nombre de voyelles est de :" + compteur);