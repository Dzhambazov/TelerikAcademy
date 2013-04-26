using System;
class CirclePerimeterArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;
        Console.WriteLine("Circle's perimeter is {0}", perimeter);
        Console.WriteLine("Circle's area i s {0}",area);
    }
}
