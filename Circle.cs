using System;

class Circle
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert your circle's radius : ");
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double area = (pi * radius * radius) / 2;
        double perimeter = 2 * pi * radius;
        Console.WriteLine("The area of your circle is {0:F2}, and the perimeter of your circle is {1:F2}.", area, perimeter);
    }
}

