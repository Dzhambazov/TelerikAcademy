using System;
class Program
{
    static void Main()
    {
        int[] myArray = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 4 };
        Array.Sort(myArray);
        int tempNumber = myArray[0];
        int number = 0;
        int tempCounter = 0;
        int counter = 0;
        for (int i = 1; i < myArray.Length; i++)
        {
            if (tempNumber == myArray[i])
            {
                tempCounter++;
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    number = tempNumber;
                }
            }
            else
            {
                if (i<myArray.Length-1)
                {
                     tempNumber = myArray[i];
                }
                tempCounter = 1;
            }
        }
        Console.WriteLine(number);
        Console.WriteLine(counter);
    }
}