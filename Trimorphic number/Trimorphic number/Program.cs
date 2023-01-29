using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimorphic_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num < 100000; num++)
            {
                int cubed = num * num * num;
                string scubed = cubed.ToString();
                string z = num.ToString();

                if (scubed.EndsWith(z))
                {
                    Console.WriteLine(num);
                }

            }
            Console.ReadKey();
        }
    }
}
