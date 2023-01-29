using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise5();
            //Exercise6();
            //Exercise7();
            CountingCharacters();


            Console.ReadKey();

        }
        static void Exercise5()
        {
            //Write a C# Sharp program to create a new string where 'if' is added to the front of a given string.
            //If the string already begins with 'if', return the string unchanged. Go to the editor

            Console.WriteLine("Input a new string.");
            string userInput = Console.ReadLine();
            string ifuserInput = "if " + userInput;

            if (userInput.StartsWith("if"))
                Console.WriteLine(userInput);
            else
                Console.WriteLine(ifuserInput);
        }
        static void Exercise6()
        {
            //Write a C# Sharp program to remove the character in a given position of a given string.
            //The given position will be in the range 0.. string length -1 inclusive.

            Console.WriteLine("Enter text.");
            string userInput = Console.ReadLine();
            Console.WriteLine("Enter start index.");
            int startIndex = Convert.ToInt32(Console.ReadLine());

            if (startIndex > userInput.Length || startIndex < 1)
            {
                Console.WriteLine("Wrong Index");
                return;
            }
            
            Console.WriteLine("Here it is: ");
            Console.WriteLine(userInput.Remove(startIndex - 1, 1));

        }
        static void Exercise7()
        {
            //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
            Console.WriteLine("Enter some text.");
            string UserInput = Console.ReadLine();
            char firstLetter = UserInput[0];
            char lastLetter = UserInput[UserInput.Length -1];
            string firstLetterRemove = UserInput.Remove(0, 1);

            firstLetterRemove = firstLetterRemove.Remove(firstLetterRemove.Length -1, 1);
            Console.WriteLine(lastLetter + firstLetterRemove + firstLetter);         

        }
        static void CountingCharacters()
        {
            //Write a C# program which gets a text and the user chooses a letter to find in the text and counts the occurency of a
            //character in the specified text and outputs the positions of the characters
            Console.WriteLine("Enter a sentence.");
            string sentence = Console.ReadLine();
            Console.WriteLine("Now choose a character.");
            char letter = Convert.ToChar(Console.ReadLine());
            int occurence = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == letter)
                {
                    occurence++;
                    Console.WriteLine(i +1);
                }
                
            }
            Console.WriteLine("The occurency of your chosen character is: " + occurence);         
                


        }

}
    }

