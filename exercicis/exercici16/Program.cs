namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nota de pràctiques:");
        var nota_pt = Console.ReadLine();
        float nota_pt_float = float.Parse(nota_pt);

        Console.WriteLine("Nota de l'examen:");
        var nota_ex = Console.ReadLine();
        float nota_ex_float = float.Parse(nota_ex);

        float examen = nota_ex_float * 0.7;

        float practica = nota_pt_float * 0.3;

        float nota = examen + practica;


        Console.WriteLine($"La nota final és {nota} o sigui un");
    }
}
