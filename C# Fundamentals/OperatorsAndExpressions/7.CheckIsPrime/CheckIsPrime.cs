using System;

class CheckIsPrime
{
    static void Main()
    {
        int N;
        do
        {
            Console.WriteLine("Enter a number between 0 and 100");
            N = int.Parse(Console.ReadLine());
        }
        while(N<0 || N>100);

        int counter = 0;
        for (int i = 2; i < N; i++)
        {
            if (N % i == 0)
            {
                counter++;
                break;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("{0} is a prime number", N);
        }
        else
        {
            Console.WriteLine("{0} is NOT a prime number", N);
        }
    }
}