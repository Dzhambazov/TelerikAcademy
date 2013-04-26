using System;
class PrintSumNumbersN
{
    static void Main()
    {
        Console.Write("Enter the number of numbers: ");
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        int Number;
        for (int i = 0; i < N; i++)
        {
            Console.Write("Number: ");
            Number = int.Parse(Console.ReadLine());
            sum += Number;
        }
        Console.WriteLine("The sum of numbers is: {0}",sum);
    }
}