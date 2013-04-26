using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string str = "Here is my email: wtf@abv.bg Aloso I have another email - lool@gmail.com";
        string pattern = @"(\w+)@(\w+)\.(\w+)";
        foreach (var email in Regex.Matches(str, pattern))
        {
            Console.WriteLine(email);
        }
    }
}
