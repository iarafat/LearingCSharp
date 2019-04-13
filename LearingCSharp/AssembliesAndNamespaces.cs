using System;
using System.IO;
using System.Net;

namespace LearingCSharp
{
    class AssembliesAndNamespaces
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\Arafat\source\repos\LearingCSharp\LearingCSharp\AssembliesAndNamespaces.txt", reply);
            Console.ReadLine();
        }
    }
}
