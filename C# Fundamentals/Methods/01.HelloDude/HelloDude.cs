using System;
class HelloDude
{
    static void Main()
    {
        GreetSomeone();
    }

    static void GreetSomeone()
    {
        String name = Console.ReadLine();
        Console.WriteLine("Hello, {0} Straße", name);
    }
}
