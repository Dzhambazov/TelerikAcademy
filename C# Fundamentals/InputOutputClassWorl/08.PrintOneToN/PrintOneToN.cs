using System;
class PrintOneToN
{
    static void Main()
    {
        Console.Write("Your number: ");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }
    }
}
