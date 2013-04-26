using System;
class SequenceOfString
{
    static void Main()
    {
        String[,] Matrix = new String[,]{
            {"da","ga","wt","ja"},
            {"ha","ha","ja","da"}, // [1,3]
            {"da","sa","da","ga"}, // [2,2]    result from this matrix      da da da     3  times ...
            {"ja","da","hd","ha"} //  [3,1]
        };

        String resultString = "";
        int resultCount = 0;
        for (int row = 0; row < Matrix.GetLength(0); row++)
        {
            for (int col = 0; col < Matrix.GetLength(1); col++)
            {
                int nextRow = 1;
                int nextCol = 1;
                if (row+1 < Matrix.GetLength(0))
                {
                    int tempCount = 1;
                    while (Matrix[row, col] == Matrix[row + nextRow, col])
                    {
                        tempCount++;
                        nextRow++;
                        if (tempCount > resultCount)
                        {
                            resultCount = tempCount;
                            resultString = Matrix[row, col];
                        }
                        if (row + nextRow >= Matrix.GetLength(0))
                        {
                            break;
                        }
                    }
                }

                if (col+1 < Matrix.GetLength(1))
                {
                    nextRow = 1;
                    nextCol = 1;
                    int tempCount = 1;
                    while(Matrix[row,col] == Matrix[row,col+nextCol])
                    {
                        tempCount++;
                        nextCol++;
                        if (tempCount > resultCount)
                        {
                            resultCount = tempCount;
                            resultString = Matrix[row, col];
                        }
                        if (col+nextCol >= Matrix.GetLength(1))
                        {
                            break;
                        }
                    }
                }
                if (row + 1 < Matrix.GetLength(0)) // DIAGONALS
                {
                    if (col + 1 < Matrix.GetLength(1)) // diagonal right to left
                    {
                        nextRow = 1;
                        nextCol = 1;
                        int tempCount = 1;
                        while (Matrix[row, col] == Matrix[row + nextRow, col + nextCol])
                        {
                            tempCount++;
                            nextCol++;
                            nextRow++;
                            if (tempCount > resultCount)
                            {
                                resultCount = tempCount;
                                resultString = Matrix[row, col];
                            }
                            if (row + nextRow >= Matrix.GetLength(0) || col + nextCol >= Matrix.GetLength(1))
                            {
                                break;
                            }
                        }
                    }
                    if (col + 1 == Matrix.GetLength(1)) // diagonal right to left
                    {
                        nextRow = 1;
                        nextCol = 1;
                        int tempCount = 1;
                        while (Matrix[row, col] == Matrix[row + nextRow, col - nextCol])
                        {
                            tempCount++;
                            nextCol++;
                            nextRow++;
                            if (tempCount > resultCount)
                            {
                                resultCount = tempCount;
                                resultString = Matrix[row, col];
                            }
                            if (row + nextRow >= Matrix.GetLength(0) || col - nextCol < 0)
                            {
                                break;
                            }
                        }

                    }
                }
	        }
        }
        Console.WriteLine("{0} - {1} times",resultString,resultCount);
    }
}