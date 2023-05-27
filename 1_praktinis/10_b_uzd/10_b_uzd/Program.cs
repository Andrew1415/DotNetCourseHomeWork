//10_b_užduotis Andrius Stulgys

using System;

class Program
{
    static void Main()
    {
        double x = 47.62;
        string y = "951";
        string z = "61X!";

        int xInt = (int)x;
        Console.WriteLine("x konvertuotas į sveikąjį skaičių: " + xInt);
        int yInt = 0;
        int zInt = 0;


        if (int.TryParse(y, out yInt))
        {
            Console.WriteLine("y konvertuotas į sveikąjį skaičių: " + yInt);
        }
        else
        {
            Console.WriteLine("y negalima konvertuoti į sveikąjį skaičių.");
        }

        if (int.TryParse(z, out zInt))
        {
            Console.WriteLine("z konvertuotas į sveikąjį skaičių: " + zInt);
        }
        else
        {
            Console.WriteLine("z negalima konvertuoti į sveikąjį skaičių.");
        }
    }
}
