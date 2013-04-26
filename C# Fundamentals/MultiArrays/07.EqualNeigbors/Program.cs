using System;
class Program
{
    // ----------------------------------
    //    U N F I N I S H E D !!!!!!!!
    // ----------------------------------

   static int[,] myMatrix = {  
                         {1,3,2,2,2,4},
                         {3,3,3,2,4,4},
                         {4,3,1,2,3,3},
                         {4,3,1,3,3,1},
                         {4,3,3,3,1,1},
                      };

   static bool[,] checkedElements = new bool[myMatrix.GetLength(0), myMatrix.GetLength(1)];

   static int checkCurrRow(int[,]arr, int row,int col)
   {
       int count = 1;
       for (int i = col + 1; i < arr.GetLength(1); i++)
       {
           if (arr[row, col] != arr[row, i])
           {
               break;
           }
           count++;
           checkedElements[row, i] = true;
       }
       return count;
   }

   static void checkNextRow()
   {

   }

   static int checkNeighbors(int[,] arr,int row, int col)
   {
       int count = 0;
       if (checkedElements[row,col] == false)
       {
           count = +checkCurrRow(arr,row,col);
       }
       return count;
   }
   

    static void Main()
    {
        for (int row = 0; row < myMatrix.GetLength(0)-1; row++)
        {
            for (int col = 0; col < myMatrix.GetLength(1)-1; col++)
            {
                if (checkedElements[row,col] == false)
                {
                    Console.WriteLine(checkCurrRow(myMatrix, row, col));
                    
                }
            }
        }

       
    }
}
