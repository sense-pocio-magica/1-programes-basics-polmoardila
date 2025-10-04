namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nom d'usuari");
        var usuari = Console.ReadLine();

        Console.WriteLine("nom de domini");
        var domini = Console.ReadLine();

        Console.WriteLine($"El teu correu es {usuari}@{domini}");
    }
}
