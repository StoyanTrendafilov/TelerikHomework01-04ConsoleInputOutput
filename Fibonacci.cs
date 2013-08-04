using System;
using System.Numerics;

class Fibonacci
{
    static void Main(string[] args)
    {
        BigInteger n1 = 0, n2 = 1, temp = 0;
        for (int i = 1; i <= 100; i++)
        {
            temp = n1 + n2;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("{0, 3} : {1, 22}", i, n1); 
        }
    }
}
