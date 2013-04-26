using System;
using System.Numerics;
class PrintFibonacci
{
    static void Main()
    {
        BigInteger n1 = 0;
        BigInteger n2 = 1;
        BigInteger sum = 0;
        Console.WriteLine(n1);
        for (int i = 0; i < 100; i++)
        {
            sum = n1 + n2;
            n1 = n2;
            n2 = sum;
            Console.WriteLine(sum);
        }
    }
}
