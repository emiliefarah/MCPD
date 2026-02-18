using exercice21calculmoyenne.exception;

double calculmoyenne(int[]notes)
{
    if (notes == null || notes.Length == 0)
        throw new InvalidArrayException("le tableau ne doit pas etre vide ou nulle");
    

    int somme = 0;
    foreach (int note in notes)
    {
        if (note < 0 || note >20)
            throw new ArgumentOutOfRangeException("la note entrée est invalide");

        somme += note;
    }

    return somme / notes.Length;
}


int[] note = new int[5];
note[0] = 9;
note[1] = 13;
note[2] = 16;
note[3] = 10;
note[4] = 20;

double resultat = 0;

try
{
   resultat = calculmoyenne(note);
}

catch(InvalidArrayException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("la moyenne est : " + resultat);