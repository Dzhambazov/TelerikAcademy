using System;
using System.IO;
using System.Text.RegularExpressions;
class ReplaceWords
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("file.txt"))
        {
            using (StreamWriter writer = new StreamWriter("tempFile.txt"))
            {
                string pattern =  @"\b(start)\b";
                Regex regExpression = new Regex(pattern);

                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = regExpression.Replace(line, "finish");
                    writer.WriteLine(newLine);
                }
            }
        }

        File.Delete("file.txt");

        File.Move("tempFile.txt", "file.txt");
    }
}
