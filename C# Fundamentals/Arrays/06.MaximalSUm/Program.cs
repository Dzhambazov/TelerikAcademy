using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter array's length: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of elements: ");
        int K = int.Parse(Console.ReadLine());

        int[] myArray = new int[N];
        int[] Result = new int[K];

        for (int i = 0; i < N; i++)
        {
            Console.Write("Array[{0}]: ",i);
            myArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            Array.Sort(Result);
            if (myArray[i] > Result[0])
            {
                Result[0] = myArray[i];
            }
        }
        Array.Sort(Result);
        int Sum = 0;
        Console.Write("The sum of { ");
        foreach (var v in Result)
        {
            Sum += v;
            Console.Write("{0} ",v);
        }
        Console.Write("} = ");
        Console.WriteLine("{0}",Sum);
    }
 }