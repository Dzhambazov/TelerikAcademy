using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class ReverseWordsInStr
{
    static void Main(string[] args)
    {
        string text = "C#, is not C++, not PHP and not Delphi!";
        string pattern = @"\s+|,\s*|\.\s*|!\s*|\?\s*";
        string[] allWords = Regex.Split(text,pattern);
        Stack<string> words = new Stack<string>();
        foreach (var word in allWords)
        {
            if (!String.IsNullOrEmpty(word))
            {
                words.Push(word);
            }
        }

        foreach (var separator in Regex.Matches(text, pattern))
        {
            Console.Write(words.Pop() + separator);
        }
        Console.WriteLine();
    }
}
