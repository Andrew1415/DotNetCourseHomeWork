//2_užduotis Andrius Stulgys
using System;

class Program
{
    static void Main()
    {
        Console.Write("Įveskite skaičių: ");
        string input = Console.ReadLine();
        int number;

        if (int.TryParse(input, out number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Įvestas skaičius yra lyginis.");
            }
            else
            {
                Console.WriteLine("Įvestas skaičius yra nelyginis.");
            }
        }
        else
        {
            Console.WriteLine("Įvesta reikšmė nėra skaičius.");
        }
    }
}
