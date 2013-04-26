using System;

//
//  TOZI KOD NE E MOI !   Ne uspeqh da se spravq sam i poglednah za re6eniq v internet, pone mislq che razbrah koda :)
//
class SpiralMatrix
{

    static int n;
    static int[,] m;
    static int len;
    static int col = -1;
    static int row = 0;
    static int val = 0;
    static bool finished;

    static void Main()
    {
        Console.Write("Input N: ");
        n = int.Parse(Console.ReadLine());
        len = n;
        m = new int[n, n];
        while (!finished)
        {
            finished = true;
            right();
            down();
            left();
            up();
        }

        printMatrix();
    }


    static void right()
    {
        while (col < len - 1 && m[row, col + 1] == 0)
        {
            val++;
            col++;
            m[row, col] = val;
            finished = false;
        }
    }

    static void down()
    {
        while (row < len - 1 && m[row + 1, col] == 0)
        {
            val++;
            row++;
            m[row, col] = val;
            finished = false;
        }
    }


    static void left()
    {
        while (col > 0 && m[row, col - 1] == 0)
        {
            val++;
            col--;
            m[row, col] = val;
            finished = false;
        }
    }


    static void up()
    {
        while (row > 0 && m[row - 1, col] == 0)
        {
            val++;
            row--;
            m[row, col] = val;
            finished = false;
        }
    }


    static void printMatrix()
    {
        for (col = 0; col < n; col++)
        {
            for (row = 0; row < n; row++)
            {
                Console.Write("{0,4}", m[col, row]);
            }
            Console.WriteLine();
        }
    }
}