namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Carrer:");
        string carrer = Console.ReadLine();

        Console.WriteLine("Número:");
        var numero = Console.ReadLine();
        
        Console.WriteLine("Codi postal:");
        var codi_postal = Console.ReadLine();

        Console.WriteLine("Població");
        string població = Console.ReadLine();

        Console.WriteLine($"Vius al {carrer} amb el número {numero} codi postal {codi_postal} a {població}");
    }
}
