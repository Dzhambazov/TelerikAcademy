using System;
class AgeInTenYears
{
    static void Main()
    {
        Console.Write("Your age: ");
        byte CurrentAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be {0} years old !",CurrentAge+10);
    }
}
