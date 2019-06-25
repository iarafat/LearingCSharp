using System;
using MyCodeLibrary;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // @"C:\Users\Arafat\source\repos\LearingCSharp\MyCodeLibrary\ScrapeWebpage.txt"
            Scrape myScrape = new Scrape();

            string value = myScrape.ScrapeWebpage("http://msdn.microsoft.com");
            string value2 = myScrape.ScrapeWebpage("http://msdn.microsoft.com");

            Console.WriteLine(value);
        }
    }
}
