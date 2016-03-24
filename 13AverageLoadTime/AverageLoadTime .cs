using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLoadTimeCalcilator
{
    class AverageLoadTime
    {
        static void Main()
        {
            Console.WriteLine("Input a report and press ENTER :");
            Dictionary<string,List< double>> dict = new Dictionary<string,List< double>>();
            string input = Console.ReadLine();

            while (input != string.Empty)
            {
                string[] tokens = input.Split(' ');
                string site = tokens[2];
                double loadTime = double.Parse(tokens[3]);

                if (!dict.ContainsKey(site))
                {
                    dict.Add(site, new List<double>());
                }
                dict[site].Add(loadTime);
                input = Console.ReadLine();
            }

            Console.WriteLine("The average load time for URL:");
            Console.WriteLine();

            foreach (var item in dict)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value.Average());
            }
            Console.WriteLine();
        }
    }
}
