using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string str = "da ne  povqrvash kakvo shte stane";
        List<string> words = new List<string>();
        foreach(Match v in Regex.Matches(str,@"\w+"))
        {
            words.Add(v.ToString());
        }
        words.Sort();
        foreach(string v in words)
        {
            Console.Write(v+' ');
        }
        Console.WriteLine();
    }
}
