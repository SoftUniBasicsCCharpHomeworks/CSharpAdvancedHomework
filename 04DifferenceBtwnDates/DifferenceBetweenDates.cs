using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBtwnDates
{
    class DifferenceBetweenDates
    {
        static void Main()
        {
            Console.WriteLine("Enter first date (dd.MM.yyyy):");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter second date (dd.MM.yyyy):");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            var result = secondDate - firstDate;

            Console.WriteLine("The days between: " + result.Days);
        }
    }
}
