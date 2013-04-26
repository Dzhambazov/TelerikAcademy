using System;
class WahtIsTheBit
{
    static void Main()
    {
        int i = 5;
        byte b = 2;
        int mask = 1;
        mask = mask << b;
        int IAndMask = i & mask;
        Console.WriteLine("The bit on position {0} is {1}",b, (IAndMask >> b));
    }
}
