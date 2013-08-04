using System;

class Accuracy
{
    static void Main(string[] args)
    {
        decimal sum = 1m;
        decimal sum2 = 0;
        decimal delitel = 2;
        int znak = 1;
        do //while (1m / delitel > 0.001m)
        {
            sum2 = sum + sum2;
            sum = sum + (1 / delitel) * znak;
            znak = znak * (-1);
            delitel++;
            sum = Math.Round(sum, 3);
            Console.WriteLine(sum.ToString("0.000000"));
            Console.WriteLine("---------------");

        }
        while ((sum2 - sum) < 0.001m);
    }
}

