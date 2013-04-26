using System;
class BiggestOf5Int
{
    static void Main(string[] args)
    {
        int num1 = 2;
        int num2 = 1;
        int num3 = 3;
        int biggest = 0; int middle = 0; int smallest = 0;

        if (num1 > num2 && num1 > num3)
        {
            biggest = num1;
            if (num2 > num3)
            {
                middle = num2;
                smallest = num3;
            }
            else
            {
                middle = num3;
                smallest = num2;
            }
        }
        else if (num2 > num1 && num2 > num3)
        {
            biggest = num2;
            if (num1 > num3)
            {
                middle = num1;
                smallest = num3;
            }
            else
            {
                middle = num3;
                smallest = num1;
            }
        }
        else if (num3 > num1 && num3 > num2)
        {
            biggest = num3;
            if (num1 > num2)
            {
                middle = num1;
                smallest = num2;
            }
            else
            {
                middle = num2;
                smallest = num1;
            }
        }
        Console.WriteLine("{0}, {1}, {2}",biggest,middle,smallest);
    }
}