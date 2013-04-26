using System;
class MaxElement
{
    static void Main()
    {
        int[] myArray = new int[] {1,6,44,22,88,3,1,87,32,45,98,21,33,84,42,19};
        int startingIndex = int.Parse(Console.ReadLine());
        Console.WriteLine(MaxElementt(myArray, startingIndex));
    }


    static int MaxElementt(int[] arr, int start)
    {
        int maxElement = int.MinValue;
        for (int i = start; i < arr.Length-1; i++)
        {
            if (arr[i] > maxElement)
            {
                maxElement = arr[i];
            }
        }
        return maxElement;
    }

}
