using System;

namespace exercici16
{
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

            float examen = nota_ex_float * 0.7f;
            float practica = nota_pt_float * 0.3f;
            float nota = examen + practica;

            int notaFinal = (int)Math.Round(nota);

            Console.WriteLine($"La nota final és {nota:F1} o sigui un {notaFinal}");
        }
    }
}
