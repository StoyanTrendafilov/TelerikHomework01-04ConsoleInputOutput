using System;

class NumbersCompare
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert number 1 : ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert number 2 : ");
        int b = int.Parse(Console.ReadLine());

        int result = Math.Max(a, b);

        int result1 = (a + b + Math.Abs(a - b)) / 2;

        int result2 = a - ((a - b) & (a - b) >> 31); // towa go prepisah, ne go razbrah :D

        Console.WriteLine("The bigger number is : {0},  and also by other way {1}, ant by bitwise operators {2}", result, result1, result2);
    }
}

