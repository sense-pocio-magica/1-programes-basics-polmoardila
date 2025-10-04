namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calcul de minuts a continuació introdueix els minuts que vols passar a hores:");
        var minuts = Console.ReadLine();
        int minutsint = Convert.ToInt16(minuts);

        int hores = minutsint / 60 ;
        int totalminuts = minutsint % 60;
        Console.WriteLine($"Això són {hores} hores i {totalminuts} minuts.");

    }
}
