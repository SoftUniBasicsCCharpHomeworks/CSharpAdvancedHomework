using System;
using System.Collections.Generic;

class MagicCarNumbers
{
    static void Main()
    {
        int weight = int.Parse(Console.ReadLine());
        int sum = 40;
        List <int> letters = new List<int>();
        letters.Add(10);
        letters.Add(20);
        letters.Add(30);
        letters.Add(50);
        letters.Add(80);
        letters.Add(110);
        letters.Add(130);
        letters.Add(160);
        letters.Add(200);
        letters.Add(240);

        int count = 0;

        for (int a = 0; a <= 9; a++)
        {
            for (int b = 0; b <= 9; b++)
            {
                for (int c = 0; c <= 9; c++)
                {
                    for (int d = 0; d <= 9; d++)
                    {
                        for (int i = 0; i < letters.Count; i++)
                        {
                            
                            for (int j = 0; j < letters.Count; j++)
                            {
                                sum += a + b + c + d + letters[i] + letters[j];

                                if (sum==weight &&
                                    ((a==b && a==c )||
                                    (b==c && b==d)||
                                    (a==b && c==d)||
                                    (a==c && b==d)||
                                    (a==d && b==c)))
                                {
                                    count++;
                                    
                                }
                                sum = 40;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}

