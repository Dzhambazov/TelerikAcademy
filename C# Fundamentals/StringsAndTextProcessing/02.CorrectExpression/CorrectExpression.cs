using System;
class CorrectExpression
{
    static bool IsCorrectExpression(string expression)
    {
        int count = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                count++;
            }
            if(expression[i] == ')')
            {
                count--;
            }
        }
        return count == 0;
    }

    static void Main(string[] args)
    {
        string expression = "((a+b)/5-d)";
        Console.WriteLine(IsCorrectExpression(expression));

    }
}