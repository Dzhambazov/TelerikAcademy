using System;
class ReevrseDigits
{
    static void Main()
    {
        decimal num = decimal.Parse(Console.ReadLine());
        Console.WriteLine(ReverseNumber(num));

    }

    static decimal ReverseNumber(decimal num)
    {
        string str = num.ToString();
        char[] newChar = str.ToCharArray();
        Array.Reverse(newChar);
        string newstring = new String(newChar);
        decimal result = decimal.Parse(newstring);
        return result;
    }
}

