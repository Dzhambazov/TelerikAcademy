using System;

class CheckThirdDigit
{
    static void Main()
    {
        int Numb = int.Parse(Console.ReadLine());
        Numb = Math.Abs(Numb) / 100;
        if (Numb % 10 == 7)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

    }
}
