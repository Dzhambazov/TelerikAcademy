using System;

class Program
{
    static void Main()
    {
        int[] Array = new int[20];
        for (int i = 0; i < Array.Length; i++)
        {
            Array[i] = i * 5;
        }

        foreach(var v in Array)
        {
            Console.WriteLine(v);
        }
    }
}
