//8_uždavinys Andrius Stulgys

using System;

class Program
{
    static void Main(string[] args)
    {
        bool hasThree = false;
        int i = 1;
        do
        {
            int j = 1;
            do
            {
                int product = i * j;
                Console.Write($"{i} x {j} = {product}");
                if (CheckForThree(product))
                {
                    Console.Write($" -> true\t ");
                }
                else
                {
                    Console.Write($" -> false\t ");
                }
                j++;
            } while (j <= 9);
            Console.WriteLine();
            i++;
        } while (i <= 9);
    }

    static bool CheckForThree(int number)
    {
        while (number > 0)
        {
            if (number % 10 == 3)
            {
                return true;
            }
            number /= 10;
        }
        return false;
    }
}
