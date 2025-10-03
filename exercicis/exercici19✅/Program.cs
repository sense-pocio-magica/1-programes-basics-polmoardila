namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Paraula:");
        string paraula = Console.ReadLine();

        var num = paraula.Length;
        Console.WriteLine($"La paraula {paraula} té {num} lletres");
    }
}
