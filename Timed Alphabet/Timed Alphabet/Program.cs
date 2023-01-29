using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Timed_Alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Alphabet typer");
            Console.WriteLine("Lets see how fast you can type the alphabet");
            Console.WriteLine("Try to go for best of three");
            Stopwatch stopwatch = new Stopwatch();
            Console.Write("\npress any key to start: ");
            Console.ReadKey();

            bool correct = true;
            int completeRound = 0;
            TimeSpan timeSpan;
            TimeSpan averageTime = TimeSpan.Zero;
            
            do 
            {
                Console.WriteLine();
                stopwatch.Start();
                for (char i = 'a'; i <= 'z'; i++)
                {                         
                    ConsoleKeyInfo letter = Console.ReadKey();
                    correct = letter.KeyChar == i;
                    if (!correct)
                    {                        
                        Console.WriteLine("\nYou made an error " + letter.KeyChar + " broke the sequence");
                        break;
                    }      
                }                
                stopwatch.Stop();
                if (correct)
                {                    
                    completeRound++;
                    timeSpan = stopwatch.Elapsed;                    
                    averageTime+= timeSpan;
                }             

            }
            while (!correct || completeRound != 3);

            double average = (averageTime.TotalMilliseconds/ 3) /1000;
            Console.WriteLine("\nNice, your average time is: " + average + " seconds");
           

            Console.ReadKey();
        }
    }
}
