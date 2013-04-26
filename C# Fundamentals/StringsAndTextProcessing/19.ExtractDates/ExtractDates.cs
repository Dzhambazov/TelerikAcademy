using System;
using System.Text.RegularExpressions;
using System.Globalization;
class ExtractDates
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");


        string str = "Today is 11.04.2015 yaer. Tomorrow will be 12.04.2015 ";
        foreach (Match date in Regex.Matches(str,@"(\d\d).(\d\d).(\d\d\d\d)"))
        {
            DateTime newDate = DateTime.ParseExact(date.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(newDate);
        }
    }
}
