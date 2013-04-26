using System;
class IsPrime
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        byte counter = 0;
        for (int i = 2; i < N-1; i++)
        {
            if (N % i == 0)
            {
                counter++;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("The number {0} is prime", N);
        }
        else
        {
            Console.WriteLine("The number {0} is NOT prime",N);
        }
    }
}