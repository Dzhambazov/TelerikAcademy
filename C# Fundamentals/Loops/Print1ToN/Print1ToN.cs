using System;

class Print1toN
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }
    }
}
