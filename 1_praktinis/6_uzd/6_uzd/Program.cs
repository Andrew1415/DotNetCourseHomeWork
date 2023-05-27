//6_uždavinys Andrius Stulgys

using System;

class Program
{
    static void Main()
    {
        Console.Write("Įveskite skaičių n: ");
        int n = int.Parse(Console.ReadLine());

        int faktorialas = 1;
        for (int i = 1; i <= n; i++)
        {
            faktorialas *= i;
        }

        Console.WriteLine($"{n} faktorialas yra {faktorialas}");
    }
}
