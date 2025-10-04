namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrega el primer numero:");
        var num1 = Console.ReadLine();
        float numint1 = float.Parse(num1);

        Console.WriteLine("Entrega el segon numero:");
        var num2 = Console.ReadLine();
        float numint2 = float.Parse(num2);

        float suma = numint1 + numint2;
        float resta = numint1 - numint2;
        float multiplicació = numint1 * numint2;
        float divisió = numint1 / numint2;
        float sobra = numint1 % numint2;

        Console.WriteLine($"{numint1} + {numint2} = {suma}");
        Console.WriteLine($"{numint1} - {numint2} = {resta}");
        Console.WriteLine($"{numint1} * {numint2} = {multiplicació}");
        Console.WriteLine($"{numint1} / {numint2} = {divisió} i sobra {sobra}");


    }
}
