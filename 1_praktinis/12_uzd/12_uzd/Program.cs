//12_užduotis Andrius Stulgys

using System;

class Program
{
    static void Main()
    {
        Console.Write("Įveskite n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Įveskite m: ");
        int m = int.Parse(Console.ReadLine());

        int suma = 0;
        int kiekis = 0;

        for (int i = n; i <= m; i++)
        {
            suma += i;
            kiekis++;
        }

        double vidurkis = (double)suma / kiekis;

        Console.WriteLine($"Suma: {suma}, Vidurkis: {vidurkis}");
    }
}
