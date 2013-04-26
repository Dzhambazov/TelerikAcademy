using System;
class BInarySearch
{
    static void Main()
    {
        int[] myArray = new int[100];
        for (int i = 1; i < myArray.Length; i++)
        {
            myArray[i] = i + 1;
        }
        Console.Write("The number you'r searching: ");
        int searchedNumber = int.Parse(Console.ReadLine());
        int firstIndex = 0;
        int lastIndex = myArray.Length - 1;

        while (firstIndex <= lastIndex)
        {
            int middleIndex = (firstIndex + lastIndex) / 2;
            if (myArray[middleIndex] == searchedNumber)
            {
                Console.WriteLine("The index you'r searching is: {0}", middleIndex);
                break;
            }

            if (searchedNumber > myArray[middleIndex])
            {
                firstIndex = middleIndex + 1;
            }

            if (searchedNumber < myArray[middleIndex])
            {
                lastIndex = middleIndex - 1;
            }
        }
    }
}
