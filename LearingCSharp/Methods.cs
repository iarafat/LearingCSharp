using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearingCSharp
{
    class Methods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's you first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's you last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In hat city were you born? ");
            string city = Console.ReadLine();

            DisplayReslut(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

           // Console.WriteLine();
           // DisplayReslut(ReverseString(firstName) +" "+ ReverseString(lastName)+" "+ReverseString(city));

            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);
        }

        private static void DisplayReslut(
            string reversFirstName, 
            string reverseLastName, 
            string reverseCity)
        {
            Console.Write("Results: ");
            Console.Write(string.Format("{0} {1} {2}",
            reversFirstName,
            reverseLastName,
            reverseCity));
        }

        private static void DisplayReslut(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
        }
    }
}
