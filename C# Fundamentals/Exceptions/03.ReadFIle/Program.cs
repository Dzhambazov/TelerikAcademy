using System;
using System.IO;
class Program
{
    static void Main()
    {
        try
        {
            string path = "file.txt";
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("EXCEPTION: there is no path to the file");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("EXCEPTION: path is a zero-length string, contains only white space, or contains one or more invalid characters");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("EXCEPTION: paths must be less than 248 characters, and file names must be less than 260 characters.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("EXCEPTION: DirectoryNotFoundException");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("path specified a file that is read-only");
            Console.WriteLine("or this operation is not supported on the current platform.");
            Console.WriteLine("or path specified a directory.");
            Console.WriteLine("or the caller does not have the required permission.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("EXCEPTION: The file specified in path was not found.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("EXCEPTION: path is in an invalid format.");
        }
    }
}