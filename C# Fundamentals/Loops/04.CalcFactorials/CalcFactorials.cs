using System;
class CalcFactorials
{
    static void Main()
    {
        int N, K;
        Console.Write("N: ");
        N = int.Parse(Console.ReadLine());
        Console.Write("K: ");
        K = int.Parse(Console.ReadLine());
        if (N > 1 && K > N)
        {
            int result = 1;
            for (int i = N+1; i <= K; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Wrong input data !");
        }
       
    }
}
