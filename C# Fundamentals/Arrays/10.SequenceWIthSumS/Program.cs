using System;
class Program
{
    static void Main()
    {
        int S = int.Parse(Console.ReadLine());
        int[] myArray = new int[] { 4, 3, 1, 4, 2, 5, 8 };

        int sum = 0;
        bool brPoint = false;
        int tempFirstElement = 0;
        int firstElement = 0;
        int elementsCount = 0;

        for (int i = 3; i < myArray.Length-1; i++)
        {
            for (int j = i+1; j  < myArray.Length; j ++)
            {
                sum = myArray[i];
                tempFirstElement = i;
                int counter = 1;
                for (int k = i + 1; k <= myArray.Length - j + i; k++) 
                {
                    sum += myArray[k];
                    counter++;
                }
                if (sum == S)
                {
                    firstElement = tempFirstElement;
                    elementsCount = counter;
                    brPoint = true;
                    break;
                }
            }
            if (brPoint == true)
            {
                break;
            }
        }
        if (brPoint == true)
        {
            Console.Write("< ");
            for (int i = firstElement; i < firstElement+elementsCount - 1; i++)
            {
                Console.Write("{0}, ", myArray[i]);
            }
            Console.WriteLine("{0} > sum is: {1}", myArray[firstElement+elementsCount - 1],S);
        }
        else
        {
            Console.WriteLine("There isn't a sequence with a sum of {0}",S);
        }
        
    }
}