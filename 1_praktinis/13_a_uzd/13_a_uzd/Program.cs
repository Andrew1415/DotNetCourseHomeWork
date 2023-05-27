//13_a_užduotis Andrius Stulgys

using System;

public class SquareProgram
{
    static void Main(string[] args)
    {
        int num1 = 7;
        double num2 = 7.5;

        int squareInt = Square(num1);
        double squareDouble = Square(num2);

        Console.WriteLine("Sveikojo skaičiaus kvadratas: " + squareInt);
        Console.WriteLine("Realausjo skaičiaus kvadratas: " + squareDouble);
    }

    static int Square(int num)
    {
        return num * num;
    }

    static double Square(double num)
    {
        return num * num;
    }
}
