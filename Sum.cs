using System;

class Sum
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert first number: ");
        int digit1 = int.Parse(Console.ReadLine());
        Console.Write("Please, insert second number: ");
        int digit2 = int.Parse(Console.ReadLine());
        Console.Write("Please, insert third number: ");
        int digit3 = int.Parse(Console.ReadLine());
        int sum = digit1 + digit2 + digit3;
        Console.WriteLine("The sum of your numbers is : {0} :) ", digit3 + digit2 + digit1);
    }
}
