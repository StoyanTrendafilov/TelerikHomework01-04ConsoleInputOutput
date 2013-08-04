using System;

class Counter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, insert two digits: (make first smaller)");
        UInt32 number1 = UInt32.Parse(Console.ReadLine());
        UInt32 number2 = UInt32.Parse(Console.ReadLine());
        //UInt32 result = 0;
        UInt32 count = 0;
        if (number1 < number2)
        {
            for (UInt32 i = number1; i < number2; i++)
            {
                if (i % 5 == 0)
                    count++;

            }
            Console.WriteLine(count);
        }
        else
            Console.WriteLine("Insert correct numbers!");


        //if (number1 <= number2) // i dwata warianta rabotqt, ako otkmoentirame tozi i zakomentirame drugiq se polu4awa ednoi sy6to 
        //result = (number2 - number1) / 5; 
        //else
        //result = (number1 - number2) / 5;
        //Console.WriteLine(" You can put \"5\" {0} times between your numbers", result);
    }
}

