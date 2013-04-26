using System;

class PrintSmallestAndGreatest
{
    static void Main()
    {
        Console.Write("Array Length: ");
        int n = int.Parse(Console.ReadLine());
        int[] Numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            Numbers[i] = int.Parse(Console.ReadLine());
        }
        int Smallest = Numbers[0];
        int Biggest = Numbers[0];
        for (int i = 1; i < Numbers.Length; i++)
        {
            if (Numbers[i] < Smallest)
            {
                Smallest = Numbers[i];
            }

            if (Numbers[i] > Biggest)
            {
                Biggest = Numbers[i];
            }
        }
        Console.WriteLine("The smallest number is {0}", Smallest);
        Console.WriteLine("The biggest number is {0}", Biggest);
    }
}
