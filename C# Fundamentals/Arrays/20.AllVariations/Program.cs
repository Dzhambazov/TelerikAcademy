using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("K: ");
        int K = int.Parse(Console.ReadLine());
 
        List<int> elements = new List<int>();
        for (int i = 0; i < K; i++) 
        {
            elements.Add(1); 
        }
        for (int i = 0; i < K; i++)
        {
            while (true)
            {
                int index = K - 1;
                int tempValue = 0;
                foreach (var v in elements)
                {
                    Console.Write("{0} ",v);
                }
                Console.WriteLine();
                while (index > -1 && elements[index] == N)
                {
                    tempValue = elements[index];
                    elements[index] = 1;
                    index--;
                }
                if (index == -1 && tempValue == N)
                {
                    break;
                }
                elements[index]++;
            }
        }
    }
}
