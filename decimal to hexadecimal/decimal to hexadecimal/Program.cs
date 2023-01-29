using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace decimal_to_hexadecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = File.AppendText("ConvertToHexa.txt");
            int stop = 1;
            while (stop != 2)

            {
                string input = ReadInput();
                
                if (input == "x")
                {
                    stop = 2;
                }
                else
                {
                    string n = ConvertToHexaComplicated(int.Parse(input));
                    Console.WriteLine(n);
                    file.WriteLine("input = " + input + "      output = " + n);
                }

            }
            file.Close();
            Console.WriteLine("You entered the following numbers: ");

            ShowFile();
            Console.WriteLine("Okey bye!");
            
            Console.ReadKey();

            //user inputs a decimal number, if he enters x the program ends
            //the program will convert the decimal into hexa
            //it will save into file Append("input = decimal , output = hexa")
        }
        static void ShowFile()
        {
            StreamReader file = File.OpenText("ConvertToHexa.txt");
            while (!file.EndOfStream)
            {
                Console.WriteLine(file.ReadLine());
            }

        }
        static string ConvertToHexa(string num)
        {

            if (num == "x")
            {
                string exit = "x";
                return exit;
            }
            else
            {
                string hexa = int.Parse(num).ToString("X");
                return hexa;
            }

        }
        static string ReadInput()
        {
            Console.WriteLine("Enter a number: / or press x to exit");
            string num = Console.ReadLine();
            return num;
        }
        static string ConvertToHexaComplicated(int num)
        {
            string hex = "0123456789ABCDEF";
            do 
            {
                int convD = num / 16;
                int convM = num % 16;
                return hex[convD].ToString() + hex[convM];
            }
            while (num > 16) ;
        }
    }
}
