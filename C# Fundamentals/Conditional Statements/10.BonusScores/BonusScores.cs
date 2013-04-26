using System;
class BonusScores
{
    static void Main(string[] args)
    {
        string number =  Console.ReadLine();
        int d;
        bool N = int.TryParse(number, out d);
        if (!N)
        {
            Console.WriteLine("Error !");
        }
        else
        {
            int num = Convert.ToInt32(number);
            int result = 0;
            switch (num)
            {
                case 1:
                case 2:
                case 3: result = num * 10;
                    break;
                case 4:
                case 5:
                case 6: result = num * 100;
                    break;
                case 7:
                case 8:
                case 9: result = num * 1000;
                    break;
            }
            Console.WriteLine("The result is: {0}", result);
        }
    }
}
