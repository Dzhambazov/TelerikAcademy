using System;
using System.Text;
class ConvertToUnicode
{
    static string ConvertToUniCode(string str)
    {
        StringBuilder result = new StringBuilder();
        foreach (char ch in str)
        {
            result.AppendFormat("\\u{0:X4}",(int)ch);
        }
        return result.ToString();
    }


    static void Main(string[] args)
    {
        string str = "Hello!";
        Console.WriteLine(ConvertToUniCode(str));
    }
}