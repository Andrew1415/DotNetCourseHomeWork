//11_užduotis Andrius Stulgys

using System;

class Program
{
    static void Main()
    {
        Console.Write("Įveskite skaičių: ");
        int skaicius = int.Parse(Console.ReadLine());

        Console.WriteLine("IsSymmetrical(" + skaicius + ") -> " + IsSymmetrical(skaicius));
    }

    static bool IsSymmetrical(int skaicius)
    {
        string skaiciusTekstu = skaicius.ToString();
        int ilgis = skaiciusTekstu.Length;

        for (int i = 0; i < ilgis / 2; i++)
        {
            if (skaiciusTekstu[i] != skaiciusTekstu[ilgis - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}
