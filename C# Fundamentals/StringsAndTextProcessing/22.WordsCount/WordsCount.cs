using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class WordsCount
{
    static void Main()
    {
        string str = "here we go here again and again and again, go go go";
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        foreach (Match v in Regex.Matches(str, @"\w+"))
        {
            string word = v.ToString();
            if (!dictionary.ContainsKey(word))
            {
                dictionary.Add(word, 1);
            }
            else
            {
                dictionary[word]++;
            }
        }

        foreach (KeyValuePair<string, int> v in dictionary)
        {
            Console.WriteLine("{0} ----> {1}", v.Key, v.Value);
        }
    }
}