using System;
class ChangeBIt
{
    static void Main()
    {
        int n, v, p;
        n = 5;
        p = 3;
        v = 1;
        n = n & (~(1 << p));
        n = n | (v << (p));
        Console.WriteLine(n);
    }
}