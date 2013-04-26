using System;
using System.Text;
class ToUpperCase
{
    static string UpperCase(string str)
    {
        string start = "<upcase>";
        string end = "</upcase>";
        int lowcaseIndex = 0;
        int startIndex = -1;
        int endIndex = -1;
        StringBuilder text = new StringBuilder();
        while (true)
        {
            startIndex = str.IndexOf(start, startIndex+1);
            if (startIndex == -1)
            {
                break;
            }
            text.Append(str.Substring(lowcaseIndex, startIndex - lowcaseIndex));

            endIndex = str.IndexOf(end, endIndex + 1);
            text.Append(str.Substring(startIndex+8,(endIndex-startIndex-8)).ToUpper());

            lowcaseIndex = endIndex + 9;
        }
        text.Append(str.Substring(endIndex+9, str.Length-endIndex-9));
        string texxt = text.ToString();
        return texxt;
    }

    static void Main(string[] args)
    {
        string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(UpperCase(str));
    }
}