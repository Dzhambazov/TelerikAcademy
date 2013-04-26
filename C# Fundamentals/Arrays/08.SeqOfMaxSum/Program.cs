using System;
class Program
{
    static void Main()
    {
        int[] myArray = new int[] {2, 3, -6, -1, 2, -1, 6, 4, -8, 8};

        int maxSum = 0;
        int tempSum = 0;
        int tempFirstElement;
        int firstElement = 0;
        int elementsCount = 0;
        int counter = 0;


        for (int i = 0; i < myArray.Length-1; i++)
        {
            for (int j = myArray.Length-i-1; j > 0; j--)
            {
                tempSum = myArray[i];
                tempFirstElement = i;
                counter = 1;
                for (int k = j+i; k > i; k--)
                {
                    tempSum += myArray[k];
                    counter++; 
                }
                if (tempSum >= maxSum)
                {
                    maxSum = tempSum;
                    firstElement = tempFirstElement;
                    elementsCount = counter;
                }
            }
        }
        Console.Write("The sequence <");
        for (int i = firstElement; i < firstElement+elementsCount; i++)
        {
            Console.Write("{0}, ",myArray[i]);
        }
        Console.WriteLine(">  ===> has sum {0}", maxSum);
    }
}