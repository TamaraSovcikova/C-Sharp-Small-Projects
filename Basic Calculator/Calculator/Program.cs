using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chose operation
            string operation = "";
            do 
            { 
                Console.WriteLine("Please enter + ; - ; * ; / or 0 to end");
                operation = Console.ReadLine();
                decimal result = 0;
            
                if (operation != "0")
                {
                    //Enter number values 1 and 2
                    Console.WriteLine("Now enter the number values.");
                    decimal num01 = Convert.ToDecimal(Console.ReadLine());
                    decimal num02 = Convert.ToDecimal(Console.ReadLine());

                    //Calculate the result

                    if (operation == "+")
                    { result = num01 + num02; }
                    else if (operation == "-")
                    { result = num01 - num02; }
                    else if (operation == "*")
                    { result = num01 * num02; }
                    else if (operation == "/")
                    { result = num01 / num02; }

                    Console.WriteLine("Your result is " + result);
                }
                if (operation == "0")
                { Console.WriteLine("Thank you, bye."); }
            }
            while (operation != "0");

            Console.ReadKey();
            //Output the result
        }
    }
}
