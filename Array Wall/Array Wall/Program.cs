using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Wall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wallSize = 0;
            int[,] wall = {
                { 1, 1, 1, 1, 1 },
                { 1, 1, 0, 0, 1 },
                { 1, 1, 0, 0, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 } };

            for (int i = 0; i < wall.GetLength(0); i++)
            {
                for (int j = 0; j < wall.GetLength(1); j++)
                {
                    //check is policko 0,0 is 1
                    //if policko = 1 - plocha +1
                    if (wall[i, j] == 1)
                    {
                        wallSize = wallSize + 1;
                    }             
                                        
                }
            }
            Console.WriteLine("your wall size is " + wallSize);
            Console.ReadKey();
        }
        static void LongWall()
        {
            int wallLenght = 0;
            string gaps;
            

            Console.WriteLine("how big long is your wall?");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int wallSize = x * y;
            int[] wall = new int[wallSize];

            for (int row = 0; row < wall.GetLength(0); row++)
            {
                for (int column = 0; column < wall.GetLength(1); column++)
                {
                    if (row % 2 == 1)
                    {
                        wall[row * y + column] = 1;
                    }
                    else
                        wall[row * y + column] = 0;
                }
                
            }
        }
    }
}
