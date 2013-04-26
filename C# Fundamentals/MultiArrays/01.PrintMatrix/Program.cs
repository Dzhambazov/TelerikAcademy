using System;
class Program
{
    //Matrix1
    static void Matrix1(int size)
    {
        int[,] Matrix = new int[size, size];
        int num = 1;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Matrix[j, i] = num;
                num++;
            }
        }
        PrintMatrix(Matrix);
    }


    //Matrix2

    static void Matrix2(int size)
    {
        int[,] Matrix = new int[size, size];
        int num = 1;
        for (int col = 0; col < size; col++)
        {
            if (col % 2 == 0)
            {
                for (int TopToBot = 0; TopToBot < size; TopToBot++)
                {
                    Matrix[TopToBot, col] = num;
                    num++;    // col*4+1
                }
            }
            else
            {
                for (int BotToTop = size-1; BotToTop >= 0; BotToTop--)
                {
                    Matrix[BotToTop, col] = num;
                    num++;
                }
            }
        }
        PrintMatrix(Matrix);
    }

    //Matrix3

    static void Matrix3(int size)
    {
        int[,] Matrix = new int[size, size];
        int num = 1;
        for (int i = size-1; i >= 0; i--)
        {
            int col = 0;
            for (int j = size-i,m=0; j > 0; j--,m++)
            {
                Matrix[i+m,col] = num;
                num++;
                col++;
            }
        }

        for (int i = 1; i < size; i++)
        {
            int row = 0;
            for (int j = size-i,col=i; j > 0; j--,col++)
            {
                Matrix[row, col] = num;
                row++;
                num++;
            }   
        }

        PrintMatrix(Matrix);
    }




    //PrintMatrix
    static void PrintMatrix(int[,] arr)
    {
        int c = 0;
        foreach (var v in arr)
        {

            Console.Write("{0,4}", v);
            if (++c % arr.GetLength(0) == 0)
            {
                Console.WriteLine();
            }

        }
    }


    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Matrix1(n);
        Console.WriteLine();
        Matrix2(n);
        Console.WriteLine();
        Matrix3(n);
    }
}