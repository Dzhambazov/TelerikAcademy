using System;
class BiggestInt
{
    static void Main()
    {
        int Num1 = int.Parse(Console.ReadLine());
        int Num2 = int.Parse(Console.ReadLine());
        int Num3 = int.Parse(Console.ReadLine());
        int BiggestInt = Num1;

        if (Num2 > Num1)
        {
            BiggestInt = Num2;
            if (Num3 > Num2)
            {
                BiggestInt = Num3;
            }
        }
        else if(Num3 > Num1)
        {
            BiggestInt = Num3;
        }
        Console.WriteLine(BiggestInt);
    }
}
