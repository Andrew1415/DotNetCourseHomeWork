//3_užduotis Andrius Stulgys

using System;

class Program
{
    static void Main()
    {
        Console.Write("Įveskite skaičių a: ");
        short a = short.Parse(Console.ReadLine());
        Console.Write("Įveskite skaičių b: ");
        short b = short.Parse(Console.ReadLine());
        Console.Write("Įveskite skaičių c: ");
        short c = short.Parse(Console.ReadLine());
        Console.Write("Įveskite skaičių d: ");
        short d = short.Parse(Console.ReadLine());

        short max = a;
        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }
        if (d > max)
        {
            max = d;
        }

        Console.WriteLine("Didžiausias skaičius yra: " + max);
    }
}
