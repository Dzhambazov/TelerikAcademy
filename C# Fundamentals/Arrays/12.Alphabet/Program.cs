using System;
class Program
{
    static void Main()
    {
        char[] Alpha = new char[26];
        for (int i = 0; i < 26; i++)
        {
            Alpha[i] = (char)(i+97);
        }
        Console.Write("Your word or sentence: ");
        string myWord = Console.ReadLine();
        myWord = myWord.ToLower();

        for (int i = 0; i < myWord.Length; i++)
        {
            for (int j = 0; j < Alpha.Length; j++)
            {
                if (myWord[i] == Alpha[j])
                {
                    Console.Write("{0}, ", j+1);         // +1 cause of position in alphabet
                    break;
                }
            }
        }
        Console.WriteLine();
    }
}