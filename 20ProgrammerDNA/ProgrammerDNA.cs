using System;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = (char)Console.Read();
        int lineCount = 0;

        while (true)
        {
            for (int i = 0; i < 7; i++)
            {
                int dotCount = Math.Abs(3 - i);
                int charCount = 7 - 2 * dotCount;
                Console.Write(new string('.', dotCount));

                for (int j = 0; j < charCount; j++)
                {

                    Console.Write(letter);
                    if (letter == 'G')
                    {
                        letter = 'A';
                    }
                    else
                    {
                        letter++;
                    }
                }

                Console.Write(new string('.', dotCount));
                Console.WriteLine();
                lineCount++;

                if (lineCount == n)
                {
                    return;
                }
            }
        }
    }
}

