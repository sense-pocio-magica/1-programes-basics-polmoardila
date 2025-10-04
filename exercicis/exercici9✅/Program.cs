namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 peus) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Valor en metres:");
        var metres = Console.ReadLine();
        float metresf = float.Parse(metres);
        float peus = 3.28084f;

        float resultat = peus * metresf;

        Console.WriteLine($"{metres} metres son {resultat} peus");

    }
}
