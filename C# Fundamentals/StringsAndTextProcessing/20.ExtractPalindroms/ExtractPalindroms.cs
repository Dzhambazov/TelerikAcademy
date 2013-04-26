using System;
using System.Text.RegularExpressions;
class ExtractPalindroms
{
    static void Main()
    {
        string str = "here isi my exe of elle leel";
        foreach(Match v in Regex.Matches(str,@"\w+"))
        {
            string word = v.ToString();
            bool isTrue = false;
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] == word[word.Length - 1 - i])
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    break;
                }
            }
            if (isTrue)
            {
                Console.WriteLine(word);
            }
        }
    }
}
