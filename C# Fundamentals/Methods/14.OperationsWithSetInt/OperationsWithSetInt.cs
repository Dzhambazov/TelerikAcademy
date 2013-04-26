using System;
using System.Collections.Generic;
class OperationsWithSetInt
{
    static void Main()
    {
        Console.WriteLine(Min(124.222222, 2, 323.22, 5555555555, 5.3));
        Console.WriteLine(Max(124.222222, 2, 32.22, 5555555555, 5.3));
        Console.WriteLine(Average(124.222222, 2, 323.22, 5555555555, 5.3));
        Console.WriteLine(Sum(124.222222, 2, 323.22, 5555555555, 5.3));
        Console.WriteLine(Product(124.222222, 2, 323.22, 5555555555, 5.3));
    }

    // Min
    static T Min<T>(params T[] arr)
    {
        dynamic min = int.MaxValue;
        foreach (var v in arr)
        {
            if (v < min)
            {
                min = v;
            }
        }
        return min;
    }

    // Max

    static T Max<T>(params T[] arr)
    {
        dynamic max = int.MinValue;
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

    static T Average<T>(params T[] arr)
    {
        dynamic sum = 0;
        foreach (var v in arr)
        {
            sum += v;
        }
        return sum / arr.Length;
    }

    // Sum
    static T Sum<T>(params T[] arr)
    {
        dynamic sum = 0;
        foreach (var v in arr)
        {
            sum += v;
        }
        return sum;
    }

    // Product
    static T Product<T>(params T[] arr)
    {
        dynamic product = 1;
        foreach (var v in arr)
        {
            product *= v;
        }
        return product;
    }
}