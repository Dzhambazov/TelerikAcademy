using System;
using System.Collections.Generic;
class ExtractSentences
{
    static List<string> getSentence(string text, string searchedWord)
    {
        string wordCase1 = " " + searchedWord + " ";
        string wordCase2 = " " + searchedWord + ".";
        string wordCase3 = " " + searchedWord + ",";
        string[] Sentences = text.Split('.');
        List<string> result = new List<string>();
        for (int i = 0; i < Sentences.Length; i++)
        {
            if (Sentences[i].IndexOf(wordCase1) == -1 && Sentences[i].IndexOf(wordCase2) == -1 && Sentences[i].IndexOf(wordCase3) == -1)
            {
                continue;
            }
            result.Add(Sentences[i].Trim() + '.');
        }
        return result;
    }

    static void Main(string[] args)
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string searchedWord = "in";
        foreach (string str in getSentence(text, searchedWord))
        {
            Console.WriteLine(str);
        }
    }
}