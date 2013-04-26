using System;
class BinSearch
{
    static void Main()
    {
        Console.Write("Array lenght: ");
        int N = int.Parse(Console.ReadLine());
        int[] myArr = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Array[{0}] = ",i);
            myArr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("K: ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(myArr);
        int index = Array.BinarySearch(myArr, k);

        while (index < 0)
        {
            if (k < myArr[0])
            {
                break;
            }
            k--;
            index = Array.BinarySearch(myArr, k);
        }
        if (index < 0)
        {
            Console.WriteLine("The element was NOT found");
        }
        else
        {
            Console.WriteLine("Result: {0}",myArr[index]);
        }
    }
}
