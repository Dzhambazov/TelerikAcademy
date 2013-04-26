using System;
class PrintAllCards
{
    static void Main()
    {
        string[] cards = new string[13] { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] colors = new string[4] { "clubs", "diamonds", "hearts", "spades" };
        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine(colors[i]);
            Console.WriteLine("------------");
            for (int j = 0; j < cards.Length; j++)
            {
                Console.WriteLine("{0} of {1}", cards[j], colors[i]);
            }
        }
    }
}