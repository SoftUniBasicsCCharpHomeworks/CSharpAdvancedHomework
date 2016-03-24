using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main()
        {
            Console.WriteLine("How many strings will you enter?");
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];
            Console.WriteLine("Enter {0} strings:", n);

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }

            int count = 1, maxCount = 0, index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {

                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        index = i;
                    }
                }
                count = 1;
            }
            Console.WriteLine("The longest sequence of equal elements: ");
            Console.WriteLine(maxCount);

            for (int i = index; i < index+maxCount; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
