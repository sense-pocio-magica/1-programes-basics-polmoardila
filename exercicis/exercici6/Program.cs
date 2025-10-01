namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Els quadrats tenen 4 costats. Digue'm el perimetre del teu quadrat.");
        var perimetre = Console.ReadLine();
        float perimetrefloat = float.Parse(perimetre);

        float quadrat = 4;
        float resultat = perimetrefloat * quadrat;

        Console.WriteLine($"El perimetre del teu quadrat es {resultat}");
    }
}
