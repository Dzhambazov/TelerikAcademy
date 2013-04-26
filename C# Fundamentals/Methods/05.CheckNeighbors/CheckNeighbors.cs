using System;
class CheckNeighbors
{
    static void Main()
    {
        int[] myArray = new int[] {1,2,6,2,6,7,2,4,8,8,3,5,7,5};
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine(IsBiggerThanNeighbors(myArray,position));

    }
    static bool IsBiggerThanNeighbors(int[] arr, int pos)
    {
        if (pos > 0 && pos < arr.Length - 1)
        {
            if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
