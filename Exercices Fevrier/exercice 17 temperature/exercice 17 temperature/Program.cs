using System.ComponentModel.Design;

List<int> listDeTemperatures = new List<int>();
int temp;
int nbInvalid = 0;

do
{
    Console.WriteLine("veuillez saisir une température");
  if (int.TryParse( Console.ReadLine() ,out temp)) 
    {
       if ( temp >= -50 && temp <= 50)
        listDeTemperatures.Add(temp);

    }

    else
        nbInvalid++;

} while (temp != -999);
  

Console.WriteLine(listDeTemperatures.Count);
Console.WriteLine(nbInvalid);
Console.WriteLine(listDeTemperatures.Max());
Console.WriteLine(listDeTemperatures.Min ());