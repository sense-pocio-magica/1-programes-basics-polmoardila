using System;

namespace exercici3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nom producte");
            var producte = Console.ReadLine();

            Console.WriteLine("Preu producte");
            var preu = Console.ReadLine();

            Console.WriteLine("Aquest article està en stock? (si/no)");
            var disponibilitat = Console.ReadLine();

            Console.WriteLine($"El producte {producte} val {preu} i {disponibilitat} està en stock. ");
        }
    }
}