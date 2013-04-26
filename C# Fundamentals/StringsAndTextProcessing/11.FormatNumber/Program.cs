using System;
class FormatNumber
{
    static void Main(string[] args)
    {
        int number = 15;

        Console.WriteLine(String.Format("{0:F}", number));
        Console.WriteLine(String.Format("{0:X}", number));
        Console.WriteLine(number.ToString("P"));
        Console.WriteLine(String.Format("{0:E}", number));

    }
}
