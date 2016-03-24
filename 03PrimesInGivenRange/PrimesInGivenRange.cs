using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            Console.Write("start number= ");
            int startNum = int.Parse(Console.ReadLine());

            Console.Write("end number= ");
            int endNum = int.Parse(Console.ReadLine());

            List<int> primes = FindPrimesInRange(startNum, endNum);
            PrintArray(primes);
        }

        private static void PrintArray(List<int> primes)
        {
            Console.WriteLine("All primes in this range:");

            for (int i = 0; i < primes.Count; i++)
            {
                Console.Write(primes[i]);
                if (i == primes.Count - 1)
                {
                    Console.WriteLine();
                    break;
                }
                Console.Write(", ");
            }
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            if (startNum < 2)
            {
                startNum = 2;
            }
            for (int i = startNum; i <= endNum; i++)
            {

                bool isPrime = true;
                for (int j = 2; (j * j) <= i; j++)
                {
                    if ((i % j) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            return primes;
        
        }
    }
}
