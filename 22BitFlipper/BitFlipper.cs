using System;

namespace BitFlipper
{
    class BitFlipper
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong mask = 7;
            for (int i = 61; i >= 0; i--)
            {
                ulong bits = (n >> i) & mask;
                if (bits==7 || bits==0)
                {
                    n ^= mask << i;
                    i -= 2;
                }
            }
            Console.WriteLine(n);
        }
    }
}
