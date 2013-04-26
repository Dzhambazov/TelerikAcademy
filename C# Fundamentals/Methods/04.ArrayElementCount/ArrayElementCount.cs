using System;
class ArrayElementCount
{
    static void Main()
    {
        long[] myArray = new long[] {1,5,6,2,7,3,6,3,2,7,8,6,5,3};
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(ElementCount(myArray, number));

    }

    static long ElementCount(long[] arr, long num)
    {
        int count = 0;
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] == arr[num])
            {
                count++;
            }
        }
        return count;
    }
}
