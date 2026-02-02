int choice;

int choix = 7;

do
{
    Console.WriteLine("Devine le bon nombre!!");
    bool choiceOK = int.TryParse(Console.ReadLine(), out choice);

    if (choiceOK)
    {
        if (choice == choix)
        {
            Console.WriteLine("vous avez trouvé le bon nombre");
            break;
        }
        else if (choice != choix)
        {
            Console.WriteLine("Mauvais nombre");
        }
    }

    else
        Console.WriteLine("entrer un nombre");

} while (true);