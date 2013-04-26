using System;
class Program
{
    static void Main()
    {
        int[] Array = new[] {1,7,3,2,6,7,8,9,10,4,7,2,1,8,6,7,2};

        int? firstInSeq = null;
        int max = 0;
        int temp = 1;
        for (int i = 0; i < Array.Length-1; i++)
        {
            for (int j = i+1, k = i; j < Array.Length; j++,k++)
            {
                if (Array[j] == Array[k] + 1)
                {
                    temp++;
                    if (temp >= max)
                    {
                        firstInSeq = Array[i];
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
        for (int? i = firstInSeq; i<firstInSeq+max-1; i++)
        {
            Console.Write("{0}, ", i);
        }
        Console.Write("{0}",firstInSeq+max-1);
        Console.WriteLine("}");
    }
}