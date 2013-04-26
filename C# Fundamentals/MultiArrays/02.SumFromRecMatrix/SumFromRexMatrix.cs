using System;
class SumFromRexMatrix
{
    static decimal SubMatrix3x3BestSum(decimal[,] Matrix)
    {
        decimal bestSum = decimal.MinValue;
        if (Matrix.GetLength(0) >= 3 && Matrix.GetLength(1) >= 3)
        {
            for (int startRow = 0; startRow <= Matrix.GetLength(0) - 3; startRow++) 
            {
                decimal tempSum = decimal.MinValue;
                for (int startCol = 0; startCol <= Matrix.GetLength(1) - 3; startCol++)
                {
                    tempSum = Matrix[startRow, startCol] + Matrix[startRow, startCol + 1] + Matrix[startRow, startCol + 2] +
                              Matrix[startRow + 1, startCol] + Matrix[startRow + 1, startCol + 1] + Matrix[startRow + 1, startCol + 2] +
                              Matrix[startRow + 2, startCol] + Matrix[startRow + 2, startCol + 1] + Matrix[startRow + 2, startCol + 2];
                    if (tempSum > bestSum)
                    {
                        bestSum = tempSum;
                    }
                }
            }
            return bestSum;
        }
        return 0;
    }

    static void PrintMatrix(decimal[,] arr)
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
        Console.Write("Matrix rows: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Matrix cols: ");
        int M = int.Parse(Console.ReadLine());
        decimal[,] Matrix = new decimal[N, M];

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write("Matrix[{0}][{1}] = ",row,col);
                Matrix[row,col] = decimal.Parse(Console.ReadLine());
            }
        }
        PrintMatrix(Matrix);
        Console.WriteLine("Best sum of submatrix 3x3 is: {0}",SubMatrix3x3BestSum(Matrix));
    }
}