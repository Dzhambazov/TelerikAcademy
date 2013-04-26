using System;
class LeapYears
{
    static void Main()
    {
        Console.Write("Enter year to check is it Leap: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} yaer is LEAP !", year);
        }
        else
        {
            Console.WriteLine("{0} year is NOT leap",year);
        }
    }
}
