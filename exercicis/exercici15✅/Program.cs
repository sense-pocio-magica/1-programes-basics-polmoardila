﻿namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nom:");
        string nom = Console.ReadLine();

        Console.WriteLine("Cognom:");
        string cognom = Console.ReadLine();

        string nom1 = char.ToUpper(nom[0]) + nom.Substring(1);
        string cognom1 = char.ToUpper(cognom[0]) + cognom.Substring(1);
        Console.WriteLine($"{nom1} {cognom1}");
    }
}
