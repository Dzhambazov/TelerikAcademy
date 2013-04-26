using System;
class Program
{
    static void Main()
    {
        int a, b, c, sum;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        sum = a + b + c;
        Console.WriteLine("The sum of {0} + {1} + {2} = {3}",a,b,c,sum);
    }
}
