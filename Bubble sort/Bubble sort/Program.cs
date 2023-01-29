using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sort
{
    internal class Program
    {
        static List<int> numbers = new List<int>();
        static void Main(string[] args)
        {
            AskPrompt();
            bool done = false;
            do
            {
                int choice = ChooseAlgorithm();
                if (choice == 1)
                {
                    BubbleSort();
                }
                else
                    InsertionSort();

                Console.WriteLine();

                TypeOutOrderdList();
                Console.WriteLine("Want to try again? y/n");
                string again = Console.ReadLine();
                if (again == "y")
                    done = false;
                else done = true;
            }
            while (!done);

            Console.ReadKey();
        }
        static void AskPrompt()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Enter 10 numbers: ");
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
        }
        static int ChooseAlgorithm()
        {
            Console.WriteLine("Now please choose a sorting algorithm: ");
            Console.WriteLine("1; Bubble sort");
            Console.WriteLine("2; Insertion sort");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static void TypeOutOrderdList()
        {
            Console.WriteLine();
            foreach (int n in numbers)
                Console.WriteLine(n);
        }
        static void InsertionSort()
        {
            for (int i = 1; i < 10; i++)
            {
                int num = numbers[i];
                bool done = false;

                for (int j = i - 1; j >= 0 && !done; j--)
                {
                    if (num < numbers[j])
                    {
                        numbers.Insert(j,numbers[j + 1]);
                        numbers.RemoveAt(j + 2);                                               
                    }
                    else
                        done = true; 
                }
            }
        }
        static void BubbleSort()
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 1; i < 10; i++)
                {
                    if (numbers[i-1] > numbers[i])
                    {
                        numbers.Insert(i - 1, numbers[i]);
                        numbers.RemoveAt(i+1);
                    }
                }
            }
        }
    }
}
