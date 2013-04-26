using System;
using System.IO;
using System.Text.RegularExpressions;
class RemoveWords
{
    static void Main(string[] args)
    {
        try
        {
            string regExpression = @"\b(" + String.Join("|", File.ReadAllLines("wordsList.txt")) + @")\b";

            using (StreamReader reader = new StreamReader("file.txt"))
            {
                using (StreamWriter writer = new StreamWriter("resultFile.txt"))
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        writer.WriteLine(Regex.Replace(line, regExpression, String.Empty));
                        line = reader.ReadLine();
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
