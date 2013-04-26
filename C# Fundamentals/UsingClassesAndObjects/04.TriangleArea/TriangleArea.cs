using System;
class TriangleArea
{

    static double SideAndAltitude(double a, double h)
    {
        return (a * h) / 2;
    }

    static double ThreeSIdes(double a, double b, double c)
    {
        double perimeter = a + b + c;
        return Math.Sqrt(perimeter*(perimeter-a)*(perimeter-b)*(perimeter-c));
    }

    static double TwoSidesAndAngle(double a, double b, double angle)
    {
        return (a * b * Math.Sin(Math.PI * angle / 180)) / 2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(SideAndAltitude(23.3,10.4));
        Console.WriteLine(ThreeSIdes(10.2,15.1,10.2));
        Console.WriteLine(TwoSidesAndAngle(22.4,25.3,46));
    }
}
