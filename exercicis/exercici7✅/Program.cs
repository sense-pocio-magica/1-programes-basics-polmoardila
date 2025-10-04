namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Diguem 3 notes:");
        var num1 = Console.ReadLine();
        var num2 = Console.ReadLine();
        var num3 = Console.ReadLine();

        float numero1 = float.Parse(num1);
        float numero2 = float.Parse(num2);
        float numero3 = float.Parse(num3);

        float mitjana1 = numero1 + numero2 + numero3;
        float mitjana = mitjana1 / 3;

        Console.WriteLine($"La mitjana de la nota és: {mitjana:F2}");
    }
}
