using System;

class RecArea
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle width:");
        float Width = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle height:");
        float Height = float.Parse(Console.ReadLine());

        float RecArea = Width * Height;
        Console.WriteLine("A rectangle with width: {0} and height: {1} has area: {2}",Width,Height,RecArea);
    }
}