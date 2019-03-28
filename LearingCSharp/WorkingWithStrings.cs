using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearingCSharp
{
    class WorkingWithStrings
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a \nnew line?";

            //string myString = "Go to your C:\\ drive";
            //string myString = @"Go to your C:\ drive";

            //string myString = String.Format("{1} = {0}", "First", "Seconed");

            //string myString = string.Format("{0:c}", 123.45);

            //string myString = string.Format("{0:n}",5464745645454);
            //string myString = string.Format("{0:G}", 1234.56);
            //string myString = string.Format("Percentage: {0:p}",.123);
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890); // adding extra char in (###)

            //string myString = " That summer we took threes across the board   ";
            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);

            //myString = string.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length);

            /*string myString = "";

            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }*/

            /*StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }*/

            string myString = string.Format("{2} - {3}", "3", "4", "5");

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
