using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number for Fib(n), n= ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int fibonacci = 1;

            for (int i = 1; i <= n; i++)
            {
                fibonacci = a + b;
                a = b;
                b = fibonacci;
            }
            
            Console.WriteLine(fibonacci);
        }
    }
}
