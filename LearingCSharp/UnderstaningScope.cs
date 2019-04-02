using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearingCSharp
{
    class UnderstaningScope
    {
        private static string K = "";

        static void Main(string[] args)
        {
            string J = "";
            for (int i = 0; i < 10; i++)
            {
                J = i.ToString();
                K = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string Z = i.ToString();
                }
                //Console.WriteLine("Outsite of if: "+ Z);
            }

            Console.WriteLine("outside of for: "+ K);
            Console.WriteLine("outside of for: "+ J);

            HelperMethod();
        }

        static void HelperMethod()
        {
            Console.WriteLine("From Helper method"+ K);
        }
    }
}
