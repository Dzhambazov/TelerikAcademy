using System;

class FactorialsExpression
{
    static void Main()
    {
        int K, N;
        do
        {
            Console.Write("Enter N: ");
            N = int.Parse(Console.ReadLine());
        }
        while (N < 1);

        do
        {
            Console.Write("Enter K: ");
            K = int.Parse(Console.ReadLine());
        }
        while (K < N);

        int NFac = 1;
        int KFac = 1;

        for (int i = K; i > 1; i--)
        {
            KFac *= i;
        }

        for (int j = N; j > 1; j--)
        {
            NFac *= j;
        }
        Console.WriteLine(KFac * NFac / (K - N));
    }
}
