﻿using System;

class Program
{
    static int ReadNumber(int start, int end)
    {
            int n = int.Parse(Console.ReadLine());
            if (!(start < n && n < end))
            {
                throw new ArgumentOutOfRangeException();
            }
        return n;
    }

    static void Main()
    {
        int minNum = 1, maxNum = 100;
        for (int i = 1; i <= 10; i++)
        {
            minNum = ReadNumber(minNum, maxNum);
        }
       
    }
}