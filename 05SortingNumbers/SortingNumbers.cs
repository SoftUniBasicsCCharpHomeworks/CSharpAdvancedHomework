using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumbers
{
    class SortingNumbers
    {
        static void Main()
        {
            Console.WriteLine("How many numbers will you enter?");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            Console.WriteLine("Enter {0} numbers:",n);
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            numbers= SortArray(numbers);

            Console.WriteLine("The numbers in increasing order:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static int[] SortArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int oldNum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = oldNum;
                    }
                }
            }
            return numbers;
        }
    }
}
