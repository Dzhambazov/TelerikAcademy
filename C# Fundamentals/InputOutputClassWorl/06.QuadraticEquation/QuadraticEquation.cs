using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c:");
        int c = int.Parse(Console.ReadLine());

        double D = (b * b) - (4 * a * c);
        if (D == 0)
        {
            Console.WriteLine("There're not real roots !");
        }
        else
        {
            int root1 = ((-b) + (int)Math.Sqrt(D)) / (2 * a);
            int root2 = ((-b) - (int)Math.Sqrt(D)) / (2 * a);

            Console.WriteLine("Root 1 is: {0} ", root1);
            Console.WriteLine("Root 2 is: {0}", root2);
        }
    }
}