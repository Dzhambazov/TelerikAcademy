using System;
using System.IO;
using System.Collections.Generic;
class SortNames
{
    static void Main()
    {
        List<string> Names = new List<string>();
        using (StreamReader reader = new StreamReader("unsortedNames.txt"))
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                Names.Add(line);
                line = reader.ReadLine();
            }
        }
        Names.Sort();
        using (StreamWriter writer = new StreamWriter("sortedNames.txt"))
        {
            for (int i = 0; i < Names.Count; i++)
            {
                writer.WriteLine(Names[i]);
            }
        }
    }
}