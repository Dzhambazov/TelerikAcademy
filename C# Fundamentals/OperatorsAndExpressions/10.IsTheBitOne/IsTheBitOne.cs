using System;
class IsTheBitOne
{
    static void Main()
    {
        int v = 42;
        byte p = 3;
        int mask = 1;
        mask = mask << p;
        int VAndMask = v & mask;
        bool isOne = (VAndMask >> p) == 1;
        Console.WriteLine("Bit {0} in number {1} is 1: {2}",p,v,isOne);
    }
}
