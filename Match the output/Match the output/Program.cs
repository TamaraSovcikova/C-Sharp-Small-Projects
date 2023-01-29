using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_the_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            do
            {
                try
                {
                    Console.WriteLine("Enter a number: /or 0 to exit");
                    num = int.Parse(Console.ReadLine());

                    int[] numbers = new int[num];


                    for (int j = 0; j < num; j++)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            numbers[i] = num - num + i + j;
                            Console.Write(numbers[i]);

                        }
                        Console.WriteLine("\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            while (num != 0);

            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
