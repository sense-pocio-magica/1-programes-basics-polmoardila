namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digue'm el teu nom:");
        var nom = Console.ReadLine();

        Console.WriteLine("Digue'm el teu any de naixament:");
        var data = Console.ReadLine();
        int data2 = Convert.ToInt16(data);

        int edat = 2025 - data2;
        
        Console.WriteLine($"Hola {nom}! Ja tens {edat} anys?");
    }
}
