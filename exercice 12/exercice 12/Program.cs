using exercice_12.Class;
using exercice_12.Interface;

Voiture v1 = new Voiture("clio","renault");
VoitureHybride vh1 = new VoitureHybride("class g", "mercedes");
Hydravion h1 = new Hydravion("voisin", "les voisins");

v1.Demarrer();
vh1.Demarrer();
vh1.Recharger();
h1.Atterir();
h1.Demarrer();
h1.Decoller();
h1.Naviguer();

Vehicule[] Vehicules = { v1, vh1, h1 };

foreach(Vehicule v in Vehicules)
{
    Console.WriteLine(v);
}

IMotorise[]Motorises= { v1, vh1, h1 };

foreach (IMotorise m in Motorises)
{
    Console.WriteLine(m);
    m.Demarrer();
}