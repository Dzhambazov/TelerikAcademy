using System;
using System.IO;
class Program
{
    static void Main()
    {
        
        using (StreamReader reader = new StreamReader("file.txt"))
        {
            using (StreamWriter writer = new StreamWriter("result.txt"))
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    writer.Write("{0}. ", lineNumber);
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}

