using System;
using System.IO;
using System.Collections.Generic;
class DeleteOddLines
{
    static void Main(string[] args)
    {
        string firstFileName = "file.txt";
        List<String> textFromFile = new List<String>();

        using (StreamReader reader = new StreamReader(firstFileName))
        {
            string line = reader.ReadLine();
            int lineNumber = 0;

            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 == 0)
                {
                    textFromFile.Add(line);
                }
                line = reader.ReadLine();
            }
        }

        using (StreamWriter writer = new StreamWriter(firstFileName))
        {
            for (int i = 0; i < textFromFile.Count; i++)
            {
                writer.WriteLine(textFromFile[i]);
            }
        }
    }
}