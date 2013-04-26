using System;
using System.IO;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("file.txt"))
        {
            using (StreamWriter writer = new StreamWriter("resultFile.txt"))
            {
                int lineNunber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNunber++;
                    writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                    line = reader.ReadLine();
                }
            }
        }
    }
}
