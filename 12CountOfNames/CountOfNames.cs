using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfNames
{
    class CountOfNames
    {
        static void Main()
        {
            Console.WriteLine("Enter a list of names:");
            List <string> names = Console.ReadLine().Split(' ').ToList();
            names.Sort();

            Dictionary <string, int> result = new Dictionary <string, int>();

            int counter = 1;
            for (int i = 0; i < names.Count; i++)
            {
                if (i == names.Count - 1)
                {
                    result[names[i]] = counter;
                    break;
                }
                if (names[i] == names[i + 1])
                {
                    counter++;
                }
                else
                {
                    result[names[i]] = counter;
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
