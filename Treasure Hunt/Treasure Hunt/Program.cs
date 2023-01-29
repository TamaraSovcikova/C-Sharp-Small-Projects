using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treasure_Hunt
{
    internal class Program
    {
        static public string[,] treasureBoard = new string[10, 10];
        static void Main(string[] args)
        {
            SetTreatureHunt();
            SetTreasure();
            ShowTreasureHunt();
            SearchForTreasure();

            Console.ReadKey();

        }
        static void SetTreatureHunt()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 10; y++)
                {
                    treasureBoard[i, y] = "0";
                }
            }
        }
        static void ShowTreasureHunt()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.Write(treasureBoard[i, y]);
                }
                Console.WriteLine();
            }
        }
        static void SetTreasure()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 10);
            int y = rnd.Next(0, 10);
            treasureBoard[x, y] = "T";

        }
        static void SearchForTreasure()
        {
            bool foundTreasure = false;
            do
            {
                Console.WriteLine("Enter the x coordinate of the treasure: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the y coordinate of the treasure: ");
                int y = int.Parse(Console.ReadLine());
                treasureBoard[x - 1, y - 1] = "X";

                if (treasureBoard[x, y] == "T")
                {
                    Console.WriteLine("SUCCESS YOU FOUND THE TREASURE!");
                    foundTreasure = true;
                }
                else
                {
                    Console.WriteLine("Sorry the treasure isnt here...");
                    foundTreasure = false;
                }
                ShowTreasureHunt();
            }
            while (foundTreasure != true);
        }
    }   
    
}
