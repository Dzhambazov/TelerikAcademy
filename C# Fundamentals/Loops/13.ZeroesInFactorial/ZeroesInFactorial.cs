using System;
class ZeroesInFactorial
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Factorial of {0} has {1} zeroes in the end ",N,N/5);
    }
}
