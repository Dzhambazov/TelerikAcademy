using System;
class TrapezoidArea
{
    static void Main()
    {
        double a, b, h, area;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());
        area = (a + b) / 2 * h;
        Console.WriteLine("The trapezoid's area is {0}",area);
    }
}
