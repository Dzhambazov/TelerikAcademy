using System;
class SolveThreeTasks
{
    static void Main()
    {
        Console.WriteLine("To Reverse numbers - type 1");
        Console.WriteLine("To calculate average of sequence - type 2");
        Console.WriteLine("To solve linear equation - type 3");
        byte myDecision = 0;
        do
        {
            Console.Write("What do you want so solve?: ");
            myDecision = byte.Parse(Console.ReadLine());
            if (myDecision > 0 && myDecision < 4)
            {
                switch (myDecision)
                {
                    case 1:
                        Console.Write("Your number: ");
                        decimal num = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Reversed number: {0}",ReverseNumber(num));
                        break;
                    case 2:
                        Console.Write("How many numbers: ");
                        int numbersCount = int.Parse(Console.ReadLine());
                        if (numbersCount < 1)
                        {
                            break;
                        }
                        int[] myArray = new int[numbersCount];
                        for (int i = 0; i < numbersCount; i++)
                        {
                            Console.Write("Number {0}: ",i+1);
                            myArray[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Average: {0}",AverageOfSequence(myArray));
                        break; 
                    case 3:
                        Console.WriteLine(LinearEquation());
                        break;
                }
            }
        }
        while(myDecision < 4 && myDecision > 0);
    }

    // Reverse Digits
    static decimal ReverseNumber(decimal num)
    {
        string str = num.ToString();
        char[] newChar = str.ToCharArray();
        Array.Reverse(newChar);
        string newstring = new String(newChar);
        decimal result = decimal.Parse(newstring);
        return result;
    }

    //Average of sequence

    static int AverageOfSequence(int[] arr)
    {
        
        int sum = 0;
        foreach (var v in arr)
        {
            sum += v;
        }
        return sum / arr.Length;
    }

    //Linear Equation

    static decimal LinearEquation()
    {
        decimal a;
        do
        {
            Console.Write("a = ");
            a = decimal.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("a cannot be 0");
            }
        }
        while(a==0);
        Console.Write("b = ");
        decimal b = decimal.Parse(Console.ReadLine());

        decimal x = 0;
        x = -(b / a);
        return x;
    }
}