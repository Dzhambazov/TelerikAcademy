using System;

class CheckDigit
{
    static void Main()
    {
        int N;
        do
        {
            Console.WriteLine("Enter a number > 999");
            N = int.Parse(Console.ReadLine());
        }
        while(N<999);
        N /= 100;
        int Digit = N % 10;
        Console.WriteLine(Digit%7==0);
    }
}