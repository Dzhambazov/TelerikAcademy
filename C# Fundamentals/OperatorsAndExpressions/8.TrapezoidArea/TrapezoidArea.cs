using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter trapezoid's first side");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter trapezoid's second side");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter trapezoid's first height");
        double h = double.Parse(Console.ReadLine());

        double Area = ((a + b) / 2) * h;
        Console.WriteLine("Trapezoid's area is {0}", Area);
        
    }
}