using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ExtractURLs
{
    class ExtractURLs
    {
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\b(?:https?://|www\.)\S+\b");
            MatchCollection matches = regex.Matches(text);

            Console.WriteLine();
            Console.WriteLine("All URLs from the text:");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
