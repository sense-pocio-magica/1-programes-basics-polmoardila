namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nom producte");
        var producte = Console.ReadLine();

        Console.WriteLine("Preu producte");
        var preu = Console.ReadLine();

        Console.WriteLine("Aquest article està en stock?");
        var disponibilitat = Console.ReadLine();
        bool disponibilitat2 = ()
        
        if (disponibilitat == true)
        {
            Console.WriteLine("Si");
        }
        else 
        {
            Console.WriteLine("No");
        }


        Console.WriteLine($"El producte {producte} val {preu} i {disponibilitat} està disponible");

    }
}
