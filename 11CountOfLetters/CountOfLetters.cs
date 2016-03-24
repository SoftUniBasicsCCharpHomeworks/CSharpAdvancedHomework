using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfLetters
{
    class CountOfLetters
    {
        static void Main()
        {
            Console.WriteLine("Enter a list of letters:");
            List <char> letters = Console.ReadLine().Split(' ').Select(char.Parse).ToList();
            letters.Sort();

            Dictionary <char, int> result = new Dictionary <char, int>();

            int counter = 1;
            for (int i = 0; i < letters.Count; i++)
            {
                if (i == letters.Count - 1)
                {
                    result[letters[i]] = counter;
                    break;
                }
                if (letters[i] == letters[i+1])
                {
                    counter++;
                }
                else
                {
                    result[letters[i]] = counter;
                    counter = 1;
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
