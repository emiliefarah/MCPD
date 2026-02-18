//Exercice 1

int A = 8;
int B = 10;
int C = 0;

C = B;
B = A;
A = C;
Console.WriteLine("la valeur de B est "+B );
Console.WriteLine("la valeur de A est "+A );

//Exercice 2

Console.WriteLine("Veuillez saisir deux nombres");
int nombreutilsateur1=int.Parse(Console.ReadLine());
int nombreutilsateur2 =int.Parse(Console.ReadLine());

int resultat=nombreutilsateur1 + nombreutilsateur2;
Console.WriteLine("Le resultat des deux nombres est " + resultat);

//Exercice 3

Console.WriteLine("Veuillez entrer une temperature en Celsius");
float temperaturecelsisus = float.Parse(Console.ReadLine());
float fahrenheit = (temperaturecelsisus * 9 / 5) + 32;
Console.WriteLine("La temperature en fahrenheit est "+fahrenheit);

//Exercice 4
Console.WriteLine("Mettre la longueur du rectangle");
float longueurrectangle=float.Parse(Console.ReadLine());
Console.WriteLine("Mettre la largeur du rectangle");
float largeurrectangle=float.Parse(Console.ReadLine());
float perimetre = 2 * (longueurrectangle + largeurrectangle);
Console.WriteLine("Le périmétre du rectangle est " + perimetre);
float airerectangle = (longueurrectangle * largeurrectangle);
Console.WriteLine("L'aire du rectangle est " + airerectangle);


//Exercice 5 

Console.WriteLine("Veuillez entrer un poid en KG ");
int poids = int.Parse(Console.ReadLine());
Console.WriteLine("Veuillez rentrer la livraison souhaité : Standard (1) ou express (2)");
int livraison = int.Parse(Console.ReadLine());

if (poids < 1) {
    if (livraison == 1)
        Console.WriteLine("Le prix de l'envoi est de 4.99€");
    else if (livraison == 2)
        Console.WriteLine("Le prix de l'envoi est de 7.99€");
    else
        Console.WriteLine("Erreur");
       
}
if (poids < 5)
{
    if (livraison == 1)
        Console.WriteLine("Le prix de l'envoi est de 6.99€");
    else if (livraison == 2)
        Console.WriteLine("Le prix de l'envoi est de 10.99€");
    else
        Console.WriteLine("Erreur");

}
if(poids >5) { 

    if (livraison == 1)
        Console.WriteLine("Le prix de l'envoi est de 9.99€");
    else if (livraison == 2)
        Console.WriteLine("Le prix de l'envoi est de 14.99€");
    else
        Console.WriteLine("Erreur");

}

//Exercice 6

Console.WriteLine("Veuillez saisir un nombre");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
string o= Console.ReadLine();

switch (o)
{
    case "+":
        Console.WriteLine("a+b est egal à " + (a + b));
        break;


    case "-":
        Console.WriteLine("a-b est egal à" + (a - b));
        break;
    
    
    case "*":
            Console.WriteLine("a*b est egal à " +( a * b));
            break;
        
    
    case "/":
        if (b == 0)
            Console.WriteLine("Division impossible");
            Console.WriteLine("a/b est egal à " +( a / b));
            break;

    default: Console.WriteLine("operateur invalide");
        break;
    }

            //Exercice 7
            Console.WriteLine("Veuillez saisir une note");
int note = int.Parse(Console.ReadLine());

string resultat1 = "";

resultat1 = note switch
{
    >= 18 and <= 20 => "Excellent",
    >= 15 and <= 17 => "Tres bien ",
    >=12  and <= 14 => "Bien",
    >= 10 and <= 14 => "Passable",
    > 0  and <= 9 => "Insuffisant",
   _ => "Note invalide"

};

Console.WriteLine(resultat1);

//Exercice 8

Console.WriteLine("Veuillez saisir un nombre");
int n = int.Parse(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("le nombre est negatif");
}
else if (n == 0)
{
    Console.WriteLine("le nombre est nul");
}
else
{
    Console.WriteLine("le nombre est positif");
}
if (n % 2 == 0)
{
    Console.WriteLine("le nombre est pair");
}
else
{
    Console.WriteLine("le nombre est impair");
}
if (n >= -10 && n <=10)
{
    Console.WriteLine("N est dans l'intervalle");
}
else
{
    Console.WriteLine("N n'est pas dans l'intervalle");
}

//Exercice 9

Console.WriteLine("Veuillez entrer votre identifiant");
string? login = Console.ReadLine();
string identifiant = login ?? "Invité";

Console.WriteLine("Veuillez entrer votre mot de passe");
string? password = Console.ReadLine();

Console.WriteLine("Veuillez entrer votre identifiant");
string? code = Console.ReadLine();


if ((identifiant != "Invité"&& password=="1234") || code=="ADMIN"){
    Console.WriteLine("acces autorisé");
}
else
{
    Console.WriteLine("acces refusé");
}









