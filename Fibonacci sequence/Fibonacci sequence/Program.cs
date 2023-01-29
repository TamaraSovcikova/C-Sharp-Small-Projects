using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_sequence
{
    internal class Program
    {
        static public int newNum = 0;
        static public int carryNum = 0;
        static public int middleNum = 1;
        static public int num = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how long you want the sequence to be: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("\n" + "0 1 ");
            //FibonacciSequence(num);
            RecursionFibonacciSequence(num);

            Console.ReadKey();
        }
        static void FibonacciSequence(int num)
        {
            int newNum = 0;
            int carryNum = 0;
            int middleNum = 1;
            int primeNum = 0;

            int[] primeNumbers = new int[100];

            for (int i = 2; i < num; i++)
            {
                newNum = carryNum + middleNum;
                Console.Write(newNum + " ");
                carryNum = middleNum;
                middleNum = newNum;
                int notAPrime = 0;

                for (int y = 1; y < newNum; y++)
                {
                    if (newNum != y && newNum % y == 0)
                    {
                        notAPrime++;
                    }
                }
                if (notAPrime == 1)
                {
                    primeNum++;
                    primeNumbers[i] = newNum;
                }
            }
            Console.WriteLine();
            Console.WriteLine("\n" + primeNum + " numbers are prime numbers, these are: ");
            for (int i = 0; i < primeNumbers.GetLength(0); i++)
            {
                if (primeNumbers[i] != 0)
                {
                    Console.Write(primeNumbers[i] + " ");
                }
            }
        }
        static void RecursionFibonacciSequence(int num)
        {
            if (num <= 2)
                return;
            newNum = carryNum + middleNum;
            Console.Write(newNum + " ");
            carryNum = middleNum;
            middleNum = newNum;
            if (num == 3)
                return;
            RecursionFibonacciSequence(num - 1);
        }
    }
}
