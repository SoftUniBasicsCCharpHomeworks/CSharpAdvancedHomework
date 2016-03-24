using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLists
{
    class JoinLists
    {
        static void Main()
        {
            Console.WriteLine("Enter 1st list of numbers:");
            var numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine("Enter 2nd list of numbers:");
            var numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> newNumbers = new List<int>();

            for (int i = 0; i < numbers1.Count; i++)
            {
                if (!newNumbers.Contains(numbers1[i]))
                {
                    newNumbers.Add(numbers1[i]);
                }
            }

            for (int i = 0; i < numbers2.Count; i++)
            {
                if (!newNumbers.Contains(numbers2[i]))
                {
                    newNumbers.Add(numbers2[i]);
                }
            }
            newNumbers.Sort();

            Console.WriteLine("New list of numbers:");
            foreach (var item in newNumbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
