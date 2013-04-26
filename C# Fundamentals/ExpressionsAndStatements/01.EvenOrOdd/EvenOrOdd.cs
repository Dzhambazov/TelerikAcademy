using System;

class EvenOrOdd
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        if (N % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("THe number is odd");
        }
    }
}

