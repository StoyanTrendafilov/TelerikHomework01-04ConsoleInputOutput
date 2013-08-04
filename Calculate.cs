using System;

class Calculate
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert a, b and c for your quadric equation: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double deskr = (b * b) - (4 * a * c);

        if (deskr < 0)
            Console.WriteLine(" This equation has no results");

        if (deskr == 0)
        {
            double result = -b / (2 * a);
            Console.WriteLine(" The result is : {0} ! ", result);
        }

        if (deskr > 0)
        {
            double x1 = (-b + Math.Sqrt(deskr)) / 2;
            double x2 = (-b - Math.Sqrt(deskr)) / 2;

            Console.WriteLine("THe results of you equation are {0:F2} and {1:F2} ! ", x1, x2); // ограничил съм знаците след десетичната запетая 
        }                                                                                               // защото така ми изглецда по-прегледно.
    }
}

