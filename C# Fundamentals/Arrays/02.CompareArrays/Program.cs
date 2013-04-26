using System;
class Program
{
    static void Main()
    {
        Console.Write("Number elements in arrays: ");
        int N = int.Parse(Console.ReadLine());
        string[] FirstArr = new string[N];
        string[] SecondArr = new string[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("FirstArr [{0}]: ",i);
            FirstArr[i] = Console.ReadLine();
        }

        bool Equal = true;

        for (int i = 0; i < N; i++)
        {
            Console.Write("SecondArr [{0}]: ", i);
            SecondArr[i] = Console.ReadLine();

            if (SecondArr[i] != FirstArr[i])
            {
                Equal = false;
                break;
            }
        }

        if (Equal == true)
        {
            Console.WriteLine("Arrays are equal");
        }
        else
        {
            Console.WriteLine("Arrays are NOT equal");
        }

    }
}
