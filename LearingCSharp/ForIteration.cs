using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearingCSharp
{
    class ForIteration
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found seven");
                    break;
                }
            }

            for (int myValuei = 0; myValuei < 12; myValuei++)
            {
                Console.WriteLine(myValuei);
            }
            Console.ReadLine();
        }
    }
}
