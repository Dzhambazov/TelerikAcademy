using System;
class Subsets
{
    static void Main()
    {
        int[] MainArray = new int[5];
        for (int i = 0; i < 5; i++)
        {
            MainArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < MainArray.Length; i++)
        {
            if (MainArray[i] == 0)
            {
                Console.WriteLine("<{0}>", 0);
                break;
            }
        }
        for (int i = 0; i < MainArray.Length - 2; i++)
        {
            for (int j = i + 1; j < MainArray.Length; j++)
            {
                if (MainArray[i] + MainArray[j] == 0)
                {
                    Console.WriteLine("<{0},{1}>", MainArray[i], MainArray[j]);
                }
                for (int k = j + 1; k < MainArray.Length; k++)
                {
                    if (MainArray[i] + MainArray[j] + MainArray[k] == 0)
                    {
                        Console.WriteLine("<{0},{1},{2}>", MainArray[i], MainArray[j], MainArray[k]);
                    }
                    for (int l = k + 1; l < MainArray.Length; l++)
                    {
                        if (MainArray[i] + MainArray[j] + MainArray[k] + MainArray[l] == 0)
                        {
                            Console.WriteLine("<{0},{1},{2},{3}>", MainArray[i], MainArray[j], MainArray[k], MainArray[l]);
                        }
                    }
                }
            }
        }
    }
}