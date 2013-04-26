using System;
using System.IO;
class SumInMatrix
{
    static long SubMatrix2x2BestSum(int[,] Matrix)
    {
        long bestSum = long.MinValue;
        if (Matrix.GetLength(0) >= 2 && Matrix.GetLength(1) >= 2)
        {
            for (int startRow = 0; startRow <= Matrix.GetLength(0) - 2; startRow++)
            {
                long tempSum = long.MinValue;
                for (int startCol = 0; startCol <= Matrix.GetLength(1) - 2; startCol++)
                {
                    tempSum = Matrix[startRow, startCol] + Matrix[startRow, startCol + 1] +
                              Matrix[startRow + 1, startCol] + Matrix[startRow + 1, startCol + 1];
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

    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("file.txt"))
        {
            string M = reader.ReadLine();
            int N = Convert.ToInt32(M);
            int[,] Matrix = new int[N, N];

            for (int row = 0; row < N; row++)
            {
                string line = reader.ReadLine();
                for (int col = 0; col < N*2-1; col++)
                {
                    if (line[col] == ' ')
                    {
                        continue;
                    }
                    Matrix[row, col/2] = line[col]-48;
                }
            }
            Console.WriteLine(SubMatrix2x2BestSum(Matrix));

        }
    }
}