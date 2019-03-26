using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearingCSharp
{
    class WhileIteration
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumber();
                return true;
            } 
            else if (result == "2")
            {
                GuessinGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumber()
        {
            Console.Clear();
            Console.Write("Print Number");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= result)
            {
                Console.Write(counter + "-");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessinGame()
        {
            Console.Clear();
            Console.Write("Guessing game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 to 10: ");
                int result = int.Parse(Console.ReadLine());
                guesses++;

                if (result == randomNumber)
                    incorrect = false;
                else
                    Console.WriteLine("Wrong!");
            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} guesses.", guesses);

            Console.ReadLine();
        }
    }
}
