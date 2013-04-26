using System;
class ShowSign
{
    static void Main()
    {
        int Num1 = int.Parse(Console.ReadLine());
        int Num2 = int.Parse(Console.ReadLine());
        int Num3 = int.Parse(Console.ReadLine());
        int Result = 0;

        if (Num1 < 0)
        {
            Result++;
        }
        if (Num2 < 0)
        {
            Result++;
        }
        if (Num3 < 0)
        {
            Result++;
        }
        if (Num1*Num2*Num3 != 0)
        {
            if (Result % 2 == 0)
            {
                Console.WriteLine("The product is a positive number");
            }
            else
            {
                Console.WriteLine("The product is a negative number");
            }
        }
        else
        {
            Console.WriteLine("The product is zero");
        }

    }
}
