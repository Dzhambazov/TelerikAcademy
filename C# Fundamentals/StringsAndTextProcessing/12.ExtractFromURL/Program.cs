using System;
using System.Text;
using System.Text.RegularExpressions;
class ExtractFromURL
{
    static void Main(string[] args)
    {
        string url = "http://www.devbg.org/forum/index.php";
        //int protocolIndex = url.IndexOf("://");
        //string protocol = url.Substring(0,protocolIndex);
        //int serverIndex = url.IndexOf("www.");
        //string server = url.Substring(serverIndex, url.IndexOf("/", serverIndex)-serverIndex);
        //string resource = url.Substring(url.IndexOf("/", serverIndex));
        //Console.WriteLine(@"[protocol] = ""{0}"" ", protocol);
        //Console.WriteLine(@"[server] = ""{0}"" ", server);
        //Console.WriteLine(@"[resource] = ""{0}"" ", resource);

        var parts = Regex.Match(url, @"(.*)://(.*?)(/.*)").Groups;
        Console.WriteLine("[protocol]: {0}", parts[1]);
        Console.WriteLine("[server]: {0}", parts[2]);
        Console.WriteLine("[resource]: {0}", parts[3]);
    }
}