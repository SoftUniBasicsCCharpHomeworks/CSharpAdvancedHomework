using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {
            Console.Write("Enter a number n= ");
            long number = long.Parse(Console.ReadLine());
            bool isPrime = true;

            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine("Is {0} prime: {1}",number,isPrime);
        }
    }
}
