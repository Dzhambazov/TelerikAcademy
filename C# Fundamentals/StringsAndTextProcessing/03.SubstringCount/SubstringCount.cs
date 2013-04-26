using System;
class SubstringCount
{
    static int SubstringCounter(string str)
    {
        int index = -1;
        int counter = 0;
        while(true)
        {
            index = str.IndexOf("in", index + 1);
            counter++;
            if (index == -1)
	        {
                break;
	        }
        }
        return counter;
    }

    static void Main(string[] args)
    {
        string str  = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine(SubstringCounter(str));   
    }
}

