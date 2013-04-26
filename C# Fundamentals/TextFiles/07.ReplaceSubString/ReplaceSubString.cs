using System;
using System.IO;
class ReplaceSubString
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("file.txt"))
        {
            using (StreamWriter writer = new StreamWriter("tempFile.txt"))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = line.Replace("start","finish");
                    writer.WriteLine(newLine);
                }
            }
        }

        File.Delete("file.txt");

        File.Move("tempFile.txt", "file.txt");
    }
}
