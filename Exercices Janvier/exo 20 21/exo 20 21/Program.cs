(double note, double note2, double note3) notes;

(double moyenne, string mention) result(double note, double note2, double note3)
{
    double moyenne = (note + note2 + note3) / 3;
    string mention = "";

    if (moyenne < 10)
    {
        mention = "Echec";

    }
    else if (moyenne >= 10 && moyenne < 12)
    {
        mention = "Passable";
    }
    else if (moyenne >= 12 && moyenne < 14)
    {
        mention = "Assez bien";

    }
    else if (moyenne >= 14 && moyenne < 16)
    {
        mention = "Bien";

    }
    else if (moyenne >= 20 )
    {
        mention = "Trés bien";


    }
    else 
    {
        mention = "Note non valide";


    }




    return (moyenne, mention);
}


(double moyenne, string mention) moyenne = result(10, 20, 15);

Console.WriteLine("Votre moyenne est : "+moyenne.moyenne+" votre mention est : "+moyenne.mention );
