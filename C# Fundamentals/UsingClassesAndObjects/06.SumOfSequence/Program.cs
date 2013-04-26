using System;
class Program
{
    static int SumOfSequence(string str)
    {
        int multy = 1;
        int sum = 0;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (str[i] < 48 || str[i] > 57)
            {
                multy = 1;
                continue;
            }
            sum += (Convert.ToInt32(str[i]) - '0') * multy;
            multy *= 10;
        }
        return sum;
    }

    static void Main()
    {
        string str = "20 12 THIS 4 1119 8 SYMBOLS 144 DO23 NOTHING"; // symbols other than numbers do not affect
        Console.WriteLine(SumOfSequence(str));
    }
}