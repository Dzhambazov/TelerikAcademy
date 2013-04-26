using System;
class CheckPoints
{
    static void Main()
    {
        int x = 3;
        int y = 4;
        bool IsInside = ((x>=0 && x<=5 && y>=0 && y<=5) || (x<=0 && x>=-5 && y>=0 && y<=5) || 
                         (x<=0 && x>=-5 && y<=0 && y>=-5) || (x>=0 && x<= 5 && y<=0 && y>=-5));
        Console.WriteLine(IsInside);
    }
}
