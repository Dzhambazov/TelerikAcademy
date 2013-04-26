using System;

class CheckDevideNumber
{
    static void Main()
    {
        int num = 35;
        bool checkNumber = (num%5==0 && num%7==0);
        Console.WriteLine(checkNumber);
    }
}