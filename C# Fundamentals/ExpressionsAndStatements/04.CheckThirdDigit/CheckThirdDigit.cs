using System;
    class CheckThirdDigit
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            N /= 100;
            if (N % 10 == 7)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
