using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string str = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        //string result = Regex.Replace(str, @"<a href", "[URL");
        //result = Regex.Replace(result, "\">", "\"]" );
        //result = Regex.Replace(result, @"</a>", "[/URL]");
        string result = Regex.Replace(str,@"<a href=""(.*?)"">(.*?)</a>",@"[URL=$1]$2[/URL]");
        Console.WriteLine(result);
    }
}
