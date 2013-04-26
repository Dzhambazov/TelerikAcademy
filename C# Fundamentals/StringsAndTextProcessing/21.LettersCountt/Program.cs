using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string str = "Yyeaah right thhisss is myy strrrring";
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        foreach (Match v in Regex.Matches(str, @"\w"))
        {
            string letter = v.ToString().ToLower();
            if (!dictionary.ContainsKey(letter))
            {
                dictionary.Add(letter, 1);
            }
            else
            {
                dictionary[letter]++;
            }
        }
        foreach (KeyValuePair<string, int> v in dictionary)
        {
            Console.WriteLine("{0} -----> {1}",v.Key,v.Value);
        }
    }
}
