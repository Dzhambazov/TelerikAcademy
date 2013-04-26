using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader reader1 = new StreamReader("file1.txt");
        string file1Text = reader1.ReadToEnd();
        StreamReader reader2 = new StreamReader("file2.txt");
        string file2Text = reader2.ReadToEnd();
        reader1.Close(); reader2.Close();
        StreamWriter writer = new StreamWriter("result.txt");
        using (writer)
        {
            writer.Write(file1Text+file2Text);
        }
        writer.Close();
    }
}
