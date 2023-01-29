using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_my_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerGuess = 0;
            int attempts = 0;
            Console.WriteLine("The computer is thinking about a number between 100-999");
            int numToGuess = ComputerThinksOfNumber();
            Console.WriteLine("Try and guess the number it is thinking of: ");
            playerGuess = int.Parse(Console.ReadLine());
            if (playerGuess != numToGuess)
            {
                while (playerGuess != numToGuess)
                {
                    attempts++;
                    Console.WriteLine("Nope, " + HelpGuessCard(playerGuess, numToGuess));
                    playerGuess = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n--------YES! THATS IT!--------");
            Console.WriteLine("It took you " + attempts + " tries to guess the number");
            Console.ReadKey();
        }
        static int ComputerThinksOfNumber()
        {
            Random rnd = new Random();
            int numToGuess = rnd.Next(100, 1000);
            return numToGuess;
        }
        static string HelpGuessCard(int playerGuess, int numToGuess)
        {
            string navigation = " ";
            if (playerGuess > numToGuess)
                navigation = "lower";
            else
                navigation = "higher";
            return navigation;

        }

    }
}
