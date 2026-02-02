Console.WriteLine("- - - Calcul du périmétre et de l'aire d'un carré - - -");
Console.WriteLine("Entrez la longeur d'un coté du carré (en cm)");
    float L = float.Parse(Console.ReadLine());
    float air = L * 4;
Console.WriteLine("le perimetre du carré est :" + air+"cm");
float peri = L * L;
Console.WriteLine("l'aire du carré est :" + peri+ "cm²");

Console.WriteLine("- - - Calcul du périmétre et de l'aire d'un rectangle - - -");
Console.WriteLine("Entrez la longeur du rectangle (en cm)");
float longueur=float.Parse(Console.ReadLine());
Console.WriteLine("Entrez la largeur du rectangle (en cm)");
float largeur = float.Parse(Console.ReadLine());
float perimetre = (largeur+longueur) * 2;
float airrec = longueur * largeur;
Console.WriteLine("Le périmétre du rectangle est :"+perimetre+"cm");
Console.WriteLine("L'air du rectangle est : " + airrec+"cm²");

