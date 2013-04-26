using System;
class FindCatalanNumber
{
    static void Main()
    {
        long N;
        do
        {
            Console.Write("Enter N >= 0: ");
            N = long.Parse(Console.ReadLine());    
        }
        while(N < 0);

        long DoubleNFac = 1;
        long NPlus1Fac = 1;
        long NFac = 1;

        for (int i = 1; i <= 2*N; i++)
        {
            DoubleNFac *= i;
        }

        for (int i = 1; i <= N+1; i++)
        {
            NPlus1Fac *= i;
        }

        for (int i = 1; i <= N; i++)
        {
            NFac *= i;
        }

       long result = DoubleNFac / (NPlus1Fac*NFac);
       Console.WriteLine("The {0} catalan number is: {1}",N,result);
    }
}
