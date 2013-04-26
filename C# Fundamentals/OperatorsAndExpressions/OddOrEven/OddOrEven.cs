using System;
class OddOrEven
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        if (N % 2 == 0)
        {
            Console.WriteLine("{0} is an even number", N);
        }
        else
        {
            Console.WriteLine("{0} is an odd number", N);   
        }
    }
}
