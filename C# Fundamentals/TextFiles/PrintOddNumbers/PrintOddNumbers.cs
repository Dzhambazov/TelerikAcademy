using System;
using System.IO;
class PrintOddNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("file.txt");
        int lineNumber = 0;
        string line = reader.ReadLine();
        using (reader)
        {
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
            }
        }
    }
}
