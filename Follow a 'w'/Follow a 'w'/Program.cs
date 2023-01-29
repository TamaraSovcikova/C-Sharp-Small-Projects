using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Follow_a__w_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence starting with three w: ");
            string link = Console.ReadLine();

            bool isfollowed = false;
            int count = 0;
            for (int i = 0; i < link.Length; i++)
            {
                if (link[i].ToString().ToLower() == "w")
                    count++;
                else if (link[i].ToString().ToLower() != "w")
                {
                    if (count == 3)
                        isfollowed = true;
                    else
                        isfollowed = false;
                }
            }
            Console.WriteLine(isfollowed);
            Console.ReadKey();
        }
    }
}
