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

        int numero1 = Convert.ToInt16(num1);
        int numero2 = Convert.ToInt16(num2);
        int numero3 = Convert.ToInt16(num3);

        int mitjana1 = numero1 + numero2 + numero3;
        int mitjana = mitjana1 / 3;

        Console.WriteLine($"La mitjana de la nota és: {mitjana}");
    }
}
