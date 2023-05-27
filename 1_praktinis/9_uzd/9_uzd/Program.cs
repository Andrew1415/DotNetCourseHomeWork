//9_užduotis Andrius Stulgys

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] A = { 1, 2, 2, 2, 9, 7, 1, 10, 3 };
        int[] B = { 3, 9 };

        var uniqueElements = A.Distinct().OrderBy(x => x).Where(x => !B.Contains(x));

        Console.WriteLine(string.Join(", ", uniqueElements));
    }
}
