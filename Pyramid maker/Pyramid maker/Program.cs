using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid_maker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string end = "";
            do
            {
                Console.WriteLine("Enter base size of pyramid => ");
                int baseSize = int.Parse(Console.ReadLine());
                if (baseSize % 2 == 1)
                {
                    MakeRightSideUpPyramid(baseSize);
                    MakeUpsideDownPyramid(baseSize);
                    Console.WriteLine("Press y to continue or any other key to exit");
                    end = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid - Number must be an odd integer");
                }
            }
            while (end == "y");
            Console.WriteLine("Bye bye then!");
            Console.ReadKey();
        }        
        static void MakeRightSideUpPyramid(int baseSize)
        {
            int pad = (baseSize +1) / 2;
            int layer = 0;
            string space = " ";
            Console.WriteLine("\n <3 Here is your right side up pyramid <3 \n");
            while (layer != baseSize && pad != 0)
            {
                Console.Write(space.PadLeft(pad));
                for (int y = 0; y <= layer; y++)
                {
                    Console.Write("*");
                }
                layer = layer +2;
                Console.WriteLine();
                pad--;
            }
        }
        static void MakeUpsideDownPyramid(int baseSize)
        {
            int pad = 1;
            string space = " ";
            Console.WriteLine("\n <3 Here is your upside down pyramid <3 \n");
            while (baseSize >= 1)
            {
                Console.Write(space.PadLeft(pad));
                for (int y = 0; y < baseSize; y++)
                {
                    Console.Write("*");
                }
                baseSize = baseSize - 2;                
                Console.WriteLine();                
                pad++;
            }            
        }
    }
}
