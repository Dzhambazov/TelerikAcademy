using System;
using System.IO;
class CompareFiles
{
    static void Main()
    {
        using (StreamReader reader1 = new StreamReader("file1.txt"))
        {
            using (StreamReader reader2 = new StreamReader("file2.txt"))
            {
                int lineNumber = 0;
                string firstFileLine = reader1.ReadLine();
                string secondFIleLine = reader2.ReadLine();
                int equal = 0;
                int notEqual = 0;
                while (firstFileLine != null)
                {
                    lineNumber++;
                    if (firstFileLine == secondFIleLine)
                    {
                        equal++;
                    }
                    else
                    {
                        notEqual++;
                    }
                    firstFileLine = reader1.ReadLine();
                    secondFIleLine = reader2.ReadLine();
                }
                Console.WriteLine("Equal Rows: {0}", equal);
                Console.WriteLine("Not equal Rows: {0}", notEqual);
            }

        }
    }
}
