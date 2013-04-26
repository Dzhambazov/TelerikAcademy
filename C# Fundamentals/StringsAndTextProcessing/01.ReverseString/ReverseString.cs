using System;
class ReverseString
{
    static void Main(string[] args)
    {
        String str = "Hello, C#";
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(new string(arr));
    }
}
