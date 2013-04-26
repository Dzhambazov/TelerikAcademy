using System;
class NumbersDevByFive
{
    static void Main()
    {
        uint Num1, Num2;
        Num1 = uint.Parse(Console.ReadLine());
        Num2 = uint.Parse(Console.ReadLine());
        int counter = 0;
        for (uint i = Num1; i <= Num2; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("Result: {0}",counter);
    }

}
