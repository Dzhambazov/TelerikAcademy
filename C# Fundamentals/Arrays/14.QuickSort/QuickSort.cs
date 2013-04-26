using System;
class QuickSort
{
    public static void QuickSortt(string[] elements, int firstElement, int lastElement)
    {
        int i = firstElement, j = lastElement;
        string mid = elements[(firstElement + lastElement) / 2];
        while (i <= j)
        {
            while (elements[i].CompareTo(mid) < 0)
            {
                i++;
            }
            while (elements[j].CompareTo(mid) > 0)
            {
                j--;
            }
            if (i <= j)
            {
                string tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;
                i++;
                j--;
            }
        }
        if (firstElement < j)
        {
            QuickSortt(elements, firstElement, j);
        }
        if (i < lastElement)
        {
            QuickSortt(elements, i, lastElement);
        }
    }


    static void Main(string[] args)
    {
        string[] myArray = { "t", "n", "d", "y", "z", "j", "l"};
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + ", ");
        }
        Console.WriteLine();
        QuickSortt(myArray, 0, myArray.Length - 1);
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + ", ");
        }
        Console.WriteLine();
    }
}