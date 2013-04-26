using System;
using System.Text.RegularExpressions;
class ExtractFromHTML
{
    static void Main(string[] args)
    {
        string str = "<html> <head><title>News</title></head> <body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into  skillful .NET software engineers.</p></body></html>";

        foreach (Match v in Regex.Matches(str, @">(.*?)<"))
        {
            if (!String.IsNullOrWhiteSpace(v.Value))
            {
                Console.Write(v.Groups[1]);
            }
        }
    }
}
