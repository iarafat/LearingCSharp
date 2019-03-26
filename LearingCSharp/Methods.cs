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

            Console.Write("Results: ");
            ReverseString(firstName);
            ReverseString(lastName);
            ReverseString(city);

            Console.ReadLine();
        }

        private static void ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (var item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write(" ");
        }
    }
}
