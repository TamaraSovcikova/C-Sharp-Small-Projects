using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp to copy the elements one array into another array.
            Console.WriteLine("Input the number of elements to be sotred into the array: ");
            int numOf = int.Parse(Console.ReadLine());
            Console.WriteLine("Now imput your " + numOf + " elements into the array: ");

            int[] numbers = new int[numOf];

            for (int i = 0; i < numOf; i++)
            {
                Console.WriteLine("Enter Number " + ( i +1));
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The elements stored in the first array are: ");
            for (int i = 0; i < numOf; i++)
            {
                Console.WriteLine(numbers[i] + ", ");
            }

            int[] numbers2 = new int[100];
            for (int i = 0; i < numOf; i++)
            {
                numbers[i] = numbers2[i];
            }
            Console.WriteLine("---------------");
            Console.WriteLine("The elements copied into the second array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers2[i] + ", ");
            }
            Console.ReadKey();
        }
    }
}
