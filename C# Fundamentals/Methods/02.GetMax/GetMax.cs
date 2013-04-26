using System;
class GetMax
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine(getMaxx(num1,getMaxx(num2,num3)));
    }

 
    static int getMaxx(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

}
