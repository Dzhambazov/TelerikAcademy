using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            uint num = uint.Parse(Console.ReadLine());
        }
        catch (OverflowException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect format. You need to type integer number !");
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }
    }
}
