//5_užduotis Andrius Stulgys

using System;

class Program
{
    static void Main()
    {
        const int n = 1112; 

        int firstDigit = n / 1000; 
        int lastDigit = n % 10; 
        int secondDigit = (n / 100) % 10; 
        int thirdDigit = (n / 10) % 10; 

        int product = firstDigit * lastDigit;
        int sum = secondDigit + thirdDigit;

        if (product > sum)
        {
            Console.WriteLine("Pirmojo ir paskutinio skaitmenų sandauga ({0}) yra didesnė už antrojo ir trečiojo skaitmenų sumą ({1})", product, sum);
        }
        else if (product == sum)
        {
            Console.WriteLine("Pirmojo ir paskutinio skaitmenų sandauga ({0}) yra lygi antrojo ir trečiojo skaitmenų sumai ({1})", product, sum);

        }
        else
        {
            Console.WriteLine("Antrojo ir trečiojo skaitmenų suma ({0}) yra didesnė pirmojo ir paskutinio skaitmenų sandaugai ({1})", sum, product);
        }
    }
}
