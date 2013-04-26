using System;
class RandomValues
{
    static void Main()
    {
        Random rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rand.Next(100, 201));
        }
    }
}