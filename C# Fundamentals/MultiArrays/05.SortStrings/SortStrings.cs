using System;
class SortStrings
{
    static String[] SortStringArr(String[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j].Length > arr[i].Length)
                {
                    String temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
            }
        }
        return arr;
    }

    static void Main()
    {
        String[] myArray = new String[] { "wtf", "hahah", "dabeda", "kakvoetova", "tralala" };
        foreach (String str in SortStringArr(myArray))
        {
            Console.WriteLine(str);
        }
    }
}