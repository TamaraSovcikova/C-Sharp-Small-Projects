using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Array_sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReverseArray();            
            //SumOfElements();
            //CopyArray();
            //ArrayDuplicates();            
            //MinMax();
            //UniqueNumebers();
            Frequency();

            Console.ReadKey();

        }
        static void Frequency()
        {
            Console.WriteLine("How many numbers do you want to input? ");
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + times + " numbers: ");
            int num = 0;
            int[] array01 = new int[times];
            int[] array02 = new int[times];

            int exit = 0;
            for (int i = 0; i < times;)
            {
                num = int.Parse(Console.ReadLine());
                array01[i] = num;
                array02[i] = 0;
                exit = 0;
                for (int y = 0; y < times; y++)
                {
                    if (array01[y] == num)
                    {
                        array02[y]++;
                        

                    }
                    else
                    {
                        exit = 1;
                    }                       
                    
                }
                if (exit == 1)
                {
                    i++;
                }


            }
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(array01[i] + " occures: " + array02[i] + " times.");
            }
        }




        static void UniqueNumebers()
        {
            Console.WriteLine("How many numbers do you want to input? ");
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + times + " numbers: ");
            int num = 0;
            int[] array01 = new int[times];

            int contains = times;

            for (int i = 0; i < times; i++)
            {
                num = int.Parse(Console.ReadLine());
                for (int j = 0; j < times; j++)
                {
                    if (num == array01[j])
                        contains--;

                }
                array01[i] = num;
            }

            Console.WriteLine("Your array contains " + contains + " unique numbers");

        }

        static void ReverseArray()
        {
            StreamWriter file = File.CreateText("ReverseArray.txt");
            int times = 0;

            Console.WriteLine("How many numbers do you want to input? ");
            int okey = 0;
            while (okey != 1)
            {
                try
                {
                    times = int.Parse(Console.ReadLine());
                    okey = 1;
                }
                catch
                {
                    Console.WriteLine("Please enter a number ");

                }
            }

            Console.WriteLine("Enter " + times + " numbers: ");
            int num = 0;
            int[] reversenum = new int[times];

            for (int i = 0; i < times; i++)
            {

                num = int.Parse(Console.ReadLine());
                reversenum[i] = num;

                Console.WriteLine("Please enter a number ");

            }

            for (int i = 0; i < times / 2; i++)
            {
                int a = reversenum[i];
                reversenum[i] = reversenum[(times - 1) - i];
                reversenum[(times - 1) - i] = a;
            }

            Console.WriteLine();
            for (int i = 0; i < times / 2; i++)
            {
                file.WriteLine(reversenum[i * 2]);
            }

            file.Close();

            //ReversArraySimple()
            //int[] reversenum = GetArray();

            //Array.Reverse(reversenum);
            //Console.WriteLine();
            //for (int i = 0; i < reversenum.GetLength(0); i++)
            //{
            // Console.WriteLine(reversenum[i]);
            //}

            //ReverseArrayComplex()
            //int[] reversenum = GetArray();

            //Console.WriteLine();
            //for (int i = reversenum.GetLength(0) - 1; i >= 0; i--)
            //{
            //Console.WriteLine(reversenum[i]);
            //}
        }

        static void SumOfElements()
        {
            Console.WriteLine("How many numbers do you want to input? ");
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + times + " numbers: ");
            int num = 0;
            int[] arraySum = new int[times];

            for (int i = 0; i < times; i++)
            {
                num = int.Parse(Console.ReadLine());
                arraySum[i] = num;
            }
            int total = 0;
            for (int i = 0; i < times; i++)
            {
                int n = arraySum[i];
                total = total + n;
            }

            Console.WriteLine("The total of all of the elements in your array is: " + total);
        }
        static void CopyArray()
        {
            int[] array = GetArray();

            int n;
            int[] array02 = new int[array.GetLength(0)];
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                n = array[i];
                array02[i] = n;
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array02[i]);
            }
        }
        static void ArrayDuplicates()
        {
            Console.WriteLine("How many numbers do you want to input? ");
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + times + " numbers: ");
            int num = 0;
            int[] array01 = new int[times];

            int contains = 0;

            for (int i = 0; i < times; i++)
            {
                num = int.Parse(Console.ReadLine());
                for (int j = 0; j < times; j++)
                {
                    if (num == array01[j])
                        contains++;
                }
                array01[i] = num;
            }

            Console.WriteLine("Your array contains " + contains + " duplicate numbers");

        }
        static void MinMax()
        {
            int[] array = GetArray();

            int numMin = array[0];
            int numMax = array[0];

            for (int y = 0; y < array.GetLength(0) / 2; y++)
            {
                if (array[y * 2] < numMin)
                {
                    numMin = array[y * 2];
                }
                if (array[y * 2 + 1] > numMax)
                {
                    numMax = array[y * 2 + 1];
                }
            }

            Console.WriteLine("Your lowest numbers is: " + numMin);
            Console.WriteLine("Your largest number is: " + numMax);

        }
        static int[] GetArray()
        {
            Console.WriteLine("How many numbers do you want to input? ");
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + times + " numbers: ");
            int num = 0;
            int[] array01 = new int[times];

            for (int i = 0; i < times; i++)
            {
                num = int.Parse(Console.ReadLine());
                array01[i] = num;
            }
            return array01;
        }
    }
}

