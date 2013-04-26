using System;

class BiggestOf5Int
{
    static void Main(string[] args)
    {
        int[] AllNums = new int[5];
        for (int i = 0; i < AllNums.Length; i++)
        {
            Console.Write("Number {0}: ",i+1);
            AllNums[i] = int.Parse(Console.ReadLine());
        }
        int BiggestInt = AllNums[0];
        for (int i = 1; i < AllNums.Length; i++)
        {
            if (AllNums[i] > BiggestInt)
            {
                BiggestInt = AllNums[i];
            }
        }
        Console.WriteLine("The biggest integer is: {0}",BiggestInt);
    }
}