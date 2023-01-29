using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string[] strs = new string[] { "a"};
            string prefix = "";
            
            int position = 0;
            var shortestName = strs.OrderBy(name => name.Length).FirstOrDefault();
            
            for (int i = 0; i < shortestName.Length; i++)
            {
                int times = 0;
                char letter = strs[0].ElementAt(position);
                foreach (string word in strs)
                {                    
                    if (word.ElementAt(position) == letter)
                    {
                        times++;                       
                    }
                }
                if (times == strs.Count())
                    prefix += letter;
                else
                    break;
                position++;
            }
            Console.WriteLine(prefix);
            Console.ReadKey();
            //look at the first letter of the first word, then look at the first letter of the second word, and then third
            //if they match continue, untill they dont match, then output what matched.
        }
    }
}
