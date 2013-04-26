using System;
class Program
{
    static void Main()
    {
        int[] Array = new int[] {1,1,2,2,4,5,2,2,2,2,2,2,6,7,2,3,4,4,4,4,4};
        int? resultElement = null;
        int max = 0;
        int temp = 1;
        for (int i = 0; i < Array.Length-1; i++)
        {
            for (int j = i+1; j < Array.Length; j++)
            {
                if (Array[i] == Array[j])
                {
                    temp++;
                    if (temp >= max)
                    {
                        resultElement = Array[i];
                        max = temp;
                    }
                }
                else
                {
                    break;
                }
            }
            temp = 1;
        }
        Console.Write("{");
        for (int i = 0; i < max-1; i++)
        {
            Console.Write(resultElement+", ");
        }
        Console.Write(resultElement);
        Console.WriteLine("}");
    }
}