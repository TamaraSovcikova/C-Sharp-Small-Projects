using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_To_Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string roman = "IMVVXXII";
            int total = RomanToInt(roman);
            Console.WriteLine(total);

            Console.ReadKey();
        }
        static int RomanToInt(string s)
        {
            char[] romanNumerals = s.ToCharArray();
            int total = 0;
            int value = 0;
            int followingValue = 0;

            for (int i = 0; i < romanNumerals.GetLength(0); i++)
            {
                value = ValueInDecimal(romanNumerals[i]);
                if (i < romanNumerals.GetLength(0) -1)
                followingValue = ValueInDecimal(romanNumerals[(i + 1)]);  
                else
                followingValue = 0;

            if (value < followingValue)
                {
                    total += followingValue - value;
                    i++;
                }
                else
                    total += value;
            }
            return total;
        }
        static int ValueInDecimal(char num)
        {
            int value = 0;
            switch (num)
            {
                case 'I': value = 1; break;
                case 'V': value = 5; break;
                case 'X': value = 10; break;
                case 'L': value = 50; break;
                case 'C': value = 100; break;
                case 'D': value = 500; break;
                case 'M': value = 1000; break;
            }
            return value;
        }
    }
}
