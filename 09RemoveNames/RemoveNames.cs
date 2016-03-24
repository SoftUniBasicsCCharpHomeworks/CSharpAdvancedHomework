using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNames
{
    class RemoveNames
    {
        static void Main()
        {
            Console.WriteLine("Enter 1st list of names:");
            string[] firstNames = Console.ReadLine().Split(new char[] { ' ' });
            Console.WriteLine("Enter 2nd list of names:");
            string[] secondNames = Console.ReadLine().Split(new char[] { ' ' });

            Console.WriteLine("The new list of names:");
            for (int i = 0; i <firstNames.Length; i++)
            {
                if (!secondNames.Contains(firstNames[i]))
                {
                    Console.Write(firstNames[i]+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
