//4_užduotis Andrius Stulgys

using System;

class Program
{
    static void Main()
    {
        Console.Write("Įveskite mėnesio numerį: ");
        int month = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Žiema");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Pavasaris");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Vasara");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Ruduo");
                break;
            default:
                Console.WriteLine("Tokio mėnesio nėra");
                break;
        }
    }
}
