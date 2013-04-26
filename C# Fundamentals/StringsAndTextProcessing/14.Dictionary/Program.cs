using System;
using System.Text.RegularExpressions;
class Dictionary
{
    static void Main(string[] args)
    {
        string[] dictionary = { 
           ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical organization of classes"
        };
        string  searchedWord = "CLR";
        foreach (var str in dictionary)
        {
            var parts = Regex.Match(str, @"(.*) - (.*)").Groups;
            if (parts[1].Value == searchedWord)
            {
                Console.WriteLine(parts[2].Value);
            }
        }
    }
}
