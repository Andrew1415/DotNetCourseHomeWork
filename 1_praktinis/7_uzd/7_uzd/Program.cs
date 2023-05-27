//7_uždavinys Andrius Stulgys

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Įveskite skaičių: ");
        int skaicius = int.Parse(Console.ReadLine());

        int ilgis = 0;
        int tmp = skaicius;
        while (tmp != 0)
        {
            tmp /= 10;
            ilgis++;
        }
        Console.WriteLine($"Skaičiaus ilgis: {ilgis}");

        int atvirkstinis = 0;
        tmp = skaicius;
        while (tmp != 0)
        {
            int skaitmuo = tmp % 10;
            atvirkstinis = atvirkstinis * 10 + skaitmuo;
            tmp /= 10;
        }
        Console.WriteLine($"Atvirkštinis skaičius: {atvirkstinis}");
    }
}
