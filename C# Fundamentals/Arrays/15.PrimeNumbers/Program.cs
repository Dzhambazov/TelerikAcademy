using System;
class Program
{
    static void Main()
    {
        int number = 10000000;
        bool[] PrimeNumbers = new bool[number];
        PrimeNumbers[2] = true;
        for (int i = 3; i <= number; i += 2)
        {
            PrimeNumbers[i] = true;
        }

        for (int i = 3; i < (int)Math.Sqrt(number); i++)
        {
            if (PrimeNumbers[i] == false)
            {
                continue;
            }
            for (int j = i*2; j < number; j += i)
            {
                PrimeNumbers[j] = false;
            }
        }
        int counter = 0;
        for (int i = 2; i < number; i++)
        {
            if (PrimeNumbers[i] == true)
            {
                Console.Write("{0} ",i);
                counter++;
            }
        }
        Console.WriteLine("Count: {0}",counter);
    }
}