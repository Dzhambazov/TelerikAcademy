using System;
class ExchangeValue
{
    static void Main()
    {
        int Num1 = int.Parse(Console.ReadLine());
        int Num2 = int.Parse(Console.ReadLine());
        int temp = 0;

        if (Num1 > Num2)
        {
            temp = Num1;
            Num1 = Num2;
            Num2 = temp;
        }

    }
}