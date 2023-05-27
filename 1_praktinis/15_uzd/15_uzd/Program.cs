//15_užduotis Andrius Stulgys

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>() { "Jake", "Jack", "Harry", "Jacob", "Charlie", "Thomas", "George", "Oscar", "James", "William" };

        // 1. Patikrinti ar sukurtame sąraše egzistuoja „Harry“ vardas.
        bool containsHarry = names.Contains("Harry");
        Console.WriteLine("Contains Harry: " + containsHarry);

        // 2. Rasti sąrašo 8-ojo indekso reikšmę.
        string index8 = names[7];
        Console.WriteLine("Index 8 value: " + index8);

        // 3. Į sąrašą įterpti naują vardą „Bob“ į 4-tą poziciją.
        names.Insert(3, "Bob");

        // 4. Ištrinti sąrašo elementus, jei vardas prasideda iš „J“ raidės.
        names.RemoveAll(name => name.StartsWith("J"));

        // 5. Išvesti likusio sąrašo elementų kiekį.
        int count = names.Count;
        Console.WriteLine("Remaining elements count: " + count);

        // 6. Rasti paskutiniojo sąrašo elemento reikšmę.
        string lastElement = names[names.Count - 1];
        Console.WriteLine("Last element: " + lastElement);

        // 7. Į sąrašą įterpti naujas reikšmes: „Emily“, „Megan“, „Susan“, „Sarah“, „Margaret“.
        names.AddRange(new List<string>() { "Emily", "Megan", "Susan", "Sarah", "Margaret" });

        // 8. Surūšiuoti sąrašą nuo Z iki A.
        names.Sort();
        names.Reverse();

        // 9. Rasti sąrašo elementą „Thomas“ ir jį pakeisti į „Tom“.
        int tomIndex = names.IndexOf("Thomas");
        names[tomIndex] = "Tom";

        // 10. Išvesti turimo sąrašo reikšmes.
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
