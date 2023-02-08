using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Program
    {
        static Random random = new Random();
        static int computerNum = 0;
        static int userNum = 0;

        static void Main(string[] args)
        {
            do
            {
                Round();
            }
            while (PlayAgain());

            Console.ReadKey();
        }
        static bool PlayAgain()
        {
            Console.Write("\nWant to play another round? y/n ==> ");
            string choice = Console.ReadLine();
            if (choice != "y")
                return false;
            else
                return true;
        }
        static void Round()
        {
            Console.WriteLine("-----Lets Play BlackJack------");
            computerNum = 0;
            userNum = 0;
            DealCards();
            Console.WriteLine("The total of your cards: " + userNum);
            if (Again()) DealCards();


            Console.WriteLine("Lets sum up the scores!");
            SumUpScores();
        }
        static void DealCards()
        {
            userNum += GenerateNumber();
            computerNum += GenerateNumber();
        }
        static void SumUpScores()
        {
            if ((computerNum > 21) && (userNum > 21))
                Console.WriteLine("You Both Lost");
            else if (((computerNum > 21) || ((21 - userNum) < (21 - computerNum))) && userNum<=21)
                Console.WriteLine("You Won!");
            else if (((userNum > 21) || ((21 - userNum) > (21 - computerNum))) && computerNum<=21)
                Console.WriteLine("You Lost!");
            else
                Console.WriteLine("It was a draw");

            Console.WriteLine("Your points: " + userNum);
            Console.WriteLine("Computers points: " + computerNum);
        }
        static bool Again()
        {
            Console.WriteLine("Want another card? y/n");
            string choice = Console.ReadLine();
            if (choice == "y")
                return true;
            else
                return false;
        }

        static int GenerateNumber()
        {
            int total = 0;
            int num = 0;
            for (int i = 0; i < 2; i++)
            {
                num = random.Next(1, 12);
                total = total + num;
            }
            return total;
        }

    }
}
