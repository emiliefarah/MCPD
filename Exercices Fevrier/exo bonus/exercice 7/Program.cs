Console.WriteLine("- - -  Calcul de la longeur de l'hypothénuse - - - ");
Console.WriteLine("Entrez la longueur du premier coté (en cm)");
float cote1=float.Parse(Console.ReadLine());
Console.WriteLine("Entrez la longueur du deuxiéme coté (en cm)");
float cote2 = float.Parse(Console.ReadLine());
double hypo =Math.Pow (2,cote1)+ Math.Pow(2,cote2);
hypo=Math.Sqrt(hypo);
Console.WriteLine("La longueur de l'hypothénuse est :"+hypo);