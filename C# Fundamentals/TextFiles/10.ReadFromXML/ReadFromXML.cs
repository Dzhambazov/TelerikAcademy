using System;
using System.IO;
class ReadFromXML
{
    static void Main(string[] args)
    {
        using (StreamReader input = new StreamReader("file.xml"))
        {
            int i = 0;
            do
            {
                if (i == '>')
                {
                    string newText = String.Empty;

                    while ((i = input.Read()) != -1 && i != '<')
                    {
                        newText += (char)i;
                    }
                    Console.WriteLine(newText.Trim());
                }
            }
            while((i = input.Read()) != -1);
        }
    }
}
