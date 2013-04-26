using System;
class GreaterNumber
{
    static void Main()
    {
        double Num1 = double.Parse(Console.ReadLine());
        double Num2 = double.Parse(Console.ReadLine());
        double result = Math.Max(Num1, Num2);
        Console.WriteLine("The greater number of {0} and {1} is {2}",Num1,Num2,result);
    }
}
