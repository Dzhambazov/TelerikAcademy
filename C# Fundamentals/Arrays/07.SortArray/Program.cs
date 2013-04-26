using System;
class Program
{
    static void Main()
    {
        int[] myArray = new int[] {5,2,7,1,8,3,6,9,4};
        int[] newArray = new int[myArray.Length];
        int temp = 0;        
        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = i+1; j < myArray.Length; j++)
            {
                if (myArray[j] < myArray[i])
                {
                    temp = myArray[i];
                    myArray[i] = myArray[j];
                    myArray[j] = temp;
                }
            }
        }
        foreach (var v in myArray)
        {
            Console.WriteLine(v);
        }
    }
}
