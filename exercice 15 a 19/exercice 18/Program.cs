
int[] notes = { 12, 2, 15, 8, 9, 22 };

// si la valeur de mon tableau est inferieur a 10 elle devient 10 si superieur a 20 elle deveint 20

for (int i = 0; i < notes.Length; i++)
{
    if (notes[i] < 10)
    {
        notes[i] = 10;
    }

    if (notes[i] > 20)
    {
        notes[i] = 20;
    }

}
foreach (int note in notes)
{
    Console.WriteLine(note);

}
Console.WriteLine();