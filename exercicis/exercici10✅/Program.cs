namespace exercici10;

/* Declara dues variables: una per al nom i una altra per l’any de naixement. 
Combina-les per crear una contrasenya bàsica (per exemple, Pere i 1982 -> Pere1982). 
Imprimeix la contrasenya generada (i sobretot no la facis servir mai que és molt dolenta) */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digue'm el teu nom:");
        string nom = Console.ReadLine();

        Console.WriteLine("Any de neixament:");
        string any = Console.ReadLine();
        int anyint = Convert.ToInt16(any);

        Console.WriteLine($"La teva contrasenya es {nom}{any} no la facis servir en cap lloc.");

    }
}
