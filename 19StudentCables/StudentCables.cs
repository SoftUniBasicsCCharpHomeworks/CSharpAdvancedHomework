using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCables
{
    class StudentCables
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int joinedCable = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int cableLength= int.Parse(Console.ReadLine());
                string measure = Console.ReadLine();

                switch (measure)
                {
                    case "meters": cableLength = cableLength * 100; break;
                        
                    case "centimeters": cableLength = cableLength; break;
                    default:
                        break;
                }

                if (cableLength >= 20)
                {
                    joinedCable += cableLength ;
                    count++;
                }
            }
            joinedCable = joinedCable - 3 * (count - 1);
            int studentsCable = joinedCable / 504;
            int remainingCable = joinedCable - (studentsCable * 504);
            Console.WriteLine(studentsCable);
            Console.WriteLine(remainingCable);
        }
    }
}
