namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hora actual:");
        var hora = Console.ReadLine();

        Console.WriteLine("Hores a incrementar:");
        var incrementar = Console.ReadLine();

        int horafl = Convert.ToInt16(hora);
        int incrementarfl = Convert.ToInt16(incrementar);



        int resultat = (horafl + incrementarfl) % 12;
        if (resultat == 0) resultat = 12;



        Console.WriteLine($"D'aqui {incrementar} hores seràn les {resultat}.");
    }
}

// No puc més, help me
