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
            ReverseString();


            Console.ReadLine();
        }

        private static void ReverseString()
        {
            string message = "Hello world!";
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (var item in messageArray)
            {
                Console.Write(item);
            }
        }
    }
}
