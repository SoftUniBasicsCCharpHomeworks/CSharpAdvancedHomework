using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            Console.WriteLine("Enter rows and columns on a single line:");
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = input[0];
            int c = input[1];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0}{1}{0} ",(char)('a' + i), (char)('a' + i+ j));
                }
                Console.WriteLine();
            }
        }
    }
}
