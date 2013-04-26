using System;
using System.Numerics;
using System.Text;
static class Program
{
    static string ToStringNonLinqy(int[] array)
    {
        if (array.Length > 0)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                strBuilder.Append(string.Empty);
                strBuilder.Append(array[i]);
            }
            return strBuilder.ToString();
        }
        else
        {
            return string.Empty;
        }
    }
    static BigInteger BigIntSum(BigInteger n1, BigInteger n2)
    {
        return n1 + n2;
    }

    static void Main()
    {
        int[] arr1 = {1,2,3,4,5,6};
        int[] arr2 = {6,5,4,3,2,1};
        Array.Reverse(arr1);
        Array.Reverse(arr2);
        BigInteger num1 = BigInteger.Parse(ToStringNonLinqy(arr1));
        BigInteger num2 = BigInteger.Parse(ToStringNonLinqy(arr2));
        Console.WriteLine(BigIntSum(num1, num2));
    }
}