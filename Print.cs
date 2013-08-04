using System;

class Print
{
    static void Main(string[] args)
    {
        Console.Write("Please insert N : ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.WriteLine(i);
    }
}

