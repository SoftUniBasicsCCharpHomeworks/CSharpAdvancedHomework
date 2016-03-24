using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace CountingWordInText
{
    class CountingWordInText
    {
        static void Main()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine().Trim();

            Console.WriteLine("Enter a text:");
            int bufferSize = 1024;
            Stream inStream = Console.OpenStandardInput(bufferSize);
            Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufferSize));
            string text = Console.ReadLine();

            Regex wordRegex = new Regex(@"\b" + word + @"+\b", RegexOptions.IgnoreCase);
            MatchCollection matches = wordRegex.Matches(text);

            Console.WriteLine();
            Console.WriteLine("{0} is found {1} times", word, matches.Count);
        }
    }
}
