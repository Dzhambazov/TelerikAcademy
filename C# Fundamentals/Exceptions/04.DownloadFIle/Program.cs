using System;
using System.Net;
class Program
{
    static void Main()
    {
        try
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"myfile.jpg");
        }
        catch (WebException)
        {
            Console.WriteLine("The URI formed by combining BaseAddress and address is invalid");
            Console.WriteLine("or filename has no name");
            Console.WriteLine("or The file does not exist.");
            Console.WriteLine("or An error occurred while downloading data.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
    }
}

