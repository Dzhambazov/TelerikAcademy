using System;

class PrintMatrix
{
    static void Main()
    {
        int N;
        do
        {
            Console.Write("Enter N: ");
            N = int.Parse(Console.ReadLine());
        }
        while (N >= 20);

        for (int i = 1; i <= N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i + j < 10)
                {
                    Console.Write("  {0}", i + j);
                }
                else
                {
                    Console.Write(" {0}", i + j);
                }
            }
            Console.WriteLine();
        }
    }
}