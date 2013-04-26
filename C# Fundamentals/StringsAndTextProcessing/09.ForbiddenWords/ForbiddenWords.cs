using System;
class ForbiddenWords
{
    static string RemoveForbiddenWords(string text, string forbidden)
    {
        string[] forbiddenWords = forbidden.Split(',');
        string result = text;
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            result = result.Replace(forbiddenWords[i].Trim(), new string('*',forbiddenWords[i].Length));
        }
        return result;
    }
    static void Main(string[] args)
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR";
        string forbiddenWords = "PHP, CLR, Microsoft";
        Console.WriteLine(RemoveForbiddenWords(text,forbiddenWords));
    }
}