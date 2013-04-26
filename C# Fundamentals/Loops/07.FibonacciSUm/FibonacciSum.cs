using System;
using System.Numerics;
class FibonacciSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        BigInteger Num = 0;
        BigInteger Result = 1;
        BigInteger Temp;
        BigInteger Sum = 1;
        for (int i = 2; i < N; i++)
        {
            Temp = Num;
            Num = Result;
            Result = Temp + Num;
            Sum += Result;
        }
        Console.WriteLine(Sum);
    }
}