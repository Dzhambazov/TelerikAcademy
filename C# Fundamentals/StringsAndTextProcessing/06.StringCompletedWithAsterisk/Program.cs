using System;
using System.Text;
class Program
{
    static string CompleteString(string str)
    {
        StringBuilder sb = new StringBuilder(20);
        sb.Append(str);
        sb.Append(new string('*', (20-str.Length)));
        return sb.ToString();
    }

    static void Main(string[] args)
    {
        string str = "Some text";
        Console.WriteLine(CompleteString(str)); 

        //------------------------------
        //Console.WriteLine(str.PadRight(20,'*'));   ili na 1 red s gotov metod
        //------------------------------
    }
}
