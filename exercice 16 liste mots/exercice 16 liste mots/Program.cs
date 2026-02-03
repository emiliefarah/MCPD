

List<string>listeDeString =new List<string>();
string input;

do
{
    Console.WriteLine("Veuillez saisir des mots (une chaine de caractére)");
    input = Console.ReadLine();

    if (input.ToLower() == "stop")
        break;

    listeDeString.Add(input);

}while(true);

Console.WriteLine("Il y a " + listeDeString.Count + " mots dans la liste");

foreach (string str in listeDeString)
{
    Console.WriteLine(str);
}