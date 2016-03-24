using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordInText
{
    class LongestWordInText
    {
        static void Main()
        {
            Console.WriteLine("Enter a text:");
            
            string[] words = Console.ReadLine().Split(new char[] { ' ', '.', ',', '!', '\"', '\'' }, 
                StringSplitOptions.RemoveEmptyEntries);

            int maxLength=0;
            int index = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxLength)
                {
                    index = i;
                    maxLength = words[i].Length;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Longest word is:");
            Console.WriteLine(words[index]);
        }
    }
}
