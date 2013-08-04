using System;

class Sum
{
    static void Main(string[] args)
    {
        Console.Write("PLease, insert N: ");
        int n = int.Parse(Console.ReadLine()); ;
        int sum, result;
        result = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Please, insert a number(this will repeat n times):");
            sum = int.Parse(Console.ReadLine());
            result = sum + result;
            //Console.WriteLine(result);

        }
        Console.WriteLine("The sum of your numbers is : " + result);
    }
}

