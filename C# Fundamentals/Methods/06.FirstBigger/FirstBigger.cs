using System;
class FirstBigger
{
    static void Main()
    {
        int[] myArray = new int[] { 1, 2, 6, 2, 6, 7, 2, 4, 8, 8, 3, 5, 7, 5 };
        Console.WriteLine(IsBiggerThanNeighbors(myArray));
    }


    static int IsBiggerThanNeighbors(int[] arr)
    {
        for (int i = 1; i < arr.Length-2; i++)
        {
            if (arr[i] > arr[i-1] && arr[i] > arr[i+1])
            {
                return i;
            }
        }
        return -1;
    }
}
