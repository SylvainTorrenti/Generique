using Generique;
#region methode generique
Console.WriteLine("!!!!!METHODE GENERIQUE!!!!!");
#region Est egal
int i = 5;
int j = 5;
double d = 9.5;
Console.WriteLine(EstEgal(i, j));
Console.WriteLine(EstEgal(i, d));
static bool EstEgal<T, U>(T t, U u)
{
    return t.Equals(u);
}
#endregion
Console.WriteLine("------------------");
Console.WriteLine("------------------");
Console.WriteLine("------------------");
Console.WriteLine("------------------");
#region Echange

#region Echange de int
int k = 5;
int l = 10;
Console.WriteLine("k a pour valeur : " + k);
Console.WriteLine("l a pour valeur : " + l);
Console.WriteLine("------------------");
Echanger(ref k, ref l);
Console.WriteLine("k a maintenant pour valeur : " + k);
Console.WriteLine("l a maintenant pour valeur : " + l);
#endregion
Console.WriteLine("++++++++++++++++++++++");
Console.WriteLine("++++++++++++++++++++++");
Console.WriteLine("++++++++++++++++++++++");
Console.WriteLine("++++++++++++++++++++++");
#region echange de couleur
Voiture v1 = new Voiture { Couleur = "Rouge" };
Voiture v2 = new Voiture { Couleur = "Verte" };
Console.WriteLine("La voiture 1 a pour couleur : " + v1.Couleur);
Console.WriteLine("La voiture 2 a pour couleur : " + v2.Couleur);
Console.WriteLine("------------------");
Echanger(ref v1, ref v2);
Console.WriteLine("La voiture 1 a maintenant pour couleur : " + v1.Couleur);
Console.WriteLine("La voiture 2 a maintenant pour couleur : " + v2.Couleur);
static void Echanger<T>(ref T t1, ref T t2)
{
    T temp = t1;
    t1 = t2;
    t2 = temp;
}
#endregion

#endregion
Console.WriteLine("                  ");
Console.WriteLine("                  ");
Console.WriteLine("                  ");
Console.WriteLine("                  ");
#endregion
#region class generique
Console.WriteLine("!!!!!CLASS GENERIQUE!!!!!");
MaListeGenerique<int> maListe = new();

maListe.Ajouter(1);
maListe.Ajouter(2);
maListe.Ajouter(3);

Console.WriteLine("A l'indice 0 la valeur est de : " + maListe.ObtenirElement(0));
Console.WriteLine("A l'indice 1 la valeur est de : " + maListe.ObtenirElement(1));
Console.WriteLine("A l'indice 2 la valeur est de : " + maListe.ObtenirElement(2));

Console.WriteLine("------------------");
Console.WriteLine("------------------");
Console.WriteLine("------------------");

for (int ii = 0; ii < 30; ii++)
{
    maListe.Ajouter(ii);
}

Console.WriteLine("A l'indice 5 la valeur est de : " + maListe.ObtenirElement(5));
Console.WriteLine("A l'indice 8 la valeur est de : " + maListe.ObtenirElement(8));
Console.WriteLine("A l'indice 10 la valeur est de : " + maListe.ObtenirElement(10)); 
#endregion
