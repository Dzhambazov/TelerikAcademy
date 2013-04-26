using System;
class GenericMethods
{
    static void Main()
    {
        Console.WriteLine(Min(1, 2, 3, 4, 5));
        Console.WriteLine(Max(1, 2, 3, 4, 5));
        Console.WriteLine(Average(1, 2, 3, 4, 5));
        Console.WriteLine(Sum(1, 2, 3, 4, 5));
        Console.WriteLine(Product(1, 2, 3, 4, 5));
    }

    // Min int
    static int Min(params int[] arr)
    {
        int min = int.MaxValue;
        foreach (var v in arr)
        {
            if (v < min)
            {
                min = v;
            }
        }
        return min;
    }

    // Max in

    static int Max(params int[] arr)
    {
        int max = int.MinValue;
        foreach (var v in arr)
        {
            if (v > max)
            {
                max = v;
            }
        }
        return max;
    }


    // Average

    static int Average(params int[] arr)
    {
        int sum = 0;
        foreach (var v in arr)
        {
            sum += v;
        }
        return sum / arr.Length;
    }

    // Sum
    static int Sum(params int[] arr)
    {
        int sum = 0;
        foreach (var v in arr)
        {
            sum += v;
        }
        return sum;
    }

    // Product
    static long Product(params int[] arr)
    {
        long product = 1;
        foreach (var v in arr)
        {
            product *= v;
        }
        return product;
    }
}