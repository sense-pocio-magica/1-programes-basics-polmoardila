namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Diguem una paraula:");
        string paraula = Console.ReadLine();
        char primera = paraula[0];
        char ultima = paraula[paraula.Length - 1];
        char mitg = paraula[paraula.Length / 2];


        Console.WriteLine($"La primera lletra és ({primera}) la ultima és ({ultima}) la paraula del mitg ({mitg}).");
    }
}
