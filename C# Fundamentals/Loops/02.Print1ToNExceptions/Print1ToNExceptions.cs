using System;

class Print1ToNExeptions
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            if (i % 35 == 0)
            {
                continue;
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}