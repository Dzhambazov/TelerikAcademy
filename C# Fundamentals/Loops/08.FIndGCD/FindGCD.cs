using System;
class FindGCD
{
    static void Main()
    {
        Console.Write("Enter Num1: ");
        int Num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Num2: ");
        int Num2 = int.Parse(Console.ReadLine());

        int SmallerNum = Math.Min(Num1,Num2);
        int BiggerNum = Math.Max(Num1,Num2);

        int result = 0;
        for (int i = SmallerNum; i >= 1; i--)
        {
            if (SmallerNum % i == 0)
            {
                if (BiggerNum % i == 0)
                {
                    result = i;
                    break;
                }
            }
        }
        Console.WriteLine(result);
    }
}