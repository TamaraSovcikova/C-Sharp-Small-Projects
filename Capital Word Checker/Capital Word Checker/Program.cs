using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Word_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            do
            {
                Console.WriteLine("Enter a sentence with capitalized words");
                string sentence = Console.ReadLine();
                string[] splitSentence = sentence.Split();

                int lowercaseCount = 0;
                for (int i = 0; i < splitSentence.GetLength(0); i++)
                {
                    if (splitSentence[i] == "") { }
                    else if (splitSentence[i].First().ToString() != (splitSentence[i].First().ToString().ToUpper()) || Char.IsDigit(splitSentence[i].First()))
                    {
                        lowercaseCount++;
                    }
                }
                if (lowercaseCount == 0)
                {
                    Console.WriteLine("Perfect");
                }
                else
                {
                    Console.WriteLine("Not all words in this sentence are uppercase.");
                }
                
                Console.Write("\nWant to try another sentence? press x if yes: ");
                string choice = Console.ReadLine();
                if (choice != "x")
                    again = false;
            }
            while (again == true);
            Console.ReadKey();


        }
    }
}
