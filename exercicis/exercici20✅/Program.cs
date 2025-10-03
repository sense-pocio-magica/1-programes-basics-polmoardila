namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Numero de tres xifres:");
        var num = Console.ReadLine();
        int numint = Convert.ToInt16(num);

        int num1 = numint % 10;
        int num2 = numint / 100;
        int num3 = numint % 100 / 10;


        Console.WriteLine($"{num1} {num3} {num2}");

    }
}
