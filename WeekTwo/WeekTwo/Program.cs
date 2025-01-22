/*
Name: James Vernon
COP 2360 WeekTwo Example
21 Jan 2025

I worked on this alone

Week Two is a practical example for Week Two

Calculate the midpoint on a line with two given points
*/

namespace WeekTwo;

class Program
{
    //variables to hold input data
    static int x1, x2, y1, y2;
    static double result1, result2;

    static void Main(string[] args)
    {

        //prompt the user for input
        Console.WriteLine("Midpoint Calculator");
        Console.Write("Enter the value for x1 ");
    
        //capture the first point
        if (Int32.TryParse(Console.ReadLine(), out x1))
        {
            Console.WriteLine($"Captured the value of {x1} for the x1 value. Please enter the y1 value");
            y1 = Int32.Parse(Console.ReadLine()!);

        }

        Console.WriteLine($"First point [{x1}, {y1}] Please enter the x2 value");

        //cappture the second point
        if (int.TryParse(Console.ReadLine(), out x2))
        {//not Int32 but int is an alias for Int32
            Console.WriteLine($"Captured the value of {x2} for the x2 value. Please enter the y2 value");
            y2 = Int32.Parse(Console.ReadLine()!);
        }
        Console.WriteLine($"Second point [{x2}, {y2}]");

        result1 = ((x1 + y1)/2.0000F);
        result2 = ((x2 + y2)/2);

        Console.WriteLine($"The midpoint for the ordered pairs [[{x1}, {y1}], [{x2}, {y2}]] is ({result1}, {result2})");
    }
}
