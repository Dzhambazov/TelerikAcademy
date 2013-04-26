using System;
class FindBit
{
    static void Main()
    {
        int n =44;
        byte p = 3;
        int mask = 1;
        mask = mask << p;
        int nAndMask = n & mask;
        bool IsOne = (nAndMask >> p) == 1;
        Console.WriteLine("The bit on position {0} is  1:  {1}",p,IsOne);
    }
}
